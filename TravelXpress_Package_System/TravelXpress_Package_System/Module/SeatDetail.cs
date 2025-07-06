using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelXpress_Package_System
{
    public class SeatDetail
    {
        public string SeatNumber { get; set; }

        public string[] SeatNumberArray { get; set; } = new string[50]; // Assuming 50 seats for simplicity
        public int NumberOfSeats { get; set; }
        public decimal TotalFees { get; set; }
        //public void SeatDetails(string seatNumber, int numberOfSeats, decimal totalFees)
        //{
        //    SeatNumber = seatNumber;
        //    NumberOfSeats = numberOfSeats;
        //    TotalFees = totalFees;
        //}
    }
}
