﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeVidProject.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string MembershipName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}