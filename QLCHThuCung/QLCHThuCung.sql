
drop Database QLCHThuCung

CREATE DATABASE QLCHThuCung /*!40100 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE QLCHThuCung;

CREATE TABLE LoaiHangHoa (
  LoaiHangHoaID int IDENTITY PRIMARY KEY,
  TenLoai nvarchar(255) NOT NULL
  )
GO

CREATE TABLE LoaiUser (
  LoaiUserID int IDENTITY PRIMARY KEY,
  TenLoai nvarchar(255) NOT NULL
)
GO 

CREATE TABLE Users(
  UserID int IDENTITY PRIMARY KEY,
  HoTen nvarchar(255) NOT NULL,
  NgaySinh date NOT NULL,
  GioiTinh nvarchar(4) NOT NULL,
  CMND varchar(12) NOT NULL,
  TaiKhoan varchar(20) NOT NULL,
  MatKhau varchar(255) NOT NULL,
  NgayVaoLam date NOT NULL,
  Email varchar(255) NOT NULL,
  DiaChi nvarchar(255) NOT NULL,
  SDT varchar(10) NOT NULL,
  TrangThai bit NOT NULL DEFAULT 1,
  LoaiUserID int NOT NULL,
  
  FOREIGN KEY (LoaiUserID) REFERENCES LoaiUser (LoaiUserID)
)
GO

CREATE TABLE NhaCungCap (
  NhaCungCapID int IDENTITY PRIMARY KEY,
  TenCongTy nvarchar(255) NOT NULL,
  DiaChi nvarchar(255) NOT NULL,
  Email varchar(255) NOT NULL,
  SDT varchar(10) NOT NULL,
)
GO


CREATE TABLE HangHoa (
  HangHoaID int IDENTITY PRIMARY KEY,
  TenHangHoa nvarchar(255) NOT NULL,
  ThuongHieu nvarchar(255) NOT NULL,
  SoLuongTK int NULL,
  GiaNiemYet decimal(10,0) NOT NULL,
  GiaNhap decimal(10,0) NOT NULL,
  TinhTrang bit NOT NULL DEFAULT 1,
  LoaiHangHoaID int NULL,
  NhaCungCapID int NUll
  
  FOREIGN KEY (LoaiHangHoaID) REFERENCES LoaiHangHoa (LoaiHangHoaID),
  FOREIGN KEY (NhaCungCapID) REFERENCES NhaCungCap (NhaCungCapID)
)
GO 


CREATE TABLE KhachHang (
  KhachHangID int IDENTITY PRIMARY KEY,
  HoTen nvarchar(255) NOT NULL,
  NgaySinh date NOT NULL,
  GioiTinh nvarchar(4) NOT NULL,
  DiaChi nvarchar(255) NOT NULL,
  SDT varchar(11) NOT NULL,
) 
GO

CREATE TABLE DonHang (
  DonHangID int IDENTITY PRIMARY KEY,
  NgayTao datetime NOT NULL,
  NhanVienID int NOT NULL,
  KhachHangID int NULL,
  
	FOREIGN KEY (NhanVienID) REFERENCES Users (UserID),
	FOREIGN KEY (KhachHangID) REFERENCES KhachHang (KhachHangID)
) 
GO
  
CREATE TABLE ChiTietDonHang (
  DonHangID int,
  HangHoaID int,
  SoLuong int NOT NULL,
  DonGia decimal(10,0) NOT NULL,
  GiamGia float DEFAULT 0,
  
  PRIMARY KEY (DonHangID, HangHoaID),
  FOREIGN KEY (DonHangID) REFERENCES DonHang (DonHangID),
  FOREIGN KEY (HangHoaID) REFERENCES HangHoa (HangHoaID)
  )
GO
  
  
  INSERT INTO LoaiHangHoa (TenLoai) VALUES (N'Di??ch vu??'),(N'Th????c ??n cho cho??'), (N'Th????c ??n cho me??o'), (N'Phu?? ki????n');
  
  INSERT INTO LoaiUser (TenLoai) VALUES (N'Qua??n ly?? tr??????ng'), (N'Thu?? kho'), (N'Nh??n vi??n');
  
  INSERT INTO Users (HoTen,NgaySinh,GioiTinh,CMND,TaiKhoan,MatKhau,NgayVaoLam,Email,DiaChi,SDT,TrangThai,LoaiUserID) VALUES
  (N'Tr????ng Phong','1990-01-01',N'Nam','0222334455','truongphong','1','2018-03-02','truongphong@gmail.com',N'Qu????n 7, TP.HCM','0793278239',1,1);
  INSERT INTO Users (HoTen,NgaySinh,GioiTinh,CMND,TaiKhoan,MatKhau,NgayVaoLam,Email,DiaChi,SDT,TrangThai,LoaiUserID) VALUES
  (N'Pha??m Lu??n','1980-04-27',N'Nam','033445567788','phamluan','1','2018-03-02','phamluan@gmail.com',N'Go?? V????p, TP.HCM','0987654321',1,2);
  INSERT INTO Users (HoTen,NgaySinh,GioiTinh,CMND,TaiKhoan,MatKhau,NgayVaoLam,Email,DiaChi,SDT,TrangThai,LoaiUserID) VALUES
  (N'Tr????n Nh?? T??m','1997-03-14',N'N????','0374832938','trannhutam','1','2018-03-02','trannhutam@gmail.com',N'TP.Thu?? ??????c','0792348918',1,2);
  INSERT INTO Users (HoTen,NgaySinh,GioiTinh,CMND,TaiKhoan,MatKhau,NgayVaoLam,Email,DiaChi,SDT,TrangThai,LoaiUserID) VALUES
  (N'Huy??nh Thi?? Thanh','1999-03-21',N'N????','0364687732','huynhthithanh','1','2018-03-02','huynhthithanh@gmail.com',N'Bi??nh D????ng','0382349726',1,3);
   INSERT INTO Users (HoTen,NgaySinh,GioiTinh,CMND,TaiKhoan,MatKhau,NgayVaoLam,Email,DiaChi,SDT,TrangThai,LoaiUserID) VALUES
  (N'Phu??ng Thi????n Nh????t','2000-04-03',N'Nam','0337422034','phungthiennhat','1','2020-05-03','phungthiennhat@gmail.com',N'Qu????n Bi??nh Tha??nh','0921648324',1,3);
  
  INSERT INTO nhacungcap (TenCongTy,DiaChi,Email,SDT) VALUES (N'Milu Shop',N'371 Nguy????n Ki????m, Ph??????ng 3, Qu????n Go?? V????p','sales@cityzoo.vn','0834502000');
  INSERT INTO nhacungcap (TenCongTy,DiaChi,Email,SDT) VALUES (N'City Zoo',N'146D4 Nguy???n V??n H?????ng, Ph??????ng Th???o ??i???n, Qu???n 2','sales@cityzoo.vn','0834502000');
  INSERT INTO nhacungcap (TenCongTy,DiaChi,Email,SDT) VALUES (N'Nutrience',N'366 L?? V??n S???, Ph?????ng 14, Qu???n 3','info@petpro.vn','0901636696');
  INSERT INTO nhacungcap (TenCongTy,DiaChi,Email,SDT) VALUES (N'DOCA',N'L?? 19 ??.04, KCN Ch??u ?????c, X?? Ngh??a Th??nh, Huy????n Ch??u ?????c,','docavn79.com@gmail.com','0254629979');
  INSERT INTO nhacungcap (TenCongTy,DiaChi,Email,SDT) VALUES (N'Fusion Group',N'L?? L1-06B-07B-08B Khu du l???ch sinh th??i cao c???p An Kh??nh, x?? An Kh??nh, huy???n Ho??i ?????c','Info@fusiongroup.vn','0436367676');
  
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? nhu????m 2 tai (2 ma??u)',N'Milu Shop', 999,250000,200000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? v???? sinh',N'Milu Shop', 999,120000,100000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? ca??o l??ng, c????t ti??a',N'Milu Shop', 999,150000,130000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,Gianhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? c????t mo??ng, ma??i mo??ng',N'Milu Shop', 1000,40000,30000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,Gianhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? v???? sinh tai, nh???? l??ng tai',N'Milu Shop', 999,40000,35000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? nhu????m 2 tai (1 ma??u)',N'Milu Shop', 999,200000,180000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? nhu????m 4 ch??n (1 ma??u)',N'Milu Shop', 1000,250000,235000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Di??ch vu?? nhu????m 4 ch??n (2 ma??u)',N'Milu Shop', 999,300000,288000,1,1,1);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'TH???C ??N ?????T ROYAL CANIN MAXI ADULT',N'ROYAL CANIN',10,408000,400000,1,2,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'BEAPHAR JUNIOR PASTE - GEL DINH D?????NG CHO CH?? CON','beaphar',18,162000,155000,1,2,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'BEAPHAR MULTI VITAMIN TOP 10 - VITAMIN T???NG H???P CHO CH??',N'beaphar',11,236000,224000,1,2,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'BEAPHAR DUO ACTIVE JUNIOR PASTE CAT - GEL DINH D?????NG CHO M??O CON',N'beaphar',11,162000,157000,1,3,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'BEAPHAR LACTOL KITTY MILK - S???A CHO M??O CON',N'beaphar',24,502000,495000,1,3,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'ROYAL CANIN URINARY CARE WET - H??? TR??? S???C KH???E TI???T NI???U',N'ROYAL CANIN', 10,391000,380000,1,3,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'NT Grain Free cao c???p cho Ch?? - G?? t??y, c?? tr??ch, tr???ng g?? v?? rau c??? qu??? t??? nhi??n',N'Nutrience',20,128000,118000,1,2,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'NT Subzero cho Ch?? - Th???t b??, c?? h???i v?? rau c??? qu??? t??? nhi??n (Cho m???i gi???ng ch?? ??? m???i l???a tu???i)',N'Nutrience',19,160000,150000,1,2,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'NT Original cho Ch?? con - Th???t g?? v?? rau c??? qu??? t??? nhi??n (D?????i 12 th??ng tu???i)',N'Nutrience',12,120000,115000,1,2,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'NT Original cho M??o con - Th???t g?? v?? rau c??? qu??? t??? nhi??n (D?????i 12 th??ng tu???i)',N'Nutrience',8,520000,515000,1,3,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'NT Original cho M??o tr?????ng th??nh - Th???t g?? v?? rau c??? qu??? t??? nhi??n',N'Nutrience',7,900000,880000,1,3,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'NT Subzero cho M??o - Th???t g??, c?? h???i, c?? tr??ch v?? rau c??? qu??? t??? nhi??n (Cho m???i gi???ng m??o ??? m???i l???a tu???i)',N'Nutrience',5,1400000,1350000,1,3,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n Cho Ch?? M???i L???a Tu???i - Doca Dog 450gr',N'FRESH TRINO',5,45000,38000,1,2,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n Ch?? Tr?????ng Th??nh - Regular Dog 7 450gr',N'FRESH TRINO',16,40000,35000,1,2,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n Ch?? Con - Alphatrino 450gr',N'FRESH TRINO',14,45900,39200,1,2,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n M??o Tr?????ng Th??nh - Brutrino 450gr',N'FRESH TRINO',12,43200,38500,1,3,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n M??o Con - Neutrino Cat 450gr',N'FRESH TRINO',3,49400,45300,1,3,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'S???a M??? Kh?? Cho M??o - Msbilac Gold Cat 330gr',N'Ch??u Tha??nh JSC',4,120000,115000,1,3,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n h???t h???u c?? cho ch?? ANF 6 Free v??? c?? h???i 2kg',N'ANF',5,440000,40000,1,2,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'H???t Dinh D?????ng Kh??ng Ng?? C???c V??? V???t Nutriwell D??nh Cho Ch?? M???i L???a Tu???i 1.5kg',N'Jeil PetFood',12,310000,304200,1,2,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'H???t Th???c ??n Ch???c N??ng T???t Cho S???c Kh???e ???????ng Ru???t Nature Kitchen (d??nh Cho Ch?? M???i L???a Tu???i)',N'ANF',11,360000,354600,1,2,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'Th???c ??n cho m??o m???i l???a tu???i 5kg - Today dinner',N'Farmsco Corporation',37,395000,387000,1,3,2);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'B??nh th?????ng dinh d?????ng cho m??o Gozip v??? c?? ng???',N'Jeil PetFood',10,48000,44400,1,3,3);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'TRAVEL - Balo v???n chuy???n',N'Pawise',30,547000,541300,1,4,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'C??t V??? Sinh M??o Si??u Kh??? M??i - Diamond Feline 7kg',N'Diamond Feline',200,200000,194600,1,4,4);
  INSERT INTO hanghoa (TenHangHoa,ThuongHieu,SoLuongTK,GiaNiemYet,GiaNhap,TinhTrang,LoaiHangHoaID,NhaCungCapID) VALUES (N'S???a T???m Ch?? M??o M?????t Da L??ng - DC Guard 500ml',N'DC Guard',50,130000,122000,1,4,2);
  
  
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Nguy????n Minh Vi????t','1983-06-28',N'Nam', N'1111 ????????ng 3/2, Ph??????ng 12, Qu????n 11','0932478390');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Hoa??ng V??n Thu','1968-04-27',N'N????', N'333 ????????ng Nguy????n Duy D????ng, Ph??????ng 4, Qu????n 10','0793247628');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Nguy????n Hoa??ng','1994-04-25',N'Nam', N'Qu????n 2','0934783203');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'La??i V??n Ba','1962-03-26',N'Nam', N'Qu????n Go?? V????p','0932473592');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Huy??nh Thi?? Tuy????t Nhi','2000-02-14',N'N????', N'Ninh Thu????n','0994732629');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Tr????ng Thu Tha??o','1998-04-15',N'N????', N'Bi??nh D????ng','0792348900');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Phan Thi?? Ngo??c','2002-04-14',N'N????', N'Qu????n 3','0793274932');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'Vo?? Chi?? N??ng','2003-09-28',N'Nam', N'Qu????n Bi??nh T??n','0932479592');
  INSERT INTO khachhang (HoTen,NgaySinh,GioiTinh,DiaChi,SDT)
  VALUES (N'T?? V??n Be??','2001-03-20',N'Nam', N'Qu????n 8','0932567409');
  
  
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-03-02',4,2);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-04-10',5,3);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-05-12',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-06-04',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-07-27',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-08-29',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-09-20',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-10-12',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-11-03',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2018-12-07',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-01-28',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-02-18',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-03-02',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-04-20',4,4);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-05-21',5,5);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-07-01',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-10-20',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2019-12-10',4,6);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2020-01-20',4,7);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2020-02-01',5,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2020-04-24',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2020-05-21',5,8);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2020-08-12',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2020-12-15',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2021-03-14',4,9);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2021-10-03',4,1);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2021-11-10',4,3);
  INSERT INTO DonHang(NgayTao,NhanVienID,KhachHangID) VALUES ('2021-11-11',5,2);
  
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (1, 9, 90, 408000, 0.15);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (1, 16, 100, 160000, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (1, 27, 2, 440000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (2, 12, 114, 130000, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (2, 32, 70, 275000, 0.15);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (3, 27, 1, 440000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (4, 14, 22, 391000, 0.1);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (5, 17, 5, 120000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (6, 18, 2, 520000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (7, 19, 7, 900000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (8, 20, 113, 1400000, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (9, 21, 112, 45000, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (10, 22, 114, 40000, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (11, 23, 101, 459000, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (12, 24, 10, 43200, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (13, 25, 15, 49400, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (14, 08, 1, 300000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (15, 31, 35, 48000, 0.1);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (16, 11, 30, 236000, 0.1);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (17, 10, 87, 162000, 0.15);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (18, 06, 1, 250000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (19, 19, 1, 900000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (20, 20, 4, 1400000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (21, 21, 6, 45000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (22, 22, 3, 40000, 0); 
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (23, 23, 2, 45900, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (24, 24, 101, 43200, 0.2);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (25, 25, 2, 49400, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (26, 26, 11, 120000, 0);
 
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (27, 27, 4, 440000, 0);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (27, 29, 12, 360000, 0);
  
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (28, 22, 1, 40000, 0.5);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (28, 1, 1, 120000, 0.5);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (28, 2, 1, 150000, 0.5);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (28, 4, 1, 40000, 0.5);
  INSERT INTO ChiTietDonHang(DonHangID,HangHoaID,soluong,dongia,giamgia) VALUES (28, 5, 1, 200000, 0.5);
  
  
Create Proc [dbo].[RP_DoanhThuTheoNgay]
@NgayBD Datetime,
@NgayKT Datetime
AS
BEGIN
	SET NOCOUNT ON
	SELECT HangHoa.HangHoaID, HangHoa.TenHangHoa, ChiTietDonHang.SoLuong as SoLuongDaBan, sum((DonGia*(1-GiamGia)) * SoLuong) as ThanhTien
	FROM HangHoa, ChiTietDonHang, DonHang
	WHERE HangHoa.HangHoaID = ChiTietDonHang.HangHoaID
	AND ChiTietDonHang.DonHangID = DonHang.DonHangID
	AND NgayTao < @NgayKT
	AND NgayTao >= @NgayBD
	GROUP BY HangHoa.HangHoaID, HangHoa.TenHangHoa, ChiTietDonHang.SoLuong	
END
GO

Create Proc [dbo].[RP_TongChiPhi]
AS
BEGIN
	SET NOCOUNT ON
	SELECT HangHoaID, TenHangHoa, SoLuongTK as SoLuongNhap, GiaNhap,  (GiaNhap* SoLuongTK) as ThanhTien
	FROM HangHoa
END
GO