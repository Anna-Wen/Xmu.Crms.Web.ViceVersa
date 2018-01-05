using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarGradeDetailVO
    {
        /// <summary>
        /// VO
        ///讨论课分数信息 
        /// @author Group ViceVersa
        /// </summary>
        public string SeminarName { get; set; }
        public string GroupName { get; set; }
        public string LeaderName { get; set; }
        public int PresentationGrade { get; set; }
        public int ReportGrade { get; set; }
        public int Grade { get; set; }
    }
}
