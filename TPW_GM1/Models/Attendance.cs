using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPW_GM1.Models
{
    public class Attendance: BaseClass
    {
        public ApplicationUser userId { get; set; }
        public DateTime date { get; set; }
        public bool type  { get; set; }
        public Method method { get; set; }

    }
    public enum Method
    {
        QR='Q',
        Manual='M'
    }

}