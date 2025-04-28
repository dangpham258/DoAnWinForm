using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CrewMember : Person
    {
        // Các field (biến thành viên)
        private string jobType;              // Loại công việc
        private int yearsOfExperience;       // Số năm kinh nghiệm
        private string phoneNumber;          // Số điện thoại liên hệ
        private string fullName;             // Tên của thành viên
        private string cccd;                 // CCCD (Căn cước công dân)
        private int status;               // 1 nếu phi công đó rảnh, 0 nếu không

        // Constructor đầy đủ (bao gồm personId)
        public CrewMember(int personId, string userName, string password, string jobType, int yearsOfExperience, string phoneNumber, string fullName, string cccd, int status) : base(personId, userName, password)
        {
            this.jobType = jobType;
            this.yearsOfExperience = yearsOfExperience;
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
            this.cccd = cccd;
            this.status = status;
        }

        // Constructor không có personId;
        public CrewMember(string userName, string password, string jobType, int yearsOfExperience, string phoneNumber, string fullName, string cccd, int status) : base(userName, password)
        {
            this.jobType = jobType;
            this.yearsOfExperience = yearsOfExperience;
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
            this.cccd = cccd;
            this.status = status;
        }

        // Các properties (getters và setters)
        public string JobType
        {
            get { return jobType; }             // Lấy loại công việc của đội bay
            set { jobType = value; }            // Gán loại công việc
        }

        public int YearsOfExperience
        {
            get { return yearsOfExperience; }   // Lấy số năm kinh nghiệm
            set { yearsOfExperience = value; }  // Gán số năm kinh nghiệm
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }         // Lấy số điện thoại liên hệ
            set { phoneNumber = value; }        // Gán số điện thoại
        }

        public string FullName
        {
            get { return fullName; }            // Lấy tên của thành viên
            set { fullName = value; }           // Gán tên
        }

        public string CCCD
        {
            get { return cccd; }                // Lấy căn cước công dân (CCCD)
            set { cccd = value; }               // Gán căn cước công dân
        }
        public int Status
        {
            get { return status; }                // Lấy status
            set { status = value; }               // Gán status
        }
    }
}
