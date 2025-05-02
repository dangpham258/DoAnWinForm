using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Airport
    {
        public string City { get; set; }
        public string Code { get; set; }

        public Airport(string city, string code)
        {
            City = city;
            Code = code;
        }
    }

    public static class AirportData
    {
        public static readonly List<Airport> Airports = new List<Airport>
        {
            new Airport("Hà Nội - HAN", "HAN"),
            new Airport("Hải Phòng - HPH", "HPH"),
            new Airport("Điện Biên - DIN", "DIN"),
            new Airport("Thanh Hóa - THD", "THD"),
            new Airport("Nghệ An - VII", "VII"),
            new Airport("Quảng Bình - VDH", "VDH"),
            new Airport("Thừa Thiên Huế - HUI", "HUI"),
            new Airport("Đà Nẵng - DAD", "DAD"),
            new Airport("Quảng Nam - VCL", "VCL"),
            new Airport("Bình Định - UIH", "UIH"),
            new Airport("Phú Yên - TBB", "TBB"),
            new Airport("Khánh Hòa - CXR", "CXR"),
            new Airport("Đắk Lắk - BMV", "BMV"),
            new Airport("Lâm Đồng - DLI", "DLI"),
            new Airport("Gia Lai - PXU", "PXU"),
            new Airport("TP.HCM - SGN", "SGN"),
            new Airport("Cà Mau - CAH", "CAH"),
            new Airport("Bà Rịa-Vũng Tàu - VCS", "VCS"),
            new Airport("Cần Thơ - VCA", "VCA"),
            new Airport("Kiên Giang (Rạch Giá) - VKG", "VKG"),
            new Airport("Kiên Giang (Phú Quốc) - PQC", "PQC"),
            new Airport("Quảng Ninh - VDO", "VDO")
        };
    }
}
