---
category: PowerShell
tags: [Windows, powershell7, on-my-posh, 美化]
---

## 在windows安装powershell7.x，以及oh-my-posh的美化   

- **1.安装Windows Terminal**   

    有下面几种安装方式
    * 直接在windows的商店重搜索windows terminal然后安装即可  

    * 通过**winget**安装
    ``` shell
    winget install --id=Microsoft.WindowsTerminal -e
    ```
    * 通过**Chocolatey**安装
    ``` shell
    choco install microsoft-windows-terminal
    ```

- **2.安装powershell7**

    可以通过下面几种方式安装
    * 在官网下载msi安装包，直接安装   
    [https://learn.microsoft.com/zh-cn/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.2](https://learn.microsoft.com/zh-cn/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.2)

    如下图
    ![diagram](https://linkliu.github.io/game-tech-post/assets/img/common/9.png){:  .shadow width = "90%" }
    * 使用 **winget** 安装   
    ``` shell
    winget install --id Microsoft.Powershell --source winget
    ```  

    * 设置默认启动的shell为powershell7
        - 打开windows terminal
        - 在窗口标题栏右键，然后点击设置
        - 然后选择启动，然后选择默认用powershell7启动，如下图

        ![diagram](https://linkliu.github.io/game-tech-post/assets/img/common/10.png){:  .shadow width = "90%" }

        - 然后关闭windows terminal,重新打开，就可以看到默认是以powershell启动  
   
<br>  

- **3.安装oh-my-posh[顺带安装posh-git]**   
    安装oh-my-posh和posh-git   
    旧教程都是通过在powershell中安装模块的方式安装，但是作者现在已经不推荐那样安装了，具体的原因在这里：[原因](https://ohmyposh.dev/docs/migrating)  
    新的oh-my-posh的安装方式，也在[原因](https://ohmyposh.dev/docs/migrating)有说明，过程如下：   
    **oh-my-posh**   
    1. 首先移除掉之前的一些模块缓存文件 
    ``` shell
    Remove-Item $env:POSH_PATH -Force -Recurse
    ```   
    `:exclamation:` **注意**   
    如果你在这个位置有放自己的一些内容，这些内容会一起被删除，所以在执行上面的命令之前，请一定要记得先保存这些自己的文件   

    2. 安装oh-my-posh 
    ``` shell
    winget install JanDeDobbeleer.OhMyPosh -s winget
    ```   
    这个命令会做下面两件事:   
    安装 `oh-my-posh.exe`可执行文件到你的电脑   
    安装`Oh My Posh`的最新的主题【如果你有设置自定义的主题，就会使用你自己的】 
    3.  卸载powershell中的oh-my-posh模块    
    ``` shell
    Uninstall-Module oh-my-posh -AllVersions
    ```   
    4.  从$PROFILE中删掉下面的模块导入命令   
    ``` shell
    Import-Module oh-my-posh
    ```  

    **posh-git**   
    1. 执行下面的命令:   
    ``` shell 
    Install-Module posh-git -Scope AllUsers
    ```
    2. 一些权限需要开启   
    ``` shell
    Install-Module -Name PSReadLine -AllowPrerelease -Scope AllUsers -Force -SkipPublisherCheck
    ```
    3. 为powershell创建一个配置文件   
    下面的命令会自动创建一个配置文件，并且打开，
    ``` shell
    if (!(Test-Path -Path $PROFILE )) { New-Item -Type File -Path $PROFILE -Force }
    notepad $PROFILE
    ```
    4. 在配置中添加下面的命令   
    ``` shell 
    Import-Module posh-git  ## 在当前打开的 PowerShell 终端中引入 posh-git（已安装，这里只是引入）
    Import-Module PSReadLine  ## 这个工具主要做命令提示管理等操作，默认集成在了 PowerShell 中，不需要安装
    Set-PSReadlineKeyHandler -Key Tab -Function Complete  ## 设置 Tab 键补全
    Set-PSReadLineKeyHandler -Key "Ctrl+d" -Function MenuComplete  ## 设置 Ctrl+D 为菜单补全和 Intellisense
    Set-PSReadLineKeyHandler -Key "Ctrl+z" -Function Undo  ## 设置 Ctrl+Z 为撤销
    Set-PSReadLineKeyHandler -Key UpArrow -Function HistorySearchBackward  ## 设置向上键为后向搜索历史记录
    Set-PSReadLineKeyHandler -Key DownArrow -Function HistorySearchForward  ## 设置向下键为前向搜索历史记录
    oh-my-posh init pwsh --config ~/Documents/PowerShell/themes/robbyrussel.omp.json | Invoke-Expression  ## 设置主题，如果不喜欢robbyrussel这个主题，到oh-my-posh官方网站（https://ohmyposh.dev/docs/themes）找到自己喜欢的，然后换一下名字就可以
    ```
    5. 安装主题   
    去[https://github.com/JanDeDobbeleer/oh-my-posh](https://github.com/JanDeDobbeleer/oh-my-posh)把项目下载下来，把里面的themes文件夹直接复制一份，
    放到 **~/Documents/PowerShell** 这个目录中去。需要什么主题，修改上面命令的最后一行代码，把主题文件改成你喜欢的就行了。   
    
    **注意**   
    有可能遇到无法识别 **oh-my-posh** 的问题，说它不是命令之类的错误，这个时候执行下面的命令
    ``` shell
    Set-ExecutionPolicy Bypass -Scope Process -Force; Invoke-Expression ((New-Object System.Net.WebClient).DownloadString('https://ohmyposh.dev/install.ps1'))
    ```

- **4.安装nerdfont字体**

    昨晚上面的步骤，你的美化还没有算完全配置完。因为oh-my-posh使用的是nerd字体，控制台中的各种优美的符号和图标都在这些字体上，所以请去下面的网站安装自己
    喜欢的字体，我个人推荐的是JetBrainMono字体   
    [https://www.nerdfonts.com/font-downloads](https://www.nerdfonts.com/font-downloads)

    安装玩字体后，还是要在windows terminal的设置重选择你安装的字体，设置位置在下图: 
    ![diagram](https://linkliu.github.io/game-tech-post/assets/img/common/11.png){:  .shadow width = "90%" }
    然后重新打开windows terminal看效果










