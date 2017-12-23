using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student Leader { get; set; }
        public List<Student> Members { get; set; }
        public List<Topic> Topics { get; set; }
        public string Report { get; set; }
        public SeminarGrade Grade { get; set; }
    }
}