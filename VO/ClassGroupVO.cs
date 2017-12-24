using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class ClassGroupVO
    {
        public UserVO Leader { get; set; }
        public List<UserVO> Members { get; set; }
    }
}