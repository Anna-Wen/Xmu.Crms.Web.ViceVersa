using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarGradeVO
    {
        /// <summary>
        /// VO
        ///讨论课分数信息 
        /// @author Group ViceVersa
        /// </summary>
        public SeminarGradeVO()
        {
        }

        public List<int> PresentationGrade { get; set; }
        public int ReportGrade { get; set; }
        public int Grade { get; set; }
    }
}