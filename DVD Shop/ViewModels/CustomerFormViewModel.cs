using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DVD_Shop.Models;

namespace DVD_Shop.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        

        public string Title
        {
            get { return Customer.Id != 0 ? "Edit Customer" : "New Customer"; }
        }

        



    }
}