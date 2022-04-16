---
category: shader
tags: [U3D, Shader,Cookbook,中文版]
math: true
---
## 创建 BlinnPhong 类型的高光反射着色器

**Blinn**是另一种计算和模拟高光的更有效的方法。它只要视角方向和光线方向向量的中间向量就可以计算出来。这个高光是**Jim Blinn**带入到Cg世界中的。 他发现比起计算反射向量来，只要中间向量的效率更好。它减少了代码量和处理时间。 如果你在**UnityCG.cginc**文件中查看了Unity内建的**BlinnPhong**光照模型的话，它也是用了中间向量，因此它被命名为**BlinnPhong** 。它只是完整**Phong**光照计算中的一种简单的版本。

***




- **始前准备**

  让我们按照下面的步骤开始学习这个知识点：

  1. 这次我们不创建新的场景，就用原来场景和场景内的对象就好，然后我们需要创建一个新的着色器和材质，并且把名字都叫**BlinnPhong**。
  2. 当我们创建好着色器后，双击它，开始编辑。


***




- **操作步骤**

  按照下面的步骤走，我们来创建**BlinnPhong**光照模型：
  1. 首先，我们需要在着色器的**属性(Properties)**块中添加我们需要用到的属性，这样好让我们控制高光效果：
  ```c#
  Properties
  {
    _MainTint ("Diffuse Tint", Color) = (1,1,1,1)
    _MainTex ("Base (RGB)", 2D) = "white" {}
    _SpecularColor ("Specular Color", Color) = (1,1,1,1)
    _SpecPower ("Specular Power", Range(0.1,60)) = 3
  }
  ```
  2. 接下来在**CGPROGRAM**块中添加与属性对应的变量，这样我们就可以获得来自**属性(Properties)**中的数据：
  ```c#
  sampler2D _MainTex;
  float4 _MainTint;
  float4 _SpecularColor;
  float _SpecPower;
  ```
  3. 接下来就是要创建我们自定义的光照模型了，用来处理漫反射和高光的计算，代码如下所示:
  ```c#
  fixed4 LightingCustomBlinnPhong (SurfaceOutput s, fixed3 lightDir,half3 viewDir, fixed atten)
  {
      float NdotL = max(0,dot(s.Normal, lightDir));
      float3 halfVector = normalize(lightDir + viewDir);
      float NdotH = max(0, dot(s.Normal, halfVector));
      float spec = pow(NdotH, _SpecPower) * _SpecularColor;
      float4 c;
      c.rgb = (s.Albedo * _LightColor0.rgb * NdotL) + (_LightColor0.rgb * _SpecularColor.rgb * spec) * atten;
      c.a = s.Alpha;
      return c;
  }
  ```
  4. 为了完成我们的着色器，我们还需要告知着色器的**CGPROGRAM**块使用我们自定义的光照模型而不是Unity内建的，修改**#pragma**指示，改成如下代码所示：
  ```c#
  CPROGRAM
  #pragma surface surf CustomBlinnPhong
  ```
  下图演示了我们自己的**BlinnPhong**光照模型的效果：
  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram41.png"/></div>

  ***




  - **原理介绍**

    **BlinnPhong**高光跟**Phong**高光很像，但是前者的效率比后者要高，因为后者用更优化的代码实现了几乎一样的效果。在介绍基于物理原理的渲染之前，这种方法是Unity4中高光反射的默认选择。
    计算反射向量**R**的代价通常很高。**BlinnPhong**高光并没有计算它，而是用介于视角**V**和光线**L**之间的中间向量**H**：

    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram42.png"/></div>
    跟完整的计算出我们的反射向量不同，我们转而去获得介于视角方向和光线方向之间的中间向量，基本模拟了反射向量。跟**Phong**高光比起来，这种方法更加贴近真实的物理现象，但是我们依然认为，向你介绍所有的这些方法依然是很有必要的：
    
    $$ S_{Phong} = (R \cdot V)^p, S_{BlinnPhong} = (N \cdot H)^p $$
    
    根据向量的代数计算，中间向量可以用下面的方法算出：
    
    $$H\frac{V+L}{|V+L|} $$
    
    这里 的$\|V+L\|$表示向量$V+L$的长度。在Cg中，我们简单的将视角方向和光线方向相加并且对结果进行标准化成一个单位向量：
    ```c#
    float3 halfVector = normalize(lightDir + viewDir);  
    ```
    然后，我们简单的对顶点的法线和我们的中间向量求点积，从而获得我们主要的高光值。在这之后，我们把它用指数**_SpecPower**进行指数运算并且乘以高光颜色变量**_SpecularColor**。跟**Phong**高光比起来，整个算法在代码量和运算量上都要少很多，但在很多实时渲染情况中，它依然能给我们带来很好的高光效果。 

    ***




- **额外内容**

  在这一章介绍的光照模型都非常的简单；现实中我们是找不出完全粗糙或完全光滑的材料的。要知道，生活中复杂的材料是很常见的，比如衣服，木材和皮肤等等，这些材质涉及到物体表面下层的光如何散射的知识。

  我们用下面的表格来回顾我们之前学些过的不同光照模型知识：

  | Technique  | Type     | Unity 5 shader             | Light Intensity (I)                                          |
  | ---------- | -------- | -------------------------- | ------------------------------------------------------------ |
  | Lambertian | Diffuse  | Legacy Shaders \| Diffuse  | $I = N \cdot L$                                              |
  | Phong      | Specular |                            | $I = N \cdot L + (R \cdot V)^p$ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  $R = 2N\cdot(N \cdot L) - L$ |
  | BlinnPhong | Specular | Legacy Shaders \| Specular | $I = N \cdot L +(N \cdot H)^p $ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;$H = \frac{V+L}{\|V+L\|}$ |

  下面的链接有一些关于粗糙表面的更有趣的光照模型，比如**Oren-Nayar**：
  
  [https://en.wikipedia.org/wiki/Oren%E2%80%93Nayar_reflectance_model](https://en.wikipedia.org/wiki/Oren%E2%80%93Nayar_reflectance_model)

