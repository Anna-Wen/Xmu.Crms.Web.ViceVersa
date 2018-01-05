using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class CourseVO
    {
        /// <summary>
        /// VO
        /// 课程信息 对应Course Model
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public UserVO Teacher { get; set; }
        public string Name { get; set; }
        public int NumClass { get; set; }
        public int NumStudent { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public GradeProportionVO Proportions { get; set; }


        /// <summary>
        /// 根据course、班级数和学生人数构造 
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="course">课程信息</param>
        /// <param name="numClass">班级数</param>
        /// <param name="numStudent">学生人数</param>
        public CourseVO(Course course,int numClass,int numStudent)
        {
            Id = course.Id;
            Name = course.Name;
            NumClass = numClass;
            NumStudent = numStudent;
            StartTime = course.StartDate.ToString("yyyy-MM-dd");
            EndTime = course.EndDate.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 根据course构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="course">课程信息</param>
        public CourseVO(Course course)
        {
            Id = course.Id;
            Name = course.Name;
            StartTime = course.StartDate.ToString("yyyy-MM-dd");
            EndTime = course.EndDate.ToString("yyyy-MM-dd");
            Description = course.Description;
        }
    }
}