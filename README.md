# THUAI3.0
THUAI3.0 原电子系第21届队式程序设计大赛

## 赛题简介

待定，头脑风暴中

## 框架简介

待定，C/S架构，实时游戏，同时支持人/AI，支持多种部署方式（局域网、服务器、本地）

## 玩法介绍

- 运行runServer.bat
- 运行runAgent.bat
- 运行runClient.bat
- 在runClient的Console窗口输入以下字母：
  - Q W E A D Z X C 分别向八个方向的走路（输入一次连续走5格）
  - F 捡拾物品或抓取食物产生点/灶台的食材
  - R、T 按R或T后再次输入数字键1~9可以指定扔东西的距离，R丢弃菜肴（Dish） ，T丢弃工具（Tool）
  - U 使用物品
- 上帝模式：
  - 在runServer的Console窗口中键入~则进入上帝模式
  - 输入“<操作> <物品类型> <物品代码> <X坐标> <Y坐标>”即可生成物品
  - 例："Add Dish 3 15.5 7.5"在(15.5,7.5)的位置生成马铃薯
  - 物品代码参见Logic.Constant.Constant.cs

## 仓库说明

本仓库为所有开发工作共用仓库，请勿上传大文件，每个目录均已配置好Visual Studio开发时的`gitignore`忽略规则，请根据需要自行修改，不要修改主目录下的`gitignore`忽略规则，目录分配如下：

- CAPI：选手接口，生成控制台可执行文件
- communication：通信组件（Server/Agent），生成`.Net Standard 2`类库与exe程序（Agent）
- installer：下载/更新器，生成Windows GUI程序
- interaction：玩家交互，生成Unity程序
- launcher：游戏启动器，生成Windows GUI程序
- logic：游戏逻辑，生成控制台可执行文件（`.Net Core 3.0`）
- dependency：需要使用的各种依赖与proto文件
- resource：用于主目录下markdown文件的图片等
- unittest：单元测试

分支：
- master：工作较稳定的版本或阶段性成果，需要2 reviewers。
- dev：各个小组开发工作最新进展，需要1 reviewer。

## 开发注意事项
- PR与Commit标题统一采用中文，禁止使用无意义的内容，科协仓库仅master与dev分支设有保护，可以自行创建其他分支用于小范围的团队合作
- 仍需要大家先将仓库fork到自己的仓库中进行开发
- 尽量不要上传大文件
- 不要在有大量改动的分支上使用rebase
- 对接内容应记录在`架构与对接.md`中，主要是通信格式、回放文件格式
- 多了解其他小组的工作

## 开发组成员

玩家交互：尤予阳 李翔宇

下载/更新器与游戏启动器：胡开哲 徐楼喆 白旻浩

游戏逻辑：邹俊泓 周君宝 李侔繁

通信与C++接口：常灿 郑荣坤 王冲

测试与部署：李侔繁

围观群众：胡钰彬 周嵩林 齐涛 孙志尧 饶淙元 贺鲲鹏 李煜泽 马啸阳

端茶送水：张钧 

 
