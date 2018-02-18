using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPW_GM1.Models
{
    public class Payment:BaseClass
    {
        public ApplicationUser UserId { get; set; }
        public GymRate gymRateId { get; set; }
        public DateTime paymentDate { get; set; }
        public float  discount { get; set; }
        public string discountReason { get; set; }
        public float finalPrice { get; set; }

    }
}