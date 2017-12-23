using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class Student : User
    {
        public Student() => Type = "student";
    }
}
