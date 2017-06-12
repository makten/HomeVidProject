using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeVidProject.Models;

namespace HomeVidProject.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customers { get; set; }
    }
}