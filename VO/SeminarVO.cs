using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class SeminarVO
    {
        /// <summary>
        /// VO
        ///讨论课信息 对应Seminar Model
        /// @author Group ViceVersa
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupingMethod { get; set; }      //只能为random/fixed
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public List<TopicVO> Topics { get; set; }

        /// <summary>
        /// 隐式转换构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="v">讨论课信息</param>
        public static implicit operator SeminarVO(Seminar v)
        {
            SeminarVO seminarVO = new SeminarVO { Id = v.Id, Name = v.Name, Description = v.Description, StartTime = v.StartTime.ToString("yyyy-MM-dd"), EndTime = v.EndTime.ToString("yyyy-MM-dd") };
            if (v.IsFixed == true)
                seminarVO.GroupingMethod = "固定分组";
            else
                seminarVO.GroupingMethod = "随机分组";

            return seminarVO;
        }
    }
}