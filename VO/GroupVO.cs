using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class GroupVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public UserVO Leader { get; set; }
        public List<UserVO> Members { get; set; }
        public List<TopicVO> Topics { get; set; }
        public string Report { get; set; }
        public SeminarGradeVO Grade { get; set; }

        // 另，Name的标准解决还没有！！！
        // 不包含Members Topics Name Grade.PresentationGrade
        public static implicit operator GroupVO(SeminarGroup v)
        {
            GroupVO groupVO = new GroupVO { Id = v.Id, Leader = v.Leader, Report = v.Report };

            // Grade (不包含PresentationGrade)

            if (v.ReportGrade == null)
                v.ReportGrade = 0;
            if (v.FinalGrade == null)
                v.FinalGrade = 0;
            SeminarGradeVO seminarGradeVO = new SeminarGradeVO { ReportGrade = (int)v.ReportGrade, Grade = (int)v.FinalGrade };
            groupVO.Grade = seminarGradeVO;

            groupVO.Name = v.Leader.Name + "的小组";


            return groupVO;
        }

        // Name:解决方案是用第一个Topic的Serial和Leader的名字来命名
        public void GetName()
        {
            if (Topics.Count > 0)
                Name = Topics[0].Serial + Leader.Name + "小组";
        }
    }
}