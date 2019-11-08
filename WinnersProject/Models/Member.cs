using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WinnersProject.Models
{
    public class Member : Entity
    {
        public string name { get; set; }
        public string address { get; set; }
        public string bustop { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
        public string sex { get; set; }
        public string occupation { get; set; }
        public string servicePreference { get; set; }
        public string wasInvited { get; set; }
        public string cameOnYourOwn { get; set; }
        public string whoInvitedYou { get; set; }
        public string phoneNoOfInvitee { get; set; }

        //Tick as Applicable
        public string newMemberStaus { get; set; }

        public string prayerRequest { get; set; }

        //official use only
        public string officialName { get; set; }
        public string signatureDate { get; set; }

        public string asFirstTimer { get; set; }
        public string asBornAgain { get; set; }

        public string asBothFirstBornAgain { get; set; }

        public int districtId { get; set; }


        public int BranchId { get; set; }
        public Branch Branch { get; set; }


    }
}