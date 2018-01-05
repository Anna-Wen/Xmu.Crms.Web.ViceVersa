using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarClassesVO
    {
        /// <summary>
        /// VO
        ///班级和讨论课信息 
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<ClassVO> Classes { get; set; } 
    }
}
