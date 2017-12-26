using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SchoolVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }

        public SchoolVO(long id, string name, string province, string city)
        {
            Id = id;
            Name = name;
            Province = province;
            City = city;
        }

        public SchoolVO()
        {
        }

        public static implicit operator SchoolVO(School v)
        {
            if (v != null)
            {
                SchoolVO school = new SchoolVO(v.Id, v.Name, v.Province, v.City);
                return school;
            }
            return new SchoolVO();
        }
    }
}