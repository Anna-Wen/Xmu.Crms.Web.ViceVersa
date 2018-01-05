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
        /// С�������Ϣ
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
        /// ����
        /// @author Group ViceVersa
        /// </summary>
        /// <param name="report">�������ռ��</param>
        /// <param name="presentation">չʾ����ռ��</param>
        /// <param name="c">c����ռ��</param>
        /// <param name="b">b����ռ��</param>
        /// <param name="a">a����ռ��</param>
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