
USE QUANLYCHUOINHAHANG
--THAY CN = CHI NHÁNH Ở TRẠM CỦA MÌNH
-- ĐÂY LÀ 1 SỐ DỮ LIỆU MẪU
insert into  BAN values ('B1','BAN1',N'trống',null,'CN1')
insert into  BAN values ('B2','BAN2',N'trống',null,'CN1')
insert into  BAN values ('B3','BAN3',N'trống',null,'CN1')
insert into  BAN values ('B4','BAN4',N'trống',null,'CN1')
insert into  BAN values ('B5','BAN5',N'trống',null,'CN1')
insert into  BAN values ('B6','BAN6',N'trống',null,'CN1')
insert into  BAN values ('B7','BAN7',N'trống',null,'CN1')
insert into  BAN values ('B8','BAN8',N'trống',null,'CN1')
insert into  BAN values ('B9','BAN9',N'trống',null,'CN1')
insert into  BAN values ('B10','BAN10',N'trống',null,'CN1')
select * from BAN

insert into BOPHAN values ('BPB',N'Bếp',null,'CN1','0912121212')
insert into BOPHAN values ('BPBar',N'BAR',null,'CN1','0912121213')
insert into BOPHAN values ('BPQL',N'Quản lý',null,'CN1','0912121214')
insert into BOPHAN values ('BPK',N'Kho',null,'CN1','0912121215')
insert into BOPHAN values ('BPPV',N'Phục vụ',null,'CN1','0912121216')

insert into CHINHANH values ('CN1',N'Chi nhánh 1','Lê Duẩn quận 1','095234561')
--insert into CHINHANH values ('CN2',N'Chi nhánh 2','Lê Lợi quận 1','094234561')
--insert into CHINHANH values ('CN3',N'Chi nhánh 3','Lê Bình quận 1','093234561')
--insert into CHINHANH values ('CN4',N'Chi nhánh 4','Lê Thứ quận 1','0912345561')

--insert into KHACHHANG values ('kh1',N'Trần Sơn','0912354656','1991/11/11','2123/cmt8',null,'NAM')
--insert into KHACHHANG values ('kh2',N'Trần hùng','092354626','1991/11/11','2123/cmt1',null,'NU')
--insert into KHACHHANG values ('kh3',N'Trần khoa','0912354646','1991/11/11','2123/cmt2',null,'NAM')
--insert into KHACHHANG values ('kh4',N'Trần quang','0912334356','1991/11/11','2123/cmt3',null,'NU')

insert into KHO values ('K1','KHO1',N' 123 ly quan q3','0912312312','BPK')
insert into KHO values ('K2','KHO2',N' 123 ly quan q5','0912312318','BPK')
insert into KHO values ('K3','KHO3',N' 123 ly quan q4','0912312311','BPK')
insert into KHO values ('K4','KHO4',N' 123 ly quan q6','0912312314','BPK')

insert into LOAINGUYENLIEU values ('LNN',N'Nguyên liệu làm món ngọt')
insert into LOAINGUYENLIEU values ('LNM',N'Nguyên liệu làm món mặn')


insert into LOAITHUCDON values ('TDN',N'món ngọt',N'mở bán')
insert into LOAITHUCDON values ('TDM',N'món mặn',N'mở bán')

insert into NGUYENLIEU values ('nl1',N'kem trà xanh',N'còn hàng',N'nguyên liệu kem làm từ matcha',5,'LNN','kg','40000')
insert into NGUYENLIEU values ('nl2',N'kem chocolate',N'còn hàng',N'nguyên liệu kem làm từ chocolate',5,'LNN','kg','40000')
insert into NGUYENLIEU values ('nl3',N'Bánh flan',N'còn hàng',N'nguyên liệu làm từ sữa và trứng',100,'LNN','cái','2000')
insert into NGUYENLIEU values ('nl4',N'Shiratama',N'còn hàng',N'Viên shi làm từ bột gạo rang',1000,'LNN','viên','200')
insert into NGUYENLIEU values ('nl5',N'Sốt matcha',N'còn hàng',N'nguyên liệu kem làm từ bột trà xanh nguyên chất',20,'LNN','bình','25000')
insert into NGUYENLIEU values ('nl6',N'Cá hồi',N'còn hàng',N'Cá hồi',5,'LNM','kg','200000')
insert into NGUYENLIEU values ('nl7',N'Cá ngừ',N'còn hàng',N'Cá ngừ',5,'LNM','kg','150000')
insert into NGUYENLIEU values ('nl8',N'Tôm sú',N'còn hàng',N'Tôm sú',5,'LNM','kg','60000')
insert into NGUYENLIEU values ('nl9',N'Tôm hùm',N'còn hàng',N'Tôm hùm',10,'LNM','kg','550000')
insert into NGUYENLIEU values ('nl10',N'Trứng cá hồi',N'còn hàng',N'trứng cá hồi',50,'LNM','gam','25000')

insert into NHACUNGCAP values('NCC1',N'LÊ BÌNH',N'123 ly đại hành q10') --,'091230234'
insert into NHACUNGCAP values('NCC2',N'LONG THÀNH',N'123 ly  kiet q3') --,'091231834'
insert into NHACUNGCAP values('NCC3',N'VĂN KIỆM',N'123 ly thuong kiet q1') --,'091235234'
insert into NHACUNGCAP values('NCC4',N'S7 LAAER',N'123 ly thuong q12') -- ,'091231234'


insert into NHANVIEN values ('NV1', N'Trần Sơn', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý', 'Nam', '1995-10-27', '2013-08-13', 'BPQL', 'ADMIN');
--insert into NHANVIEN values ('NV2', N'Nguyễn Tấn Khoa', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý', 'Nam', '1995-10-27', '2013-08-13', 'BPQL', 'ADMIN');
--insert into NHANVIEN values ('NV3', N'Lê Hồng Quang', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý', 'Nam', '1995-10-27', '2013-08-13', 'BPQL', 'ADMIN');
--insert into NHANVIEN values ('NV4', N'Nguyễn Vinh', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý', 'Nam', '1995-10-27', '2013-08-13', 'BPQL', 'ADMIN');
insert into NHANVIEN values ('NV5', N'Nguyễn Hùng', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bar', 'Nam', '1995-10-27', '2013-08-13', 'BPbar', 'MOD');
--insert into NHANVIEN values ('NV6', N'Trần Anh Kiệt', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bar', 'Nam', '1995-10-27', '2013-08-13', 'BPbar', 'MOD');
--insert into NHANVIEN values ('NV7', N'Lý Bá Khá', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bar', 'Nam', '1995-10-27', '2013-08-13', 'BPbar', 'MOD');
--insert into NHANVIEN values ('NV8', N'Công Phượng', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bar', 'Nam', '1995-10-27', '2013-08-13', 'BPbar', 'MOD');
insert into NHANVIEN values ('NV9', N'Đoàn Văn Hậu', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bếp', 'Nam', '1995-10-27', '2013-08-13', 'BPB', 'MOD');
--insert into NHANVIEN values ('NV10', N'Nguyễn Duy', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bếp', 'Nam', '1995-10-27', '2013-08-13', 'BPB', 'MOD');
--insert into NHANVIEN values ('NV11', N'Nguyễn Phát Tài', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bếp', 'Nam', '1995-10-27', '2013-08-13', 'BPB', 'MOD');
--insert into NHANVIEN values ('NV12', N'Trần Nghị', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Trưởng bếp', 'Nam', '1995-10-27', '2013-08-13', 'BPB', 'MOD');
insert into NHANVIEN values ('NV13', N'Trần Văn Sang', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Phục vụ', 'Nam', '1995-10-27', '2013-08-13', 'BPK', 'NV');
--insert into NHANVIEN values ('NV14', N'Lê Bá Sĩ', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Phục vụ', 'Nam', '1995-10-27', '2013-08-13', 'BPPV', 'NV');
--insert into NHANVIEN values ('NV15', N'Trần Văn Tỏn', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Phục vụ', 'Nam', '1995-10-27', '2013-08-13', 'BPPV', 'NV');
--insert into NHANVIEN values ('NV16', N'Hồ Quang Hiếu', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Phục vụ', 'Nam', '1995-10-27', '2013-08-13', 'BPPV', 'NV');
insert into NHANVIEN values ('NV17', N'Vũ Thị Thu', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý kho', 'Nam', '1995-10-27', '2013-08-13', 'BPK', 'MOD');
--insert into NHANVIEN values ('NV18', N'Trần Thị Thúy', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý kho', 'Nam', '1995-10-27', '2013-08-13', 'BPK', 'MOD');
--insert into NHANVIEN values ('NV19', N'Trần Văn Bảnh', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý kho', 'Nam', '1995-10-27', '2013-08-13', 'BPK', 'MOD');
--insert into NHANVIEN values ('NV20', N'Trần Hùng Hào', N'835 Lighthouse Bay Avenue', '385-171-0113', 'blengthorn0@pcworld.com', '10000000', N'Quản lý kho', 'Nam', '1995-10-27', '2013-08-13', 'BPK', 'MOD');

insert into THUCDON values ('M1',N'Kem trái cây vị choco','TDN','60000','kem chocolate cùng các loại trái cây',null,null,'Ly')
insert into THUCDON values ('M2',N'Kem trái cây vị matcha','TDN','60000','kem matcha cùng các loại trái cây',null,null,'Ly')
insert into THUCDON values ('M3',N'Matchashiratama','TDN','60000','matcha với shiratama',null,null,'Ly')
insert into THUCDON values ('M4',N'Matchasinsui','TDN','60000','matchamatcha sinsui',null,null,'Ly')
insert into THUCDON values ('M5',N'ArigaMatcha','TDN','60000',',matcha ariga',null,null,'Ly')
insert into THUCDON values ('M6',N'shushi tôm','TDM','200000','shushi tôm sú',null,null,'phần')
insert into THUCDON values ('M7',N'shushi tôm hùm','TDM','1000000','shushi tôm hùm',null,null,'phần')
insert into THUCDON values ('M8',N'trứng cá hồi hấp','TDM','1200000','trứng cá hồi hấp',null,null,'phần')
insert into THUCDON values ('M9',N'shushi cá ngừ','TDM','280000','shushi cá ngừ',null,null,'phần')
insert into THUCDON values ('M10',N'shushi cá hồi','TDM','300000','shushi cá hồi',null,null,'Phần')
