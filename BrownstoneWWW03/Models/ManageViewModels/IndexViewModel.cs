﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrownstoneWWW03.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

    
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        public string Address { get; set; }

        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [DefaultValue("USA")]
        public string Country { get; set; }

        [DisplayName("Merchant ID")]
        public string MerchantID { get; set; }

        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [DisplayName("Routing Number")]
        public string RouteNumber { get; set; }
    }
}
