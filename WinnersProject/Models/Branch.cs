using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinnersProject.Models
{
    public class Branch : Entity
    {
        [Required]
        public string branchName { get; set; }
        [Required]
        public int DistrictId { get; set; }
        [JsonIgnore]
        public virtual District District { get; set; }

        public Branch()
        {

        }

        public Branch(int DistrictId, string branchName)
        {
            this.DistrictId = DistrictId;
            this.branchName = branchName;
        }




    }
}