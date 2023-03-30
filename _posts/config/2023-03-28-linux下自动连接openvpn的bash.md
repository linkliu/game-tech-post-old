---
category: openvpn
tags: [Ubuntu, openvpn, linux, 自动连接, ovpn文件, 指定目录]
---

## Linux下的openvpn自动连接bash，自动尝试指定目录下的所有.ovpn文件   

脚本如下所示：   
``` bash
#!/usr/bin/env bash

# 存放所有ovpn文件的目录
ovpn_dir="/media/link/D/config/vpn/config/"

# 存放用户认证信息的文件
auth_file="/media/link/D/config/vpn/auth.txt"

# 存放临时日志的文件
log_file="/media/link/D/config/vpn/temp.log"

process_name=openvpn

# 遍历ovpn目录下的所有ovpn文件
for file in ${ovpn_dir}/*.ovpn; do
    echo "Trying ${file}..."

    # 删除旧的日志文件并创建新的
    rm -f ${log_file} && touch ${log_file}

    # 连接VPN并将所有日志重定向到临时日志文件
    sudo openvpn --config ${file} --auth-user-pass ${auth_file} --connect-timeout 10 --connect-retry-max 3 > ${log_file} &
    while true ; do
        for line in $(cat ${log_file});do
            if echo "${line}" | grep -q "Initialization Sequence Completed"; then
                echo "connect success!"
                while true; do
                    read -p "Input 'stop' to exit" input
                    if [ "${input}" == "stop" ]; then
                        echo "Exiting..."
                        exit 0
                    fi
                done
            fi
        done
        sleep 0.2
        process_id=$(pidof openvpn)
        if [[ -z $process_id ]]; then
            echo "openvpn exited! try next config!"
            break
        fi
    done

    # 如果连VPN接失败，则提示connect fail!
    echo "connect fail!"
done
```   

<br>
这个教程使用的openvpn这个客户端，如果没有这个命令，请先安装openvpn，openvpn的安装方法，请去网上查找。