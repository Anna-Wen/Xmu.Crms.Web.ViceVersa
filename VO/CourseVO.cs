using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class CourseVO
    {
        public long Id { get; set; }
        public Teacher Teacher { get; set; }
        public string Name { get; set; }
        public int NumClass { get; set; }
        public int NumStudent { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public GradeProportion Proportions { get; set; }

        public CourseVO(Course course,int numClass,int numStudent)
        {
            Id = course.Id;
            Name = course.Name;
            NumClass = numClass;
            NumStudent = numStudent;
            StartTime = course.StartDate.ToString("yyyy-MM-dd");
            EndTime = course.EndDate.ToString("yyyy-MM-dd");
        }

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