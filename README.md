# 图书管理系统
简单的图书管理系统
连接的数据库名称是：book2
建立的五个基本表
建表SQL脚本如下：
--建表
create table BookAdmin --管理员
(
	id varchar(20) primary key,--登录账号
	psw varchar(20) not null,--密码
	name varchar(20),--管理员名字
	admin_type varchar(20),--管理员类型
);

create table BookUser --用户
(
	id varchar(20) ,--登录账号/身份凭证
	name varchar(20),--用户名字
	sex varchar(10),--用户性别
	psw varchar(20) not null,--密码
	primary key(id),
);

create table ReaderCategory --用户类别
(
	id varchar(20) foreign key references BookUser--用户登录账号
	on delete cascade,
	user_type varchar(20), --用户类型
	bb_number int,--用户最大借书的数量
	book_number int,--用户已经借书的数量
	max_datetime int,--最大借书时间
);

create table Book--图书表
(
	id varchar(30) primary key,--图书编号
	name varchar(20),--图书名
	author varchar(20),--第一作者
	press varchar(20),--出版社
	inventory int,--图书馆借出数量
	book_number int,--总数量
	book_type varchar(20),--图书类别
	price int, --图书单价
	bookstate int not null, --状态（正常-1，报废-0）
);

create table BookLend --借书记录表
(
	no int ,--借书记录编号
	uid varchar(20) foreign key (uid) references  BookUser(id) on delete cascade,--用户id
	bid varchar(30) foreign key (bid) references Book(id) on delete cascade,--图书id
	datetime datetime,--借书日期
	lbook_time datetime,--还书日期
	money float not null check (money>=0), --超期扣款
	isback int not null, --是否已还书 
	renew int not null--是否续借
);

create view user_01 --创建读者用户视图
as
select id,name,sex
from BookUser;

create view admin_01 --创建管理员视图
as
select id,name,admin_type
from BookAdmin;
--管理员设置
insert into BookAdmin values('1','1','张三','系统管理员');
--用户设置
insert into BookUser values('1001','罗翔','男','1');
--图书入库
insert into Book 
values('10001','C语言','谭浩强','高等教育出版社',0,20,'计算机',30,1)
,('10002','数据库原理','王珊','高等教育出版社',0,10,'计算机',35,1)
,('10003','我在凡人科学修仙','洛青子','起点小说网',0,10,'玄幻',35,1);
