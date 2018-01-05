using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class CourseClassVO
    {
        /// <summary>
        /// VO
        /// 课程和班级信息 
        /// @author Group ViceVersa
        /// </summary>
        

        /// <summary>
        /// 根据ClassInfo构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="ClassInfo">班级信息</param>
        /// <param name="numstudent">学生人数</param>
        public CourseClassVO(ClassInfo classInfo,int numstudent)
        {
            Id = classInfo.Id;
            Name = classInfo.Name;
            NumStudent = numstudent;
            Time = classInfo.ClassTime;
            Site = classInfo.Site;
            CourseId = (int)classInfo.Course.Id;
            CourseName = classInfo.Course.Name;
            CourseTeacher = classInfo.Course.Teacher;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int NumStudent { get; set; }
        public string Time { get; set; }
        public string Site { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public UserVO CourseTeacher { get; set; }
    }
}
