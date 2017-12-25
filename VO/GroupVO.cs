using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class GroupVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public UserVO Leader { get; set; }
        public List<UserVO> Members { get; set; }
        public List<TopicVO> Topics { get; set; }
        public string Report { get; set; }
        public SeminarGradeVO Grade { get; set; }

        public static implicit operator GroupVO(SeminarGroup v)
        {
            // Group的Name命名方法还没有解决？？？
            GroupVO groupVO = new GroupVO { Id = v.Id };

            return groupVO;
        }
    }
}