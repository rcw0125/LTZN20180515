update rbcaozuo set banbie=(select 班别 from 高炉大班排班表 where 日期=trunc(rbcaozuo.sj) and 班次='白班') where to_number(to_char(sj,'HH24'))>=9 and to_number(to_char(sj,'HH24'))<=19 and gaolu in (3,4,5);
update rbcaozuo set banbie=(select 班别 from 高炉大班排班表 where 日期=trunc(rbcaozuo.sj) and 班次='夜班') where to_number(to_char(sj,'HH24'))<9  and gaolu <>1;
update rbcaozuo set banbie=(select 班别 from 高炉大班排班表 where 日期=trunc(rbcaozuo.sj+1) and 班次='夜班') where to_number(to_char(sj,'HH24'))>19 and gaolu in (3,4,5);
update rbcaozuo set banbie=(select 班别 from 高炉大班排班表 where 日期=trunc(rbcaozuo.sj) and 班次='白班') where to_number(to_char(sj,'HH24'))>=9 and to_number(to_char(sj,'HH24'))<=20 and gaolu=2;
update rbcaozuo set banbie=(select 班别 from 高炉大班排班表 where 日期=trunc(rbcaozuo.sj+1) and 班次='夜班') where to_number(to_char(sj,'HH24'))>20 and gaolu=2;
update rbcaozuo set banbie=(select 班别 from 高炉排班表 where 日期=trunc(rbcaozuo.sj) and 班次='夜班') where to_number(to_char(sj,'HH24'))>=1 and to_number(to_char(sj,'HH24'))<=8 and gaolu=1;
update rbcaozuo set banbie=(select 班别 from 高炉排班表 where 日期=trunc(rbcaozuo.sj) and 班次='白班') where to_number(to_char(sj,'HH24'))>=9 and to_number(to_char(sj,'HH24'))<=16 and gaolu=1;
update rbcaozuo set banbie=(select 班别 from 高炉排班表 where 日期=trunc(rbcaozuo.sj) and 班次='中班') where to_number(to_char(sj,'HH24'))>=17 and gaolu=1;
update rbcaozuo set banbie=(select 班别 from 高炉排班表 where 日期=trunc(rbcaozuo.sj-1) and 班次='中班') where to_number(to_char(sj,'HH24'))=0 and gaolu=1;
commit;