银行管理系统 --基于C#/MySQL

-----------------

使用前，将`bank.cs`中的`ConnectStr`中参数修改，连接到自己的数据库

```c#
public const string ConnectStr = "server = ********; port = 3306;user = bank;password = ****; database = ****;";
```

-----------------

数据表中其他数据表在服务器中自己搭建

`pro`

![image-20200707180242450](F:\C#\上交\Bank1.0\IMAGE\1.png)

`product`

![image-20200707180254241](F:\C#\上交\Bank1.0\IMAGE\2.png)

-------

汇率更新数据库，爬虫程序见`.py`文件

运行在服务器端

----------------

小组成员：吴泽森（组长)、陈惟逸、陈伯钧