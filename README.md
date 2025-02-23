---
category: shader
tags: [U3D, Shader,Cookbook,中文版]
---

​		我打算试着翻译这本技术书，目的又两个，1.希望自己能帮助英文不太好的朋友，2.希望自己也学到这些知识，顺便帮助自己提升英语水平。我英语水平不是很好，接下来如果有什么错误的地方，有看到的朋友还请帮忙纠正。我不会web前端技术，我想试着学学markdown语法，尽量让页面好看些但是最重要的还是内容。

  

## Unity 5.x Shaders and Effects Cookbook中文版（第二版）

## 目录表

## [鸣谢](#credits)

## [关于作者](#about_author)

## [www.PacktPub.com](#packtpub)

* [电子书, 优惠, 还有其他](#ebook)

* [为什么需要订阅?](#subscribe)

## [前言](#preface)

- [这本书包含哪些内容](#whatcover)

- [学习的过程中你需要准备的](#youneed)

- [本书的适合人群](#who_for)

- [内容结构](#sections)

  + [始前准备](#sections)

  + [操作步骤](#sections)

  - [原理介绍](#sections)

  + [额外内容](#sections)

  - [相关补充](#sections)

- [本书的一些文体说明](#Conventions)

- [读者反馈](#feedback)

- [客户支持](#support)

  - [示例代码下载](#codedownload)

  - [本书一些彩图的下载](#downloadPDF)

  - [勘误表](#errata)

  - [盗版声明](#piracy)

  - [本书有问题请联系](#questions)

## 1.[创建你的第一个着色器](#chapter1)

- [介绍](#cha1_intro)

- [创建一个基本的标准着色器](#CBSS)
  - [始前准备](#CBSS_getting_ready)
  
  - [操作步骤](#CBSS_how_to_do_it)
  
  - [原理介绍](#CBSS_how_it_work)
  
  - [额外内容](#CBSS_see_also)
  
- [如何把Unity 4的旧着色器迁移至Unity 5](#MLSUU)
  - [始前准备](#MLSUU_getting_ready)
  
  - [操作步骤](#MLSUU_how_to_do_it)
    - 着色器版本的自动升级
    
    - 使用标准着色器
    
    - 迁移用户自定义的着色器
  
  - [原理介绍](#MLSUU_how_it_works)

  - [额外内容](#MLSUU_see_also)

- [给着色器添加属性](#APTS)
  - [始前准备](#APTS_getting_ready)
  
  - [操作步骤](#APTS_how_to_do_it)
  
  - [原理介绍](#APTS_how_it_works)
  
  - [额外内容](#APTS_see_also)
  
- [使用表面着色器的属性](#UPISS)
  - [操作步骤](#UPISS_how_to_do_it)
  
  - [原理介绍](#UPISS_how_it_works)
  
  - [相关补充](#UPISS_there_is_more)
  
  - [额外内容](#UPISS_see_also)

## 2.[表面着色器和纹理贴图](#SSTM)

- [介绍](#SSTM_introduction)

- [漫反射的着色处理](#SSTM_diffuse_shading)

  - [始前准备](#SSTM_getting_ready)

  - [操作步骤](#SSTM_how_to_do_it)

  - [原理介绍](#SSTM_how_it_works)

- [使用包组](#UPA)
  - [操作步骤](#UPA_how_to_do_it)
    - 压缩矩阵
  
  - [额外内容](#UPA_see_also)
  
- [向着色器添加纹理](#ATTS)
  - [始前准备](#ATTS_getting_ready)
  
  - [操作步骤](#ATTS_how_to_do_it)
  
  - [原理介绍](#ATTS_how_it_works)
  
  - [相关补充](#ATTS_there_is_more)
  
  - [额外内容](#ATTS_see_also)
  
- 通过改变UV值来移动纹理

  - 始前准备

  - 操作步骤

  - 原理介绍

- 法线贴图

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 创建一个带透明度的材质

  - 始前准备

  - 操作步骤

  - 原理介绍

- 创建一个有全息效果的着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

  - 额外内容

- 纹理的压缩和混合

  - 始前准备

  - 操作步骤

  - 原理介绍

- 在地形的表面绘制一个圆

  - 始前准备

  - 操作步骤
    - 在表面移动这个圆

  - 原理介绍

## 3. 理解光照模型

- 介绍

- 创建一个自定义的漫反射光照模型

  - 始前准备

  - 操作步骤

  - 原理介绍

- 创建一个Toon风格的着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 创建一个Phong类型类型的高光反射着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

- 创建 BlinnPhong 类型的高光反射着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 额外内容

- 创建各向异性类型的高光反射着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

## 4.Unity 5中基于物理原理的渲染

- 介绍

- 理解金属质感的设置

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 额外内容

- 向PBR中添加透明度

  - 始前准备

  - 操作步骤

    - 半透明材质

    - 物体如何消失

    - 如何在显示物体中挖一个孔

  - 额外内容

- 创建镜子和反射面

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 额外内容

- 烘培场景中的光

  - 始前准备

  - 操作步骤

    - 场景中静态几何体的设置

    - 光探针的设置

    - 光的烘培

  - 原理介绍

  - 额外内容

## 5.顶点函数

- 介绍

- 在表面着色器中访问顶点颜色

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 对表面着色器中的顶点使用动画

  - 始前准备

  - 操作步骤

  - 原理介绍

- 模型的形变

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充
    - 添加形变纹理

- 实现一个被雪覆盖的着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

    - 为物体表面设置颜色

    - 修改几何体

  - 额外内容

- 实现范围体爆炸

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

  - 额外内容

## 6.片元着色器和通道提取

- 介绍

- 理解顶点和片元着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

    - 顶点的输入语义

    - 顶点的输出语义

  - 额外内容

- 使用通道提取

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 实现一个玻璃效果的着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 在2D游戏中实现水效果的着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

## 7. 移动设备着色器适配

- 介绍

- 什么是低成本着色器?

  - 始前准备

  - 操作步骤

  - 原理介绍

- 着色器的性能分析

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 针对移动设备修改着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

## 8.通过Unity 渲染纹理实现屏幕特效

- 介绍

- 设置屏幕特效脚本系统

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 亮度, 饱和度和对比度在屏幕特效中的作用

  - 始前准备

  - 操作步骤

  - 原理介绍

- 屏幕特效中基础的照片融合模式

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 屏幕特效中的叠加混合模式

  - 始前准备

  - 操作步骤

  - 原理介绍

## 9.游戏和屏幕特效

- 介绍

- 创建一个老电影屏幕特效

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 额外内容

- 创建一个夜视仪效果的屏幕特效

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

## 10.更高级的着色器技术

- 介绍

- 使用Unity内建的CG包含文件功能

  - 始前准备

  - 操作步骤

  - 原理介绍

- CG包含文件功能如何让着色器模块化

  - 始前准备

  - 操作步骤

  - 原理介绍

- 实现一个毛皮效果的着色器

  - 始前准备

  - 操作步骤

  - 原理介绍

  - 相关补充

- 如何通过数组来实现热图

  - 始前准备

  - 操作步骤

  - 原理介绍







***

<span id="credits"></span>

**鸣谢** 

**本书作者** 

Alan Zucconi 

Kenneth Lammers 

**审稿** 

Kenneth Lammers 

**组稿编辑** 

Priya Singh 

**策划编辑** 

Rahul Nair 

Erol Staveley 

**项目内容编辑** 

Mehvash Fatima 

**技术编辑** 

Pranil Pathare 

Danish Shaikh 

**文字编辑** 

Tasneem Fatehi 

**项目助理** 

Kinjal Bari 

**校对员** 

Safis Editing 

**索引员** 

Monica Ajmera Mehta 

**图像** 

Kirk D’Penha 

Disha Haria 

**制作协调员** 

Nilesh Mohite 

**封面设计** 

Nilesh Mohite



---

<span id="about_author"></span>

**关于作者** 

**Alan Zucconi** 是一个充满激情的开发者, 作者, 和一个激励的演讲者, 是开发者领域的佼佼者。 有着过去10年来相关领域的专业技能积累，并且决定在今后把精力都放在学术领域和游戏产业领域。作为一名自由职业者，他以非凡的创造力去探索如何让游戏更好的与艺术结合。  在此之前，他在伦敦帝国理工学院工作，在这里他发现了他教学和写作的激情。 他的头衔包括了 gravity puzzle, 0RBITALIS, 和the upcoming time travel platformer, Still Time（这些单词实在不知道怎么翻译了，应该是游戏名字）. 

**Kenneth Lammers** 在游戏领域有超过15年的经验, 担任过角色艺术家，技术美术，技术美术总监，和程序员。这让他有机会参与《使命召唤3》《除暴战警2》 《心灵杀手》和《Kinect星球大战》等众多著名游戏的开发。他现在跟他的商业伙伴**Noah Kaarbo**一起运营自己的Ozone 工作。，同时，他们也跟亚马逊，Eline Media，IGT和微软也有过合作。他之前为微软游戏工作室，动视和Surreal工作过。现如今他离开了哪些工作室，一手开办了自己的 CreativeTD 和 Ozone 工作室（感觉翻译成互动娱乐更好）。Kenny通过Packt Publishing出版社写了他的第一版 《Unity Shaders and Effects Cookbook》书，整个过程非常的愉快。

***

<span id = "packtpub"></span>

## [www.PacktPub.com](https://www.packtpub.com/)

这是一个电子书的网站，等于是帮这个网站宣传了吧，大家直接点击超链接进去看就行了。一般来说，你只要在上面买了电子书，特别是技术书籍，相关的代码，附件也可以从上面下载。

***

<span id = "ebook"></span>

**电子书, 优惠折扣, 额外信息**

**Packt **电子书网站拥有包含pdf和ePub格式的所有已经出版的书籍的电子书。你可以在www.PacktPub.com 更新你的电子书版本并且如果你购买过相应的纸质书籍的话，可以在购买对应的电子版本时享有折扣。你可以通过 <customercare@packtpub.com> 这个邮箱向我们了解优惠的详细信息。你可以在 www.PacktPub.com 阅读一系列免费的技术文章，现在在网站注册可以获知最新的免费和折扣信息 

[https://www2.packtpub.com/books/subscription/packtlib ](https://www2.packtpub.com/books/subscription/packtlib)

（告诉大家一个不幸的消息，上面这个网址已经过期了） 

你是否因为IT技术问题缺乏具体的示例而苦恼，上面这个网站也许可以帮到你，这是一个在线的数字图书馆。你可以在这个数字图书馆上搜索，获取资料和阅读**Packt**电子书网站为你准备的丰富的电子书。



***

<span id = "subscribe"></span>

**为什么希望你订阅?** 

可以查阅所有 **Packt**网站发布的的书籍 

可以拷贝，打印所有书籍 

可以通过浏览器查找你最需要的资料



***

<span id = "preface">

## 前言

**Unity 5.x Shaders and Effects Cookbook**这本书能让你在Unity5引擎中创建着色器和特效更加得心应手，能让你入门起来比较容易，学会创建大部分基础的着色器，并且学会如何组织你的着色器代码。本书的章节安排是循序渐进的，每一章节的基础知识，旨在后面让你能实现更高级的技术技巧，比如实现范围体爆炸效果，毛皮特效等。这本书是专门在Unity5这个游戏引擎下讲解的，希望帮助你掌握诸如基于物理原理的渲染和全局光照等知识，让你尽可能获得照片级的效果。 

在每一章的结尾，你都会获得一些新的技巧，这些技巧有助于提高你的着色器质量并且让你在写着色器的时候更加有效率。 为了让你能从入门到专家，每一个章节的特殊技巧和知识点都是我们为你精心编排的。对于着色器的初学者来说，你也可以通过一个章节一个章节的阅读，逐渐丰富你的着色器知识。不管怎样，通过本书的知识点，可以让你的游戏在次世代看起来更棒。当你完成这本书的学习之后，在Unity3d创建游戏的过程中，你就可以有各种各样的着色器用于你的游戏，并且了解怎么向你的游戏中去添加它们，怎么向你的游戏添加各种特效，怎么去优化你的游戏。让我们开始吧。

***

<span id = "whatcover"></span>

**这本书包含哪些内容** 

**<u>第一章</u>**,创建你的第一个着色器, 向你介绍如何在unity4和unity5中编写着色器代码（我会试着在unity2018上去实验，保证shader代码的正常执行，不限于unity4和5）。 

**<u>第二章</u>**, 表面着色器和纹理贴图, 介绍了一些如何实现表面着色器的通用且实用的技术，比如如何给游戏模型使用纹理和法线贴图。 

**<u>第三章</u>**, 理解光照模型，带你深入理解在给模型使用着色器时光带来的影响，这一章会教你一些如何实现自定义的光照模型的技术技巧，以便于你去实现一些独特的特效，比如Toon着色器效果。 

**<u>第四章</u>**, Unity 5中基于物理原理的渲染, 这一章为你介绍在unity5中基于物理原理的标准渲染技术，这些技术主要是为了在你的游戏中实现次世代的画面（直译就是看起来跟现实世界一样）。会向你解释如何尽可能的模拟这种现实，让你对透明度，反射表面和全局光照有更深入的理解。 

**<u>第五章</u>**, 顶点函数,向你介绍如何使用着色器来修改游戏中物体的几何特性；想知道范围体爆炸，着色器模拟下雪等特效嘛？这一章里的着色器操作顶点的技术技巧会告诉你如何实现 

**<u>第六章</u>**, 片元着色器和通道提取, 这一章会解释如何使用半透明材质和通道提取来实现扭曲形变效果 

**<u>第七章</u>**, 移动设备着色器适配，主要介绍如何针对移动设备进行优化。 

**<u>第八章</u>**, 通过Unity 渲染纹理实现屏幕特效,介绍了通过该技术才能更容易实现的视觉特效的实现方式。 

**<u>第九章</u>**, 游戏和屏幕特效,向你介绍一些游戏后处理特效，让游戏模拟的更加真实，比如夜视仪特效。 

**<u>第十章</u>**, 更高级的着色器技术,介绍一些向毛坯特效的着色器，热图渲染等本书会涉及的大部分高级技术技巧  

***

<span id="youneed"></span>

**学习的过程中你需要准备的**
下面列举了在学习本书知识的过程中必须的工具软件和可选的工具软件:

- Unity5引擎
- 一款3D建模软件，比如Maya，3DMax，或Blender (可选l)
- 一款2D图片编辑软件，比如PS或者Gimp (可选)  



***

<span id = "who_for"></span>

**本书的适合人群** 

本书适合色器编程初学者，或者想通过专业的后处理特效让游戏更棒的开发者。 

当然开发者本身需要对Unity游戏引擎有比较深入的理解。

***

<span id = "sections"></span> 

**内容结构** 

在本书中， 会经常出现一系列的小标题 (**始前准备**，**操作步骤**，**原理介绍**，**额外内容** ，**相关补充**)。

主要功能是对每一个知识点进行说明，如何完成该知识点的掌握。下面说明具体的用法： 



- **始前准备** 

  这个部分会告诉你这个知识点会学习什么，怎么安装和设置对应的软件。 

- **操作步骤**

  这个部分包含了学习该知识点包含那些步骤。

- **原理介绍**

  该部分通常是为了详细解释“**操作步骤**”这个部分的知识原理，上面的每一步到底做了什么。

- **额外内容**

  为了让读者了解更多与该知识点相关的额外知识，我们才准备了这个额外信息让读者阅读。

- **相关补充**

  如果想了解更多与该知识点相关的信息，这里还额外提供了一些相关链接。



***

<span id = "Conventions"></span>

**本书的一些文体说明** 

在书中你可以发现很多种不同的文本样式用来表示不同的信息内容。这里列举几个来解释一下。（需要说明一下的是，我在翻译的过程中，代码的字体样式可能会跟书本上不一样，我主要是用markdown的代码块来表示。然后它的粗体，比如强调，那我就用markdown中的强调标签来表示，说声抱歉了，希望大家能看的懂）

代码块，数据库表名，文件夹名字 ，文件名字，文件扩展名，路径名称，虚拟URL（觉得这个翻译不准确），用户输入，推特账号等会按照如下表示：“请输入下面的代码到你的着色器属性块（**Properties **）中” 

```c#
void surf (Input IN, inout SurfaceOutput o) 
{ 
	float4 c; 
	c = pow((_EmissiveColor + _AmbientColor), _MySliderValue); 
	o.Albedo = c.rgb; o.Alpha = c.a;
}  
```

当我们想提醒你代码块中的特别部分，那么对应的代码行或者语句会用粗体标记,比如那个void：(代码块中我不知道怎么加粗，下面这个就不用代码块了)

**void** surf (Input IN, inout SurfaceOutputStandard o)  

{  

​	fixed4 c = pow((_Color + _AmbientColor), _MySliderValue);  

​	o.Albedo = c.rgb;  

​	o.Metallic = _Metallic; 

​	o.Smoothness = _Glossiness;  

​	o.Alpha = c.a;  

}



**新的术语** 和 **非常重要的词语** 都应该用粗体表示.像出现再电脑屏幕中的菜单和弹窗中的文本，也会用粗体加以强调。比如：“在Unity编辑器的菜单栏中的“**项目(Project)**,在**资产(Assets)**文件夹上右键单击和在菜单中选择**创建(Create)\|文件夹(Folder)**。” （中文后面括号里的是英文版的编辑器中菜单项的名字）

**注意(Note)** 

警告或者很重要的注意会像这样，有个**注意(Note)**提醒你。 

**提示(Tip)** 

提示和小技巧会像这样，有个**提示(Tip)**提示你。  

***

<span id="feedback"></span>

**读者反馈** 

非常欢迎来自各位读者的反馈。这能让我们知道你们是否喜欢这本书。你们给与的重要反馈可以让我们写出更适合且对你们更有帮助的内容。 

通常最简单的反馈方式是通过<feedback@packtpub.com>邮箱给我们发邮件，然后在反馈邮件的标题中告诉我们书标题。 

如果在本书中有你擅长领域的话题想跟我们讨论，或者你愿意把你专长领域的知识贡献给本书，也可以通过这个网址 [www.packtpub.com/authors](https://www.packtpub.com/authors)的指引进行操作



***

<span id="support"></span>

**客户支持** 

很高心您能拥有此书，为了让您物有所值，我们还为你准备了很多东西（很搞不懂这也要搞一个章节出来，就一句话）。

 

 

 

 

 

 

***

<span id="codedownload">

**示例代码下载** 

通过这个网站[http://www.packtpub.com](https://www.packtpub.com/)，你可以用自己的账号下载本书的实例代码(其实我本人是建议自己手动敲一遍，我试了一下，代码是可以直接在这个网站下载的，就算你没有购买这本书也是可以的。但是需要注册一个账号才行，然后搜索到这本书，这本书的页面下面就有下载代码的链接)。如果你在别的地方购买了这本书，那么你可以浏览网站[ http://www.packtpub.com/support](https://www.packtpub.com/support)注册一个账号，然后在该页面直接通过书名搜索，也能找到这些文件的下载链接。

代码文件可以通过下面的步骤获得：

1. 通过邮箱和账号密码在我们的[网站](https://www.packtpub.com/)上登陆或者注册。

2. 把网页拉到最下面，点击**支持主页([Support Home](https://www.packtpub.com/support))**（这本书出了很久了，网页早就改版了，这是我实际打开网页的操作步骤）。

3. 然后点击该页面左边的**代码下载&勘误表(Code Downloads & Errata)**。

4. 然后在**搜索(Search)**框中输入你的书名（不用输入完整的书名，支持模糊搜索）。

5. 选择那本你想要下载代码的书。

6. 然后在下面的下拉菜单中选择你是从哪儿购买本书的（不要紧，随便选一个，然后下拉菜单的下面就会有一个下载链接）。 

7. 然后点击**代码下载**（链接早就生成了，为了方便大家，我贴出链接，点击就可以[下载](https://account.packtpub.com/getfile/9781785285240/code)了，不清楚是否是永久链接）

下载好后，请自行解压，然后就可以获得本书的代码了。

 

 

 

 

 

 

***

<span id="downloadPDF">

**本书一些彩图的下载** 

这本书中的彩图，比如说屏幕截图/示意图我们都把他放在了一个PDF文件中。希望这些图片可以让你更好的理解屏幕输出图像的变化。 你可以通过下面的链接下载这个PDF文件[https://www.packtpub.com/sites/default/files/downloads/Unity5xShadersAndEffectsCookboo](https://static.packt-cdn.com/downloads/Unity5xShadersAndEffectsCookbook_SecondEdition_Graphics.pdf)





***

<span id="errata"></span>

**勘误表** 

尽管我们非常注意本书内容的准确性，但还是会有不小心出错的地方。如果您在我们出版的书中（不限本书）找到了错误，有可能是文字错误或者代码错误，我们非常欢迎您将这些错误报告给我们。如此善举，既解他人之惑，亦可助改善此书。如果您发现任何勘误，请通过链接[https://www.packtpub.com/support/errata](https://www.packtpub.com/support/errata) （原书写的链接失效了）向我们报告。当您的勘误确认后，您提交的勘误将会被接受并且勘误会上传至我们的网站和任何已存在的勘误名单中。 如果您想看看之前的勘误提交，可以访问[https://www.packtpub.com/support/code-downloads](https://www.packtpub.com/support/code-downloads)（原书的网址失效了，现在是这个），然后输入书名搜索，你想要的信息会出现在下面的勘误部分。

***

<span id="piracy"></span>

**盗版声明** 

在网上，所有媒体的版权资料盗版问题从未停歇。 在**Packt**网，我们非常重视保护我们的版权和许可证。如果你在英特网上看到任何来自我们工作成果的 非法拷贝，不管来自那里，还请你提供给我们地址或者网址，这样我们可以挽回我们的损失。还请通过<copyright@packtpub.com>邮箱联系我们。 

我们非常感激您帮助我们保护作者和保护我们继续给你带来有价值的内容。

***

<span id="questions">

**本书有问题请联系** 

如果您对本书有任何层面的问题，您可以通过邮箱<questions@packtpub.com>联系我们，我们会尽己所能改善这些问题。

***

<span id="chapter1"></span>



## 第一章 创建你的第一个着色器

在这一章我们包含了一些在当今**游戏开发着色器管线**中更通用的漫反射技术基础。在这一章我们将会学习下面的知识点: 



- 创建一个基础的标准着色器
- 从Unity4迁移旧着色器至Unity5
- 为着色器添加属性
- 在表面着色器中使用属性



<span id="cha1_intro">

### 介绍

让我在脑海中想象一个完全由白色绘制立方体。尽管立方体的每一个面的颜色都是相同的，但是由于不同方向的光线照射和我们看这个立方体的角度的不同，我们总能发现立方体不同的白色阴影。这种层级的逼真场景就是通过3D图形学中的着色器实现的，它是一种模拟光的作用原理的特别的程序。一个木质的立方体和一个金属的立方体也许可以是同一种3d模型，之所以让他们看起来一个是木质的，一个是金属的，就是因为它们使用了不同的着色器的缘故。我们循序渐进，第一章将会向你介绍如何在Unity中进行着色器编码。如果你从来没有编写着色器的经验，那么在这一章，你将会了解着色器是什么，他们如何工作和如何自定义着色器。 接着在这一章的结尾，你将会学习如何构建拥有基础操作的基础着色器。有了这些知识后，那么你将可以创建任何的表面着色器。

<span id="CBSS"></span>

### 创建一个基本的标准着色器

每一个Unity游戏开发者应该都对**组件(components)**这个概念非常熟悉。游戏中的对象都有很多的组件，这些组件决定了游戏中的对象看起来是什么样子和会有什么样的行为。然而**游戏脚本(scripts )** 定义的是游戏对象会有怎样的行为，**渲染器(renderers )**决定游戏对象如何出现在屏幕中。 对于我们想要看到游戏对象类型，Unity本身提供了一些渲染器。每一个3D模型通常都有一个网格渲染器。一个游戏对象应该只能有一个渲染器，但是一个渲染器它可以包含多个**材质(materials)**。 每个材质封装了一个着色器--3D图形的最后一环。这些组件的关系可以用如下的示意图表示：

![donate](https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram1.png")



<center>理解这些组件之间的不同之处对于理解着色器的工作原理是很有必要的</center>

***

<span id="CBSS_getting_ready">


- **始前准备**
  开始学习这个知识点之前，你需要打开你的Unity5并且创建一个新的项目。本书的内容讲解都会在这个项目中开展，随着学习的深入你之后自己创建的着色器都可以放在这。这一步完成之后----欢迎来到着色器实时编程的精彩世界。 

***

<span id="CBSS_how_to_do_it">


- **操作步骤**

  在创建我们的第一个着色器前，让我们为实验着色器创建一个简单游戏场景。首先我们导航到Unity的菜单栏，然后选择**游戏对象\|创建空对象**。然后在Unity编辑器的**层级面板(Hierarchy)**选中刚刚创建的空对象，在上面创建一个平面作为地面，再创建几个球体用来应用我们的着色器，然后在场景里面创建平行光源。当场景弄好后，我们接下来就按步骤开始着色器的编写： 

  1. 在编辑器的**项目(Project)**窗口中，直接右键选择**创建(Create)\|文件夹(Folder)**。【这里的文件夹名字我就直接用英文了，大家在自己开发的过程中也尽量用有意义的英文文件夹吧】
     **注意**
     如果你导入了本书提供的项目文件（就是你从网站上下载的代码，他是一个unitypackage包，导入之后这个文件自动就有了），你可以直接跳至步骤4。
     
  2. 选择该文件夹，右键然后选择**重命名(Rename)**，把这个文件夹命名成**Shaders**。或者你也可以选中该文件夹，然后按**F2**，重命名为**Shaders**。
  
  3. 用上面同样的方法创建一个**Materials**的文件夹，用来放材质文件的。
  
  4. 右键**Shaders**文件夹，然后在出的窗口中选择**创建(Create)\|着色器(Shader)\|标准表面着色器(Standard Surface Shader)**（这里注意跟原文不一样，创建一个着色器要三步，书中只有两部）。接着我们创建一个材质，右键**Materials**文件夹，然后在弹窗中选择**创建(Create)\|材质(Material)**。
  
  5. 把刚刚创建的着色器和材质都命名成**StandardDiffuse**。【各位，文件名也用英文呀，因为怕Unity对中文的支持不好】
  
  6. 然后用Visual Studio 2015或者Visual Studio Code打开**StandardDiffuse**这个着色器【这里我不建议用MonoDevelop这个编辑器，原文是用这个，不好用，强烈建议用各位用Visual Studio Code打开，这个编辑器很好用，一定要去试试】   
   **注意**  
   打开着色器你会发现Unity其实已经为我们的着色器生成了一些基本的代码。这些基础代码给了你一个基础的漫反射着色器，而且可以传入一张纹理。我们会在后面的步骤修改这些着色器代码，创建自己的着色器。
      
  7. 首先我们给自己的着色器一个自定义的文件夹【这不是传统的文件夹，我更倾向理解为材质选择路径】，这样方便使用时可以按照这个文件夹找到它。着色器的第一行代码是一段描述，这段描述的作用是当我们为材质选择着色器时，这段描述会会转换成选择路径，给材质添加我们自己的着色器。我们把这个路径重写为 **Shader "CookbookShaders/StandardDiffuse"**。当然你也能在任何时间把它命名为任何路径。不用特别在意这个路径名。然后记得保存我们的代码，然后切换回Unity编辑器。当Unity编辑器检测到着色器代码有更新，它会自动重新编译着色器。修改后的着色器代码如下所示：
	```c# 
	Shader "CookbookShaders/StandardDiffuse" {
		Properties {
			_Color ("Color", Color) = (1,1,1,1)
			_MainTex ("Albedo (RGB)", 2D) = "white" {}
			_Glossiness ("Smoothness", Range(0,1)) = 0.5
			_Metallic ("Metallic", Range(0,1)) = 0.0
			}
			SubShader {
				Tags { "RenderType"="Opaque" }
				LOD 200
				CGPROGRAM
				// Physically based Standard lighting model, and enable shadows on all light types
				#pragma surface surf Standard fullforwardshadows
				// Use shader model 3.0 target, to get nicer looking lighting
				#pragma target 3.0
				sampler2D _MainTex;
				struct Input {
					float2 uv_MainTex;
					};
				half _Glossiness;
				half _Metallic;
				fixed4 _Color;
				void surf (Input IN, inout SurfaceOutputStandard o) {
					// Albedo comes from a texture tinted by color
					fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
					o.Albedo = c.rgb;
					// Metallic and smoothness come from slider variables
					o.Metallic = _Metallic;
					o.Smoothness = _Glossiness;
					o.Alpha = c.a;
				}
				ENDCG
			}FallBack "Diffuse"
	}
	```
	8. 专业一点说，这是一个**基于物理原理渲染(physically-basedrendering)**的表面着色器，只是Unity5把它作为了一个内建的标准着色器。根据这种着色器的字面意思，这是一种根据现实中光的物理原理，来模拟游戏中光照射到物体时所表现的物理特性，通过这种模拟，来虚拟现实。 如果你用的时早期版本的着色器（比如Unity4），那么你的着色器代码跟现在的会有比较大的差别。相比于现在的基于物理原理的着色器技术而言，Unity4使用的技术还是相对比较简单的。所有的这些着色器类型我们会在本书后面的章节介绍。  
	9.  当你的着色器创建好后，我们需要将它与材质关联起来。选中我们之前在步骤4创建的**StandardDiffuse**材质，然后看**检查器面板(Inspector tab)**。然后再**着色器(Shader)**下拉列表中选择**CookbookShaders \| StandardDiffuse**。（如果你在第7步修改的路径跟书上不一样，那么这里的选项也不一样）通过上述步骤，你的着色器就会跟这个材质关联起来，你现在可以把这个材质添加到一个游戏对象中去了。
	      **注意**
	
	      你可以在**项目窗口(Project tab)**选中这个材质，然后直接拖拽到你在游戏场景中的游戏对象身上。当然你也可以直接选中这个材质，然后拖拽到Unity编辑器的**检查器面板(Inspector tab)**上，把这个材质应用到这个游戏对象上，前提是你要先选中这个游戏对象，然后再拖拽，这样**检查器面板(Inspector tab)**显示的才是游戏对象的属性。 
	
	      下面时这个示例的屏幕截图：【各位按照自己的情况来就行了，不一定非要找一个跟书本一样的模型】
	

![donate](https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram2.png")     
_看起来很简陋, 但是着色器开发环境搭建好了，接下来我们可以开发自己想要的着色器了_
***

  <span id="CBSS_how_it_work"></span>

- **原理介绍**

  Unity帮助你简化了着色器运行的环境配置，你很多时候只需要点击鼠标就可以完成。但事实上这些简单的操作背后有着大量的各种各样的工作，只是Unity引擎替你做了。Unity 使用CG着色器语言，并且它在背后做了大量的工作【unity会自动生成相应的CG代码】，让你在写着色器的时候非常高效。用表面着色器格式的语言来写着色器更加方便。比如处理你自己的纹理的坐标或者线性变换矩阵，这些功能都已经准备好，不用再从头开始。以前写着色器，你必须重新创建一个着色器然后一遍又一遍的重新很多代码。随着你对表面着色器的深入理解，你可能会越想了解CG语言更底层的功能以及Unity是如何处理那些更底层的**图形处理单元(graphics processing unit (GPU))**任务的。  

  **注意**
  Unity项目中的所有文件都有自己的引用，跟它在你电脑上具体的某个文件夹上没有关系。我们在编辑器上，你可以可以随便移动着色器文件和材质文件，它们之间不会有关联信息丢失的风险。但你千万不要在编辑器外面移动这些文件，【比如直接打开项目文件夹，在电脑上直接移动这些文件】这样的话Unity编辑器不能够更新这些文件之间的关联，可能会发生丢失的情况。 

  我们通过简单的修改着色器的路径属性可以给着色器一个我们想要的名字，我们在Unity环境中进行了基础的漫反射着色器的研究，包括光呀，阴影呀之类的。而这些，仅仅是通过改变一行代码。  
  
  ***
  <span id="CBSS_see_also"></span>
- **额外内容** 
  
  在Unity5中内建的着色器的源码通常被隐藏起来了，你不能像打开自己的着色器代码那样打开它。在你的Unity安装目录**Unity45\Editor\Data\CGIncludes**，你能找到大部分的Unity内建的CG功能代码。在这个目录下面，你能找到被Unity隐藏起来的一些着色器。
  经过多年的迭代，它们已经发生了很多的改变；如果你想查阅Unity不同版本之间的色器源码发生了那些变化，下面这个网站也许是个好去处：[https://unity3d.com/get-unity/download/archive](https://unity3d.com/get-unity/download/archive)。选择你的Unity版本，然后在下拉列表中选择**内建着色器(Built in shaders)** ，如下图所示。 此时我们需要留意其中的三个文件—**UnityCG.cginc**，**Lighting.cginc**和**UnityShaderVariables.cginc**。我们现在学习的着色器都只要用到这三个相关的文件：

  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram3.png"/></div>	      
  <center>第十章.<i><b>更高级的着色器技术</b></i>, 我们将会深层次探索如何使用GcInclude进行模块化的着色器编程</center> 

***





<span id="MLSUU"></span>


### 如何把Unity 4的旧着色器迁移至Unity 5
不可否认，在过去10年中图形学在电子游戏中获得了惊人的发展。每一个新游戏带来的尖端技术让我们的游戏画面更加接近现实。随着Unity引擎版本的不断迭代，它的着色器技术也自然而然的经历了相当大的变化。这也是为什第一次接触着色器的时候感到困惑的原因。在Unity5还没有推出之前，Unity自带了两种不同的着色器，分别是：**漫反射(Diffuse)**和**高光反射(Specular)**。正如其名字所描述，它们分别用来模拟表面粗糙和表面光滑的材料。如果你现在使用的Unity5，那么你其实可以跳过这个知识点。该知识点会讲解如何在Unity5中重现这些效果。 


***

- **始前准备**<span id="MLSUU_getting_ready"></span>

  要开始这个知识点，前提时你有个用Unity4版本作为开发引擎工作空间，并且你使用了这个版本内建的一些着色器。当你开发新游戏的时候，毫无疑问你应该改选择最新版本的Unity引擎。然而如果你的项目已经使用了旧版的Unity引擎开发，那么你在迁移着色器前应该三思。引擎背后可能又很多东西都不一样了，即使有时候内建的着色器表面看起来可以正常工作，但是你写的脚本可未必能。所以如果你要迁移整个项目空间，这个时候首先要做的事情就是备份。但是要注意噢，仅仅只是保存Assets资源和场景可不够，同时所有的.meta文件也要一并保存，因为大多数Unity的配置信息保存在元数据中。在迁移项目的过程中最稳妥的办法还是要把整个项目空间所在文件夹都复制一份。最好的是物理拷贝一份，如果是windows就在资源管理器物理复制，如果是Mac就在Finder中物理复制。【建议大家将这个项目目录用压缩工具【如winrar】打包一份】。
  
***

  

- **操作步骤**<span id="MLSUU_how_to_do_it"></span>

  如果你想要迁移你的内建着色器，有两个主要选择：采用自动升级的方式或者切换至**标准着色器**

  - **着色器版本的自动升级**

    这种选择是最操作起来最简单的。Unity5可以导入使用旧版内建着色器的项目并且自动升级。你需要主义的是一旦升级完成后，那么你在Unity4中就不能再使用它们了。尽管这个过程并没有直接改变你的Assets资源，但是Unity的元数据已经被转换过了。要进行这个过程，你需要打开Unity5引擎，然后点击**文件(File)\|打开项目(Open Project)**来打开你就项目所在的文件夹。然后回有提示问你是否愿意转换；然后点击**升级(Upgrade)**执行改过程。Unity就会重新导入所有的Assets资源并且重新编译所有的游戏脚本。如果你的项目非常巨大，这个过程可能回持续几个小时。一旦转换完成，来自Unity4的内建的旧着色器会被相应的替换掉。 你可以通过检查器面板验证这个转换，材质实例中从原来的**Bumped Diffuse**变为了**Legacy Shader/Bumped Diffuse**。
    
    **注意**
    
    尽管Unity4版本的漫反射，高光反射和其他内建的着色器现在已经已弃用了，但是Unity5依然向后对它们保持兼容。它们在材质的**Legacy Shaders**路径下的下拉列表中依然可以看到。
    
  - **使用标准着色器**
  
    相比于使用旧版本的着色器，你可能想使用Unity5新的内建标准着色器替代它们。但是这么做之前，请留意新旧两个版本的着色器是基于不同的光照模型的，你的材质很可能看起来不一样。Unity4总共有8个不同的内建着色器，它被划分进了6个大类(**法线(Normal)**，**透明(Transparent)**，**透明剪切(Transparent Cutout)**，**自发光(Self-Illuminated)**和**反射(Reflective)**)。但在Unity5中，它们都被上一个知识点所讲的那些标准着色器所替代了。不幸的是，没有什么很好的办法能够将旧着色器完美的迁移只新版本的着色器。但是你可以通过下面这个表格着重理解如何通过配置标准着色器去模拟unity4的旧着色器的效果：
    
    
    <table>
        <tr>
            <th>Shader</th>
            <th>Unity 4 </th>
            <th>Unity 4 (Legacy)</th>
            <th>Unity 5</th>
      </tr>
        <tr>
            <td>Diffuse</td>
            <td>Diffuse Lambert</td>
            <td>Legacy Shader/Diffuse Lambert</td>
            <td>Standard Physically-based rendering: Metallic Workflow</td>
        </tr>
        <tr>
            <td>Specular</td>
            <td>Specular Blinn-Phong </td>
            <td>Legacy Shader/Specular Blinn-Phong</td>
            <td>Standard (Specular setup) Physically-based rendering: Specular Workflow</td>
        </tr>
        <tr>
            <td rowspan="2">Transparent</td>
            <td>Specular Blinn-Phong </td>
            <td>Legacy Shader/Transparent Vertex-Lit</td>
            <td>Standard Rendering Mode: Transparent</td>
        </tr>
         <tr>
            <td>Transparent Cutout Vertex-Lit </td>
            <td>Legacy Shader/Transparent Cutout Vertex-Lit</td>
            <td>Standard Rendering Mode: Cutout</td>
        </tr>
    </table>
    
    你可以在旧材质的**检查器面板(Inspector)**上通过**着色器(Shader)**下拉菜单改变它所使用的着色器。所有你需要做的就是简单的选择适当的标准材质。如果你的旧着色器使用了纹理，颜色和发现题图，那么在新版本的标准着色器上也会自动使用。当然为了更好的接近之前旧版本着色器的光照模型，你可能需要配置标准着色器的相关参数。 下图展示的是常见的斯坦福兔(*Stanford bunny* )，它们分别使用旧版本的漫反射着色器(右)，被转换的标准着色器(左)，和把**平滑度(Smoothness)**设置成0的标准着色器(中)：
    
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram4.png"/></div>	 


  - **迁移用户自定义的着色器** 

    如果你以前在Unity4上有写自定义的着色器，很有可能在Unity5中能直接正常使用。即使如此，Unity也有可能在着色器的工作原理上做了细小的改动，这些改动是可能引发一些错误和不一致性。有个变化最明显的重要参数就是光的强度。 光在Unity5中是原来亮度的两倍。所有的旧版本着色器在重写的的时候都应该考虑到这一点；如果你升级了你的着色器或者切换到标准着色器，你不会发现有任何的不同。但是如果你是自己写的光照模型，那么你就要注意确认光的强度不能再乘以二了。我们就用下面的代码举例来确认这种变化：

    ```c#
    // Unity 4
    c.rgb = s.Albedo * _LightColor0.rgb * (diff * atten * 2);
    // Unity 5
    c.rgb = s.Albedo * _LightColor0.rgb * (diff * atten);
    ```

    

    如果你还没有写过着色器，大可不必惊慌：光照模型会在第三章，**理解光照模型** 中全面详细的讲解。

    **注意**

    Unity5对着色器的处理相比于Unity4来说还有一些其他的变化，你可以下面这个网址中查看所有着色器在Unity5中的处理方式的变化 

    [http://docs.unity3d.com/Manual/UpgradeGuide5-Shaders.html](http://docs.unity3d.com/Manual/UpgradeGuide5-Shaders.html)。

***
  - **原理介绍**<span id="MLSUU_how_it_works"></span>

    着色器的编写需要权衡画面表现和效率；效果逼真的着色器需要极大的计算量，可能导致严重的延迟。所以，有一点很重要，就是只使用我们确切需要的效果：如果一个材质不需要高光反射，那么就不要在着色器中去计算它们。这也是在Unity4中把这些效果拆分成了很多不同着色器的主要原因。 新版本的标准着色器有潜力替换掉先前旧版本的着色器，因为它把法线贴图，透明度和反射都包括在内了。然而，这个标准着色器经过巧妙的优化，使它能够只去计算用到的效果，没用到的效果就不计算。尽管这样，标准着色器主要还是设计用于模拟现实的材质。相比较而言，漫反射和高光反射着色器并不是为模拟现实的材质设计的。 这就是为什么从旧版本的着色器切换到标准着色器时，游戏对象在渲染的时候通常回发生一些细小的变化的原因。




***
  - **额外内容**<span id = "MLSUU_see_also"></span>

    第三章， **理解光照模型**, 将会深入探索漫反射和高光反射着色器的作用原理。尽管在Unity5中，它们已经被弃用了，但是如果你想要设计新的光照那么理解它们还是有必要的。 
    
    第四章，**Unity 5中基于物理原理的渲染** ，将会介绍如何在Unity5中展现标准着色器的潜力。








***
<span id = "APTS"></span>

### 给着色器添加属性

着色器的属性对于着色器管线来说时非常重要，因为艺术家或者用户想要添加纹理或者调整着色器的值都是通过著色器的属性来修改的。着色器的属性在材质的**检查器面板(Inspector  )**中会提供GUI，提供图形界面让玩家去调整一个着色器，不用打开额外的编辑器。用Visual Studio Code打开你的着色器代码，从第2行到第7行的代码块就是着色器的**属性(Properties  )**。当前的这个着色器，他会有一个叫**_MainTex**的属性。如果你查看使用了这个着色器的材质，你能注意到着色器的**检查器面板(Inspector )**中有一个**纹理(texture )**的GUI元素。着色器中的这行代码为我们创建了这个GUI元素。还有就是，Unity工作人员通过编码方式和努力的迭代，让你改变属性的这个过程非常快速高效。 



***
- **始前准备**<span id = "APTS_getting_ready"></span>

  让我们来了解一下这个过程在**标准漫反射(StandardDiffuse)**着色器中是如何工作的，为此我们要创建自己的属性并且学习更多相关的着色器语法。比如我们会修改之前创建的着色器。在这个修改的着色器中，不适用纹理，而是仅仅使用能从**检查器面板(Inspector)**直接修改的颜色和其他的属性。开始之前，我们先复制一个**标准漫反射(StandardDiffuse)**着色器。你可以在**项目(Project)**面板中选中它，然后按**Ctrl + D**。这样就会复制一份新的**StandardDiffuse 1**的着色器。【书上的写法有问题，在Inspector面板根本不能选中复制，应该在项目面板中选中在复制】
  **注意**
  你最好给你复制的这个着色器在第一行代码处给它一个恰当的名字。比如，**Shader "CookbookShaders/StandardDiffuse"**可以告诉Unity这个着色器叫**StandardDiffuse**并且把它分组到**CookbookShaders**这个着色器组。如果你是通过**Ctrl + D**复制的着色器，你新复制的这个着色器跟被复制的着色器就会用相同的名字和分组。为了避免混淆，一定要记得复制着色器代码之后，在第一行那里修改着色器的名字，给一个不会重复的名字。 




***
- **操作步骤**<span id = "APTS_how_to_do_it"></span>

  当**StandardDiffuse2**这个着色器准备好后，我们就可以开始修改它的属性了：
  1. 在着色器的**属性(Properties )**块中，删除着色器中下面的属性代码，整行删除：
    ```c#
    _MainTex ("Albedo (RGB)", 2D) = "white" {}
    ```
  2. 当我们移除这个必要的属性后，着色器不会被编译直到所有跟**_MainTex**的代码都被移除。然我们删除另外有引用的代码：
    ```c#
    sampler2D _MainTex;
    ```

  3. 原始的着色器使用**_MainTex**给游戏模型上色。为了改变这个，我们替换掉**surf()**方法的第一行代码，通过如下代码：
    ```c#
    fixed4 c = _Color;
    ```

  4. 当你修改完成之后，返回Unity，然后着色器会被重新编译， 之后我们的材质**检查器**面板中就没有纹理选择这一选项了。 为了完成这个着色器的调整，让我们添加一个额外的属性给着色器，看看会有什么效果。输入下面的代码：
    ```c#
    _AmbientColor ("Ambient Color", Color) = (1,1,1,1)
    ```

  5. 我们在材质的**检查器**面板中添加了另一个颜色选项。现在，让我们来额外添加另一种类型的属性来找找属性语法的感觉。添加下面的代码到**属性**代码块中：
    ```c#
    _MySliderValue ("This is a Slider", Range(0,10)) = 2.5
    ```
  6. 我们创建了其他两种不同类型的GUI元素，它们可以让我们与着色器进行可视化的交互。我们这次创建了一个叫做**This is a Slider**的滑动条，就如下图所示：

      <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram5.png"/></div>	

  着色器的属性让你可以通过可视化的方式调整着色器，而不用在着色器自己的代码中调整。 下一个知识点将会为你介绍如何利用这些属性创建一些更有趣的着色器。
  **注意**
  尽管属性属于着色器，但是着色器上属性的值却是保存在材质上的。不同的材质可以很安全的共用相同的着色器。从另一方面说，修改材质上的属性的值，将会影响到所有使用了该材质的游戏对象的外观。 





***
- **原理介绍**<span id = "APTS_how_it_works"></span>

  每一个Unity的着色器都有它想要的内建的代码结构。**属性**代码块就是Unity所期望的功能之一。**属性**代码块的目的是让着色器编程人员能快速的创建GUI交互元素，并且将GUI元素与着色器代码相关联起来。那些你在着色器**属性**面板中申明的属性，能让你在着色器代码中使用，从而修改着色器中的一些值，颜色和纹理。 定义一个属性的语法[也可以叫语义，也可以叫语法糖]如下：
  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram6.png"/></div>	

  让我们来解释一下这个示意图。 当你第一次开始写一个新的属性时，你需要给这个书信一个**变量名(Variable Name)**。这个变量名能让着色器使用并且能让着色器代码获得来自该变量名绑定的GUI元素的值。这给我们节约了大量的时间因为我们不用自己来创建这么一个系统。属性的下一个元素时**检查器面板GUI名称( Inspector GUI Name )**和属性的**类型(Type)**，这两个元素放在一对括号中。当玩家想要交互和调整着色器时，**检查器面板GUI名称( Inspector GUI Name )**将会在材质的**检查器面板(Inspector tab)**中展示。**类型(Type)**就是这个属性想要控制的数据类型。在Unity着色器中，有很多属性可以使用的类型。下面这个表展示了我们在着色器中可以使用的变量类型： 

  <table>
    <tr>
      <th colspan="2" align="center" >Surface Shader property types</th>
    </tr>
    <tr>
      <td>Range (min, max)</td>
      <td>创建一个浮点类型的滑动条属性，值从最小值到最大值[min最小值，max最大值]</td>
    </tr>
    <tr>
      <td>Color</td>
      <td>在<b>检查器面板(Inspector tab)</b>中创建一个颜色选取框，当你打开的时候会弹出一个调色板，颜色值(R,G,B,A)[四个浮点数，分别表示红，绿，蓝，透明度]</td>
    </tr>
    <tr>
      <td>2D</td>
      <td>创建了纹理选取框的GUI元素，可以让玩家通过拖拽的方式给着色器一张纹理</td>
    </tr>
    <tr>
      <td>Rect</td>
      <td>创建一个非2次幂纹理[NPOT]选取框，功能更<b>2D</b>属性类似</td>
    </tr>
    <tr>
      <td>Cube</td>
      <td>在<b>检查器面板(Inspector tab)</b>创建一个立方体纹理[大家想想天空盒],可以让玩家拖拽立方体纹理到着色器中</td>
    </tr>
    <tr>
      <td>Float</td>
      <td>在<b>检查器面板(Inspector tab)</b>中创建一个浮点型的值，但是没有滑动条</td>
    </tr>
    <tr>
      <td>Vector</td>
      <td>创建一个有四个值的属性，能让你表示方向或者颜色</td>
    </tr>
  </table>
  最后就是这些属性的**默认值(Default Value)**了。可以在着色器代码中简单的给着色器的属性设置特定的值。在上一个图片属性改成颜色属性的列子中，属性
  
  **_AmbientColor**的默认值是一个**Color**类型的默认值，其值为**1，1，1，1**。这个颜色属性需要一个**RGBA**或者**float4**或者**r,g,b,a=x,y,z,w**赋值。颜色属性第一次创建的时候默认值时白色。





***
- **额外内容**<span id = "APTS_see_also"></span>

  着色器属性的文档在Unity手册中的位置在[http://docs.unity3d.com/Documentation/Components/SL-Properties.html](http://docs.unity3d.com/Documentation/Components/SL-Properties.html) 
  
***







<span id = "UPISS"></span>

### 使用表面着色器的属性

现在我们已经为着色器创建了一些属性，这里我们将要正式的把这些属性跟着色器关联起来，这些属性就像着色器的调节器一样，可以让材质拥有更好的交互性。 

我们可以在材质的**检查器面板(Inspector tab)**使用着色器属性的值，因为我们为这个属性添加了一个变量名，但是如果你在着色器代码中想要通过这个变量名来获得这个值，我们仍然还有很多事情要做。









***
- **操作步骤**<span id = "UPISS_how_to_do_it"></span>

  下面的步骤展示了如何在表面着色器中使用属性：
  1. 开始之前，我们先删除下面的行的代码,就好像我们在章节***创建一个基本的标准着色器***中删除属性的操作步骤一样，删除**_MainTex**属性：
  ```c#
  _MainTex ("Albedo (RGB)", 2D) = "white" {}
  ```
  ```c#
  sampler2D _MainTex;
  ```
  ```c#
  fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
  ```
  2. 下一步，添加下面这些行的代码到着色器代码中，添加到**CGPROGRAM**下面, add the following lines of code to the shader, below the CGPROGRAM line:
  ```c#
  float4 _AmbientColor;
  float _MySliderValue;
  ```
  3. 当第二部完成之后，我们就可以在着色器中使用属性的值了。我们把**_Color**属性的值与**_AmbientColor**值相加，并且把两者的结果赋值给**o.Albedo**。为了达成目的，我们需要在着色器代码中的**surf()**方法中添加如下代码：
  ```c#
  void surf (Input IN, inout SurfaceOutputStandard o) 
  {
        fixed4 c        = pow((_Color + _AmbientColor), _MySliderValue);
        o.Albedo        = c.rgb;
        o.Metallic      = _Metallic;
        o.Smoothness    = _Glossiness;
        o.Alpha         = c.a;
  }
  ```
  4. 最终你的代码将会是如下所示。如果你在你的VSCode中保存好然后返回Unity编辑器，你的着色器将会重新编译。 如果没有什么错误，那么现在你可以修改材质的环境光和自发光的颜色，当然也可以通过滑动条增加最终颜色的饱和度。听巧妙的噢。
  ```c#
  Shader "CookbookShaders/StandardDiffuse3" 
  {
        // We define Properties in the properties block
        Properties 
        {
            _Color ("Color", Color) = (1,1,1,1)
            _AmbientColor("Ambient Color", Color) = (1,1,1,1)
            _MySliderValue("This is a Slider", Range(0,10)) = 2.5
        }
        SubShader 
        {
            Tags { "RenderType"="Opaque" }
            LOD 200
            // We need to declare the properties variable type inside of the 
            //CGPROGRAM so we can access its value from the properties block.
            CGPROGRAM
            #pragma surface surf Standard fullforwardshadows
            #pragma target 3.0
            struct Input { float2 uv_MainTex;};
            fixed4 _Color;
            float4 _AmbientColor;
            float  _MySliderValue;
            void surf (Input IN, inout SurfaceOutputStandard o) 
            {
                // We can then use the properties values in our shader
                fixed4 c = pow((_Color + _AmbientColor), _MySliderValue);
                o.Albedo = c.rgb;
                o.Alpha = c.a;
            }
            ENDCG
        }
        FallBack "Diffuse"
  }  
  ```

- **提示**
  **下载示例代码**
  你可以在**Packt**网站登陆后，下载所有已购买书籍的所有示例代码文件，下载地址：[http://www.packtpub.com](http://www.packtpub.com)。如果你是在别处购买的书，那么请访问：
  [http://www.packtpub.com/support](http://www.packtpub.com/support)然后注册，以便通过邮件直接获取相关的代码文件。

- **注意**
  **pow(arg1, arg2)**这个方法是内置的，他的功能跟数学的幂函数**power**是等价的。第一个参数是底数，第二参数是指数 。想了解更深入的了解**pow()**方法，请去看Cg语言的教程。下面这个网址提供了非常棒的资源，能让你学习更多有关着色器的知识，并且里面有Cg着色器语言的所有函数的表：  
  [http://http.developer.nvidia.com/CgTutorial/cg_tutorial_appendix_e.html](http://http.developer.nvidia.com/CgTutorial/cg_tutorial_appendix_e.html) 
  下面的屏幕截图展示了通过材质的**检查器面板(Inspector tab)**来控制材质的属性，从而控制材质的颜色和饱和度：
  
  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram7.png"/></div>
***








- **原理介绍**<span id = "UPISS_how_it_works"></span>

  当你在**属性(Properties )**代码块中声明一个新的属性时，等于是在材质的**检查器面板( Inspector tab)**给着色器添加了可以访问调整值[tweaked value]的方式。这个值存储在这个属性的变量名中。在这个例子中，**_AmbientColor**，**_Color** 和**_MySliderValue**这三个变量就是我们用来保存调整值的。为了让你能够在**SubShader{}** 这个代码块中使用这些值，你需要在这个代码块中对应创建三个变量，而且这三个变量的名字要跟属性代码块中的变量名保持一致。这样的话Unity会自动把**SubShader{}**代码块和属性代码块中的变量关联起来，然后让着色器知道这些变量使用的是相同的数据。另外，这个属性声明同时也告诉我们在**SubShader{}**代码块中对应的变量的数据类型，在后续有关着色器的优化相关的章节中，会用到这些。
  
  当你再**subshader**代码块中创建好变量后，接下来你就可以再**surf()**方法中使用它们的值。在这个例子中，**_Color**，**_AmbientColor**与**_MySliderValue**这三个变量获得了来自材质的**检查器面板(Inspector tab)** 对应的值。变量**_Color**跟变量**_AmbientColor**这两个值相加，并且把这个值当作底数，**_MySliderValue**的值当作指数，进行幂运算。
  
  大多数着色器都是从一个标准着色器开始，然后一步一步修改它直到它们符合设计的样子。我们现如的这个例子为以后需要散射组件的表面着色器打好了基础。
  
  **注意**
  材质时一种**资源(assets)**。这意味着，当你的游戏在编辑器中运行时，你对它的任何改变都将会是永久的[这里解释一下，一般在Unity编辑器运行时，你对游戏做的修改，在停止运行后，又会恢复到运行之前的状态，这里材质不一样，修改之后，即使停止运行，它也不会恢复]。如果你不小心错误修改了属性的值，你可以通过快捷键***Ctrl + Z***取消这个修改。

***








- **相关补充**<span id = "UPISS_there_is_more"></span>

  跟其他一些编程语言一样，Cg也是不允许有错误。如果你的着色器代码中有错误的话，着色器将不会起作用。当着色器不起作用时，你的材质会因为没有着色器而以品红的方式渲染：
  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram8.png"/></div>
  当一个脚本没有被编译，Unity引擎会禁止你的游戏导出或者运行。 然而，着色器中有错误，Unity并不会阻止你运行你的游戏。如果你的着色器呈现出品红色，那么就应该检查一下到底哪里出现了问题。当你在Unity的编辑器中选中这个报错的着色器，那么你可以在**检查器面板(Inspectortab)**中看到一大串错误： 
  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram9.png"/></div>
  尽管错误提示展示了错误所在的行，但是通常不一定是引起错误的正真原因。上一张示例图所展示的错误是因为删除了了**SubShader{}**代码块中的**sampler2D _MainTex**变量引起的。 然而报错的地方是试图去访问这个未定义的变量所在的代码行。找到错误并且修复的过程就是我们常说的**debug**。你最常用的一些错误检查如下：
  
  - 忘记括号匹配。 如果忘记用花括号对代码块进行配对匹配，那么编译器就会在代码文档的最后，开始或者新的代码块中提示错误。
  
  - 忘记写分号结束语句。这是最常见的错误，同时也是最容易定位和修复的错误。通常会在下一行开始产生一个错误。
  
  - 在**属性(Properties)**代码块中定义了一个属性，但是没有在**SubShader{}**代码块中定义对应的变量。【这两者是需要成对出现的，也就是说在**属性(Properties)**块里面定义了一个新的属性，那么在**SubShader{}**代码块中就需要声明一个与之对应的变量】
  
  - 更Unity中的C#脚本不一样，Cg语言中的浮点值不需要在后面加**f**来表示浮点类型：浮点值1.0就写作**1.0**，而不是**1.0f**。
  
  着色器中提示的错误很具有误导性，特别是因为它们那严格的语法约束。如果看不懂错误什么意思，那就直接百度或者谷歌。 或者去Unity的论坛搜索一下看看，里面可能就有跟你遇到相同问题（修复了相同问题）的开发者。
  
  ***







  - **额外内容**<span id = "UPISS_see_also"></span>

    在[第二章]()，***表面着色器和纹理贴图***，我们会了解如何去掌握**表面着色器(Surface Shaders)**跟它们的**属性(properties  )**。如果使用着色器的所有潜能和特性，到底能做些什么？如果你对这个问题感兴趣，你应该去看一看[第十章]()，***更高级的着色器技术*** 。里面有本书的一些最高级的着色器技术。

***






## 第二章 表面着色器和纹理贴图 <span id="SSTM"></span>

在这一章节，我们将会探索表面着色器的使用。我们会用一个非常简单的磨砂材质开始讲起，然后会在后面讲解全息投影和高级的地形混合。 我们将能够使用纹理制作动画效果，混合等，或者用着色器去驱动我们想要的属性。在这一章你将会学习下面一些表面着色器的使用方法：
- 漫反射的着色处理
- 使用包组
- 向着色器添加纹理
- 通过改变UV值来移动纹理
- 法线贴图
- 创建一个带透明度的材质
- 创建一个有全息效果的着色器
- 纹理的压缩和混合
- 在地形的表面绘制一个圆 
***






### 介绍<span id="SSTM_introduction"></span>

我们在**第一章**，***创建你的第一个着色器*** 已经介绍了表面着色器，这是Unity引擎中的主要着色器类型。在这一章我们将更详细的向你展示它到底是什么以及它具体是如何工作的。通常来说，每个表面着色器都有两个重要的步骤。 首先，你需要在材质中描述你想指定的物理属性，比如漫反射的颜色，光滑度和透明度等。 这些属性将会在一个叫**表面函数 surface function**的函数中初始化并且保存在一个叫**表面输出 surface output**的结构体中。其次，**表面输出 surface output**结构体传入到一个**光照模型 lighting model**中。这是一个特殊的函数，这个函数会获取场景周围的光照信息。所有获得的这些信息将会被用于去计算你的模型最终在每一个像素点上最终呈现出来的颜色。这个光照函数就是着色器真正进行计算的地方，而正是这部分代码，决定了使用这个着色器材质的光照表现。下面的示意图简单的总结了表面着色器时如何工作的。在**第三章**，***理解光照模型***  将探索自定义光照模型，当学习到**第五章**，***顶点函数*** 会着重讲解顶点修改器：
<div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram10.png"/></div> 
***







### 漫反射的着色处理<span id="SSTM_diffuse_shading"></span>

在我们开始学习纹理贴图之前，了解漫反射材质时如何工作的显得尤为重要。具体的一些物体也许会有统一的光照和光滑的表面，但是可以还是不够光滑来反射光线。磨砂材质是漫反射着色器使用的一个典型代表 。然而我们现实世界中，完全漫反射材质是不存在的；漫反射着色器是一种成本相对比较低的实现方式并且在低多边形风格中有着大量的应用。

***







- **始前准备** <span id = "SSTM_getting_ready"></span>

  有好几种方式来创建你自己的漫反射着色器。最快的一个方式是在Unity5中创建一个表面着色器然后编辑它，移除所有的纹理，跟我们前面学习的**第一章**，***创建你的第一个着色器*** 类似。

***







- **操作步骤**<span id = "SSTM_how_to_do_it"></span>

  让我们开始创建我们的标准着色器，首先在Unity中新建一个标准着色器，然后按照下面的步骤进行修改：
  1. 首先在着色器的属性列表移除除**_Color**之外的所有属性：
  ```c# 
  _Color ("Color", Color) = (1,1,1,1)
  ```
  2. 在**SubShader{}**代码块中，移除**_MainTex**，**_Glossiness**和**_Metallic**这三个变量。但是你不能删除**uv_MainTex** 这个变量，因为**Cg**着色器语言不允许输入结构体为空。这个值会被Unity简单的忽略。
  3. 删除**surf()**函数内代码内容并且把下面代码放在里面：
  ```c#
  o.Albedo = _Color.rgb;
  ```
  4. 最终，你的着色器代码应该如下所示：
  ```c#
  Shader "CookbookShaders/Diffuse" 
  {
      Properties 
      {
          Color ("Color", Color) = (1,1,1,1)
      }
      SubShader 
      {
        Tags { "RenderType"="Opaque" }
        LOD 200
        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows
        #pragma target 3.0
        struct Input 
        {
            float2 uv_MainTex;
        };
        fixed4 _Color;
        void surf (Input IN, inout SurfaceOutputStandard o) 
        {
            o.Albedo = _Color.rgb;
        }
        ENDCG
      }
      FallBack "Diffuse"
  }
  ```
  当这个着色器从标准着色器修改调整之后，那么这个着色器将会使用基于物理原理的渲染去模拟光在模型表面的表现。如果你想试着获得一个看起来不那么真实表现的话，你可以直接修改**#pragma**部分，这样着色器就可以使用**Lambert**而不是**Standard**。如果你这样修改了的话，那么你还应该用**SurfaceOutput**替换掉**SurfaceOutputStandard **。
  按照书上的意思，应该是改成下图所示：
  
  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram11.png"/></div> 

***







- **原理介绍**<span id = "SSTM_how_it_works"></span>

  通过**表面输出surface output**，着色器可以让你材质的渲染属性跟**光照模型lighting model**进行沟通。 它基本封装了光照模型需要的所有参数。很明显，不同的关照模型肯定有着不同的表面输出结构。下表列出了在Unity中使用的三种主要的输出结构以及它们能如何使用：
  
  | Type of shaders | Unity 4                            | Unity 5                                                     |
  | --------------- | ---------------------------------- | :---------------------------------------------------------- |
  | Diffuse         | Any Surface Shader:SurfaceOutput | Standard:SurfaceOutputStandard                         |
  | Specular        | Any Surface Shader:SurfaceOutput | Standard (Specular setup):SurfaceOutputStandardSpecular |
  
  **表面输出SurfaceOutput**结构体所包含的属性如下：
  
  - **fixed3 Albedo**: 材质的漫反射颜色
  
  - **fixed3 Normal**: 空间中法线的切线，如果有法线的话
  
  - **fixed3 Emission**:这是材质指定的光的颜色 （如果是**标准着色器Standard Shaders**的话，它会被定义为**half3**类型） 
  
  - **fixed Alpha**: 这是材质的透明度
  
  - **half Specular**: 这是高光反射度【就是看起来多像高光？】，值的变化是从0到1
  
  - **fixed Gloss**: 这是高光强度
  
  **标准表面输出SurfaceOutputStandard**结构体包含以下的属性：
  - **fixed3 Albedo**: 这是材质的基本颜色(不管是高光反射还是漫反射)
  - **fixed3 Normal**：空间中法线的切线，如果有法线的话
  - **half3 Emission**: 跟表面输出结构体一样的意思，不过在这里定义为**half3**类型，而在表面输出结构体中定义为**fixed3**类型。 
  - **fixed Alpha**：同表面输出结构体
  - **half Occlusion**: 这个是遮挡（默认是1）
  - **half Smoothness**: 这个是光滑度 (0 = 粗糙, 1 = 光滑)
  - **half Metallic**:金属质感 0 = 无金属质感, 1= 金属
  
  **标准高光表面输出SurfaceOutputStandardSpecular**结构拥有如下属性：
  - **fixed3 Albedo**：同上
  - **fixed3 Normal**：同上
  - **half3 Emission**：同上
  - **fixed Alpha**：同上
  - **half Occlusion**：同上
  - **half Smoothness**：同上
  - **fixed3 Specular**: 这个是高光反射的颜色，这个跟表面叔叔结构体中的高光反射有很大的不同，因为这里是用颜色表示，而在表面输出结构体中只是一个简单的值


  正确的给表面输出结构体赋值，初始化，是使用表面着色器的前提。


***







## 使用包组<span id = "UPA">

笼统的讲，显示器上每一个像素点都至少会执行一次。这也是为什么GPU要设计高度优化的并行架构的原因。同样的在Cg语言的标准变量类型和操作符中，这种设计哲学也很明显。理解它们，不仅仅是为了正确的使用着色器，同时也是为了能够写出更高效的着色器。

***
- 操作步骤<span id="UPA_how_to_do_it">

  在Cg语言中有两种类型的变量：**单精度值single**和**包组packed arrays**。后者很容易辨别因为这种类型通常会以数字结尾，比如**float4**，**int4**等等。正如它们的名字所表示的一样，这些类型的变量跟我们编程语言中的**结构体structs**类似，这也意味着每一个这样的变量包含了多个单精度值。在Cg语言中我们称之为**包组packed arrays**，尽管它们并非真的是传统意义上的数组。

  在包组中的元素能像常见的结构体那样访问。通常它们表示成**x**，**y**，**z** 和**w** 。然而Cg语言还有另一种表示，就是**r**，**g**，**b**，**a**。尽管你使用**x**或者**r**去表示都是可以的，但是对于代码阅读者来说它们之间的区别就非常的大了。事实上，在着色器编程中，经常涉及到的就是位置和颜色的计算。你可能对下面的标准着色器代码中的代码片段还有印象吧：

  ```c#
  o.Alpha = _Color.a;
  ```

  在这里，**o**是一个结构体而**_Color**就是一个包组。这也是为什么Cg要禁止上面提到的两种表示进行混用的原因：你不能使用**_Color.xgz**。

  这里还有一个很重要的包组的特性，这种特性在C#中没有：**swizzling**[这个不知道怎么翻译]。Cg允许仅通过简单的一行代码就对包组内的元素进行寻址和重新排序。又是下面在标准着色器中熟悉的代码片段：
  
  ```c#
  o.Albedo = _Color.rgb;
  ```
  
  **Albedo** 是一个 **fixed3**类型，也就是说它里面包含了三个**fixed**类型的值。 然而**_Color** 是一个**fixed4**类型的定义。由于**_Color**定义包含的元素比 **Albedo**定义包含的元素要多，直接赋值的话，由于不匹配，肯定会产生一个编译错误。如果用C#代码来进行同样的操作，代码如下所示：
  
  ```c#
  o.Albedo.r = _Color.r;
  o.Albedo.g = _Color.g;
  o.Albedo.b = _Color.b;
  ```
  
  相比于C#代码，在Cg语言中，我们可以用如下代码简写：
  
  ```c#
  o.Albedo = _Color.rgb;
  ```
  
  Cg语言也允许对元素进行重新排序。比如，通过**_Color.bgr**这个代码去交换红色和蓝色通道的颜色。
  
  最后要讲一点，当一个单精度值赋值给包组时，这个值会被复制到包组的所有元素中去：
  
  ```c#
  o.Albedo = 0; // Black =(0,0,0)
  o.Albedo = 1; // White =(1,1,1)
  ```
  
  这个就是Cg语言中的**smearing**特性。
  
  **Swizzling**还可以被用作表达式的左值，不过仅当包组的具体元素能被这样使用：
  
  ```c#
  o.Albedo.rg = _Color.rg;
  ```
  
  上面这种特性，叫做**masking**.  

  ***
  
  **压缩矩阵**
  
  真正发挥**swizzling**特性潜力的是在它应用于压缩矩阵的时候。Cg语言允许像**float4x4**这种类型，这是一个四行四列的矩阵。你可以使用***_mRC***标记访问矩阵中的单个元素，**R**表示元素所在的行而**C**表示元素所在的列：
  
  ```c#
  float4x4 matrix; 
  // ... 
  float first = matrix._m00; 
  float last = matrix._m33;
  ```
  
  **_mRC**标记还可以接连使用：
  
  ```c#
  float4 diagonal = matrix._m00_m11_m22_m33;
  ```
  
  如果要获取矩阵的整行，可以使用中括号：
  
  ```c#
  float4 firstRow = matrix[0]; 
  // Equivalent to 
  float4 firstRow = matrix._m00_m01_m02_m03;
  ```
  ***



- 额外内容<span id="UPA_see_also">
  
  包组是Cg语言中最棒的特性之一，你可以从下面的连接获得关于包组的更多信息：
  
  [http://http.developer.nvidia.com/CgTutorial/cg_tutorial_chapter02.html](http://http.developer.nvidia.com/CgTutorial/cg_tutorial_chapter02.html)

***







## 向着色器添加纹理 <span id = "ATTS"></span>

通过纹理，可以很容易让着色器变得生动起来，获得非常真实的效果。为了更有效的使用纹理，我们需要了解一张2D图片是如何映射到3D模型中去的。 这个映射的过程称之为**纹理贴图texture mapping**，为了完成映射，我们在使用的模型和着色器上还有额外的工作。模型实际上是由很多的三角形拼接而成的；而三角形的每个顶点都保存有着色器可以访问的各种数据。 其中很重要的一个信息就是**UV信息 (UV data)**。 它包含两个坐标，**U**和**V**，其取值范围是0到1。这两者表示2D图片的像素点坐标的**XY**位置信息，而这些信息将会映射到顶点中去。 UV数据只为顶点表示[意思可能也等价于：UV数据只存在顶点中]； 当三角内的点需要被纹理贴图时，GPU会插值最接近的UV值，从而从相应的纹理中找到正确的像素点。下面的图片展示了一张2D纹理贴图到3D模型中的三角形中的情况：

  <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram12.png"/></div>

UV数据保存在3D模型中并且需要3D模型工具去编辑它们。有些模型缺少UV组件，因而它们不支持纹理贴图。比如3D模型软件中的默认的那个兔子模型，就没有提供这么一个组件。

- **始前准备**<span id="ATTS_getting_ready"></span>

  学习这个知识点的时候，你需要一个有UV数据和纹理的3D模型。然后把它们都导入到Unity中。也可以直接拖拽到Unity编辑器中，会自动导入。因为标准着色器支持默认的纹理贴图。我们会用到这一点，而后会详细的介绍它是如何工作的。
  
  ***


- **操作步骤**<span id = "ATTS_how_to_do_it">

  用标准着色器给你的模型添加一张纹理异常的简单，按照下面步骤：
  1. 创建一个叫**TexturedShader**标准着色器。
  
  2. 创建一个名为**TexturedMaterial**的材质球。
  
  3. 通过拖拽的方式，把着色器赋值给材质，把着色器拖到材质上即可。
  
  4. 选择刚才的材质，然后拖拽模型对应的纹理到一个叫**Albedo(RGB)**的矩形区域中的空白部分。如果你正确的执行了上述步骤，你的材质**检查器面板(Inspector )**会如下图所示：
  
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram13.jpg"/></div>
    <div align="center">标准着色器知道如何通过UV信息把2D图像映射到3D模型中</div>.

- **原理介绍**<span id = "ATTS_how_it_works"></span>

  当通过材质的检查器面板使用标准材质的时候，纹理贴图背后的处理过程对于开发者来说是透明的。如果我们想了解它是如何工作的，那我们需要更加详细的了解我们刚才创建的**TexturedShader**着色器。在着色器的**属性Properties**部分，我们可以看到**Albedo (RGB)**的纹理跟代码的关联如下代码所示：
  
  ```c#
  MainTex:
  _MainTex ("Albedo (RGB)", 2D) = "white" {}
  ```
  
  在我们着色器代码中的**CGPROGRAM**代码块部分，纹理被定义为**sampler2D**类型，这是一种标准的2D纹理类型：
  
  ```c#
  sampler2D _MainTex;
  ```
  
  紧接着下一行给我们展示了**Input**这个结构。这个结构就是**surface** 函数中得输入参数并且这个结构包含了一个叫做**uv_MainTex**的包组数组：
  
  ```c#
  struct Input 
  {
  	float2 uv_MainTex;
  };
  ```
  
  每一次调用**surf()**函数的时候，对应3D模型中的包含**_MainTex **这个UV的**Input **结构都需要被渲染。标准着色器会知道**uv_MainTex **跟**_MainTex **是关联的，并且会自动初始化它。如果你真的很想了解到底UV是怎么从3D模型映射到2D纹理的话，你可以看看[**第三章, 理解光照模型**]()。
  
  终于，UV数据被用来在**surface **函数中展示成一张纹理：
  
  ```c#
  fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
  ```
  
  **注意**
  
  ***U***和***V***的取值范围都是从0到1，**(0,0)**和**(1,1)**相当于两个相对的角[可以想象成一个是左下角，一个是右上角]。如果你的纹理出现了颠倒的情况，试着把V的值也颠倒就能解决了。
  
  ***







  - **相关补充**<span id = "ATTS_there_is_more"></span>

    当你把纹理导入到Unity的时候，你就会默认设置一些**sampler2D**类型将要使用的一些属性。 最重要的就是**筛选模式Filter mode**，它决定了一张纹理显示的时候颜色是如何插值的。跟UV数据会准确的指向像素的正中心非常不同；在一些其他的情况中，你也许想对最近的像素之间进行颜色插值从而获得更一致的颜色。下图是示例纹理在**检查器面板Inspector tab**的截屏： 
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/shader_book/diagram14.jpg"/></div>
    对于多数的应用程序来说，**双线性Bilinear**提供了一种性能消耗低而且高效方法来对纹理进行平滑的处理方式。然而如果你是创建一个2D游戏，**双线性Bilinear**模式可能会产生模糊块。在这种情况下，你可以使用**点Point **模式来删除来自纹理采样的所有插值。
    
    当以一个很大的倾斜角去观看一张纹理时，纹理采样似乎会呈现一种看起来不舒服的人工制品。你可以通过设置更高的**Aniso Level **的值来减少这种感觉。这一点对地板纹理和天花板纹理特别有用，可以解决一些小瑕疵导致的纹理观感不连续性的问题。

***






  - **额外内容**<span id = "ATTS_see_also"></span>

    如果你想了解更多关于纹理时如何映射到3D模型表面的内部工作原理，你可以通过下面的网址了解相关信息[可能需要用梯子才能访问]：

    [http://http.developer.nvidia.com/CgTutorial/cg_tutorial_chapter03.html](http://http.developer.nvidia.com/CgTutorial/cg_tutorial_chapter03.html)。

    如果想了解导入一张2D纹理时完整的可选择项列表，可以通过下面这个相关的网址查询：
    [http://docs.unity3d.com/Manual/class-TextureImporter.html](http://docs.unity3d.com/Manual/class-TextureImporter.html)
