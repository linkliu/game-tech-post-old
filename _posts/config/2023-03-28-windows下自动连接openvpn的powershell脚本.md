---
category: openvpn
tags: [powershell, openvpn, windows11, 自动连接, ovpn文件, 指定目录]
---

## windows下的openvpn自动连接powershell脚本，自动尝试指定目录下的所有.ovpn文件   

powershell的脚本如下所示：   
``` bash
$ovpn_dir = "D:\MyProject\mybat\vpnconf"
$auth_file = "D:\MyProject\mybat\auth.txt"
$log_file = "D:\MyProject\mybat\temp.log"

foreach ($ovpn_file in Get-ChildItem -Path $ovpn_dir -Filter *.ovpn) {
  Write-Host "Trying $($ovpn_file.Name)"
  Remove-Item $log_file -ErrorAction SilentlyContinue
  $process = Start-Process -FilePath "C:\Program Files\OpenVPN\bin\openvpn.exe" -ArgumentList "--config $ovpn_file --auth-user-pass $auth_file" -NoNewWindow -PassThru -RedirectStandardOutput $log_file
  $connected = $false
  while (!$process.HasExited) {
    $content = Get-Content $log_file
    if ($content -match "Initialization Sequence Completed") {
      $connected = $true
      Write-Host "Connected successfully!"
      break
    }
    Start-Sleep -Milliseconds 1000
  }
  if ($connected) {
    $inputStr = Read-Host "Type 'stop' to terminate the program"
    if ($inputStr.Equals("stop")) {
      $killProcess = Get-Process -Name *openvpn*
      if ($killProcess) {
        Stop-Process -Name "openvpn" -Force
      }
      break
    }
  }
  if (!$connected) {
    Write-Host "Configurations failed"
    $killProcess = Get-Process -Name *openvpn*
    if ($killProcess) {
      Stop-Process -Name "openvpn" -Force
    }
    Start-Sleep -Seconds 5
  }
}
```   

<br>
1. `$ovpn_dir`是你自己的配置文件目录，把所有的 .ovpn 文件放到该目录下面。
2. `$auth_file`是你的账户信息，里面有两行，第一行是你的用户名，第二行是你的密码。格式大概如下面一样，记得把`your_name`，`your_password`整个替换成你的用户名和密码。   
```bash
your_name
your_password
```
3. `$log_file`是openvpn的日志输出文件，控制台会读取这个文件，然后比对字符串，看看是否已经成功连接。