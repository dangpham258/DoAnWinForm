using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class FlightInfo
    {
        private int flightId;                // ID chuyến bay (tự tăng)
        private string flightNumber;         // Mã chuyến bay
        private string departCode;           // Mã sân bay khởi hành
        private string arriveCode;           // Mã sân bay đến

        private int? pilotId;                // Mã thành viên phi công (nullable)
        private string pilotName;            // Tên phi công trưởng (có thể null)

        private int? coPilotId;              // Mã thành viên cơ phó (nullable)
        private string coPilotName;          // Tên cơ phó (có thể null)

        private int? attendantId;            // Mã thành viên tiếp viên (nullable)
        private string attendantName;        // Tên tiếp viên (có thể null)

        private int passengerCount;          // Số lượng khách, mặc định 0

        // Mảng ghế - true nếu ghế đã có người, false nếu ghế trống
        private bool[] seats;                // Mảng 10 ghế từ G1 đến G10

        private int status;                  // Trạng thái vé: 0 - Chưa bay, 1 - Đã bay

        // Constructor đầy đủ với tất cả thông tin (bao gồm flightId)
        public FlightInfo(int flightId, string flightNumber, string departCode, string arriveCode,
                         int? pilotId, string pilotName, int? coPilotId, string coPilotName,
                         int? attendantId, string attendantName, int passengerCount, bool[] seats, int status = 0)
        {
            this.flightId = flightId;
            this.flightNumber = flightNumber;
            this.departCode = departCode;
            this.arriveCode = arriveCode;
            this.pilotId = pilotId;
            this.pilotName = pilotName;
            this.coPilotId = coPilotId;
            this.coPilotName = coPilotName;
            this.attendantId = attendantId;
            this.attendantName = attendantName;
            this.passengerCount = passengerCount;

            // Khởi tạo mảng ghế
            this.seats = new bool[10];
            if (seats != null && seats.Length == 10)
            {
                Array.Copy(seats, this.seats, 10);
            }
            this.status = status;
        }

        // Constructor không có flightId (dùng khi insert mới, vì flightId sẽ được SQL Server tự tăng)
        public FlightInfo(string flightNumber, string departCode, string arriveCode,
                         int? pilotId = null, string pilotName = null, int? coPilotId = null, string coPilotName = null,
                         int? attendantId = null, string attendantName = null, int passengerCount = 0, int status = 0)
            : this(0, flightNumber, departCode, arriveCode, pilotId, pilotName, coPilotId, coPilotName,
                  attendantId, attendantName, passengerCount, new bool[10], status)
        {
        }

        // Constructor tối thiểu chỉ với thông tin chuyến bay (không có thông tin phi hành đoàn)
        public FlightInfo(string flightNumber, string departCode, string arriveCode)
            : this(0, flightNumber, departCode, arriveCode, null, null, null, null,
                  null, null, 0, new bool[10], 0)
        {
        }

        // Properties (getters và setters)
        public int FlightID
        {
            get { return flightId; }
            set { flightId = value; }
        }

        public string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public string DepartCode
        {
            get { return departCode; }
            set { departCode = value; }
        }

        public string ArriveCode
        {
            get { return arriveCode; }
            set { arriveCode = value; }
        }

        public int? PilotID
        {
            get { return pilotId; }
            set { pilotId = value; }
        }

        public string PilotName
        {
            get { return pilotName; }
            set { pilotName = value; }
        }

        public int? CoPilotID
        {
            get { return coPilotId; }
            set { coPilotId = value; }
        }

        public string CoPilotName
        {
            get { return coPilotName; }
            set { coPilotName = value; }
        }

        public int? AttendantID
        {
            get { return attendantId; }
            set { attendantId = value; }
        }

        public string AttendantName
        {
            get { return attendantName; }
            set { attendantName = value; }
        }

        public int PassengerCount
        {
            get { return passengerCount; }
            set { passengerCount = value; }
        }

        public int Status
        {
            get { return status; }            // Lấy trạng thái vé
            set { status = value; }           // Gán trạng thái vé
        }

        // Phương thức để kiểm tra và thiết lập ghế
        public bool IsSeatOccupied(int seatNumber)
        {
            if (seatNumber < 1 || seatNumber > 10)
                throw new ArgumentOutOfRangeException("Số ghế phải từ 1 đến 10");

            return seats[seatNumber - 1];
        }

        public void SetSeatStatus(int seatNumber, bool isOccupied)
        {
            if (seatNumber < 1 || seatNumber > 10)
                throw new ArgumentOutOfRangeException("Số ghế phải từ 1 đến 10");

            seats[seatNumber - 1] = isOccupied;

            // Cập nhật số lượng khách nếu cần
            UpdatePassengerCount();
        }

        // Phương thức hỗ trợ để đếm lại số lượng khách dựa trên ghế đã đặt
        private void UpdatePassengerCount()
        {
            passengerCount = seats.Count(seat => seat);
        }

        // Lấy toàn bộ mảng ghế
        public bool[] GetAllSeats()
        {
            bool[] result = new bool[10];
            Array.Copy(seats, result, 10);
            return result;
        }
    }
}