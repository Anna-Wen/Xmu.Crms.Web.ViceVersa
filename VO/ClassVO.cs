using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class ClassVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int NumStudent { get; set; }
        public string Time { get; set; }
        public string Site { get; set; }
        public string Roster { get; set; }
        public GradeProportionVO Proportions { get; set; }

       
        public ClassVO(long id, string name, int numStudent, string time, string site, string roster, GradeProportionVO proportions) 
        {
            Id = id;
            Name = name;
            NumStudent = numStudent;
            Time = time;
            Site = site;
            Roster = roster;
            Proportions = proportions;
        }

        public static implicit operator ClassVO(ClassInfo v)
        {
            int report = v.ReportPercentage == null ? 0:(int)v.ReportPercentage;
            int present = v.PresentationPercentage == null ? 0 : (int)v.PresentationPercentage;
            int three = v.ThreePointPercentage == null ? 0 : (int)v.ThreePointPercentage;
            int four = v.FourPointPercentage == null ? 0 : (int)v.FourPointPercentage;
            int five = v.FivePointPercentage == null ? 0 : (int)v.FivePointPercentage;
            GradeProportionVO gradeProportionVO = new GradeProportionVO(report,present,three,four,five);
            ClassVO classVO = new ClassVO(v.Id, v.Name, 0, v.ClassTime, v.Site,"学生名单",gradeProportionVO);
            return classVO;
        }
    }
}