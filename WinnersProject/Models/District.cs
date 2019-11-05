using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinnersProject.Models
{
    public class District : Entity
    {
        public string name { get; set; }
        public string address { get; set; }

        public string pastorInCharge { get; set; }
        public string phoneNumber { get; set; }

       
    }
}