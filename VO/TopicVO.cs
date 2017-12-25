using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

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

        public static implicit operator TopicVO(Topic v)
        {
            TopicVO topicVO = new TopicVO { Id = v.Id, Serial = v.Serial, Name = v.Name, Description = v.Description, GroupLimit = v.GroupNumberLimit, GroupMemberLimit = v.GroupStudentLimit };
            // GroupLeft差一个TopicService的方法

            return topicVO;
        }
    }
}