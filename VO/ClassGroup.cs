using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class ClassGroup
    {
        public Student Leader { get; set; }
        public List<Student> Members { get; set; }
    }
}