using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarVO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupingMethod { get; set; }      //只能为random/fixed
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<TopicVO> Topics { get; set; }
        public GradeProportionVO Proportions { get; set; }
    }
}