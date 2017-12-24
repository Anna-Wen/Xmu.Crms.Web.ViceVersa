using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class UserVO
    {
        public long Id { get; set; }
        public string Type { get; set; }        //只能是student、teacher
        public string Number { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }      //只能是male、female
        public SchoolVO School { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }

        public UserVO()
        {
        }

        public UserVO(long id, string type, string number, string name, string phone, string email, SchoolVO school, string title, string avatar)
        {
            Id = id;
            Type = type;
            Number = number;
            Name = name;
            Phone = phone;
            Email = email;
            School = school;
            Title = title;
            Avatar = avatar;
        }

        public static implicit operator UserVO(UserInfo v)
        {
            //生成一个不包含Password属性的UserVO对象
            UserVO user = null;
            if (v.Type == Shared.Models.Type.Teacher)
            {
                if (v.Title == Shared.Models.Title.Professer)
                    user = new UserVO(v.Id, "teacher", v.Number, v.Name, v.Phone, v.Email, v.School, "教授", v.Avatar);
                else
                    user = new UserVO(v.Id, "teacher", v.Number, v.Name, v.Phone, v.Email, v.School, "其他", v.Avatar);
            }
            else if (v.Type == Shared.Models.Type.Student)
            {
                if (v.Education == Education.Bachelor)
                    user = new UserVO(v.Id, "student", v.Number, v.Name, v.Phone, v.Email, v.School, "本科", v.Avatar);
                else if (v.Education == Education.Master)
                    user = new UserVO(v.Id, "student", v.Number, v.Name, v.Phone, v.Email, v.School, "研究生", v.Avatar);
                else
                    user = new UserVO(v.Id, "student", v.Number, v.Name, v.Phone, v.Email, v.School, "博士生", v.Avatar);
            }
            else
            {
                user = new UserVO(v.Id, "unbinded", v.Number, v.Name, v.Phone, v.Email, v.School, "", v.Avatar);
            }
            //加Gender属性
            if (v.Gender == Shared.Models.Gender.Male)
                user.Gender = "male";
            else
                user.Gender = "female";

            return user;
        }
    }
}