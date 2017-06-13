﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using HomeVidProject.Models;

namespace HomeVidProject.Models
{
    public class Customer
    {
        public int  Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")][StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? DoB { get; set; }
        
    }
}