CREATE DATABASE BookManager
go

USE BookManager
go

CREATE TABLE LOAITAIKHOAN
(
	id int IDENTITY(1,1) primary key,
	MaLoaiTaiKhoan AS CAST('LTK' + right('000' + CAST(id as varchar(5)), 3) AS CHAR(6)) persisted ,
	TenLoaiTaiKhoan nvarchar(max) NOT NULL
)
go

CREATE TABLE TAIKHOAN
(
	id int IDENTITY PRIMARY KEY,
	MaTaiKhoan  AS CAST('TK'+ RIGHT('000000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    TenTaiKhoan NVARCHAR(MAX) NOT NULL,
    TenDangNhap VARCHAR(256) UNIQUE NOT NULL,
    MatKhau VARCHAR(MAX) NOT NULL,
	HoTenNhanVien NVARCHAR(MAX) not null,
    idLoaiTaiKhoan int REFERENCES LOAITAIKHOAN on delete cascade NOT NULL
)
go

CREATE TABLE THELOAI
(
	id int IDENTITY(1,1)  primary key,
	MaTheLoai As Cast('TL' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted,  
	TenTheLoai NVARCHAR(MAX) NOT NULL
)
go

CREATE TABLE TACGIA
(
	id INT IDENTITY PRIMARY KEY,
	MaTacGia  AS CAST('TG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenTacGia NVARCHAR(MAX) NOT NULL
)
go

Create table NHAXUATBAN
(
	id INT IDENTITY PRIMARY KEY,
	MaNhaXuatBan  AS CAST('NXB'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenNhaXuatBan NVARCHAR(MAX) NOT NULL
)

CREATE TABLE SACH
(
	id int IDENTITY  PRIMARY KEY,
	MaSach  AS cast('TS'+ right('0000' + CAST(ID AS VARCHAR(10)), 4) as char(6)) PERSISTED,
	TenSach NVARCHAR(MAX) NOT NULL,
	idTheLoai int references THELOAI NOT NULL,
	idTacGia int references TACGIA not null,
	idNhaXuatBan int references NHAXUATBAN NOT NULL,
	NamXB int NOT NULL,
	SoLuong int NOT NULL, 
	GiaBia int NOT NULL
)
go


CREATE TABLE LOAIDOCGIA
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaLoaiDocGia  AS CAST('LDG'+ RIGHT('000' + CAST(ID AS VARCHAR(10)), 3) AS CHAR(6))PERSISTED,
	TenLoaiDocGia NVARCHAR(MAX) NOT NULL
)
go

CREATE TABLE DOCGIA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MaDocGia  AS CAST('DG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenDocGia NVARCHAR(MAX) NOT NULL,
	NgaySinh datetime NOT NULL, 
	NgayLapThe Datetime NOT NULL, 
	NgayHetHan Datetime NOT NULL, 
	SoDienThoai nvarchar(max) not null,
	DiaChi NVARCHAR(MAX) not null,
	GioiTinh NVARCHAR(MAX) not null,
	idLoaiDocGia INT references LOAIDOCGIA NOT NULL
)
go

create table PHIEUMUONTRA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	SoPhieuMuonTra AS CAST('PM'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	idDocGia int references DOCGIA NOT NULL,
	idTaiKhoan int references TAIKHOAN not null,
	NgayMuon Datetime NOT NULL, 
	HanTra Datetime NOT NULL,
	DaTraSach bit, 
	TrangThaiSach NVARCHAR (max),
	TienPhat int not null,
)
go
select * from PHIEUMUONTRA
--drop table PHIEUMUONTRA
create table CT_PHIEUMUONTRA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	idSoPhieuMuonTra int references PHIEUMUONTRA(ID) not null,
	idSach int references SACH(id) NOT NULL,
	NgayTra Datetime, 
	GhiChu nvarchar,
)
go
--drop table CT_PHIEUMUONTRA


------THU TUC---------
--drop procedure sp_KiemTraDangNhap
CREATE PROCEDURE sp_KiemTraDangNhap
    @TenDangNhap VARCHAR(256),
    @MatKhau VARCHAR(MAX)
AS
BEGIN
    -- Kiểm tra tên đăng nhập và mật khẩu, nếu thành công trả về thông tin người dùng
    SELECT TOP 1 *  -- Các thông tin người dùng cần trả về
    FROM TAIKHOAN
    WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau;
    
    -- Nếu không tìm thấy người dùng nào, không trả về kết quả (hoặc có thể trả về null hoặc thông báo lỗi)
END;
GO

Create procedure MatKhau_Update
	@TenDangNhap VARCHAR(256),  -- Tên đăng nhập
    @MatKhauCu VARCHAR(MAX),    -- Mật khẩu cũ
    @MatKhauMoi VARCHAR(MAX)    -- Mật khẩu mới
AS
BEGIN
    -- Kiểm tra xem tên đăng nhập có tồn tại và mật khẩu cũ có chính xác không
    IF EXISTS (SELECT 1 FROM TAIKHOAN WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhauCu)
    BEGIN
        -- Cập nhật mật khẩu mới
        UPDATE TAIKHOAN
        SET MatKhau = @MatKhauMoi
        WHERE TenDangNhap = @TenDangNhap;
    END
End

--TAIKHOAN
---------------GetAll---------------
Create procedure TAIKHOAN_GetAll
AS
Select tk.ID, MaTaiKhoan, TenTaiKhoan, TenDangNhap, MatKhau, HoTenNhanVien, TenLoaiTaiKhoan
From TAIKHOAN tk, LOAITAIKHOAN ltk
Where tk.idLoaiTaiKhoan = ltk.id
GO
---------------Insert---------------
Create procedure TAIKHOAN_Insert
@id int output,
@TenTaiKhoan nvarchar(MAX),
@TenDangNhap varchar(256),
@MatKhau varchar(MAX),
@HoTenNhanVien nvarchar(MAX),
@idLoaiTaiKhoan int
AS
INSERT INTO [dbo].[TAIKHOAN](
TenTaiKhoan,
TenDangNhap,
MatKhau,
HoTenNhanVien,
idLoaiTaiKhoan
)
Values(
@TenTaiKhoan,
@TenDangNhap,
@MatKhau,
@HoTenNhanVien,
@idLoaiTaiKhoan
)
set @id=@@IDENTITY
GO
---------------GetByID---------------
Create procedure TAIKHOAN_GetByID
@PrimaryKey int
AS
Select * from [dbo].[TAIKHOAN]
Where id=@PrimaryKey
GO
---------------Delete---------------
Create procedure TAIKHOAN_Delete
@PrimaryKey int
AS
Delete from [dbo].[TAIKHOAN]
Where id=@PrimaryKey
DECLARE @MaxID INT;
SELECT @MaxID = MAX(Id) FROM TAIKHOAN;
DBCC CHECKIDENT ('TAIKHOAN', RESEED, @MaxID);
GO
---------------Update---------------
Create procedure TAIKHOAN_Update
@id int,
@TenTaiKhoan nvarchar(MAX),
@TenDangNhap varchar(256),
@MatKhau varchar(MAX),
@HoTenNhanVien nvarchar(MAX),
@idLoaiTaiKhoan int
AS
Update [dbo].[TAIKHOAN]
SET
TenTaiKhoan=@TenTaiKhoan,
TenDangNhap=@TenDangNhap,
MatKhau=@MatKhau,
HoTenNhanVien=@HoTenNhanVien,
idLoaiTaiKhoan=@idLoaiTaiKhoan
Where id=@id
GO

---------------GetAll---------------
Create procedure LOAITAIKHOAN_GetAll
AS
Select * from [dbo].[LOAITAIKHOAN]

--SACH--
Create procedure SACH_GetAll
AS
Select * from [dbo].[SACH]

Create procedure SACH_GetAll2
AS
Select s.id, MaSach, TenSach, TenTheLoai, TenTacGia, nxb.id as idNhaXuatBan, TenNhaXuatBan, NamXB, SoLuong, GiaBia  from SACH s, THELOAI tl, TACGIA tg, NHAXUATBAN nxb
where s.idTheLoai = tl.id and s.idTacGia = tg.id and s.idNhaXuatBan = nxb.id

Create procedure SACH_GetByID
@PrimaryKey int
AS
Select * from [dbo].[SACH]
Where id=@PrimaryKey
---------------Insert---------------
Create procedure SACH_Insert
@id int output,
@TenSach nvarchar(MAX),
@idTheLoai int,
@idTacGia int,
@idNhaXuatBan nvarchar(MAX),
@NamXB int,
@SoLuong int,
@GiaBia int
AS
INSERT INTO [dbo].[SACH](
TenSach,
idTheLoai,
idTacGia,
idNhaXuatBan,
NamXB,
SoLuong,
GiaBia
)
Values(
@TenSach,
@idTheLoai,
@idTacGia,
@idNhaXuatBan,
@NamXB,
@SoLuong,
@GiaBia
)
set @id=@@IDENTITY
---------------Update---------------
Create procedure SACH_Update
@id int,
@TenSach nvarchar(MAX),
@idTheLoai int,
@idTacGia int,
@idNhaXuatBan nvarchar(MAX),
@NamXB int,
@SoLuong int,
@GiaBia int
AS
Update [dbo].[SACH]
SET
TenSach=@TenSach,
idTheLoai=@idTheLoai,
idTacGia=@idTacGia,
idNhaXuatBan=@idNhaXuatBan,
NamXB=@NamXB,
SoLuong=@SoLuong,
GiaBia=@GiaBia
Where id=@id
---------------Delete---------------
--drop procedure SACH_Delete
go
Create procedure SACH_Delete
@PrimaryKey int
AS
begin
Delete from [dbo].[SACH]
Where id=@PrimaryKey
DECLARE @MaxID INT;
SELECT @MaxID = MAX(Id) FROM Sach;
DBCC CHECKIDENT ('Sach', RESEED, @MaxID);
end


--THELOAI--
---------------GetAll---------------
Create procedure THELOAI_GetAll
AS
Select * from [dbo].[THELOAI]
---------------GetByID---------------
Create procedure THELOAI_GetByID
@PrimaryKey int
AS
Select * from [dbo].[THELOAI]
Where id=@PrimaryKey
---------------Insert---------------
--drop procedure THELOAI_Insert
Create procedure THELOAI_Insert
@id int output,
@TenTheLoai nvarchar(MAX)
AS
INSERT INTO [dbo].[THELOAI](
TenTheLoai
)
Values(
@TenTheLoai
)
set @id=@@IDENTITY
---------------Update---------------
Create procedure THELOAI_Update
@id int,
@TenTheLoai nvarchar(MAX)
AS
Update [dbo].[THELOAI]
SET
TenTheLoai=@TenTheLoai
Where id=@id
---------------Delete---------------
Create procedure THELOAI_Delete
@PrimaryKey int
AS
Delete from [dbo].[THELOAI]
Where id=@PrimaryKey
DECLARE @MaxID INT;
SELECT @MaxID = MAX(Id) FROM THELOAI;
DBCC CHECKIDENT ('THELOAI', RESEED, @MaxID);


--TACGIA--
---------------GetAll---------------
Create procedure TACGIA_GetAll
AS
Select * from [dbo].[TACGIA]
---------------GetByID---------------
Create procedure TACGIA_GetByID
@PrimaryKey int
AS
Select * from [dbo].[TACGIA]
Where id=@PrimaryKey
---------------Insert---------------
Create procedure TACGIA_Insert
@id int output,
@TenTacGia nvarchar(MAX)
AS
INSERT INTO [dbo].[TACGIA](
TenTacGia
)
Values(
@TenTacGia
)
set @id=@@IDENTITY
---------------Update---------------
Create procedure TACGIA_Update
@id int,
@TenTacGia nvarchar(MAX)
AS
Update [dbo].[TACGIA]
SET
TenTacGia=@TenTacGia
Where id=@id
---------------Delete---------------
Create procedure TACGIA_Delete
@PrimaryKey int
AS
Delete from [dbo].[TACGIA]
Where id=@PrimaryKey
DECLARE @MaxID INT;
SELECT @MaxID = MAX(Id) FROM TACGIA;
DBCC CHECKIDENT ('TACGIA', RESEED, @MaxID);


--NHAXUATBAN
---------------GetAll---------------
Create procedure NHAXUATBAN_GetAll
AS
Select * from [dbo].[NHAXUATBAN]
---------------GetByID---------------
Create procedure NHAXUATBAN_GetByID
@PrimaryKey int
AS
Select * from [dbo].[NHAXUATBAN]
Where id=@PrimaryKey

--DOCGIA
---------------GetAll---------------
Create procedure DOCGIA_GetAll
AS
Select dg.ID, MaDocGia, TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, SoDienThoai, DiaChi, GioiTinh, TenLoaiDocGia
From DOCGIA dg, LOAIDOCGIA ldg
Where dg.idLoaiDocGia = ldg.id
---------------GetByID---------------
Create procedure DOCGIA_GetByID
@PrimaryKey int
AS
Select * from [dbo].[DOCGIA]
Where ID=@PrimaryKey
---------------Insert---------------
Create procedure DOCGIA_Insert
@ID int output,
@TenDocGia nvarchar(MAX),
@NgaySinh datetime,
@NgayLapThe datetime,
@NgayHetHan datetime,
@SoDienThoai int,
@DiaChi nvarchar(MAX),
@GioiTinh nvarchar(MAX),
@idLoaiDocGia int
AS
INSERT INTO [dbo].[DOCGIA](
TenDocGia,
NgaySinh,
NgayLapThe,
NgayHetHan,
SoDienThoai,
DiaChi,
GioiTinh,
idLoaiDocGia
)
Values(
@TenDocGia,
@NgaySinh,
@NgayLapThe,
@NgayHetHan,
@SoDienThoai,
@DiaChi,
@GioiTinh,
@idLoaiDocGia
)
set @ID=@@IDENTITY
---------------Update---------------
Create procedure DOCGIA_Update
@ID int,
@TenDocGia nvarchar(MAX),
@NgaySinh datetime,
@NgayLapThe datetime,
@NgayHetHan datetime,
@SoDienThoai int,
@DiaChi nvarchar(MAX),
@GioiTinh nvarchar(MAX),
@idLoaiDocGia int
AS
Update [dbo].[DOCGIA]
SET
TenDocGia=@TenDocGia,
NgaySinh=@NgaySinh,
NgayLapThe=@NgayLapThe,
NgayHetHan=@NgayHetHan,
SoDienThoai=@SoDienThoai,
DiaChi=@DiaChi,
GioiTinh=@GioiTinh,
idLoaiDocGia=@idLoaiDocGia
Where ID=@ID
---------------Delete---------------
Create procedure DOCGIA_Delete
@PrimaryKey int
AS
Delete from [dbo].[DOCGIA]
Where ID=@PrimaryKey
DECLARE @MaxID INT;
SELECT @MaxID = MAX(Id) FROM DOCGIA;
DBCC CHECKIDENT ('DOCGIA', RESEED, @MaxID);


--LOAIDOCGIA
---------------GetAll---------------
Create procedure LOAIDOCGIA_GetAll
AS
Select * from [dbo].[LOAIDOCGIA]
---------------GetByID---------------
Create procedure LOAIDOCGIA_GetByID
@PrimaryKey int
AS
Select * from [dbo].[LOAIDOCGIA]
Where id=@PrimaryKey
---------------Insert---------------
Create procedure LOAIDOCGIA_Insert
@id int output,
@TenLoaiDocGia nvarchar(MAX)
AS
INSERT INTO [dbo].[LOAIDOCGIA](
TenLoaiDocGia
)
Values(
@TenLoaiDocGia
)
set @id=@@IDENTITY
---------------Update---------------
Create procedure LOAIDOCGIA_Update
@id int,
@TenLoaiDocGia nvarchar(MAX)
AS
Update [dbo].[LOAIDOCGIA]
SET
TenLoaiDocGia=@TenLoaiDocGia
Where id=@id
---------------Delete---------------
Create procedure LOAIDOCGIA_Delete
@PrimaryKey int
AS
Delete from [dbo].[LOAIDOCGIA]
Where id=@PrimaryKey
DECLARE @MaxID INT;
SELECT @MaxID = MAX(Id) FROM LOAIDOCGIA;
DBCC CHECKIDENT ('LOAIDOCGIA', RESEED, @MaxID);


--PhieuMuonTra
---------------GetAll---------------
Create procedure PHIEUMUONTRA_GetAll
AS
Select pmt.ID, SoPhieuMuonTra, TenDocGia, HoTenNhanVien, NgayMuon, HanTra, DaTraSach, TrangThaiSach, TienPhat
From PHIEUMUONTRA pmt, DOCGIA dg, TAIKHOAN tk
Where pmt.idDocGia = dg.ID and pmt.idTaiKhoan = tk.ID

Create procedure PHIEUMUONTRA_Get_PhieuChuaTra
AS
Select pmt.ID, SoPhieuMuonTra, TenDocGia, HoTenNhanVien, NgayMuon, HanTra, DaTraSach, TrangThaiSach, TienPhat
From PHIEUMUONTRA pmt, DOCGIA dg, TAIKHOAN tk
Where pmt.idDocGia = dg.ID and pmt.idTaiKhoan = tk.ID and DaTraSach = 0
---------------Insert---------------
Create procedure PHIEUMUONTRA_Insert
@ID int output,
@idDocGia int,
@idTaiKhoan int,
@NgayMuon datetime,
@HanTra datetime,
@DaTraSach nvarchar(MAX),
@TrangThaiSach nvarchar(MAX),
@TienPhat int
AS
INSERT INTO [dbo].[PHIEUMUONTRA](
idDocGia,
idTaiKhoan,
NgayMuon,
HanTra,
DaTraSach,
TrangThaiSach,
TienPhat
)
Values(
@idDocGia,
@idTaiKhoan,
@NgayMuon,
@HanTra,
@DaTraSach,
@TrangThaiSach,
@TienPhat
)
set @ID=@@IDENTITY


--CT_PHIEUMUONTRA
---------------GetAll---------------
Create procedure CT_PHIEUMUONTRA_GetAll
AS
Select * from [dbo].[CT_PHIEUMUONTRA]
---------------Insert---------------
Create procedure CT_PHIEUMUONTRA_Insert
@idSoPhieuMuonTra int output,
@idSach int,
@GhiChu nvarchar(1)
AS
INSERT INTO [dbo].[CT_PHIEUMUONTRA](
idSoPhieuMuonTra,
idSach,
GhiChu
)
Values(
@idSoPhieuMuonTra,
@idSach,
@GhiChu
)

---------------Update---------------
Create procedure CT_PHIEUMUONTRA_Update
@ID int
AS
Update [dbo].[CT_PHIEUMUONTRA]
SET
NgayTra=GETDATE()
Where ID=@ID

create proc PhieuMuonTra_Update_TraHet
@id int
as
	Begin
		--Dua thuoc tinh DaTraSach tu false thanh true
		update PHIEUMUONTRA
		set	DaTraSach = 1,
			TrangThaiSach = N'Đã trả'
		where Id = @id
		--Cap nhat toan bo CT_PhieuMuonTra 
		update CT_PHIEUMUONTRA
		Set NgayTra = GetDate()
		where idSoPhieuMuonTra=@id
	End

                                         --------------INSERT DATA--------------------
-- Insert table LOAITAIKHOAN
insert into LOAITAIKHOAN(TenLoaiTaiKhoan) values (N'Quản Lý')
insert into LOAITAIKHOAN(TenLoaiTaiKhoan) values (N'Nhân Viên')
go

-- Insert table NGUOIDUNG
insert into TAIKHOAN(TenTaiKhoan, TenDangNhap, MatKhau, HoTenNhanVien, idLoaiTaiKhoan) values (N'Admin Hệ Thống', 'admin', '123', N'Đinh Lâm Gia Bảo', 1)
insert into TAIKHOAN(TenTaiKhoan, TenDangNhap, MatKhau, HoTenNhanVien, idLoaiTaiKhoan) values (N'Nhân Viên 1', 'nhanvien1', '111', N'Đinh Văn A', 2)
insert into TAIKHOAN(TenTaiKhoan, TenDangNhap, MatKhau, HoTenNhanVien, idLoaiTaiKhoan) values (N'Nhân Viên 2', 'nhanvien2', '112', N'Nguyễn Thị B', 2)
go

-- Insert table THELOAI
insert into THELOAI values(N'Truyện tranh')
insert into THELOAI values(N'Trinh Thám')
insert into THELOAI values(N'Giáo trình')
insert into THELOAI values(N'Văn học Việt Nam')
insert into THELOAI values(N'Văn học nước ngoài')
insert into THELOAI values(N'Sách y dược')
go

--Insert table NHAXUATBAN
insert into NHAXUATBAN values( 'Kim đồng')
insert into NHAXUATBAN values(N'Nhà xuất bản trẻ')
insert into NHAXUATBAN values(N'IPM')

-- Insert table SACH
insert into SACH values (N'Conan', 1, 1, 1, 2024, 2, 25000)
insert into SACH values (N'Doremon', 1, 2, 1, 2024, 9, 22000)
insert into SACH values (N'Chainsaw Man', 1, 3, 1, 2024, 7, 23000)
insert into SACH values (N'One Piece', 2, 4, 3, 2024, 2, 15000)
insert into SACH values (N'Soul Eater', 3, 5, 2, 2024, 4, 35000)
insert into SACH values (N'Blue Lock', 1)
insert into SACH values (N'Thánh Thạch Rave', 1)
insert into SACH values (N'Birdmen', 1)
insert into SACH values (N'Komi-Nữ thần sợ giao tiếp', 1)
insert into SACH values (N'Shadow House', 1)
insert into SACH values (N'Chúa tể bóng tối', 1)
insert into SACH values (N'Thiên sứ nhà bên', 1)
insert into SACH values (N'Nhiệm vụ tối thượng nhà Yorakuza', 1)
insert into SACH values (N'Alice In Borderland', 1)
insert into SACH values (N'Kỳ Án Siêu Nhiên', 1)
insert into SACH values (N'World Trigger', 1)
insert into SACH values (N'Fire Force', 1)
insert into SACH values (N'Slam Dunk', 1)
insert into SACH values (N'Lời nói dối tháng tư', 1)
insert into SACH values (N'One-Punch Man', 1)
insert into SACH values (N'Spy Family', 1)
insert into SACH values (N'Chú Thuật Hồi Chiến', 1)
insert into SACH values (N'Thiên Thần Diệt Thế', 1)
insert into SACH values (N'Nhà Có 5 Nàng Dâu', 1)
insert into SACH values (N'Banana Fish', 1)
insert into SACH values (N'Bạch Tuyết Tóc Đỏ', 1)
insert into SACH values (N'Moriarty The Pariot', 1)
insert into SACH values (N'21 Emon', 1)
insert into SACH values (N'Iruma Giá Đáo', 1)
insert into SACH values (N'Học viện siêu anh hùng', 1)
insert into SACH values (N'666 Satan', 1)
insert into SACH values (N'Dược Sư Tự Sự', 1)
insert into SACH values (N'Dragon Ball', 1)
insert into SACH values (N'Dr-Stone', 1)
insert into SACH values (N'Mashle', 1)
insert into SACH values (N'Ariadne - Vương Quốc Trời Xanh', 1)
insert into SACH values (N'Blue Flag', 1)
insert into SACH values (N'Ikigami', 1)
insert into SACH values (N'Ninja Rantaro', 1)
insert into SACH values (N'Fullmetal Achemist', 1)
insert into SACH values (N'Solo Leveling', 1)
insert into SACH values (N'Hồi kí Vanitas', 1)
insert into SACH values (N'Nhất quỉ nhì ma thứ ba Takagi', 1)
insert into SACH values (N'Cô bạn tôi thầm thích lại quên mang kính rồi', 1)
insert into SACH values (N'Tanaka lúc nào cũng vật vờ', 1)
insert into SACH values (N'Blue Period', 1)
insert into SACH values (N'Kaguya - Cuộc chiến tỏ tình', 1)
insert into SACH values (N'Cậu ma nhà xí Hanako', 1)
insert into SACH values (N'Dấu ấn Roto', 1)
insert into SACH values (N'Haikyu', 1)
insert into SACH values (N'Itto Cơn lốc sân cỏ', 1)
insert into SACH values (N'Vòng tròn máu', 2)
insert into SACH values (N'Sự im lặng của bầy cừu', 2)
insert into SACH values (N'Sherlock Holmes', 2)
insert into SACH values (N'Cơ sở dữ liệu', 3)
insert into SACH values (N'Nguyên lí lập trình cấu trúc', 3)
insert into SACH values (N'Nguyên lí lập trình hướng đối tượng', 3)
insert into SACH values (N'Kiến trúc máy tính', 3)
insert into SACH values (N'Mạng máy tính', 3)
insert into SACH values (N'Phát triển ứng dụng Desktop', 3)
insert into SACH values (N'Hoàng lê nhất thống chí', 4)
insert into SACH values (N'Lão hạc', 4)
insert into SACH values (N'Số đỏ', 4)
insert into SACH values (N'Tắt đèn', 4)
insert into SACH values (N'Từ tân thế giới', 5)
insert into SACH values (N'80 vòng quanh thế giới', 5)
insert into SACH values (N'Trên sa mạc và trong rừng thẳm', 5)
insert into SACH values (N'Những tấm lòng cao cả', 5)
insert into SACH values (N'Không gia đình', 5)
insert into SACH values (N'Trong gia đình', 5)
insert into SACH values (N'Tiếng gọi nơi hoang dã', 5)
insert into SACH values (N'Đảo giấu vàng', 5)
insert into SACH values (N'Sự suy tàn và sụp đổ của Đế chế la mã', 5)
insert into SACH values (N'Truyện cổ Grimm', 5)
insert into SACH values (N'Nghìn lẻ một đêm', 5)
insert into SACH values (N'Bá tước Monte Cristo', 5)
insert into SACH values (N'Hồng lâu mộng', 5)
insert into SACH values (N'Cuốn theo chiều gió', 5)
insert into SACH values (N'Tam quốc diễn nghĩa', 5)
insert into SACH values (N'Thần thoại hy lạp', 5)
insert into SACH values (N'Bố già', 5)
insert into SACH values (N'Ba chàng lính ngự lâm', 5)
insert into SACH values (N'Những người phụ nữ bé nhỏ', 5)
insert into SACH values (N'Thủy hử', 5)
insert into SACH values (N'Giải phẫu học', 6)
insert into SACH values (N'Dược thư quốc gia Việt Nam', 6)
insert into SACH values (N'Những cây thuốc và vị thuốc Việt Nam', 6)
insert into SACH values (N'Thuốc nam trị bệnh', 6)
insert into SACH values (N'Sơ cứu nhanh - Giành sự sống', 6)
go

-- Insert table TACGIA
insert into TACGIA VALUES (N'Aoyama Gosho')
insert into TACGIA VALUES (N'Fujiko Fujio')
insert into TACGIA VALUES (N'Fujimoto Tatsuki')
insert into TACGIA VALUES (N'Oda Eiichiro')
insert into TACGIA VALUES (N'Atsushi Ohkubo')
insert into TACGIA VALUES (N'Kaneshiro Muneyuki')
insert into TACGIA VALUES (N'Hiro Mashima')
insert into TACGIA VALUES (N'Tanabe Yellow')
insert into TACGIA VALUES (N'Tomohito Oda')
insert into TACGIA VALUES (N'Somato')
insert into TACGIA VALUES (N'Aizawa Daisuke')
insert into TACGIA VALUES (N'Saekisan')
insert into TACGIA VALUES (N'Hitsuji Gondaira')
insert into TACGIA VALUES (N'Aso Haro')
insert into TACGIA VALUES (N'Kyo Shirodaira')
insert into TACGIA VALUES (N'Ashihara Daisuke')
insert into TACGIA VALUES (N'Inoue Takehiko')
insert into TACGIA VALUES (N'Naoshi Arakawa')
insert into TACGIA VALUES (N'Yusuke Murata')
insert into TACGIA VALUES (N'Endo Tatsuya')
insert into TACGIA VALUES (N'Akutami Gege')
insert into TACGIA VALUES (N'Kagami Takaya')
insert into TACGIA VALUES (N'Haruba Negi')
insert into TACGIA VALUES (N'Akimi Yoshida')
insert into TACGIA VALUES (N'Akidzuki Sorata')
insert into TACGIA VALUES (N'Ryosuke Takeuchi')
insert into TACGIA VALUES (N'Nishi Osamu')
insert into TACGIA VALUES (N'Horikoshi Kohei')
insert into TACGIA VALUES (N'Kishimoto Seishi')
insert into TACGIA VALUES (N'Hyūga Natsu')
insert into TACGIA VALUES (N'Akira Toriyama')
insert into TACGIA VALUES (N'Inagaki Riichiro')
insert into TACGIA VALUES (N'Komoto Hajime')
insert into TACGIA VALUES (N'Norihiro Yagi')
insert into TACGIA VALUES (N'Kaito')
insert into TACGIA VALUES (N'Motoro Mase')
insert into TACGIA VALUES (N'Amako Sōbee')
insert into TACGIA VALUES (N'Arakawa Hiromu')
insert into TACGIA VALUES (N'Chu-Gong')
insert into TACGIA VALUES (N'Jun Mochizuki')
insert into TACGIA VALUES (N'Yamamoto Soichiro')
insert into TACGIA VALUES (N'Koume Fujichika')
insert into TACGIA VALUES (N'Nozomi Uda')
insert into TACGIA VALUES (N'Yamaguchi Tsubasa')
insert into TACGIA VALUES (N'Akasaka Aka')
insert into TACGIA VALUES (N'Aida Iro')
insert into TACGIA VALUES (N'Kamui Fujiwara')
insert into TACGIA VALUES (N'Haruichi Furudate')
insert into TACGIA VALUES (N'Monma Motoki')
insert into TACGIA VALUES (N'Edgar Wallace')
insert into TACGIA VALUES (N'Thomas Harris')
insert into TACGIA VALUES (N'Arthur Conan Doyle')
insert into TACGIA VALUES (N'Dlu1')
insert into TACGIA VALUES (N'Dlu2')
insert into TACGIA VALUES (N'Dlu3')
insert into TACGIA VALUES (N'Dlu4')
insert into TACGIA VALUES (N'Dlu5')
insert into TACGIA VALUES (N'Dlu6')
insert into TACGIA VALUES (N'Ngô Gia Văn Phái')
insert into TACGIA VALUES (N'Nam Cao')
insert into TACGIA VALUES (N'Vũ Trọng Phụng')
insert into TACGIA VALUES (N'Ngô Tất Tố')
insert into TACGIA VALUES (N'Yusuke Kishi')
insert into TACGIA VALUES (N'Jules Verne')
insert into TACGIA VALUES (N'Henryk Sienkiewicz')
insert into TACGIA VALUES (N'Edmondo De Amicis')
insert into TACGIA VALUES (N'Hector Malot')
insert into TACGIA VALUES (N'Jack London')
insert into TACGIA VALUES (N'Robert Louis Stevenson')
insert into TACGIA VALUES (N'Edward Gibbon')
insert into TACGIA VALUES (N'Jacob & Wilhelm Grimm')
insert into TACGIA VALUES (N'Antoine Galland')
insert into TACGIA VALUES (N'Alexandre Dumas')
insert into TACGIA VALUES (N'Tào Tuyết Cần')
insert into TACGIA VALUES (N'Margaret Mitchell')
insert into TACGIA VALUES (N'La Quán Trung')
insert into TACGIA VALUES (N'Nguyễn Văn Khoả biên soạn')
insert into TACGIA VALUES (N'Mario Puzo')
insert into TACGIA VALUES (N'Alexandre Dumas')
insert into TACGIA VALUES (N'Louisa May Alcott')
insert into TACGIA VALUES (N'Thi Nại Am')
insert into TACGIA VALUES (N'Andreas Vesalius')
insert into TACGIA VALUES (N'Bộ Y tế')
insert into TACGIA VALUES (N'Đỗ Tất Lợi')
insert into TACGIA VALUES (N'Nguyễn Công Đức')
insert into TACGIA VALUES (N'Tổ Chức Giáo Dục Sức Khỏe Wellbeing & Bách Lê')
go

-- Insert table LOAIDOCGIA
insert into LOAIDOCGIA VALUES(N'Giảng viên')
insert into LOAIDOCGIA VALUES(N'Sinh viên')
insert into LOAIDOCGIA VALUES(N'Người thân')
go

-- Insert table DOCGIA
set dateformat dmy 
insert into DOCGIA VALUES (N'Phan Thị Thanh Nga', '11/11/1991', '01/09/2024', '31/08/2025', '0238194643', N'24 Triệu Việt Vương', N'Nữ', 1)
insert into DOCGIA VALUES (N'Lê Song Anh', '22/09/2004', '01/09/2024', '31/08/2025', '0229458253', N'92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Từ Nguyên Tuấn Anh', '27/08/2004', '01/09/2024', '31/08/2025', '0912843454', N'102 Bùi Thị Xuân', 'Nam', 2)
insert into DOCGIA VALUES (N'Phan Thái Bảo', '20/08/2004', '01/09/2024', '31/08/2025', '071284932', N'12 Lê Thị Hồng Gấm', 'Nam', 2)
insert into DOCGIA VALUES (N'Võ Tôn Gia	Đạt', '17/09/2004', '01/09/2024', '31/08/2025', '0123472323', N'34 Trần Hưng Đạo', 'Nam', 2)
insert into DOCGIA VALUES (N'Triệu Quang Học', '26/10/2004',' 01/09/2024', '31/08/2025', '0239481324', N'124 Tô Hiến Thành', 'Nam', 2)
go
insert into DOCGIA VALUES (N'Mull Roong	Esai', '6/10/2004', '01/09/2024', '31/08/2025', '01293482', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Nguyễn Trung Hiếu', '5/1/2004', '01/09/2024', '31/08/2025', '02349453', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Trần Ngọc Hưng', '13/05/2004', '01/09/2024', '31/08/2025', '09127434', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Đỗ Trần Quốc Huy', '3/4/2004', '01/09/2024', '31/08/2025', '02235646', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Phan Thanh	Khải', '23/06/2004', '01/09/2024', '31/08/2025', '02235646', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Đặng Nguyễn Phúc Khang', '12/3/2004', '01/09/2024', '31/08/2025', '02235646', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Nguyễn Hoàng Nam Khánh', '5/10/2004', '01/09/2024', '31/08/2025', '02235646', '92 Lê Thánh Tôn', 'Nam', 2)
insert into DOCGIA VALUES (N'Đinh Quốc Duy', '17/10/1977', '01/09/2024', '31/08/2025', '02235646', '92 Lê Thánh Tôn', 'Nam', 3)
insert into DOCGIA VALUES (N'Lâm Thị Tuyết Minh', '22/12/1979', '01/09/2024', '31/08/2025', '039458923', '87 Phan Đình Phùng', 'Nữ', 3)
insert into DOCGIA VALUES (N'Đinh Lâm Gia Quân', '30/01/2012', '01/09/2024', '31/08/2025', '02235646', '92 Lê Thánh Tôn', 'Nam', 3)
insert into DOCGIA VALUES (N'Bạch Tiểu Lăng', '08/01/2004', '01/09/2024', '31/08/2025', '02381946', '23 Triệu Việt Vương', 'Nữ', 3)
go



delete from NHANVIEN
select * from NHANVIEN
DBCC CHECKIDENT ('NHANVIEN', RESEED, 0);
