use ecdata;
drop table if exists MonHoc;

create table if not exists MonHoc(
	Id Int(10) auto_increment,
    MaMH varchar(10) not null,
    TenMH nvarchar(20) not null,
    Status bit default 0,
    primary key(Id, MaMH),
    unique(MaMH)
);