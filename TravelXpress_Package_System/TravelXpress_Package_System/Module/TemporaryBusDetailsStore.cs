using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelXpress_Package_System
{
    public class TemporaryBusDetailsStore
    {
        public string busFrom { get; set; }
        public string busTo { get; set; }

        public bool roundTrip { get; set; }
        public DateTime departDate { get; set; }
        public DateTime reDate { get; set; }


        public string ticketID { get; set; }
        public string cusID { get; set; }

        public string bookingID { get; set; }
    }

}
