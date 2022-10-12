---
category: npm
tags: [Mac, http-server, https证书, 本地运行, 安装http-server]

---

##  Mac在本地开发中使用http-server，并且使用https

***   

- **1.在本地新建一个文件夹，并进入该文件夹**   
    新建一个文件夹**www**
    ``` bash
    mkdir www 
    ```   
    进入文件夹  
    ``` bash
    cd www
    ```   

- **2.安装 mkcert**   
    ``` bash 
    brew install mkcert
    ```

    ``` bash 
    brew install nss # if you use Firefox


- **3.将 mkcert 添加到本地根 CA**   
    ``` bash 
    mkcert -instal
    ```   

- **4.为您的站点(localhost)生成一个由 mkcert 签名的证书**   
    ``` bash 
    mkcert localhost
    ```

- **5.启动服务[把下面的命令直接放到一个.sh文件中去，直接运行.sh文件]**   
    ``` bash
    http-server  -p 8080 -S -C ./localhost.pem -K ./localhost-key.pem
    ```
    
