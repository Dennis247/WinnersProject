using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinnersProject.Models
{
    public class District : Entity
    {
        [Required]
        public string name { get; set; }
        public string address { get; set; }

        public string pastorInCharge { get; set; }
        public string phoneNumber { get; set; }

        public virtual List<Branch> Branches { get; set; }


        public District()
        {

        }

        public District(string name, string pastorInCharge, string address,string phoneNumber) {
            this.name = name;
            this.address = address;
            this.pastorInCharge = pastorInCharge;
            this.phoneNumber = phoneNumber;
        }
    }
}