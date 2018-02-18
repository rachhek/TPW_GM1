using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPW_GM1.Models
{
    public class BaseClass
    {
        public int ID { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ApplicationUser createdBy { get; set; }
        public DateTime createdAt { get; set; }
        public ApplicationUser modifiedBy { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public int MyProperty { get; set; }
    }
}