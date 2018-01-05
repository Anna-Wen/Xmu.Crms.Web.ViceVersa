using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class TopicVO
    {
        /// <summary>
        /// VO
        ///话题信息 对应Topic Model
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupLimit { get; set; }
        public int GroupMemberLimit { get; set; }
        public int GroupLeft { get; set; }

        /// <summary>
        /// 隐式转换构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="v">话题信息</param>
        public static implicit operator TopicVO(Topic v)
        {
            TopicVO topicVO = new TopicVO { Id = v.Id, Serial = v.Serial, Name = v.Name, Description = v.Description, GroupLimit = v.GroupNumberLimit, GroupMemberLimit = v.GroupStudentLimit };
            // GroupLeft差一个TopicService的方法

            return topicVO;
        }
    }
}