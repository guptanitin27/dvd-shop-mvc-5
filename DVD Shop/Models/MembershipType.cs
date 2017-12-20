using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVD_Shop.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }// few membership type
        [Required]
        public string Name { get; set; }
        public short SignUpFee { get; set; }//shor : we don't need value more than 32000
        public byte DurationInMonths { get; set; }// max number 12 months
        public byte DiscountRate { get; set; }// 0 - 100 %


        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;



    }
}