drop table if exists User;
create table if not exists User(
	Id Int(10) auto_increment,
    UserName nvarchar(20) not null,
    PassWord nvarchar(50) not null,
    DisplayName nvarchar(30) not null,
    Address nvarchar(300) not null,
    Phone nvarchar(20) null default NULL,
    RoleId int(10) not null,
    CreateTime datetime(3),
    primary key(id,UserName),
    foreign key(RoleId) references Role(Id)
);