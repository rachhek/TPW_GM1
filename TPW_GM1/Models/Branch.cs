using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPW_GM1.Models
{
    public class Branch : BaseClass
    { 
        public string branchName { get; set; }
        public string branchLocation { get; set; }
        public DateTime branchOpenDate { get; set; }
        public string branchLandLine { get; set; }
        public ApplicationUser branchManager { get; set; }
        public string branchaOwner { get; set; }


    }
}
