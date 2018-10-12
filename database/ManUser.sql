/*drop table MAN_USERGROUP;
drop table MAN_GROUPAUTHORITY;
drop table MAN_USER;
drop table MAN_GROUP;
drop table MAN_AUTHORITY;*/


create table MAN_USER(UserName varchar2(200) primary key,Password varchar2(200),Descr varchar2(200),CreateTime Date Not Null,LastLoginTime Date Not Null,LastLoginIp varchar2(20));
create table MAN_GROUP(GroupName varchar2(200) primary key,Descr varchar(200));
create table MAN_AUTHORITY(AuthorityName varchar2(200) primary key,Descr varchar(200));
create table MAN_USERGROUP(UserName varchar2(200),GroupName varchar2(200));
create table MAN_GROUPAUTHORITY(GroupName varchar2(200),AuthorityName varchar2(200));
create unique index xpk_man_usergroup on MAN_USERGROUP(UserName,GroupName);
alter table MAN_USERGROUP add (foreign key(UserName) references MAN_USER);
alter table MAN_USERGROUP add (foreign key(GroupName) references MAN_GROUP);
create unique index xpk_man_groupauthority on MAN_GROUPAUTHORITY(GroupName,AuthorityName);
alter table MAN_GROUPAUTHORITY add (foreign key(GroupName) references MAN_GROUP);
alter table MAN_GROUPAUTHORITY add (foreign key(AuthorityName) references MAN_AUTHORITY);
