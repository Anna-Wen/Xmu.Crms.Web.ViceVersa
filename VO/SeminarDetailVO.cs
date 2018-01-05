using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarDetailVO
    {
        /// <summary>
        /// VO
        ///讨论课详细信息
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
    }
}
