using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class ClassGroupVO
    {
        public ClassGroupVO()
        {
           
        }

        public ClassGroupVO(FixGroup fixGroup, IList<UserInfo> groupMember)
        {
            Members = new List<UserVO>();
           Leader = fixGroup.Leader;
            foreach (UserInfo u in groupMember)
            {
                if (u.Id == Leader.Id) continue;
                Members.Add(u);
            }
        }

        public UserVO Leader { get; set; }
        public List<UserVO> Members { get; set; }
    }
}