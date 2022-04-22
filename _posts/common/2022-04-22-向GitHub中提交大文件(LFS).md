---
category: Git
tags: [LFS, 大文件, GitHub]
---


## 向GitHub中提交大文件 LFS 

出于某些原因，我们想向GitHub中提交某些比较大的文件，比如项目中的一些音频视频这样的媒体文件，游戏中的大场景，
亦或者只是单纯的想把自己项目的压缩文件上传到GitHub上保管等等。但是GitHub在仓库上有下面的一些限制：  
先了解一些大小限制条件：  
**仓库总大小：** 官方建议小于1G，最大不能超过5G，如果大于1G，会收到官方的警告文件  
**仓库中单个文件大小：** 官方建议小于50M，最大不超过100M，如果大于50M也会收到警告  
**单个LFS：** GitHub最大支持的LFS文件大小是2G，所以如果有单个文件大小大于2G，要用压缩文件分包，每个包大小最好小于或等于1G  

官方的说明文档[https://docs.github.com/cn/repositories/working-with-files/managing-large-files/about-large-files-on-github](https://docs.github.com/cn/repositories/working-with-files/managing-large-files/about-large-files-on-github)  
由于上面的这些限制，所以我们最好还是选择LFS来提交这些文件，由于我是用的不是命令行，是SourceTree，所以这里讲的是用SourceTree提交LFS的步骤。  

<br />

#### SourceTree中提交LFS的步骤

- 1.项目初始化  
    - 1.首先在GitHub创建一个自己的仓库，并且把它拉取到本地  
    - 2.把自己的大文件用 **7z** 或者 **WinRar** 之类的软件进行分包，每个大小小于或者等于1G  
    - 3.把这些文件复制到本地仓库中，如下图所示：  
        <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/common/1.png"/></div>
- 2.在SourceTree中LFS初始化  
    在SourceTree中选择 **仓库-> Git LFS -> 初始化仓库**
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/common/2.png"/></div> 
    <br />  

    接着会弹出窗口，选择 **开始使用Git LFS**   
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/common/3.png"/></div>  
    <br />  

    然后在弹出的窗口中选择添加，在下拉列表中选择合适的扩展名，比如**.7z** ，然后点确定。  
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/common/4.png"/></div>  
    <br />

    如果是分包，可能扩展名下拉列表中不会有对应的选项，这个时候你可以手动写上去，比如我的**.001** 这样的分包后的扩展名，
    然后再点确定。最后点击窗口的确定按钮，那么这些扩展名就会加入LFS提交
    策略中了。之后会在项目中生成一个 **.gitattributes** 后缀的文件，这个要跟LFS文件一起提交。
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/common/5.png"/></div>  
    <br />  

- 3.在SourceTree中选中那些文件【只支持一个一个的选】，右键，然后选择**跟踪Git LFS的文件类型**  
    <div align="center"><img src="https://linkliu.github.io/game-tech-post/assets/img/common/6.png"/></div>  
    <br />  
    把所有要执行跟踪的LFS文件都执行一遍上面的操作，然后选择这些LFS文件外加一个**.gitattributes** 文件一起暂存，随后提交。
    之所以要这样做，是如果不执行上面的跟踪步骤，在暂存提交的时候会收到警告。
    <br />  
    <br />  

- 4.用SourceTree推送，第一次可能会有红色警告，没关系，关掉窗口，再点提交按钮，再提交一下就OK了

