using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DVD_Shop.Models;

namespace DVD_Shop.Dtos
{
    public class CustomerDto
    {
        //copied from customer model
        public int Id { get; set; }

        
        [StringLength(255)]
        public string Name { get; set; }

       //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

    }
}