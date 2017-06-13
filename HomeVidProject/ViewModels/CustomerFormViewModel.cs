﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeVidProject.Models;

namespace HomeVidProject.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}