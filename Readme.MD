新生命团队基础框架X组件，包括网络、数据库、安全、多线程、反射、序列化、模版引擎、服务代理、远程过程调用等模块，包括Mvc后台魔方、超级码神工具、消息队列等子系统，支持Mono/Android/iOS。

## 组件各组成部分
### 核心库 NewLife.Core
核心组件，支撑其它所有组件。  
主要功能包括：  
+ **[网络库]** 支持企业应用服务十万级并发 Tcp/Udp/Http/WebSocket/IPv6
+ 安全
+ 多线程
+ 反射
+ 序列化
+ 服务代理
+ 远程过程调用RPC

[网络库]:/?path=master/NewLife.Core/Net/Readme.md "支持企业应用服务十万级并发"

### Android库 NewLife.Android
Android版核心库，共用代码，供Xamarin Android开发使用

### iOS库 NewLife.iOS
iOS版核心库，共用代码，供Xamarin iOS开发使用

### 数据映射框架 NewLife.XCode
ORM组件，主要亮点：  
1，设计极致的缓存，超高性能  
2，反向工程，根据实体类主动建立数据库表结构并初始化数据，支持8种数据库  
3，无限分表分库，支持任意数据库，无需修改业务代码  

### 魔方Mvc管理后台 NewLife.Cube
酷比魔方，Bootstrap风格的Mvc权限管理后台，集成管理员、角色、菜单、权限、日志等基本功能模块。

### 网络协议库 NewLife.Net
支持DNS/DHCP等几十种常见以太网协议的解析

### 超级码神工具 XCoder
由一系列开发者工具组成：  
1，数据模型工具  
2，网络调试工具  
3，串口调试工具  
4，正则表达式工具  
5，图标处理工具  
6，文件信息处理工具  

### 模版引擎 XTemplate
使用C#编写模版，T4风格，主要用于生成实体代码和页面

新生命开发团队  
网站：http://www.NewLifeX.com  
QQ群：1600800  

## 项目源码位置
国内 https://git.NewLifeX.com/NewLife/X  
国外 https://github.com/NewLifeX/X  
