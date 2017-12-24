using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class Teacher : User
    {
        public Teacher() => Type = "teacher";
    }
}
