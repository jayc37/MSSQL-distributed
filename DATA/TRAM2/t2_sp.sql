--------------------------------------------------------------------
-- SP --- TRẠM 1 - MÁY SƠN

--------------------------------------------------------------------

use QUANLYCHUOINHAHANG
-- TABLE CHINHANH
go
-- insert
create proc SP_THEM_CHINHANH
	@IDCHINHANH NVARCHAR(10),
	@TENCHINHANH nvarchar(40),
	@SODIENTHOAI NVARCHAR(24)
as
begin
	-- kiểm tra mã chi nhánh đã tồn tại chưa.
	if exists (select * from ChiNhanh where idchinhanh = @IDCHINHANH)
	begin
		raiserror('Mã chi nhánh đã tồn tại', 16, 1)
		return
	end 
	-- da insert vao tram_1 hoac tram_2 => insert vao may_chu
	set xact_abort on
	begin distributed tran
		insert into CHINHANH values (@IDCHINHANH, @TENCHINHANH, 'CN2', @SODIENTHOAI) -- THAY 'CN1' = 'CN2' NẾU LÀ MÁY TRẠM 2 (TRẠM 3 TƯƠNG TỰ)
		insert into QLVT_LINKED_SERVER.qlvattu.dbo.ChiNhanh values (@IDCHINHANH, @TENCHINHANH, 'CN2', @SODIENTHOAI)
	commit tran
end
go
-- delete
create proc SP_XOA_CHINHANH
	@IDCHINHANH Nvarchar(10)
as
begin
	if not exists (select * from ChiNhanh where IDCHINHANH = @IDCHINHANH)
	begin
		raiserror('Mã chi nhánh không tồn tại', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 => delete ở MAY_CHU
	set xact_abort on
	begin distributed tran
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.ChiNhanh where idchinhanh = @IDCHINHANH
		delete ChiNhanh where idchinhanh = @IDCHINHANH
	commit tran
end
-- update
go
create proc sp_Sua_ChiNhanh
	@IDCHINHANH NVARCHAR(10),
	@TENCHINHANH nvarchar(40),
	@SODIENTHOAI NVARCHAR(24)
as
begin
	set xact_abort on
	begin distributed tran
		update ChiNhanh set tenchinhanh = @TENCHINHANH, sodienthoai = @SODIENTHOAI where idchinhanh = @IDCHINHANH
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.ChiNhanh set tenchinhanh = @TENCHINHANH, sodienthoai = @SODIENTHOAI where idchinhanh = @IDCHINHANH
	commit tran
end
go
--TABLE KHO
--insert
create proc sp_Them_Kho
	@IDKHO NVARCHAR(20),
	@TENKHO nvarchar(40),
	@DIACHI nvarchar(40),
	@SODIENTHOAI NVARCHAR(24)
as
begin
	set xact_abort on
	begin distributed tran
		insert KHO values (@IDKHO, @TENKHO, @DIACHI, @SODIENTHOAI,'BPK')
		insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.KHO values (@IDKHO, @TENKHO, @DIACHI, @SODIENTHOAI,'BPK')
	commit tran
end
-- delete
go
create proc sp_Xoa_Kho
		@IDKHO NVARCHAR(20)
as
begin
	if not exists (select * from Kho where idkho = @IDKHO)
	begin
		raiserror('Mã kho không tồn tại', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 hoặc 3 VÀ MÁY CHỦ
	set xact_abort on
	begin distributed tran
		delete Kho where idkho = @IDKHO
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.Kho where idkho = @IDKHO
	commit tran
end
go
-- update
create proc sp_Sua_Kho
	@IDKHO NVARCHAR(20),
	@TENKHO nvarchar(40),
	@DIACHI nvarchar(40),
	@SODIENTHOAI NVARCHAR(24)
as
begin	
	set xact_abort on
	begin distributed tran
		update kho set TenKho = @TENKHO, diachi = @DIACHI , SODIENTHOAI = @SODIENTHOAI where idkho = @IDKHO
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.kho set TenKho = @TENKHO, diachi = @DIACHI , SODIENTHOAI = @SODIENTHOAI where idkho = @IDKHO
	commit tran
end
-- TABLE NGUYENLIEU
-- insert
go
create proc SP_THEM_NGUYENLIEU
	@IDNGUYENLIEU nvarchar(20),
	@TENNGUYENLIEU nvarchar(40),
	@TRANGTHAI nvarchar(10),
	@MOTA NVARCHAR(10),
	@SOLUONG SMALLINT,
	@IDLOAINGUYENLIEU NVARCHAR(20),
	@DONVITINH NCHAR(20),
	@GIANHAP MONEY
as
begin
	set xact_abort on
	begin distributed tran
		insert into QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU 
		values (@IDNGUYENLIEU,@TENNGUYENLIEU,@TRANGTHAI,@MOTA,@SOLUONG,@IDLOAINGUYENLIEU,@DONVITINH,@GIANHAP)
		insert into NGUYENLIEU values(@IDNGUYENLIEU,@TENNGUYENLIEU,@TRANGTHAI,@MOTA,@SOLUONG,@IDLOAINGUYENLIEU,@DONVITINH,@GIANHAP)
		insert into QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU values(@IDNGUYENLIEU,@TENNGUYENLIEU,@TRANGTHAI,@MOTA,@SOLUONG,@IDLOAINGUYENLIEU,@DONVITINH,@GIANHAP) -- nếu là trạm 1 sẽ insert vào 3 trạm còn lại.
		--insert into QLVT_TRAM_3.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU values(@IDNGUYENLIEU,@TENNGUYENLIEU,@TRANGTHAI,@MOTA,@SOLUONG,@IDLOAINGUYENLIEU,@DONVITINH,@GIANHAP)
	commit tran
end
-- delete
go
create proc SP_XOA_NGUYENLIEU
	@IDNGUYENLIEU nvarchar(20)
as
begin
	-- kiểm tra id nguyên liệu không tồn tại
	if not exists (select IDNGUYENLIEU from NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU)
	begin
		raiserror('nguyên liệu không tồn tại', 16, 1)
		return
	end
	-- delete
	set xact_abort on
	begin distributed tran
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU
		delete NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU
		delete QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU -- NẾU LÀ TRẠM 1 INSERT VÀO 3 TRẠM CÒN LẠI
		--delete QLVT_TRAM_3.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU
		--delete QLVT_TRAM_4.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU
	commit tran
end
-- update
go
create proc SP_SUA_NGUYENLIEU
	@IDNGUYENLIEU nvarchar(20),
	@TENNGUYENLIEU nvarchar(40),
	@TRANGTHAI nvarchar(10),
	@MOTA NVARCHAR(10),
	@SOLUONG SMALLINT,
	@IDLOAINGUYENLIEU NVARCHAR(20),
	@DONVITINH NCHAR(20),
	@GIANHAP MONEY
as
begin
	if not exists (select IDNGUYENLIEU from NGUYENLIEU where IDNGUYENLIEU = @IDNGUYENLIEU)
	begin
		raiserror('Nguyên liệu không tồn tại', 16, 1)
		return
	end
	-- update
	set xact_abort on
	begin distributed tran
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU
		SET TENNGUYENLIEU = @TENNGUYENLIEU,trangthai =  @TRANGTHAI,MOTA = @MOTA,SOLUONG = @SOLUONG, IDNGUYENLIEU = @IDLOAINGUYENLIEU,DONVITINH = @DONVITINH,GIANHAP = @GIANHAP
		where idnguyenlieu = @IDNGUYENLIEU

		update NGUYENLIEU
		SET TENNGUYENLIEU = @TENNGUYENLIEU,trangthai =  @TRANGTHAI,MOTA = @MOTA,SOLUONG = @SOLUONG, IDNGUYENLIEU = @IDLOAINGUYENLIEU,DONVITINH = @DONVITINH,GIANHAP = @GIANHAP -- NẾU LÀ TRẠM 1 UPDATE Ở 3 TRẠM CÒN LẠI (BAO GỒM MÁY CHỦ)
		where idnguyenlieu = @IDNGUYENLIEU

		update QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU
		SET TENNGUYENLIEU = @TENNGUYENLIEU,trangthai =  @TRANGTHAI,MOTA = @MOTA,SOLUONG = @SOLUONG, IDNGUYENLIEU = @IDLOAINGUYENLIEU,DONVITINH = @DONVITINH,GIANHAP = @GIANHAP
		where idnguyenlieu = @IDNGUYENLIEU
		--update QLVT_TRAM_3.QUANLYCHUOINHAHANG.dbo.NGUYENLIEU
		--SET TENNGUYENLIEU = @TENNGUYENLIEU,trangthai =  @TRANGTHAI,MOTA = @MOTA,SOLUONG = @SOLUONG, IDNGUYENLIEU = @IDLOAINGUYENLIEU,DONVITINH = @DONVITINH,GIANHAP = @GIANHAP
		--where idnguyenlieu = @IDNGUYENLIEU

	commit tran
end	
-- TABLE NHANVIEN
-- insert
go

create proc sp_Them_NhanVien
			@idnhanvien			nvarchar(20),
			@tennhanvien			nvarchar(60),
			@diachi				nvarchar(40),
			@sodienthoai		nvarchar(24),
			@email			nvarchar(40),
			@LUONG MONEY,
			@CHUCVU NVARCHAR(20),
			@gioitinh nvarchar(10),
			@ngaysinh date,
			@ngaybatdau date,
			@idbophan NVARCHAR(20),
			@Quyen nvarchar(20)
as
begin
		insert into NHANVIEN values (@idnhanvien, @tennhanvien, @diachi, @sodienthoai, @email, @LUONG, @CHUCVU, @gioitinh, @ngaysinh, @ngaybatdau, @idbophan,@Quyen)
		insert into QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NhanVien
		values (@idnhanvien, @tennhanvien, @diachi, @sodienthoai, @email, @LUONG, @CHUCVU, @gioitinh, @ngaysinh, @ngaybatdau, @idbophan,@Quyen)
end
go
-- delete
create proc sp_Xoa_NhanVien
	@tennhanvien nvarchar(60)
as
begin
	
		delete NhanVien where tennhanvien = @tennhanvien
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NhanVien where tennhanvien = @tennhanvien
end
-- update
go
select * from NHANVIEN
create proc sp_Sua_NhanVien
			@idnhanvien			nvarchar(20),
			@tennhanvien			nvarchar(60),
			@diachi				nvarchar(40),
			@sodienthoai		nvarchar(24),
			@email			nvarchar(40),
			@LUONG MONEY,
			@CHUCVU NVARCHAR(20),
			@gioitinh nvarchar(10),
			@ngaysinh date,
			@ngaybatdau date,
			@idbophan NVARCHAR(20),
			@Quyen nvarchar(20)
as
begin
		update NhanVien set tennhanvien = @tennhanvien, DIACHI = @diachi,SODIENTHOAI = @sodienthoai,EMAIL =  @email,LUONG =  @LUONG,CHUCVU = @CHUCVU,GIOITINH =  @gioitinh,NGAYSINH = @ngaysinh,NGAYBATDAU =  @ngaybatdau,idbophan = @idbophan,QUYEN = @Quyen where idnhanvien = @idnhanvien
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NhanVien set tennhanvien = @tennhanvien, DIACHI = @diachi,SODIENTHOAI = @sodienthoai,EMAIL =  @email,LUONG =  @LUONG,CHUCVU = @CHUCVU,GIOITINH =  @gioitinh,NGAYSINH = @ngaysinh,NGAYBATDAU =  @ngaybatdau,idbophan = @idbophan,QUYEN = @Quyen where idnhanvien = @idnhanvien
end
-- TABLE KHACHHANG ĐƯỢC PHÂN MẢNH DỌC.
-- TRẠM 1 VÀ TRẠM 2 THUỘC CN1 CN2
-- + TRẠM 1 LƯU TRỮ THÔNG TIN (IDKHACHHANG, TENKHACHHANG,SODIENTHOAI, DIACHI)
-- + TRẠM 2 LƯU TRỮ THÔNG TIN (IDKHACHHANG, NGAYSINH, THONGTINKHAC, PHAI)
--TRẠM 3 THUỘC CN3
-- +TRẠM 3 TƯƠNG TỰ TRẠM 1 (CN3) PHÂM MẢNH DỌC ĐẾN TRẠM 2
go
create proc sp_Them_KhachHang --exec sp_Them_KhachHang 'KH7','Trần B','0912123123','1992/11/12','20/12 lý thường luận',null,'NAM'
	@IDKHACHHANG NVARCHAR(40),
	@TENKHACHHANG nvarchar(40),
	@SODIENTHOAI nvarchar(24),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(40),
	@THONGTINKHAC NVARCHAR(250),
	@PHAI NVARCHAR(5)
as
begin
	-- insert
	
		insert into QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.KhachHang values (@IDKHACHHANG, @TENKHACHHANG, @SODIENTHOAI, @NGAYSINH,@DIACHI,@THONGTINKHAC,@PHAI)
		insert into QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.KhachHang values (@IDKHACHHANG, @TENKHACHHANG, @SODIENTHOAI,@DIACHI)
		insert into KhachHang values (@IDKHACHHANG, @NGAYSINH,@THONGTINKHAC, @PHAI)
end
go
-- delete
create proc sp_Xoa_KhachHang
	@IDKHACHHANG NVARCHAR(40)
as
begin
-- kiểm tra mã khách hàng
	if not exists (select idkhachhang from KhachHang where idkhachhang = @IDKHACHHANG)
	begin
		raiserror('Mã khách hàng không tồn tại', 16, 1)
		return
	end
	-- delete
	set xact_abort on
	begin distributed tran
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.KhachHang where idkhachhang = @IDKHACHHANG
		delete KhachHang where idkhachhang = @IDKHACHHANG
		delete QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.KhachHang where idkhachhang = @IDKHACHHANG
	commit tran
end
go
-- update
create proc sp_Sua_KhachHang
	@IDKHACHHANG NVARCHAR(40),
	@TENKHACHHANG nvarchar(40),
	@SODIENTHOAI nvarchar(24),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(40),
	@THONGTINKHAC NVARCHAR(250),
	@PHAI NVARCHAR(5)
as
begin
	-- kiểm tra mã khách hàng
	if not exists (select @IDKHACHHANG from KhachHang where idkhachhang = @IDKHACHHANG)
	begin
		raiserror('Mã khách hàng không tồn tại', 16, 1)
		return
	end
	-- update
	set xact_abort on
	begin distributed tran
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.KhachHang
		set  tenkhachhang = @TENKHACHHANG,SODIENTHOAI = @SODIENTHOAI,ngaysinh = @NGAYSINH, DIACHI = @DIACHI, thongtinkhac = @THONGTINKHAC, PHAI = @PHAI
		where idkhachhang = @IDKHACHHANG

		update QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.khachhang
		set tenkhachhang = @TENKHACHHANG,SODIENTHOAI = @SODIENTHOAI,DIACHI = @DIACHI
		where idkhachhang = @IDKHACHHANG

		update KhachHang
		set ngaysinh = @NGAYSINH, thongtinkhac = @THONGTINKHAC,PHAI = @PHAI
		where idkhachhang = @IDKHACHHANG
	commit tran
end
-- TABLE NHACUNGCAP ĐƯỢC PHÂN MẢNH DỌC.
-- TRẠM 1 VÀ TRẠM 2 THUỘC CN1 CN2
-- + TRẠM 1 LƯU TRỮ THÔNG TIN (IDNHACUNGCAP, TENNHACUNGCAP,DIACHI)
-- + TRẠM 2 LƯU TRỮ THÔNG TIN (IDNHACUNGCAP, SODIENTHOAI)
--TRẠM 3 THUỘC CN3
-- +TRẠM 3 TƯƠNG TỰ TRẠM 1 (CN3) PHÂM MẢNH DỌC ĐẾN TRẠM 2
go
create proc sp_Them_NhaCungCap
	@IDNHACUNGCAP NVARCHAR(20),
	@TENNHACUNGCAP nvarchar(40),
	@DIACHI nvarchar(40),
	@SODIENTHOAI NVARCHAR(24)
as
begin
	-- kiểm tra mã nhà cung cấp
	if exists (select idnhacungcap from NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP)
	begin
		raiserror('Mã nhà cung cấp đã tồn tại', 16, 1)
		return
	end
	-- insert
		insert into QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NHACUNGCAP values (@IDNHACUNGCAP, @TENNHACUNGCAP, @DIACHI, @SODIENTHOAI)
		insert into QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.NHACUNGCAP values (@IDNHACUNGCAP, @TENNHACUNGCAP, @DIACHI)
		insert into NHACUNGCAP values (@IDNHACUNGCAP, @SODIENTHOAI)
end
go
-- delete
create proc sp_Xoa_NhaCungCap
	@IDNHACUNGCAP varchar(20)
as
begin
	-- kiểm tra mã nhà cung cấp
	if not exists (select idnhacungcap from NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP)
	begin
		raiserror('Mã nhà cung cấp không tồn tại', 16, 1)
		return
	end
	-- delete
	set xact_abort on
	begin distributed tran
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP
		delete NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP
		delete QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP
	commit tran
end
go
-- update
create proc sp_Sua_NhaCungCap
	@IDNHACUNGCAP NVARCHAR(20),
	@TENNHACUNGCAP nvarchar(40),
	@DIACHI nvarchar(40),
	@SODIENTHOAI NVARCHAR(24)
as
begin
	-- kiểm tra mã nhà cung cấp
	if not exists (select idnhacungcap from NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP)
	begin
		raiserror('Mã nhà cung cấp không tồn tại', 16, 1)
		return
	end
	-- insert
	set xact_abort on
	begin distributed tran
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.NHACUNGCAP
		set tennhacungcap = @TENNHACUNGCAP, DIACHI = @DIACHI, SODIENTHOAI = @SODIENTHOAI
		where idnhacungcap = @IDNHACUNGCAP

		update QLVT_TRAM_1.QUANLYCHUOINHAHANG.dbo.NHACUNGCAP
		set tennhacungcap = @TENNHACUNGCAP, DIACHI = @DIACHI
		where idnhacungcap = @IDNHACUNGCAP

		update NHACUNGCAP
		set sodienthoai = @SODIENTHOAI
		where idnhacungcap = @IDNHACUNGCAP
	commit tran
end
go
-- table HOADONNHAP
-- insert 
create proc sp_Them_PhieuNhap 
	@IDHOADONNHAP NVARCHAR(10),
	@IDNHACUNGCAP NVARCHAR(20),
	@NGAYNHAP DATE,
	@TINHTRANG nvarchar(5),
	@IDNHANVIEN NVARCHAR(20),
	@IDNGUYENLIEU NVARCHAR(20),
	@GIANHAP MONEY,
	@SOLUONG NVARCHAR(5),
	@IDKHO nvarchar(20)
as
begin
	-- kiểm tra mã phiếu nhập
	if exists (select idhoadonnhap from HOADONNHAP where idhoadonnhap = @IDHOADONNHAP)
	begin
		raiserror('Mã phiếu nhập đã tồn tại', 16, 1)
		return
	end
	-- kiểm tra mã nhà cung cấp
	if not exists (select idnhacungcap from NHACUNGCAP where idnhacungcap = @IDNHACUNGCAP)
	begin
		raiserror('Mã nhà cung cấp không tồn tại', 16, 1)
		return
	end
	-- kiểm tra mã nhân viên
	if not exists (select IDNHANVIEN from NHANVIEN where IDNHANVIEN = @IDNHANVIEN)
	begin
		raiserror('Mã nhân viên không không tại', 16, 1)
		return
	end
	-- kiểm tra mã nguyên liệu
	if not exists (select idnguyenlieu from NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU)
	begin
		raiserror('Mã nguyên liệu không tồn tại', 16, 1)
		return
	end
	-- insert
		insert into QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.hoadonnhap
		values (@IDHOADONNHAP,@IDNHACUNGCAP,@NGAYNHAP,@TINHTRANG,@IDNHANVIEN,NULL,@IDKHO)
		insert into QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.chitiethoadonnhap
		values (@IDHOADONNHAP,@IDNGUYENLIEU,@GIANHAP,@SOLUONG,NULL)
		insert into hoadonnhap
		values (@IDHOADONNHAP,@IDNHACUNGCAP,@NGAYNHAP,@TINHTRANG,@IDNHANVIEN,NULL,@IDKHO)
		insert into chitiethoadonnhap
		values (@IDHOADONNHAP,@IDNGUYENLIEU,@GIANHAP,@SOLUONG,NULL)
		exec sp_Them_CHITIETKHO @IDKHO,@IDNGUYENLIEU,@SOLUONG
end
go
--trigger
	create trigger sp_tudongnhantien on chitiethoadonnhap
	after insert,update
	as
	begin
		update CHITIETHOADONNHAP
		set thanhtien = soluong * gianhap
		update HOADONNHAP
		set thanhtien = CHITIETHOADONNHAP.thanhtien from CHITIETHOADONNHAP
		where HOADONNHAP.idhoadonnhap = CHITIETHOADONNHAP.idhoadonnhap	
	end
go

-- delete
create proc sp_Xoa_PhieuNhap --exec sp_xoa_phieunhap 'HDN2'
	@idhoadonnhap nvarchar(10)
as
begin
	-- kiểm tra mã nhà phiếu nhâp
	if not exists (select idhoadonnhap from hoadonnhap where idhoadonnhap = @idhoadonnhap)
	begin
		raiserror('Mã phiếu nhâp không tồn tại', 16, 1)
		return
	end
	-- delete
		delete CHITIETHOADONNHAP where idhoadonnhap = @idhoadonnhap
		delete HOADONNHAP where idhoadonnhap = @idhoadonnhap
		--xóa trên phiếu chi tiết nhập
		delete QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.chitiethoadonnhap where idhoadonnhap = @idhoadonnhap
		delete QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.hoadonnhap where idhoadonnhap = @idhoadonnhap
		--xóa trên phiếu chi tiết nhập
end
go
-- update
create proc sp_Sua_PhieuNhap
	@IDHOADONNHAP NVARCHAR(10),
	@IDNHACUNGCAP NVARCHAR(20),
	@NGAYNHAP DATE,
	@TINHTRANG nvarchar(5),
	@IDNHANVIEN NVARCHAR(20),
	@IDNGUYENLIEU NVARCHAR(20),
	@GIANHAP MONEY,
	@SOLUONG NVARCHAR(5),
	@IDKHO nvarchar(20)
as
begin
	-- kiểm tra mã phiếu nhập
	if not exists (select IDHOADONNHAP from HOADONNHAP where idhoadonnhap = @IDHOADONNHAP)
	begin
		raiserror('Mã phiếu nhập không tồn tại', 16, 1)
		return
	end
	-- update
	set xact_abort on
	begin distributed tran
		update HOADONNHAP set idnhacungcap = @IDNHACUNGCAP, ngaynhap = @NGAYNHAP,tinhtrang = @TINHTRANG,idnhanvien = @IDNHANVIEN , idkho = @idkho where idhoadonnhap = @IDHOADONNHAP
		update CHITIETHOADONNHAP set idnguyenlieu = @IDNGUYENLIEU, gianhap = @GIANHAP , soluong = @SOLUONG where idhoadonnhap = @IDHOADONNHAP
		update QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.hoadonnhap set idnhacungcap = @IDNHACUNGCAP, ngaynhap = @NGAYNHAP,tinhtrang = @TINHTRANG,idnhanvien = @IDNHANVIEN,idkho = @idkho where idhoadonnhap = @IDHOADONNHAP
		update QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.CHITIETHOADONNHAP set idnguyenlieu = @IDNGUYENLIEU, gianhap = @GIANHAP , soluong = @SOLUONG where idhoadonnhap = @IDHOADONNHAP

	commit tran
end
go
-- table PHIEUXUAT
-- insert

create proc sp_Them_PHIEUXUAT
	@IDHOADON NVARCHAR(20),
	@TRANGTHAITHANHTOAN NVARCHAR(10),
	@THOIGIAN DATETIME,
	@CODE nvarchar(250),
	@IDKHACHHANG NVARCHAR(20),
	@IDBAN NVARCHAR(20),
	@IDNHANVIENTHANHTOAN NVARCHAR(20),
	@GIAHIENTAI MONEY,
	@IDMON NVARCHAR(20),
	@VAT FLOAT,
	@SOLUONG SMALLINT
as
begin
	-- kiểm tra mã phiếu nhập
	if exists (select idhoadon from HOADON where idhoadon = @IDHOADON)
	begin
		raiserror('Mã phiếu xuất đã tồn tại', 16, 1)
		return
	end
	-- kiểm tra mã khách hàng
	if not exists (select IDKHACHHANG from KHACHHANG where IDKHACHHANG = @IDKHACHHANG)
	begin
		raiserror('Mã khách hàng không tồn tại', 16, 1)
		return
	end
	-- kiểm tra mã nhân viên
	if not exists (select IDNHANVIEN from NHANVIEN where IDNHANVIEN = @IDNHANVIENTHANHTOAN)
	begin
		raiserror('Mã id không không tại', 16, 1)
		return
	end
	-- kiểm tra mã món ăn
	if not exists (select idmon from THUCDON where idmon =@IDMON )
	begin
		raiserror('Mã món ăn không tồn tại', 16, 1)
		return
	end
	-- kiểm tra mã bàn
	if not exists (select idban from BAN where idban = @IDBAN)
	begin
		raiserror('Mã bàn không không tại', 16, 1)
		return
	end
	-- insert
		insert into  QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.hoadon
		values (@IDHOADON,@TRANGTHAITHANHTOAN,@THOIGIAN,@code,@IDKHACHHANG,@idban,@IDNHANVIENTHANHTOAN,null)
		insert into QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.chitiethoadon
		values (@IDHOADON,@GIAHIENTAI,@IDMON,@VAT,@SOLUONG,null)
		insert into HOADON 
		values (@IDHOADON,@TRANGTHAITHANHTOAN,@THOIGIAN,@code,@IDKHACHHANG,@idban,@IDNHANVIENTHANHTOAN,null)
		insert into CHITIETHOADON
		values (@IDHOADON,@GIAHIENTAI,@IDMON,@VAT,@SOLUONG,null)
end
go
--trigger 
	create trigger sp_tudongnhantienhoadon on CHITIETHOADON
	after insert,update
	as
	begin
		update CHITIETHOADON
		set thanhtien = giahientai * Soluong
		update HOADON
		set TongTien = CHITIETHOADON.thanhtien + (CHITIETHOADON.thanhtien/100 * CHITIETHOADON.VAT) from CHITIETHOADON
		where HOADON.idhoadon = CHITIETHOADON.idhoadon
	end
go
-- delete
create proc sp_Xoa_PhieuXuat
	@idhoadon nvarchar(20)
as
begin
	-- kiểm tra mã phiếu xuẩt
	if not exists (select idhoadon from hoadon where idhoadon = @idhoadon)
	begin
		raiserror('Mã phiếu xuất không tồn tại', 16, 1)
		return
	end
	-- delete
	set xact_abort on
	begin distributed tran
		delete QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.hoadon where idhoadon = @idhoadon
		--xóa trên phiếu chi tiết nhập
		delete QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.chitiethoadon where idhoadon = @idhoadon

		--xóa trên phiếu chi tiết nhập
		delete hoadon where idhoadon = @idhoadon
		delete CHITIETHOADON where idhoadon = @idhoadon
	commit tran
end
go
-- update
create proc sp_Sua_PhieuXuat
	@IDHOADON NVARCHAR(20),
	@TRANGTHAITHANHTOAN NVARCHAR(10),
	@THOIGIAN DATETIME,
	@CODE nvarchar(250),
	@IDKHACHHANG NVARCHAR(20),
	@IDBAN NVARCHAR(20),
	@IDNHANVIENTHANHTOAN NVARCHAR(20),
	@GIAHIENTAI MONEY,
	@IDMON NVARCHAR(20),
	@VAT FLOAT,
	@SOLUONG SMALLINT
as
begin
	-- kiểm tra mã phiếu nhập
	if not exists (select idhoadon from hoadon where idhoadon = @IDHOADON)
	begin
		raiserror('Mã phiếu xuất không tồn tại', 16, 1)
		return
	end
	-- update
	set xact_abort on
	begin distributed tran
		update HOADON set trangthaithanhtoan  = @TRANGTHAITHANHTOAN, thoigian = @THOIGIAN, code = @code,idkhachhang = @IDKHACHHANG , idban = @IDBAN, idnhanvienthanhtoan = @IDNHANVIENTHANHTOAN where idhoadon = @IDHOADON
		update CHITIETHOADON set giahientai = @GIAHIENTAI, idmon =  @IDMON, VAT = @vat,soluong = @SOLUONG where idhoadon = @IDHOADON
		update QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.HOADON set trangthaithanhtoan  = @TRANGTHAITHANHTOAN, thoigian = @THOIGIAN, code = @code,idkhachhang = @IDKHACHHANG , idban = @IDBAN, idnhanvienthanhtoan = @IDNHANVIENTHANHTOAN where idhoadon = @IDHOADON
		update QLVT_LINKED_SERVER.quanlychuoinhahang.dbo.CHITIETHOADON set giahientai = @GIAHIENTAI, idmon =  @IDMON, VAT = @vat,soluong = @SOLUONG where idhoadon = @IDHOADON
	commit tran
end

--TABLE BAN
--insert
GO
create proc sp_Them_BAN
	@IDBAN NVARCHAR(20),
	@TENBAN nvarchar(50),
	@TRANGTHAI nvarchar(20),
	@IDCHINHANH NVARCHAR(10)
as
begin
	set xact_abort on
	begin distributed tran
		insert BAN values (@IDBAN, @TENBAN, @TRANGTHAI,'CN2')
		insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.BAN values (@IDBAN, @TENBAN, @TRANGTHAI,'CN2')
	commit tran
end
-- delete
go
create proc sp_Xoa_BAN
	@IDBAN NVARCHAR(20)
as
begin
	if not exists (select * from BAN where IDBAN = @IDBAN)
	begin
		raiserror(' ban không tồn tại', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 => delete ở MAY_CHU
	set xact_abort on
	begin distributed tran
		delete ban where IDBAN = @IDBAN
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.BAN where IDBAN = @IDBAN
	commit tran
end
go
-- update
create proc sp_Sua_BAN
	@IDBAN NVARCHAR(20),
	@TENBAN nvarchar(50),
	@TRANGTHAI nvarchar(20),
	@IDCHINHANH NVARCHAR(10)
as
begin	
	set xact_abort on
	begin distributed tran
		update BAN set TENBAN = @TENBAN, TRANGTHAI = @TRANGTHAI where IDBAN = @IDBAN
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.BAN set TENBAN = @TENBAN, TRANGTHAI = @TRANGTHAI where IDBAN = @IDBAN
	commit tran
end

--TABLE LOAINGUYENLIEU
--insert
GO
create proc sp_Them_LOAINGUYENLIEU
	@IDLOAINGUYENLIEU NVARCHAR(20),
	@TENLOAINGUYENLIEU nvarchar(60)
	
as
begin
	set xact_abort on
	begin distributed tran
		insert LOAINGUYENLIEU values (@IDLOAINGUYENLIEU, @TENLOAINGUYENLIEU)
		insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.LOAINGUYENLIEU values (@IDLOAINGUYENLIEU, @TENLOAINGUYENLIEU)
	commit tran
end
-- delete
go
create proc sp_Xoa_LOAINGUYENLIEU
	@IDLOAINGUYENLIEU NVARCHAR(20)
as
begin
	if not exists (select * from LOAINGUYENLIEU where idloainguyenlieu = @IDLOAINGUYENLIEU)
	begin
		raiserror(' LOAI NGUYEN LIEU không tồn tại', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 => delete ở MAY_CHU
	set xact_abort on
	begin distributed tran
		delete LOAINGUYENLIEU where idloainguyenlieu = @IDLOAINGUYENLIEU
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.LOAINGUYENLIEU where idloainguyenlieu = @IDLOAINGUYENLIEU
	commit tran
end
go
-- update
create proc sp_Sua_LOAINGUYENLIEU
	@IDLOAINGUYENLIEU NVARCHAR(20),
	@TENLOAINGUYENLIEU NVARCHAR(60)
as
begin	
	set xact_abort on
	begin distributed tran
		update LOAINGUYENLIEU set tenloainguyenlieu = @TENLOAINGUYENLIEU where idloainguyenlieu = @IDLOAINGUYENLIEU
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.LOAINGUYENLIEU set tenloainguyenlieu = @TENLOAINGUYENLIEU where idloainguyenlieu = @IDLOAINGUYENLIEU
	commit tran
end
--TABLE THUCDON
--insert
GO
create proc sp_Them_MONAN
	@IDMON NVARCHAR(20),
	@TENMON nvarchar(60),
	@IDLOAITHUCDON NVARCHAR(20),
	@DONGIA MONEY,
	@MOTA NVARCHAR(250),
	@HINHANH NVARCHAR(250),
	@IDNGUYENLIEU NVARCHAR(20),
	@DONVITINH NVARCHAR(20)
	
as
begin
	if exists (select IDMON from THUCDON where IDMON = @IDMON)
	begin
		raiserror(' MON AN DA CO TRONG THUC DON', 16, 1)
		return
	end
	if not exists (select IDLOAITHUCDON from LOAITHUCDON where IDLOAITHUCDON = @IDLOAITHUCDON)
	begin
		raiserror(' LOAI THUC DON không tồn tại', 16, 1)
		return
	end
	if not exists (select IDNGUYENLIEU from NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU)
	begin
		raiserror('NGUYEN LIEU không tồn tại', 16, 1)
		return
	end
	set xact_abort on
	begin distributed tran
		insert THUCDON values (@IDMON,@TENMON,@IDLOAITHUCDON,@DONGIA,@MOTA,@HINHANH,@IDNGUYENLIEU,@DONVITINH)
		insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.THUCDON 
		values (@IDMON,@TENMON,@IDLOAITHUCDON,@DONGIA,@MOTA,@HINHANH,@IDNGUYENLIEU,@DONVITINH)
	commit tran
end
-- delete
go
create proc sp_Xoa_MONAN
	@IDMON NVARCHAR(20)
as
begin
	if not exists (select IDMON from THUCDON where IDMON = @IDMON)
	begin
		raiserror(' MON AN không tồn tại', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 => delete ở MAY_CHU
	set xact_abort on
	begin distributed tran
		delete THUCDON where IDMON = @IDMON
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.THUCDON where IDMON = @IDMON
	commit tran
end
go
-- update
create proc sp_Sua_MONAN
	@IDMON NVARCHAR(20),
	@TENMON nvarchar(60),
	@IDLOAITHUCDON NVARCHAR(20),
	@DONGIA MONEY,
	@MOTA NVARCHAR(250),
	@HINHANH NVARCHAR(250),
	@IDNGUYENLIEU NVARCHAR(20),
	@DONVITINH NVARCHAR(20)
as
begin	
	if not exists (select IDLOAITHUCDON from LOAITHUCDON where IDLOAITHUCDON = @IDLOAITHUCDON)
	begin
		raiserror(' LOAI THUC DON không tồn tại', 16, 1)
		return
	end
	if not exists (select IDNGUYENLIEU from NGUYENLIEU where idnguyenlieu = @IDNGUYENLIEU)
	begin
		raiserror('NGUYEN LIEU không tồn tại', 16, 1)
		return
	end
	set xact_abort on
	begin distributed tran
		update THUCDON set IDMON = @IDMON,TENMON = @TENMON,IDLOAITHUCDON = @IDLOAITHUCDON,DONGIA = @DONGIA, MOTA = @MOTA,HINHANH = @HINHANH,IDNGUYENLIEU = @IDNGUYENLIEU,DONVITINH = @DONVITINH WHERE IDMON = @IDMON
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.THUCDON set IDMON = @IDMON,TENMON = @TENMON,IDLOAITHUCDON = @IDLOAITHUCDON,DONGIA = @DONGIA, MOTA = @MOTA,HINHANH = @HINHANH,IDNGUYENLIEU = @IDNGUYENLIEU,DONVITINH = @DONVITINH WHERE IDMON = @IDMON
end

--TABLE LOAITHUCDON
--insert
GO
create proc sp_Them_LOAITHUCDON
	@IDLOAITHUCDON NVARCHAR(20),
	@TENLOAITHUCDON nvarchar(60),
	@TRANGTHAI NVARCHAR(10)
	
as
begin
	set xact_abort on
	begin distributed tran
		insert LOAITHUCDON values (@IDLOAITHUCDON, @TENLOAITHUCDON,@TRANGTHAI)
		insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.LOAITHUCDON values (@IDLOAITHUCDON, @TENLOAITHUCDON,@TRANGTHAI)
	commit tran
end
-- delete
go
create proc sp_Xoa_LOAITHUCDON
	@IDLOAITHUCDON NVARCHAR(20)
as
begin
	if exists (select * from LOAITHUCDON where idloaithucdon = @IDLOAITHUCDON)
	begin
		raiserror(' LOAI THUC DON DA CO', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 => delete ở MAY_CHU
	set xact_abort on
	begin distributed tran
		delete LOAITHUCDON where idloaithucdon = @IDLOAITHUCDON
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.LOAITHUCDON  where idloaithucdon = @IDLOAITHUCDON
	commit tran
end
go
-- update
create proc sp_Sua_LOAITHUCDON
	@IDLOAITHUCDON NVARCHAR(20),
	@TENLOAITHUCDON nvarchar(60),
	@TRANGTHAI NVARCHAR(10)
as
begin	
	set xact_abort on
	begin distributed tran
		update LOAITHUCDON set tenloaithucdon = @TENLOAITHUCDON,TRANGTHAI = @TRANGTHAI where idloaithucdon = @IDLOAITHUCDON
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.LOAITHUCDON set tenloaithucdon = @TENLOAITHUCDON,TRANGTHAI = @TRANGTHAI where idloaithucdon = @IDLOAITHUCDON
	commit tran
end
--TABLE CHITIETKHO
--insert
GO
create proc sp_Them_CHITIETKHO
	@IDKHO NVARCHAR(20),
	@IDNGUYENLIEU nvarchar(20),
	@SOLUONGTON SMALLINT
	
as
begin
	if NOT exists (select IDKHO from KHO where IDKHO = @IDKHO)
		begin
		raiserror('KHO KHONG TON TAI', 16, 1)
		return
		end
	if NOT exists (select IDNGUYENLIEU from NGUYENLIEU where IDNGUYENLIEU = @IDNGUYENLIEU)
		begin
		raiserror('NGUYEN LIEU KHONG TON TAI', 16, 1)
		return
		end
	set xact_abort on
	begin distributed tran
		insert CHITIETKHO values (@IDKHO, @IDNGUYENLIEU,@SOLUONGTON)
		insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.CHITIETKHO values (@IDKHO, @IDNGUYENLIEU,@SOLUONGTON)
	commit tran
end
-- delete
go
create proc sp_Xoa_CHITIETKHO
	@IDKHO NVARCHAR(20)
as
begin
	if NOT exists (select * from CHITIETKHO where idkho = @IDKHO)
	begin
		raiserror('BAN CHI TIET KHO KHONG TON TAI', 16, 1)
		return
	end
	-- đã delete trong trạm 1 hoặc 2 => delete ở MAY_CHU
	set xact_abort on
	begin distributed tran
		delete CHITIETKHO where idkho = @IDKHO
		delete QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.CHITIETKHO  where idkho = @IDKHO
	commit tran
end
go
-- update
create proc sp_Sua_CHITIETKHO
	@IDKHO NVARCHAR(20),
	@IDNGUYENLIEU nvarchar(20),
	@SOLUONGTON SMALLINT
as
begin	
	set xact_abort on
	begin distributed tran
		update CHITIETKHO set soluongton = @SOLUONGTON where IDKHO = @IDKHO
		update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.CHITIETKHO set soluongton = @SOLUONGTON where IDKHO = @IDKHO
	commit tran
end
GO
	CREATE TRIGGER TRG_SOLUONG ON CHITIETHOADONNHAP
		AFTER INSERT, DELETE, UPDATE
		AS
		BEGIN		
			UPDATE CHITIETKHO SET soluongton = SOLUONGTON + Soluong FROM CHITIETHOADONNHAP WHERE CHITIETKHO.idnguyenlieu = CHITIETHOADONNHAP.idnguyenlieu
		END
go
create proc sp_get_ban
as
begin
	select * from ban
end
go
create proc sp_get_bophan
as
begin
	select idbophan, tenbophan from BOPHAN
end
go
create proc sp_get_chinhanh
as
begin
	select * from ChiNhanh
end
go

create proc sp_get_hoadonnhap
@idkho nvarchar(20)
as
begin
select idhoadonnhap, idnhacungcap, ngaynhap,tinhtrang,idnhanvien,thanhtien from HOADONNHAP where idkho = @idkho
end
go

create proc sp_get_hoadonxuat
as
begin
	select * from HOADON
end
go
create proc sp_get_chitiethoadonxuat
@idhoadon nvarchar(20)
as
begin
select * from CHITIETHOADON where idhoadon = @idhoadon
end
go
create proc sp_get_khachhang
as
begin
	select T2.idkhachhang, T2.tenkhachhang, T2.sodienthoai, T1.ngaysinh, T2.diachi,t1.thongtinkhac,t1.phai
	from
		(select * from QLVT_TRAM_1.quanlychuoinhahang.dbo.KhachHang) T2
		join (select * from KhachHang) T1
		on T1.idkhachhang = T2.idkhachhang
end
go
create proc sp_get_nhacungcap
as
begin
	select T2.idnhacungcap, t2.tennhacungcap, t2.diachi, t1.sodienthoai
	from
		(select * from QLVT_TRAM_1.quanlychuoinhahang.dbo.nhacungcap) T2
		join (select * from nhacungcap) T1
		on T1.idnhacungcap = T2.idnhacungcap
end
go
create proc sp_get_kho
as
begin
	select idkho,tenkho,diachi,sodienthoai from KHO
end
go
--get
create proc sp_get_nhanvien
@idbophan nvarchar(20)
as
	if not exists(select idbophan from BOPHAN where idbophan = @idbophan)
	begin
		raiserror ('bộ phận không tồn tại',16,1)
		return
	end
begin
	select tennhanvien, diachi, sodienthoai, luong, chucvu, quyen  from NHANVIEN
	where idbophan = @idbophan
end
go
create proc sp_get_loainguyenlieu
as
begin
	select * from LOAINGUYENLIEU
end
go
create proc sp_get_nguyenlieu
@idloainguyenlieu nvarchar(20)
as
begin
	select tennguyenlieu, trangthai, mota,soluong,donvitinh,gianhap
	from NGUYENLIEU
	where idloainguyenlieu = @idloainguyenlieu
	
end
go 
create proc sp_get_thucdon
as
begin
	select * from THUCDON
end
go
create proc sp_get_loaithucdon
as
--
begin
	select * from LOAITHUCDON
end
go

--TABLE PHUCVUBAN
--insert
create proc sp_get_phucvuban
 @idban nvarchar(20)
as
begin
 if not exists (select idban from BAN where idban = @idban)
	begin
		raiserror('bàn không tồn tại', 16, 1)
		return
		end
	select a.idban, b.tennhanvien, a.caphucvu, a.SLK from phucvuban a, NHANVIEN b where a.idnhanvien = b.idnhanvien and idban = @idban
end -- edit
go
--them
create proc sp_them_phucvuban
	@idban nvarchar(20),
	@idnhanvien nvarchar(20),
	@caphucvu nvarchar(20),
	@SLK smallint
as
begin
--exec sp_them_phucvuban 'B1','NV1','Ca Sáng',10
	 if exists (select * from PHUCVUBAN where idban = @idban)
	begin
		raiserror('Ca đã được phân công', 16, 1)
		return
		end
		 if not exists (select idnhanvien from NHANVIEN where idnhanvien = @idnhanvien)
	begin
		raiserror('Nhân viên không tồn tại', 16, 1)
		return
		end
		 if not exists (select idban from BAN where idban = @idban)
	begin
		raiserror('bàn không tồn tại', 16, 1)
		return
		end
begin
		insert  phucvuban values(@idban,@idnhanvien,@caphucvu,@SLK)
end
end
go
--update
create proc sp_sua_phucvuban
	@idban nvarchar(20),
	@idnhanvien nvarchar(20),
	@caphucvu nvarchar(20),
	@SLK smallint
as
begin
		update  phucvuban set idban = @idban, idnhanvien = @idnhanvien, caphucvu = @caphucvu,SLK = @SLK where idban = @idban
end
go
--delete
create proc sp_xoa_phucvuban
	 @idban nvarchar(20)
	 as
	 begin
	 if not exists (select idban from BAN where idban = @idban)
	begin
		raiserror('bàn không tồn tại', 16, 1)
		return
	end 
	 begin
		delete from Phucvuban where idban = @idban
	 end
	 end
go

create proc sp_get_chitietho --exec sp_get_chitietho N'kem trà xanh'
	 @tennguyenlieu nvarchar(40)
	 as
	 begin
	 if not exists (select tennguyenlieu from NGUYENLIEU where tennguyenlieu = @tennguyenlieu)
	begin
		raiserror('nguyên liệu không tồn tại', 16, 1)
		return
	end 
	 begin
		SELECT a.idkho, a.soluongton FROM CHITIETKHO A, NGUYENLIEU B WHERE A.IDNGUYENLIEU = B.IDNGUYENLIEU AND B.tennguyenlieu =@tennguyenlieu
	 end
	 end
go

--TABLE BOPHAN
--insert 
create proc sp_them_bophan
	@idbophan nvarchar(20),
	@tenbophan nvarchar(40),
	@mota nvarchar(max),
	@sodienthoai nvarchar(24)
as
	if exists (select * from BOPHAN where idbophan = @idbophan)
	begin
		raiserror ('bộ phận đã tồn tại',16,1)
		return
	end
begin
	insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.bophan values (@idbophan,@tenbophan,@mota,'CN2',@sodienthoai)
	insert bophan values (@idbophan,@tenbophan,@mota,'CN2',@sodienthoai)
end
--sửa
go
create proc sp_sua_bophan
	@idbophan nvarchar(20),
	@tenbophan nvarchar(40),
	@mota nvarchar(max),
	@sodienthoai nvarchar(24)
as

begin
	update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.bophan set tenbophan = @tenbophan, mota = @mota, sodienthoai = @sodienthoai where idbophan = @idbophan
	update bophan set tenbophan = @tenbophan, mota = @mota, sodienthoai = @sodienthoai where idbophan = @idbophan
end

go
--xoa
create proc sp_xoa_bophan
	@idbophan nvarchar(20)
as

begin
	delete from QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.bophan where idbophan = @idbophan
	delete from bophan  where idbophan = @idbophan
end
--TABLE CHITIETHOADONNHAP
--get
go
create proc sp_get_chitiethoadonnhap
@idhoadonnhap nvarchar(10)
as
begin
select * from CHITIETHOADONNHAP where idhoadonnhap = @idhoadonnhap
end
go

--thêm
create proc sp_them_chitiethoadonnhap
	@idhoadonnhap nvarchar(10),
	@idnguyenlieu nvarchar(20),
	@gianhap money,
	@soluong smallint
as
	if not exists (select * from HOADONNHAP where idhoadonnhap = @idhoadonnhap)
	begin
		raiserror ('HD không tồn tại',16,1)
		return
	end
	if exists (select idnguyenlieu from NGUYENLIEU where idnguyenlieu = @idnguyenlieu)
	begin
		raiserror ('mặt đã tồn tại, nhập lại mặt hàng khác',16,1)
		return
	end
begin
	insert QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.chitiethoadonnhap values (@idhoadonnhap,@idnguyenlieu,@gianhap,@soluong,null)
	insert chitiethoadonnhap values (@idhoadonnhap,@idnguyenlieu,@gianhap,@soluong,null)
end
go
--xóa
create proc sp_xoa_chitiethoadonnhap
@idhoadonnhap nvarchar(10),
@idnguyenlieu nvarchar(20)
as
begin
delete from QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.chitiethoadonnhap where	idhoadonnhap = @idhoadonnhap 
																				and idnguyenlieu = @idnguyenlieu
delete from chitiethoadonnhap where	idhoadonnhap = @idhoadonnhap 
									and idnguyenlieu = @idnguyenlieu
end
go

--sửa
create proc sp_sua_chitiethoadonnhap
	@idhoadonnhap nvarchar(10),
	@idnguyenlieu nvarchar(20),
	@gianhap money,
	@soluong smallint
as
	if not exists (select * from HOADONNHAP where idhoadonnhap = @idhoadonnhap)
	begin
		raiserror ('HD không tồn tại',16,1)
		return
	end
	if exists (select idnguyenlieu from NGUYENLIEU where idnguyenlieu = @idnguyenlieu)
	begin
		raiserror ('mặt đã tồn tại, nhập lại mặt hàng khác',16,1)
		return
	end
begin
	update QLVT_LINKED_SERVER.QUANLYCHUOINHAHANG.dbo.chitiethoadonnhap set gianhap = @gianhap,soluong = @soluong where	idhoadonnhap = @idhoadonnhap 
																													and idnguyenlieu = @idnguyenlieu
	update chitiethoadonnhap set gianhap = @gianhap,soluong = @soluong where	idhoadonnhap = @idhoadonnhap 
																				and idnguyenlieu = @idnguyenlieu
end
go
