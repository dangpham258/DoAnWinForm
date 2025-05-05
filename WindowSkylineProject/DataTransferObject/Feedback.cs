using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public string Detail { get; set; }
        public byte Status { get; set; } = 0;
        public Feedback(string name, string phoneNumber, string message, string detail)
        {
            FullName = name;
            PhoneNumber = phoneNumber;
            Type = message;
            Detail = detail;
        }
    }
}
