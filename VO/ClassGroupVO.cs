using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class ClassGroupVO
    {
        /// <summary>
        /// VO
        /// 班级固定分组信息 对应FixGroup Model
        /// @author Group ViceVersa
        /// </summary>
        public ClassGroupVO()
        {
           
        }

        /// <summary>
        /// 根据fixGroup构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="fixGroup">固定分组信息</param>
        /// <param name="groupMember">组员信息</param>
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