﻿forum
=====

A simple forum implemented by enode framework.

How to run this forum
======================

先决条件
--------
1. Visual Studio 2019 + Sql Server数据库;

编译运行
--------
1. 打开Forum.sln解决方案，启用Nuget还原，编译解决方案；
2. 在新建的数据库中运行Scripts目录下的InstallDB.sql脚本，创建数据库以及所有的表；
3. 修改Forum.CommandHost、Forum.EventHost这两个项目的配置文件中的connectionString；修改Forum.Web、Forum.Domain.Tests这两个项目中的appsettings.json中的connectionString；
   确保能连接上面新建的Forum数据库；
4. 将Forum.Web设置为启动项目；
5. 依次启动Forum.NameServerHost、Forum.BrokerHost、Forum.CommandHost、Forum.EventHost、Forum.Web这5个工程；
6. 如果要管理论坛版块，需要注册一个名称为admin的账号，注册登录成功后，在右上角就有一个版块管理了；其他注册的账号看不到板块管理的入口；
