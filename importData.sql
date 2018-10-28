insert into THELOAI
values('TL001','Công Nghệ'),
('TL002','Khoa Học'),
('TL003','Thực Phẩm')
insert into NHAXB
values('XB001','NXB Trẻ','11111111','090009900'),
('XB002','NXB Thanh Niên','112111','090033900'),
('XB003','NXB Vị Thành Niên','111211','09012100')
insert into TACGIA
values('TG001','Trần Lê Văn Đức','0900552312','1212121'),
('TG002','Nguyễn Thái Bảo','0900532312','12312121'),
('TG003','Nguyễn Thanh Quang','09252312','121312321121')
insert into VITRI
values('VT001','A1'),
('VT002','A2'),
('VT003','A3')
insert into Khoa 
values ('CNTT',N'Công Nghệ Thông Tin')
insert into SINHVIEN
values('SV001','CNTT',N'Trần Lê Văn Đức','09/03/1997','20011222','vanduc3997@gmail.com',N'Quận 12,TP.HCM','0961260796',2015)
insert into SINHVIEN
values('SV002','CNTT',N'Nguyễn Thanh Quang','09/03/1997','20011222','vanduc3997@gmail.com',N'Quận 12,TP.HCM','0961260796',2015)
insert into CHUCVU
values ('CV001',N'Thủ Kho')
select * from taikhoan
insert into TAIKHOAN 
values ('sa011','aaaaa',1)
insert into NHANVIEN
values('NV001','CV001','sa011',N'Nguyễn Thái Bảo','12/04/1997','201122312',N'Quận Tân Phú,TP.HCM','08081508','thaigiam@gmail.com')
create View viewDoanhThu
as
select sum(p.SOTIENPHAT) as tienphat,
		sum(pm.PHIMUON) as tienmuon,
		sum(pm.PHIMUON) +sum(p.SOTIENPHAT) as tongcong
from PHAT p ,PHIEUMUONTRA pm
select * from viewDoanhThu