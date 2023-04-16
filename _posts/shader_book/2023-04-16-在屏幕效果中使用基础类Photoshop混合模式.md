---
category: shader
tags: [U3D, Shader,Cookbook,中文版]
---

## 在屏幕效果中使用基础类Photoshop混合模式   
屏幕效果不仅仅只限于调整游戏中渲染纹理的颜色。我们还可以使用它将渲染纹理和其他的图像结合在一起。这个技术跟Photoshop中创建一个新的图层没有什么不同然后选择一种混合模式将两张图片混合在一起，当然在我们这里就是将一张纹理跟渲染纹理混合。这是一个非常强的技术，因为它提供给了艺术家一个在游戏中模拟混合模式的生产环境，而不不仅仅只是在Photoshop中。   
<br>
对于这个特定的知识点，我们将会了解一些更加常用的混合模式，比如说 **Multiply**，**Add** 和 **Overlay**。你将会看到在游戏中拥有一个Photoshop中的混合模式的功能是多么的简单。   


***
<br>

- **始前准备**   
  开始前，我们需要准备资源。所以请跟着下面的步骤为我们新的 **混合模式屏幕效果（ Blend mode screen effect）** 设置好我们的屏幕效果系统并且让它顺利运行起来：   
  - 1.创建一个新的C#脚本，并且为其命名为 **BlendMode_ImageEffect**
  - 2.创建一个新的着色器，命名为 **BlendMode_Effect**
  - 3.我们简单的将我们本章节第一个知识点中的C#脚本中的代码复制到我们这个新的C#脚本中来。这样我们就可以将精力放在混合模式效果实现的数学原理上。
  - 4.同样，将本章节第一个知识点中的着色器代码赋值到我们这个新的着色器代码中来。
  - 5.最后，我们需要一张额外的纹理来表现我们的混合模式效果。在这个知识点，我们将使用一张 **粗旧类型纹理（grunge type texture）**。它能让测试效果看起来非常明显。

  <br>
  下图是这个效果要使用的一张粗旧型贴图。使用一张有足够细节和有良好灰度值范围的纹理有助于我们测试新的效果：
  ![diagram](https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram92.png){:  .shadow width = "90%" }   


***
<br>

- **操作步骤**   
  我们第一个要实现的混合模式是Photoshop中的一样的 **Multiply** 混合模式。让我们先修改我们着色器中的代码。
  - 1.在Unity的项目窗口中双击着色器，在代码编辑器中打开我们的着色器代码。
  - 2.我们需要在属性块中添加一些新的属性好让我们可以有纹理可以混合并且要有一个 **不透明度滑动条（a slider for an opacity value）**。在你的着色器中输入下面的代码：   
  ```c#
  Properties
    {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _BlendTex ("Blend Texture", 2D) = "white" {}
        _Opacity ("Blend Opacity", Range(0, 1)) = 1
    }
  ```
  - 3.在 **CGPROGRAM** 代码块中添加与属性对应的变量好让我们可以访问 **属性块（Properties block）** 中的数据：   
  ```c#
  CGPROGRAM
    #pragma vertex vert_img
    #pragma fragment frag
    #pragma fragmentoption ARB_precision_hint_fastest
    #include "UnityCG.cginc"

    uniform sampler2D _MainTex;
    uniform sampler2D _BlendTex;
    fixed _Opacity;
  ```
  - 4.最后我们修改 **frag()** 函数从而来表现我们两张纹理的 **multiply** 操作：   
  ```c#
  fixed4 frag(v2f_img i) : COLOR
    {
        //获得渲染纹理的颜色并且获取 v2f_img的uv
        fixed4 renderTex = tex2D(_MainTex, i.uv);
        fixed4 blendTex = tex2D(_BlendTex, i.uv);
        //执行 multiplay 混合模式
        fixed4 blendedMultiply = renderTex * blendTex;
        //对混合模式程度进行线性插值
        renderTex = lerp(renderTex, blendedMultiply, _Opacity);
        return renderTex;
    }
  ```
  - 5.保存着色器代码并且返回Unity编辑器，让着色器编译并且看看有没有错误。如果没有遇到错误，我们就双击C#脚本在代码编辑器中打开。
  - 6.在C#脚本中我们同样需要创建一些相应的变量。我们需要一个纹理变量用来赋值纹理并且将它发送给着色器，我们还需要一个滑动条用来调整我们想要的混合模式的最终程度：   
  ```c#
  #region Variables
    public Shader curShader;
    public Material curMaterial;
    public Texture2D blendTexture;
    public float blendOpacity = 1.0f;
    #endregion
  ```
  - 7.接下来，我们需要通过 **OnRenderImage()** 方法给着色器传递我们的变量数据：   
  ```c#
  private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (curShader != null)
        {
            material.SetTexture("_BlendTex", blendTexture);
            material.SetFloat("_Opacity", blendOpacity);
            Graphics.Blit(src, dest, material);
        }
        else
        {
            Graphics.Blit(src, dest);
        }
    }
  ```
  - 8.为了完成我们的脚本，我们还要修改 **Update()** 方法，这样我们就能把 **blendOpacity** 变量的值控制在 **[0, 1]** 范围内。   
  ```c#
  private void Update()
    {
        blendOpacity = Mathf.Clamp(blendOpacity, 0.0f, 1.0f);
    }
  ```   

  <br>
  当这些都完成之后，我们将屏幕效果脚本挂到我们的主摄像机上并且将我们的着色器拖拽赋值到我们的C#脚本中，这样让脚本可以有一个着色器来进行逐像素操作。最终，为了让效果能完全发挥功能，脚本和着色器都需要一张纹理。你可以在Unity的 **检查器面板（Inspector tab）** 给屏幕效果脚本的纹理变量添加任何一张纹理。一旦你添加了一张纹理，你就能看到游戏的渲染纹理之上还有我们刚刚添加的纹理，并且已经进行了 **multiplying** 混合操作。下图演示了这个屏幕效果：   
  ![diagram](https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram93.png){:  .shadow width = "90%" }   
  <br>
  下图演示了当不透明度更高时，对图像进行 **multiplying** 操作让它叠在渲染纹理上的表现更加明显：   
  ![diagram](https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram93.png){:  .shadow width = "90%" }   
  <br>
  --TODO