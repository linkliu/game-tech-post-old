---
category: Unity
tags: [U3D, WEBGL, XLua, ArgumentException, Destination array was not long enough]

---

## Unity使用XLua框架，打WEBGL包，运行时报错：ArgumentException: Destination array was not long enough   
具体的错误如下：   
> `dangerArgumentException: Destination array was not long enough. Check destIndex and length, and the array's lower bounds`
{: .prompt-danger }   
由于我们UI使用的时FGUI，所以这个错误的具体表现是：
- 错误表现
  + [x] 在编辑器中运行良好，没有任何问题
  + [x] 打包成WEBGL运行就报这个错，但不是每次都报错，
  + [x] 如果报错，那么UI逻辑是正常的，如果不报错，那么UI逻辑异常，比如按钮的绑定事件错乱


- **解决办法**   
  我在XLua的Issue中,找到了大佬的解决办法。是XLua在释放资源时的Lock操作引起的。[原issue地址](https://github.com/Tencent/xLua/issues/741)。但是大佬的贴的代码，不能直接运行，需要稍加修改才行【大佬可能给的时伪代码】。我在这里把解决步骤归纳一下：   
  - 1.添加一个非锁互斥队列【也可以不用添加，就用系统的也行】：   
  ``` c#
  using System.Threading;
  namespace XLua
  {
      public class LockFreeQueue<T>
      {
          internal class SingleLinkNode<U> where U : T
          {
              public SingleLinkNode<U> Next;
              public U Item;
          }
  
          static private bool CAS<T>(ref T location, T comparand, T newValue) where T : class
          {
              return comparand == Interlocked.CompareExchange(ref location, newValue, comparand);
          }
  
          SingleLinkNode<T> head;
          SingleLinkNode<T> tail;
          int count;
  
          public int Count
          {
              get { return count; }
          }
  
          public bool IsEmpty
          {
              get { return count <= 0; }
          }
  
          public LockFreeQueue()
          {
              head = new SingleLinkNode<T>();
              tail = head;
              count = 0;
          }
  
          public void Enqueue(T item)
          {
              SingleLinkNode<T> oldTail = null;
              SingleLinkNode<T> oldTailNext;
  
              SingleLinkNode<T> newNode = new SingleLinkNode<T>();
              newNode.Item = item;
  
              bool newNodeAdded = false;
              while (!newNodeAdded)
              {
                  oldTail = tail;
                  oldTailNext = oldTail.Next;
  
                  if (tail == oldTail)
                  {
                      if (oldTailNext == null)
                          newNodeAdded = CAS<SingleLinkNode<T>>(ref tail.Next, null, newNode);
                      else
                          CAS<SingleLinkNode<T>>(ref tail, oldTail, oldTailNext);
                  }
              }
  
              CAS<SingleLinkNode<T>>(ref tail, oldTail, newNode);
              Interlocked.Increment(ref count);
          }
  
          public bool TryDequeue(out T item)
          {
              item = default(T);
              SingleLinkNode<T> oldHead = null;
  
              bool haveAdvancedHead = false;
              while (!haveAdvancedHead)
              {
                  oldHead = head;
                  SingleLinkNode<T> oldTail = tail;
                  SingleLinkNode<T> oldHeadNext = oldHead.Next;
  
                  if (oldHead == head)
                  {
                      if (oldHead == oldTail)
                      {
                          if (oldHeadNext == null)
                          {
                              return false;
                          }
  
                          CAS<SingleLinkNode<T>>(ref tail, oldTail, oldHeadNext);
                      }
                      else
                      {
                          item = oldHeadNext.Item;
                          haveAdvancedHead = CAS<SingleLinkNode<T>>(ref head, oldHead, oldHeadNext);
                      }
                  }
              }
  
              Interlocked.Decrement(ref count);
              return true;
          }
  
          public T Dequeue()
          {
              T result;
              if (TryDequeue(out result)) return result;
              return default(T);
          }
  
          public void Clear()
          {
              while (Count > 0)
              {
                  Dequeue();
              }
          }
      }
  }
  ```
  - 2.修改XLua源码，添加条件编译，让WEBGL在释放引用的时候不加锁   
  改下面几个地方：   
    - `refQueue`的定义   
    ``` c#
    #if !UNITY_WEBGL
        Queue<GCAction> refQueue = new Queue<GCAction>();
    #else
        LockFreeQueue<GCAction> refQueue = new LockFreeQueue<GCAction>();
    #endif
    ```
    - `equeueGCAction`方法   
    ``` c#
    internal void equeueGCAction(GCAction action)
    {
#if!UNITY_WEBGL 
        lock (refQueue)
        {
#endif
            refQueue.Enqueue(action);
#if!UNITY_WEBGL 
        }
#endif
    }
    ```
    - `Tick`方法   
    ``` c#
    public void Tick()
    {
#if THREAD_SAFE || HOTFIX_ENABLE
        lock (luaEnvLock)
        {
#endif
            var _L = L;
#if !UNITY_WEBGL
            lock (refQueue)
            {
#endif
                while (refQueue.Count > 0)
                {
                    GCAction gca = refQueue.Dequeue();
                    translator.ReleaseLuaBase(_L, gca.Reference, gca.IsDelegate);
                }
#if !UNITY_WEBGL
            }
#endif
#if !XLUA_GENERAL
            last_check_point = translator.objects.Check(last_check_point, max_check_per_tick, object_valid_checker, translator.reverseMap);
#endif
#if THREAD_SAFE || HOTFIX_ENABLE
        }
#endif
    }
    ```   

做完上面的步骤，然后重新编译，重新打webgl包再运行，就不会报错了。因为浏览器运行都是单线程，所以我们这里把加锁操作再webgl平台时去掉，问题就解决了。
