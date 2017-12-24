using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class GroupVO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StudentVO Leader { get; set; }
        public List<StudentVO> Members { get; set; }
        public List<TopicVO> Topics { get; set; }
        public string Report { get; set; }
        public SeminarGradeVO Grade { get; set; }
    }
}