using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupingMethod { get; set; }      //只能为random/fixed
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<TopicVO> Topics { get; set; }

        public static implicit operator SeminarVO(Seminar v)
        {
            SeminarVO seminarVO = new SeminarVO { Id = v.Id, Name = v.Name, Description = v.Description, StartTime = v.StartTime.ToString("yyyy-MM-dd"), EndTime = v.EndTime.ToString("yyyy-MM-dd") };
            if (v.IsFixed == true)
                seminarVO.GroupingMethod = "固定分组";
            else
                seminarVO.GroupingMethod = "随机分组";

            return seminarVO;
        }
    }
}