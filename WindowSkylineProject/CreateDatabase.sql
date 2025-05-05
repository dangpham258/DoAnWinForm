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
    ('vuvandung',       '123456', 'Pilot',      10, '0987765432', 'Vu Van Dung',         '096789012345');
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

-- Tạo bảng Table_FeedbackDatabase
CREATE TABLE Table_FeedbackDatabase (
    FeedbackId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Type NVARCHAR(100) NOT NULL,
    Detail NVARCHAR(255),
    Status TINYINT NOT NULL DEFAULT 0 -- 0: Chưa đọc, 1: Đã đọc
)