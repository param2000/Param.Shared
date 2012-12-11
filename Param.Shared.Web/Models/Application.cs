using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Param.Shared.Core;

namespace Param.Shared.Web.Models
{
    public class Application
    {
        [RequiredForCompletnessString(DisplayName = "First Name")]
        public string FirstName { get; set; } 
        public string MiddleName { get; set; }
        [RequiredForCompletnessString]
        public string LastName { get; set; }

        [RequiredForCompletnessInt(0)]
        public int? RequestedMoney { get; set; }

        [RequiredForCompletnessString(DisplayName = " Address Line 1")]
        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set; }

        [RequiredForCompletnessString]
        public string City { get; set; }
        [RequiredForCompletnessString]
        public string State { get; set; } 

        [RequiredForCompleteness]
        public int? Zip { get; set; } 

    }
}