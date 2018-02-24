using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrownstoneWWW03.Models
{
    public class Customer
    {
        
        public int ID { get; set; }

        [DisplayName("External ID")]
        public string ExternalID { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(20)]
        [Display(Name= "Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(80)]
        public string Address { get; set; }

        [StringLength(80)]
        [DisplayName("Address Line 2")]
        public string Address2 { get; set; }

        [StringLength(80)]
        public string City { get; set; }

        [StringLength(5)]
        public string State { get; set; }

        [StringLength(12)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(80)]
        [DefaultValue("USA")]
        public string Country { get; set; }

        [StringLength(80)]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [StringLength(80)]
        [DisplayName("Routing Number")]
        public string RouteNumber { get; set; }

        public int ApplicationOrganizationID { get; set; }

        public ApplicationOrganization ApplicationOrganization { get; set; }

    }
}
