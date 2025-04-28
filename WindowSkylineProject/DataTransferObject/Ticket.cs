using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Ticket
    {
        // Các field (biến thành viên)
        private int ticketId;                // Mã vé (ID tự tăng)
        private string flightNumber;         // Mã chuyến bay
        private string airline;              // Hãng bay
        private string departCode;           // Mã sân bay khởi hành
        private string arriveCode;           // Mã sân bay đến

        private DateTime departureDate;      // Ngày bay đi
        private DateTime arrivalDate;        // Ngày hạ cánh chuyến bay đi


        private string classType;            // Hạng bay (Economy, Business, First Class, ...)
        private string seatNumber;           // Mã ghế (ví dụ: G01 đến G10)
        private int price;                   // Giá vé (kiểu int)

        private string phoneNumber;          // Số điện thoại liên hệ
        private string fullName;             // Họ và tên hành khách
        private string cccd;                 // Căn cước công dân (CCCD)

        private int status;                  // Trạng thái vé: 0 - Chưa dùng, 1 - Đã dùng, 2 - Đã hủy


        // Constructor đầy đủ với tất cả các thông tin (bao gồm ticketId)
        public Ticket(int ticketId, string flightNumber, string airline, string departCode, string arriveCode,
                      DateTime departureDate, DateTime arrivalDate,
                      string classType, string seatNumber, int price,
                      string phoneNumber, string fullName, string cccd, int status = 0)
        {
            this.ticketId = ticketId;
            this.flightNumber = flightNumber;
            this.airline = airline;
            this.departCode = departCode;
            this.arriveCode = arriveCode;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.classType = classType;
            this.seatNumber = seatNumber;
            this.price = price;
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
            this.cccd = cccd;
            this.status = status;
        }

        // Constructor không có ticketId (dùng khi insert mới, vì ticketId sẽ được SQL Server tự tăng)
        public Ticket(string flightNumber, string airline, string departCode, string arriveCode,
                      DateTime departureDate, DateTime arrivalDate,
                      string classType, string seatNumber, int price,
                      string phoneNumber, string fullName, string cccd, int status = 0)
            : this(0, flightNumber, airline, departCode, arriveCode, departureDate, arrivalDate,
                   classType, seatNumber, price, phoneNumber, fullName, cccd, status)
        {
        }

        // Properties (getters và setters)

        public int TicketID
        {
            get { return ticketId; }          // Lấy mã vé
            set { ticketId = value; }         // Gán mã vé
        }

        public string FlightNumber
        {
            get { return flightNumber; }      // Lấy mã chuyến bay
            set { flightNumber = value; }     // Gán mã chuyến bay
        }

        public string Airline
        {
            get { return airline; }           // Lấy hãng bay
            set { airline = value; }          // Gán hãng bay
        }

        public string DepartCode
        {
            get { return departCode; }        // Lấy mã sân bay khởi hành
            set { departCode = value; }       // Gán mã sân bay khởi hành
        }

        public string ArriveCode
        {
            get { return arriveCode; }        // Lấy mã sân bay đến
            set { arriveCode = value; }       // Gán mã sân bay đến
        }

        public DateTime DepartureDate
        {
            get { return departureDate; }     // Lấy ngày bay đi
            set { departureDate = value; }    // Gán ngày bay đi
        }

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }       // Lấy ngày hạ cánh chuyến bay đi
            set { arrivalDate = value; }      // Gán ngày hạ cánh chuyến bay đi
        }

        public string ClassType
        {
            get { return classType; }         // Lấy hạng bay (Economy, Business, ...)
            set { classType = value; }        // Gán hạng bay
        }

        public string SeatNumber
        {
            get { return seatNumber; }        // Lấy mã ghế
            set { seatNumber = value; }       // Gán mã ghế
        }

        public int Price
        {
            get { return price; }             // Lấy giá vé
            set { price = value; }            // Gán giá vé
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }       // Lấy số điện thoại
            set { phoneNumber = value; }      // Gán số điện thoại
        }

        public string FullName
        {
            get { return fullName; }          // Lấy họ và tên
            set { fullName = value; }         // Gán họ và tên
        }

        public string CCCD
        {
            get { return cccd; }              // Lấy căn cước công dân (CCCD)
            set { cccd = value; }             // Gán căn cước công dân (CCCD)
        }

        public int Status
        {
            get { return status; }            // Lấy trạng thái vé
            set { status = value; }           // Gán trạng thái vé
        }
    }
}
