using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xmu.Crms.Web.ViceVersa.VO
{
    public class GradeProportionVO
    {
        public GradeProportionVO(int report, int presentation, int c, int b, int a)
        {
            Report = report;
            Presentation = presentation;
            C = c;
            B = b;
            A = a;
        }

        public int Report { get; set; }
        public int Presentation { get; set; }
        public int C { get; set; }
        public int B { get; set; }
        public int A { get; set; }
    }
}