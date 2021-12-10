---
category: UnityEditor
tags: [Unity, 编辑器,Hierarchy,右键菜单]
---

## 在Unity的Hierarchy面板上添加右键菜单




这里添加的是复制一个模型的节点信息的功能，从子节点自身开始复制，一直到模型的父节点终止。因为有时候模型的子节点比较多，一个一个的去点开查找比较麻烦，或者想查看子节点的路径对不对。记得`priority`要写。

代码如下：
```c#
public static class EditorTool
{
   
    [MenuItem("GameObject/EditorTool/CopyPath", priority = 0)]
    static string CopyPath()
    {
       
        if (Selection.gameObjects.Length == 1)
        {
            GameObject selectObj = Selection.gameObjects[0];
            StringBuilder pathSB = new StringBuilder(selectObj.name);
            while (selectObj.transform.parent != null)
            {
                pathSB.Insert(0, selectObj.transform.parent.name + "/");
                selectObj = selectObj.transform.parent.gameObject;
            }

            GUIUtility.systemCopyBuffer = pathSB.ToString();

            return pathSB.ToString();


        }

        return "";
    }


}
```

![UnityEditor](https://linkliu.github.io/game-tech-post/assets/img/unity3d/1.png){: .shadow width = "50%" }