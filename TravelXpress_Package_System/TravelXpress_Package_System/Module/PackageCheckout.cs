using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelXpress_Package_System.Module
{
    public class PackageCheckout
    {
        public string PackageID { get; set; }
        public string BookingType { get; set; } = "Package";
        public CustomerDetails CustomerDetails { get; set; }
        public List<CustomerMemberDetails> CustomerMembersDetails { get; set; }
        public DateTime bookingDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SelectedPackageRoom SelectedPackageRoom { get; set; } = new SelectedPackageRoom();
        public int numPax {  get; set; }
        public double packageAmount { get; set; }
        public double roomAmount { get; set; } = 0;
        public double totalAmount { get; set; } 
        public string paymentMethod { get; set; }
    }
}
