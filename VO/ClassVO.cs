using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class ClassVO
    {
        /// <summary>
        /// VO
        /// 班级信息 对应ClassInfo Model
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public int NumStudent { get; set; }
        public string Time { get; set; }
        public string Site { get; set; }
        public string Roster { get; set; }
        public GradeProportionVO Proportions { get; set; }

        /// <summary>
        /// 构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="id">班级id</param>
        /// <param name="name">班级名称</param>
        /// <param name="numStudent">学生人数</param>
        /// <param name="time">上课时间</param>
        /// <param name="site">上课地点</param>
        /// <param name="roster">班级状态</param>
        /// <param name="proportions">评分规则</param>
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

        /// <summary>
        /// 根据ClassInfo构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="ClassInfo">班级信息</param>
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