drop table if exists Role;
create table if not exists Role(
	Id Int(10) auto_increment,
    Role nvarchar(10) not null,
    primary key(id,Role)
    
);