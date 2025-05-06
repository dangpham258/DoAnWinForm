-- Tạo cơ sở dữ liệu Skyline
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Skyline')
BEGIN
    CREATE DATABASE Skyline;
END
GO
	
USE Skyline;
GO

CREATE TABLE Table_TicketDatabase (
    TicketID INT PRIMARY KEY IDENTITY(1,1),    -- Mã vé (ID tự tăng)
    FlightNumber NVARCHAR(20) NOT NULL,        -- Mã chuyến bay
    Airline NVARCHAR(100) NOT NULL,            -- Hãng bay
    DepartCode NVARCHAR(10) NOT NULL,          -- Mã sân bay khởi hành
    ArriveCode NVARCHAR(10) NOT NULL,          -- Mã sân bay đến
    DepartureDate DATETIME NOT NULL,           -- Ngày bay đi
    ArrivalDate DATETIME NOT NULL,             -- Ngày hạ cánh chuyến bay đi
    ClassType NVARCHAR(50) NOT NULL,           -- Hạng bay (Economy, Business, First Class, ...)
    SeatNumber NVARCHAR(10) NOT NULL,          -- Mã ghế (ví dụ: G01 đến G10)
    Price INT NOT NULL,                        -- Giá vé (kiểu int)

    PhoneNumber NVARCHAR(20) NOT NULL,         -- Số điện thoại liên hệ
    FullName NVARCHAR(100) NOT NULL,           -- Họ và tên hành khách
    CCCD NVARCHAR(20) NOT NULL,                -- Căn cước công dân (CCCD)
    
    UserName NVARCHAR(50) NOT NULL,     -- Tên đăng nhập mà người dùng sử dụng đmua
    Status INT NOT NULL DEFAULT 0,             -- Trạng thái vé: 0 - Chưa dùng, 1 - Đã dùng, 2 - Đã hủy
);


-- Tạo bảng Table_UserDatabase
CREATE TABLE Table_UserDatabase (
    PersonID INT PRIMARY KEY IDENTITY(1,1),    -- Mã người dùng (ID tự tăng)

    UserName NVARCHAR(50) NOT NULL UNIQUE,     -- Tên đăng nhập, yêu cầu duy nhất
    Password NVARCHAR(100) NOT NULL,           -- Mật khẩu
    FullName NVARCHAR(100) NOT NULL,           -- Họ và tên
);



-- Tạo bảng Table_CrewDatabase dựa trên lớp CrewMember kế thừa từ Person
CREATE TABLE Table_CrewDatabase (
    PersonID INT PRIMARY KEY IDENTITY(1,1),    -- Mã người dùng (ID tự tăng)
    UserName NVARCHAR(50) NOT NULL UNIQUE,     -- Tên đăng nhập, yêu cầu duy nhất
    Password NVARCHAR(100) NOT NULL,           -- Mật khẩu

    JobType NVARCHAR(50) NOT NULL,             -- Loại công việc (phi công, tiếp viên, v.v.)
    YearsOfExperience INT NOT NULL,            -- Số năm kinh nghiệm
    PhoneNumber NVARCHAR(20) NOT NULL,         -- Số điện thoại liên hệ
    FullName NVARCHAR(100) NOT NULL,           -- Họ và tên
    CCCD NVARCHAR(20) NOT NULL,                -- Căn cước công dân (CCCD)

    Status INT NOT NULL DEFAULT 1,             -- Trạng thái: 1 - rảnh, 0 - bận
);

-- Tạo bảng Table_ControllerDatabase dựa trên lớp Controller kế thừa từ Person
CREATE TABLE Table_ControllerDatabase (
    PersonID INT PRIMARY KEY IDENTITY(1,1),    -- Mã người dùng (ID tự tăng)
    UserName NVARCHAR(50) NOT NULL UNIQUE,     -- Tên đăng nhập, yêu cầu duy nhất
    Password NVARCHAR(100) NOT NULL,           -- Mật khẩu
);

-- Tạo bảng Table_FlightInfoDatabase
CREATE TABLE Table_FlightInfoDatabase (
    FlightID INT PRIMARY KEY IDENTITY(1,1),  -- ID chuyến bay (tự tăng)
    FlightNumber NVARCHAR(20) NOT NULL,      -- Mã chuyến bay
    Airline NVARCHAR(100) NOT NULL,            -- Hãng bay
    DepartCode NVARCHAR(10) NOT NULL,        -- Mã sân bay khởi hành
    ArriveCode NVARCHAR(10) NOT NULL,        -- Mã sân bay đến
    DepartureDate DATETIME NOT NULL,           -- Ngày bay đi
    ArrivalDate DATETIME NOT NULL,             -- Ngày hạ cánh chuyến bay đi

    PilotID INT NULL,                        -- Mã thành viên phi công (có thể NULL)
    PilotName NVARCHAR(100) NULL,            -- Tên phi công trưởng (có thể NULL)
    
    CoPilotID INT NULL,                      -- Mã thành viên cơ phó (có thể NULL)
    CoPilotName NVARCHAR(100) NULL,          -- Tên cơ phó (có thể NULL)
    
    AttendantID INT NULL,                    -- Mã thành viên tiếp viên (có thể NULL)
    AttendantName NVARCHAR(100) NULL,        -- Tên tiếp viên (có thể NULL)
    
    PassengerCount INT NOT NULL DEFAULT 0,   -- Số lượng khách, mặc định 0
    
    -- Các cột để lưu trữ trạng thái của 10 ghế
    G1 BIT NOT NULL DEFAULT 0,               -- 0 = ghế trống, 1 = ghế có người
    G2 BIT NOT NULL DEFAULT 0,
    G3 BIT NOT NULL DEFAULT 0,
    G4 BIT NOT NULL DEFAULT 0,
    G5 BIT NOT NULL DEFAULT 0,
    G6 BIT NOT NULL DEFAULT 0,
    G7 BIT NOT NULL DEFAULT 0,
    G8 BIT NOT NULL DEFAULT 0,
    G9 BIT NOT NULL DEFAULT 0,
    G10 BIT NOT NULL DEFAULT 0
);

-- Tạo bảng Table_FeedbackDatabase
CREATE TABLE Table_FeedbackDatabase (
    FeedbackId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Type NVARCHAR(100) NOT NULL,
    Detail NVARCHAR(255) NOT NULL,
    Status TINYINT NOT NULL DEFAULT 0 -- 0: Chưa đọc, 1: Đã đọc
)

INSERT INTO Table_CrewDatabase
    (UserName, Password, JobType, YearsOfExperience, PhoneNumber, FullName, CCCD)
VALUES
    ('nguyenvanhai',    '123456', 'Pilot',      10, '0912345670', 'Nguyen Van Hai',     '070123456789'),
    ('tranthicam',      '123456', 'Attendant',   6, '0918765432', 'Tran Thi Cam',       '071234567890'),
    ('leminhphu',       '123456', 'Co-Pilot',    8, '0987654322', 'Le Minh Phu',         '072345678901'),
    ('phamthikieu',     '123456', 'Attendant',   4, '0909876543', 'Pham Thi Kieu',       '073456789012'),
    ('hoanganhson',     '123456', 'Pilot',      12, '0932109876', 'Hoang Anh Son',       '074567890123'),
    ('duongminhduc',    '123456', 'Co-Pilot',    7, '0943210987', 'Duong Minh Duc',      '075678901234'),
    ('truongthihoa',    '123456', 'Attendant',   5, '0954321098', 'Truong Thi Hoa',      '076789012345'),
    ('nguyentansang',   '123456', 'Pilot',      15, '0965432109', 'Nguyen Tan Sang',     '077890123456'),
    ('phamhuyhoang',    '123456', 'Co-Pilot',    9, '0976543210', 'Pham Huy Hoang',      '078901234567'),
    ('lethixuanmai',    '123456', 'Attendant',   3, '0987654321', 'Le Thi Xuan Mai',     '079012345678'),
    ('vuongthanhbinh',  '123456', 'Pilot',      11, '0911222333', 'Vuong Thanh Binh',    '080123456789'),
    ('nguyenthuongvy',  '123456', 'Attendant',   4, '0901332444', 'Nguyen Thuong Vy',    '081234567890'),
    ('nguyenthithuy',   '123456', 'Attendant',   2, '0978123456', 'Nguyen Thi Thuy',     '082345678901'),
    ('buituananh',      '123456', 'Pilot',       9, '0978234567', 'Bui Tuan Anh',        '083456789012'),
    ('phamvanlong',     '123456', 'Co-Pilot',    6, '0978345678', 'Pham Van Long',       '084567890123'),
    ('tranvanhoa',      '123456', 'Attendant',   7, '0978456789', 'Tran Van Hoa',        '085678901234'),
    ('lethianh',        '123456', 'Pilot',      13, '0978567890', 'Le Thi Anh',          '086789012345'),
    ('nguyenhuuduc',    '123456', 'Co-Pilot',    5, '0987654323', 'Nguyen Huu Duc',      '087890123456'),
    ('tranmailinh',     '123456', 'Attendant',   4, '0987543210', 'Tran Mai Linh',       '088901234567'),
    ('lequoctuan',      '123456', 'Pilot',       8, '0987432109', 'Le Quoc Tuan',        '089012345678'),
    ('phamthiha',       '123456', 'Attendant',   3, '0987321098', 'Pham Thi Ha',         '090123456789'),
    ('hoangminhtuan',   '123456', 'Pilot',      14, '0987210987', 'Hoang Minh Tuan',     '091234567890'),
    ('vuthingoc',       '123456', 'Co-Pilot',    6, '0987109876', 'Vu Thi Ngoc',         '092345678901'),
    ('dangvankhoa',     '123456', 'Attendant',   5, '0987098765', 'Dang Van Khoa',       '093456789012'),
    ('buithiphuong',    '123456', 'Attendant',   7, '0987987654', 'Bui Thi Phuong',      '094567890123'),
    ('ngoquanghuy',     '123456', 'Co-Pilot',    9, '0987876543', 'Ngo Quang Huy',       '095678901234'),
    ('vuvandung',       '123456', 'Pilot',      10, '0987765432', 'Vu Van Dung',         '096789012345'),
    ('phanngocthanh',   '123456', 'Attendant',   4,  '0976541223',   'Phan Ngoc Thanh',    '097890123456'),
    ('tranminhkhanh',   '123456', 'Co-Pilot',    8,  '0965433122',   'Tran Minh Khanh',    '098901234567'),
    ('nguyenthuyanh',   '123456', 'Pilot',      11, '0954324121',   'Nguyen Thuy Anh',    '099012345678'),
    ('lequanghiep',     '123456', 'Attendant',   5,  '0943215120',   'Le Quang Hiep',      '090123456780'),
    ('baituankiet',     '123456', 'Co-Pilot',    7,  '0932106129',   'Bai Tuan Kiet',      '091234560123');
GO

-- 2. Dữ liệu cho Controller
INSERT INTO Table_ControllerDatabase
    (UserName, Password)
VALUES
    ('ngocthang',      '23110327'),
    ('thiendang',      '23110203'),
    ('hoangtam',       '23110313'),
    ('duyphu',         '22110397');
GO

-- 3. Dữ liệu cho User
INSERT INTO Table_UserDatabase (UserName, Password, FullName)
VALUES
    ('tranminh',    '123456',    'Tran Minh'),
    ('ngocanh',     '123456',    'Ngoc Anh'),
    ('hoangdung',   'password',  'Hoang Dung'),
    ('lethuynh',    'abc123',    'Le Huynh'),
    ('phamquynh',   '12345',     'Pham Quynh'),
    ('nguyenthuy',  'thuy123',   'Nguyen Thuy'),
    ('duonghieu',   'hieu123',   'Duong Hieu'),
    ('vohong',      'vo123',     'Vo Hong'),
    ('buiphuong',   'phuong1',   'Bui Phuong'),
    ('phamxuan',    'xuan2025',  'Pham Xuan');
GO

INSERT INTO Table_FlightInfoDatabase
(FlightNumber, Airline, DepartCode, ArriveCode, DepartureDate, ArrivalDate, 
 PilotID, PilotName, CoPilotID, CoPilotName, AttendantID, AttendantName, PassengerCount,
 G1, G2, G3, G4, G5, G6, G7, G8, G9, G10)
VALUES
-- Các chuyến bay trong quá khứ (tháng 4/2025)
('VN 286', 'Vietnam Airlines', 'HAN', 'SGN', '2025-04-15 07:30:00.000', '2025-04-15 09:30:00.000', 
 1, 'Nguyen Van Hai', 3, 'Le Minh Phu', 2, 'Tran Thi Cam', 3, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0),

('VJ 162', 'Vietjet', 'SGN', 'HAN', '2025-04-18 14:20:00.000', '2025-04-18 16:25:00.000', 
 5, 'Hoang Anh Son', 6, 'Duong Minh Duc', 7, 'Truong Thi Hoa', 4, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0),

('QH 277', 'Bamboo Airways', 'SGN', 'DAD', '2025-04-22 08:45:00.000', '2025-04-22 10:00:00.000', 
 8, 'Nguyen Tan Sang', 9, 'Pham Huy Hoang', 4, 'Pham Thi Kieu', 2, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0),

('BL 595', 'Pacific Airlines', 'SGN', 'UIH', '2025-04-25 12:15:00.000', '2025-04-25 13:30:00.000', 
 11, 'Vuong Thanh Binh', 15, 'Pham Van Long', 10, 'Le Thi Xuan Mai', 3, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0),

('VU 481', 'Vietravel Airlines', 'DAD', 'HAN', '2025-04-28 16:30:00.000', '2025-04-28 18:00:00.000', 
 14, 'Bui Tuan Anh', 18, 'Nguyen Huu Duc', 12, 'Nguyen Thuong Vy', 2, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0),

-- Các chuyến bay trong tháng hiện tại (tháng 5/2025)
('VN 192', 'Vietnam Airlines', 'HAN', 'CXR', '2025-05-02 09:30:00.000', '2025-05-02 11:00:00.000', 
 17, 'Le Thi Anh', 23, 'Vu Thi Ngoc', 13, 'Nguyen Thi Thuy', 4, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0),

('VJ 427', 'Vietjet', 'SGN', 'HPH', '2025-05-10 11:20:00.000', '2025-05-10 13:15:00.000', 
 20, 'Le Quoc Tuan', 6, 'Duong Minh Duc', 21, 'Pham Thi Ha', 3, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0),

('QH 318', 'Bamboo Airways', 'HAN', 'PQC', '2025-05-13 13:45:00.000', '2025-05-13 15:30:00.000', 
 22, 'Hoang Minh Tuan', 15, 'Pham Van Long', 16, 'Tran Van Hoa', 2, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0),

('BL 724', 'Pacific Airlines', 'DAD', 'SGN', '2025-05-17 07:50:00.000', '2025-05-17 09:10:00.000', 
 27, 'Vu Van Dung', 18, 'Nguyen Huu Duc', 24, 'Dang Van Khoa', 2, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0),

('VU 502', 'Vietravel Airlines', 'SGN', 'VII', '2025-05-20 15:30:00.000', '2025-05-20 16:45:00.000', 
 30, 'Nguyen Thuy Anh', 29, 'Tran Minh Khanh', 28, 'Phan Ngoc Thanh', 3, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0),

('VN 360', 'Vietnam Airlines', 'HAN', 'DLI', '2025-05-23 10:00:00.000', '2025-05-23 11:45:00.000', 
 8, 'Nguyen Tan Sang', 23, 'Vu Thi Ngoc', 19, 'Tran Mai Linh', 2, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0),

('VJ 539', 'Vietjet', 'SGN', 'BMV', '2025-05-27 09:15:00.000', '2025-05-27 10:30:00.000', 
 14, 'Bui Tuan Anh', 9, 'Pham Huy Hoang', 25, 'Bui Thi Phuong', 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
GO

INSERT INTO Table_TicketDatabase
(FlightNumber, Airline, DepartCode, ArriveCode, DepartureDate, ArrivalDate, 
 ClassType, SeatNumber, Price, PhoneNumber, FullName, CCCD, UserName, Status)
VALUES
-- Vé cho các chuyến bay trong quá khứ
('VN 286', 'Vietnam Airlines', 'HAN', 'SGN', '2025-04-15 07:30:00.000', '2025-04-15 09:30:00.000', 
 'Economy', 'G1', 1850000, '0912345678', 'TRAN VAN TUAN', '075123456789', 'tranminh', 1),

('VN 286', 'Vietnam Airlines', 'HAN', 'SGN', '2025-04-15 07:30:00.000', '2025-04-15 09:30:00.000', 
 'Economy', 'G2', 1850000, '0923456789', 'NGUYEN THI NGA', '076234567890', 'ngocanh', 1),

('VN 286', 'Vietnam Airlines', 'HAN', 'SGN', '2025-04-15 07:30:00.000', '2025-04-15 09:30:00.000', 
 'Economy', 'G3', 1850000, '0934567890', 'PHAM VAN HUNG', '077345678901', 'hoangdung', 1),

('VJ 162', 'Vietjet', 'SGN', 'HAN', '2025-04-18 14:20:00.000', '2025-04-18 16:25:00.000', 
 'Economy', 'G1', 1450000, '0945678901', 'LE THI HANH', '078456789012', 'lethuynh', 1),

('VJ 162', 'Vietjet', 'SGN', 'HAN', '2025-04-18 14:20:00.000', '2025-04-18 16:25:00.000', 
 'Economy', 'G2', 1450000, '0956789012', 'TRAN QUOC TUAN', '079567890123', 'phamquynh', 1),

('VJ 162', 'Vietjet', 'SGN', 'HAN', '2025-04-18 14:20:00.000', '2025-04-18 16:25:00.000', 
 'Economy', 'G4', 1450000, '0967890123', 'DUONG THI MAI', '080678901234', 'nguyenthuy', 1),

('VJ 162', 'Vietjet', 'SGN', 'HAN', '2025-04-18 14:20:00.000', '2025-04-18 16:25:00.000', 
 'Economy', 'G6', 1450000, '0978901234', 'VO THANH NAM', '081789012345', 'duonghieu', 1),

('QH 277', 'Bamboo Airways', 'SGN', 'DAD', '2025-04-22 08:45:00.000', '2025-04-22 10:00:00.000', 
 'Economy', 'G3', 1920000, '0989012345', 'NGUYEN MINH KHOA', '082890123456', 'vohong', 1),

('QH 277', 'Bamboo Airways', 'SGN', 'DAD', '2025-04-22 08:45:00.000', '2025-04-22 10:00:00.000', 
 'Economy', 'G9', 1920000, '0990123456', 'PHAM THI HUONG', '083901234567', 'buiphuong', 1),

('BL 595', 'Pacific Airlines', 'SGN', 'UIH', '2025-04-25 12:15:00.000', '2025-04-25 13:30:00.000', 
 'Economy', 'G1', 1280000, '0901234567', 'TRAN VAN QUANG', '084012345678', 'phamxuan', 1),

('BL 595', 'Pacific Airlines', 'SGN', 'UIH', '2025-04-25 12:15:00.000', '2025-04-25 13:30:00.000', 
 'Economy', 'G3', 1280000, '0912345670', 'NGUYEN THI HONG', '085123456789', 'tranminh', 1),

('BL 595', 'Pacific Airlines', 'SGN', 'UIH', '2025-04-25 12:15:00.000', '2025-04-25 13:30:00.000', 
 'Economy', 'G8', 1280000, '0923456780', 'LE VAN TIEN', '086234567890', 'ngocanh', 1),

('VU 481', 'Vietravel Airlines', 'DAD', 'HAN', '2025-04-28 16:30:00.000', '2025-04-28 18:00:00.000', 
 'Economy', 'G5', 1580000, '0934567890', 'HOANG MINH TRANG', '087345678901', 'hoangdung', 1),

('VU 481', 'Vietravel Airlines', 'DAD', 'HAN', '2025-04-28 16:30:00.000', '2025-04-28 18:00:00.000', 
 'Economy', 'G9', 1580000, '0945678901', 'PHAM VAN TRUNG', '088456789012', 'lethuynh', 1),

-- Vé cho các chuyến bay trong tháng hiện tại
('VN 192', 'Vietnam Airlines', 'HAN', 'CXR', '2025-05-02 09:30:00.000', '2025-05-02 11:00:00.000', 
 'Economy', 'G1', 1720000, '0956789012', 'NGUYEN VAN BINH', '089567890123', 'phamquynh', 1),

('VN 192', 'Vietnam Airlines', 'HAN', 'CXR', '2025-05-02 09:30:00.000', '2025-05-02 11:00:00.000', 
 'Economy', 'G2', 1720000, '0967890123', 'TRAN THI HANG', '090678901234', 'nguyenthuy', 1),

('VN 192', 'Vietnam Airlines', 'HAN', 'CXR', '2025-05-02 09:30:00.000', '2025-05-02 11:00:00.000', 
 'Economy', 'G4', 1720000, '0978901234', 'LE THANH TUNG', '091789012345', 'duonghieu', 1),

('VN 192', 'Vietnam Airlines', 'HAN', 'CXR', '2025-05-02 09:30:00.000', '2025-05-02 11:00:00.000', 
 'Economy', 'G8', 1720000, '0989012345', 'PHAM THI MAI', '092890123456', 'vohong', 1),

('VJ 427', 'Vietjet', 'SGN', 'HPH', '2025-05-10 11:20:00.000', '2025-05-10 13:15:00.000', 
 'Economy', 'G1', 1395000, '0990123456', 'NGUYEN HOANG NAM', '093901234567', 'buiphuong', 1),

('VJ 427', 'Vietjet', 'SGN', 'HPH', '2025-05-10 11:20:00.000', '2025-05-10 13:15:00.000', 
 'Economy', 'G3', 1395000, '0901234567', 'TRAN VAN PHONG', '094012345678', 'phamxuan', 1),

('VJ 427', 'Vietjet', 'SGN', 'HPH', '2025-05-10 11:20:00.000', '2025-05-10 13:15:00.000', 
 'Economy', 'G9', 1395000, '0912345671', 'LE THI KIM NGOC', '095123456789', 'tranminh', 0),

('QH 318', 'Bamboo Airways', 'HAN', 'PQC', '2025-05-13 13:45:00.000', '2025-05-13 15:30:00.000', 
 'Economy', 'G2', 2150000, '0923456782', 'NGUYEN VAN MANH', '096234567890', 'ngocanh', 0),

('QH 318', 'Bamboo Airways', 'HAN', 'PQC', '2025-05-13 13:45:00.000', '2025-05-13 15:30:00.000', 
 'Economy', 'G9', 2150000, '0934567893', 'PHAM THI THANH', '097345678901', 'hoangdung', 0),

('BL 724', 'Pacific Airlines', 'DAD', 'SGN', '2025-05-17 07:50:00.000', '2025-05-17 09:10:00.000', 
 'Economy', 'G4', 1180000, '0945678914', 'TRAN QUOC BAO', '098456789012', 'lethuynh', 0),

('BL 724', 'Pacific Airlines', 'DAD', 'SGN', '2025-05-17 07:50:00.000', '2025-05-17 09:10:00.000', 
 'Economy', 'G9', 1180000, '0956789125', 'NGUYEN ANH TUAN', '099567890123', 'phamquynh', 0),

('VU 502', 'Vietravel Airlines', 'SGN', 'VII', '2025-05-20 15:30:00.000', '2025-05-20 16:45:00.000', 
 'Economy', 'G1', 1460000, '0967890136', 'LE VAN HUNG', '100678901234', 'nguyenthuy', 0),

('VU 502', 'Vietravel Airlines', 'SGN', 'VII', '2025-05-20 15:30:00.000', '2025-05-20 16:45:00.000', 
 'Economy', 'G3', 1460000, '0978901247', 'TRAN THI HUONG', '101789012345', 'duonghieu', 0),

('VU 502', 'Vietravel Airlines', 'SGN', 'VII', '2025-05-20 15:30:00.000', '2025-05-20 16:45:00.000', 
 'Economy', 'G9', 1460000, '0989012358', 'PHAM VAN TIEN', '102890123456', 'vohong', 0),

('VN 360', 'Vietnam Airlines', 'HAN', 'DLI', '2025-05-23 10:00:00.000', '2025-05-23 11:45:00.000', 
 'Economy', 'G3', 1870000, '0990123469', 'NGUYEN THI THUY', '103901234567', 'buiphuong', 0),

('VN 360', 'Vietnam Airlines', 'HAN', 'DLI', '2025-05-23 10:00:00.000', '2025-05-23 11:45:00.000', 
 'Economy', 'G9', 1870000, '0901234570', 'TRAN VAN LONG', '104012345678', 'phamxuan', 0),

('VJ 539', 'Vietjet', 'SGN', 'BMV', '2025-05-27 09:15:00.000', '2025-05-27 10:30:00.000', 
 'Economy', 'G9', 1350000, '0912345681', 'LE THI HONG', '105123456789', 'tranminh', 0);
GO

INSERT INTO Table_FeedbackDatabase
    (FullName, PhoneNumber, Type, Detail, Status)
VALUES
    -- Lỗi đặt vé
    (N'Nguyen Van Minh',   '0912345678', N'Lỗi đặt vé',        N'Không thể thanh toán vé sau khi chọn ghế',                0),
    (N'Tran Thi Huong',    '0923456789', N'Lỗi đặt vé',        N'Hệ thống báo lỗi khi đặt vé cho chuyến bay VN 192',      0),
    (N'Le Van Quang',      '0934567890', N'Lỗi đặt vé',        N'Đã thanh toán nhưng không nhận được mã vé',             0),
    (N'Pham Thi Mai',      '0945678901', N'Lỗi đặt vé',        N'Không thể chọn ghế khi đặt vé chuyến bay VJ 427',        1),
    (N'Hoang Van Nam',     '0956789012', N'Lỗi đặt vé',        N'Mã giảm giá không được áp dụng khi thanh toán',         0),
    
    -- Lỗi hệ thống
    (N'Vo Thi Lan',        '0967890123', N'Lỗi hệ thống',      N'Trang web bị treo khi tìm kiếm chuyến bay',              0),
    (N'Nguyen Minh Tuan',  '0978901234', N'Lỗi hệ thống',      N'Không thể đăng nhập vào tài khoản',                     1),
    (N'Tran Van Hung',     '0989012345', N'Lỗi hệ thống',      N'Ứng dụng bị đóng đột ngột khi thay đổi thông tin cá nhân', 0),
    (N'Le Thi Hong',       '0990123456', N'Lỗi hệ thống',      N'Không hiển thị danh sách chuyến bay sau khi tìm kiếm',   0),
    (N'Pham Quoc Bao',     '0901234567', N'Lỗi hệ thống',      N'Không thể truy cập lịch sử đặt vé',                     0),
    
    -- Góp ý tính năng
    (N'Nguyen Van Hai',    '0912345670', N'Góp ý tính năng',   N'Cần bổ sung tính năng lưu thông tin hành khách thường xuyên', 1),
    (N'Tran Thi Ngoc',     '0923456781', N'Góp ý tính năng',   N'Thêm chức năng nhắc nhở trước chuyến bay qua SMS',       0),
    (N'Le Minh Tung',      '0934567892', N'Góp ý tính năng',   N'Nên có tùy chọn đặt suất ăn đặc biệt trong quá trình đặt vé', 0),
    (N'Pham Thu Ha',       '0945678903', N'Góp ý tính năng',   N'Cần có hệ thống so sánh giá vé giữa các ngày',         0),
    (N'Hoang Minh Duc',    '0956789014', N'Góp ý tính năng',   N'Bổ sung chức năng đặt vé theo nhóm',                    1),
    
    -- Thắc mắc
    (N'Vo Thanh Trung',    '0967890125', N'Thắc mắc',          N'Chính sách hoàn vé trong trường hợp hủy chuyến bay?',   0),
    (N'Nguyen Thi Thao',   '0978901236', N'Thắc mắc',          N'Giới hạn hành lý cho chuyến bay VN 360?',               1),
    (N'Tran Hoang Nam',    '0989012347', N'Thắc mắc',          N'Làm thế nào để đổi ngày bay sau khi đã đặt vé?',        0),
    (N'Le Quang Vinh',     '0990123458', N'Thắc mắc',          N'Cần giấy tờ gì khi làm thủ tục lên máy bay?',          0),
    (N'Pham Van Long',     '0901234569', N'Thắc mắc',          N'Chuyến bay có bị hoãn do điều kiện thời tiết không?',   0),
    
    -- Khác
    (N'Nguyen Thanh Tung', '0912345682', N'Khác',              N'Cảm ơn dịch vụ khách hàng tuyệt vời',                  1),
    (N'Tran Mai Phuong',   '0923456793', N'Khác',              N'Đề xuất mở thêm đường bay mới đến Côn Đảo',            0),
    (N'Le Van Cuong',      '0934567804', N'Khác',              N'Phản hồi về chất lượng bữa ăn trên chuyến bay',        0),
    (N'Pham Thi Huyen',    '0945678915', N'Khác',              N'Góp ý về nhân viên phục vụ tại sân bay',               0),
    (N'Hoang Thu Trang',   '0956789126', N'Khác',              N'Đề xuất thay đổi quy trình check-in',                 0);
GO