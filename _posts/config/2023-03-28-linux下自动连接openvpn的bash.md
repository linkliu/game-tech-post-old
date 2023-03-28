---
category: openvpn
tags: [Ubuntu, openvpn, linux, 自动连接, ovpn文件, 指定目录]
---

## Linux下的openvpn自动连接bash，自动尝试指定目录下的所有.ovpn文件   

脚本如下所示：   
``` bash
#!/bin/bash

# 输入用户名和密码
read -p "please input username:" USERNAME
read -sp "please input password:" PASSWORD

# 配置文件目录
CONFIG_DIR="/home/config/vpn"

# 循环尝试连接配置文件
for FILE in $CONFIG_DIR/*.ovpn; do
    echo "trying $FILE"
    openvpn --config $FILE --auth-user-pass <(echo -e "$USERNAME\n$PASSWORD") --connect-timeout 10 &
    # 检查是否连接成功
    if ping -c 1 google.com &> /dev/null; then
        echo "connect success！"
        exit 0
    else
        echo "connect fail!, try next vpn config..."
        # 断开连接
        sudo pkill openvpn
    fi
done

echo "cann't connect to the vpn server！"
exit 1
```   

<br>
`CONFIG_DIR` 指的时你的配置文件的目录，请把所有的.ovpn配置文件放在这里。这个教程使用的openvpn这个客户端，如果没有这个命令，请先安装openvpn，openvpn的安装方法，请去网上查找。