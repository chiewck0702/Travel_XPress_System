using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public class AccommodationCheckout
    {
        public string AccomID { get; set; }
        public string BookingType { get; set; } = "Accommodation";
        public CustomerDetails CustomerDetails { get; set; }        
        public DateTime bookingDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int numPax { get; set; }

        public int DurationDays { get; set; }
        public double totalAmount { get; set; }
        public string paymentMethod { get; set; }

    }
}
