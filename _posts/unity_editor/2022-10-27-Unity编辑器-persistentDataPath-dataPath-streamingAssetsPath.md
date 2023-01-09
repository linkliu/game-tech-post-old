---
category: UnityEditor
tags: [Unity3D, persistentDataPath, dataPath, streamingAssetsPath]
---

## Unity中persistentDataPath, dataPath, streamingAssetsPath在不同的平台对应的路径

为了方便以后的开发，自己结合官方资料和自己的实际开发，把上面的路径变量在不同的平台对应的正式路径总结一下

***

- **Application.persistentDataPath**   
    官方参考：[https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Application-persistentDataPath.html](https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Application-persistentDataPath.html)
    1. `对app是只读的，对玩家来说读写都可以，如果是IOS或者安卓，该路径指向设备的公共目录`
    2. `app更新的时候，不会删除该目录，但是用户自己是可以对该目录增删改查的`

    |                平台                 | 指向的位置                                                                                                        |
    |---------------------------------: |: ---------------------------------------------------------------------------------------------------------------- |
    |         Windows Store Apps          | %userprofile%\AppData\Local\Packages\&lt;productname&gt;\LocalState                                        |
    | Windows Editor and Standalone Player| %userprofile%\AppData\LocalLow\&lt;companyname&gt;\&lt;productname&gt;                                                        |
    |                WebGL                | /idbfs/&lt;md5 hash of data path&gt; 该路径是URL最后一个斜杠“/”和“？”之间的字符串                                       |
    |                Linux                | $XDG_CONFIG_HOME/unity3d 或者$HOME/.config/unity3d                                                                |
    |                 iOS                 | /var/mobile/Containers/Data/Application/&lt;guid&gt;/Documents                                                          |
    |                tvOS                 | 不支持且返回空字符串                                                                                              |
    |               Android               | 通常指向/storage/emulated/0/Android/data/&lt;packagename&gt;/files，有的老机型可能指向SD卡的路径                        |
    |                 Mac                 | 指向用户的Library目录，通常该目录是隐藏的，现在Unity是指向~/Library/Application Support/company name/product name |

***  
<br>

- **Application.dataPath**   
    官方参考：[https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Application-streamingAssetsPath.html](https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Application-streamingAssetsPath.html)   
    1. `对玩家和app都是只读的，是指设备的游戏目录，只能读取`   
    2. `根据不同的平台，游戏目录不一样`   


    |平台|指向位置|
    |---:|:---|
    |Unity Editor|&lt;项目路径&gt;/Assets|
    |Mac player| &lt;path to player app bundle&gt;/Contents|
    |iOS player| &lt;path to player app bundle&gt;/&lt;AppName.app&gt;/Data|
    |Win/Linux player|  &lt;游戏的可执行文件的数据目录&gt; （请注意Linux目录是大小写敏感的，window不是)|
    |WebGL| 玩家数据目录的绝对URL（没有具体的文件名）|
    |Android| 通常指向APK，如果你使用的是安卓分包，那么它指向OBB（也就是说游戏数据文件都保存到了OBB文件中）|
    |Windows Store Apps| 是一个指向玩家数据目录的绝对路径|   

    **注意**：PC上返回的路径是用反斜杠（“\”）做分割的

***
<br>


- **streamingAssetsPath**   
    官方参考： [https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Application-streamingAssetsPath.html](https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Application-streamingAssetsPath.html)   
    1. `对玩家和app都是只读的`
    2. `都是指向Unity的StreamingAssets文件夹`

    |平台|项目路径|
    |---:|:---|
    |Unity Editor|&lt;项目路径&gt;/Assets/StreamingAssets|
    |Mac Player|&lt;path to player app bundle&gt;/Contents/Resources/Data/StreamingAssets|
    |IOS Player|&lt;path to player app bundle&gt;/&lt;AppName.app&gt;/Data/Raw|
    |Win/Linux player|&lt;游戏的可执行文件的数据目录&gt;/StreamingAssets|
    |WebGL|&lt;玩家数据目录的绝对URL&gt;/StreamingAssets|
    |Android|Application.dataPath + "!/assets"|

***   
<br>

- **如果用UnityWebRequest来获取文件，传入的路径参数**   
    官方参考：[https://docs.unity3d.com/Manual/StreamingAssets.html](https://docs.unity3d.com/Manual/StreamingAssets.html)   

    |平台|项目路径|
    |---:|:---|
    |Unity Editor|Application.streamingAssetsPath/文件名|
    |Mac Player|Application.streamingAssetsPath/文件名|
    |IOS Player|"file://" + Application.dataPath + "/Raw/" + 文件名;|
    |Win/Linux player|Application.streamingAssetsPath + "/" + 文件名|
    |WebGL|Application.streamingAssetsPath + "/" + 文件名（Unity会自动把Application.streamingAssetsPath转换为对应的URL）|
    |Android|"jar:file://" + Application.dataPath + "!/assets/" + 文件名|
