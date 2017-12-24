﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class TopicVO
    {
        public long Id { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupLimit { get; set; }
        public int GroupMemberLimit { get; set; }
        public int GroupLeft { get; set; }
    }
}