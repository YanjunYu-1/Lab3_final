一、在Model中创建Class

（1）ParkingSpace：少写一个构造函数，测试是否需要

（2）Reservation：同学的relationship没有些问题，老师的要求有问题

（3）Vehicle

（4）Pass

二、建立连接：视图=>服务器资源管理器

三、建立controller

（1）安装依赖包
```java
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

（2）建立Account和Customer的controller
```java
~/Views/Shared/_Layout.cshtml
```

（3）在appsettings中连接服务器

（4）迁移并上传SQL
```java
Add-Migration Initial
Update-Database

Remove-Migration
```

五、建立DAL和BLL

（1）DAL：建立接口，利用泛型把所有功能写入=>建立对每个class的DAL文件，将泛型功能接入。

（2）BLL：对每个Class写BLL文件，一旦建立BLL文件，需要对controller文件进行修改，因为所有数据来源的位置进行了改变

注意：BLL层调取DAL层数据，然后数据在controller中进行实现，此处用了两种方法，都可以提取数据

六、建立UnitTest

（1）Mock从DAL层取数

（2）两种方法可以解决