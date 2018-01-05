using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SchoolVO
    {
        /// <summary>
        /// VO
        ///学校信息 对应School Model
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }

        /// <summary>
        /// 构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="id">学校id</param>
        /// <param name="name">学校名</param>
        /// <param name="province">省份</param>
        /// <param name="city">城市</param>
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

        /// <summary>
        /// 隐式转换构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="v">学校信息</param>
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