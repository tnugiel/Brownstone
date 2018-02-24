using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrownstoneWWW03.Models
{
    public class ApplicationOrganization
    {
        
        public int ID { get; set; }

        [StringLength(80)]
        [Display(Name = "Legal Name")]
        public string Company { get; set; }

        [StringLength(80)]
        public string EIN { get; set; }

        [StringLength(80)]
        public string Address { get; set; }

        [StringLength(80)]
        [Display(Name = "Address Line 2")]
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
        [DisplayName("Merchant ID")]
        public string MerchantID { get; set; }

        [StringLength(80)]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [StringLength(80)]
        [DisplayName("Routing Number")]
        public string RouteNumber { get; set; }


        public ICollection<ApplicationUser> ApplicationUsers { get; set; }


    }
}
