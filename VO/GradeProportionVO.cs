using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class GradeProportionVO
    {
        /// <summary>
        /// VO
        /// 小组分数信息
        /// @author Group ViceVersa
        /// </summary>
        public int Report { get; set; }
        public int Presentation { get; set; }
        public int C { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public GradeProportionVO()
        {
        }
        /// <summary>
        /// 构造
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="report">报告分数占比</param>
        /// <param name="presentation">展示分数占比</param>
        /// <param name="c">c分数占比</param>
        /// <param name="b">b分数占比</param>
        /// <param name="a">a分数占比</param>
        public GradeProportionVO(int report, int presentation, int c, int b, int a)
        {
            Report = report;
            Presentation = presentation;
            C = c;
            B = b;
            A = a;
        }
    }
}