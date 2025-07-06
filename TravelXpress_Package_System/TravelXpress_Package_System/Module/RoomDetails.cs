using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelXpress_Package_System
{
    public class RoomDetails
    {
        public string Type { get; set; }        
        public decimal PricePerNight { get; set; } 
        public int NoOfRooms { get; set; }
        public string RAmenities { get; set; }
        public string RFacilities { get; set; }
        public string RBedType { get; set; }

        public decimal TotalAmount => PricePerNight * NoOfRooms;              
    }
}
