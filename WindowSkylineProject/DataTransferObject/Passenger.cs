﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Passenger : Person, ILogin
    {
        private string phoneNumber;   // Số điện thoại
        private string fullName;      // Họ và tên
        private string cccd;          // Căn cước công dân (CCCD)

        public string TableInDB => "Table_UserDatabase";

        // Constructor đầy đủ (bao gồm personId)
        public Passenger(int personId, string userName, string password,
                         string phoneNumber, string fullName, string cccd)
            : base(personId, userName, password)
        {
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
            this.cccd = cccd;
        }

        // Constructor không có personId
        public Passenger(string userName, string password, string fullName = null,
                         string phoneNumber = null, string cccd = null)
            : base(userName, password)
        {
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
            this.cccd = cccd;
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }      // Lấy số điện thoại
            set { phoneNumber = value; }     // Gán số điện thoại
        }

        public string FullName
        {
            get { return fullName; }         // Lấy họ và tên
            set { fullName = value; }        // Gán họ và tên
        }

        public string CCCD
        {
            get { return cccd; }             // Lấy căn cước công dân (CCCD)
            set { cccd = value; }            // Gán căn cước công dân (CCCD)
        }
    }
}
