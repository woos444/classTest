using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{

    public enum enShape
    {

        Rec,
        Tri,
        Cir,
    }
    public static class ShapeMath
    {
        public static double GetArea(enShape shape, double length1 = 1, double length2 = 2)
        {
            switch (shape)
            {
                case enShape.Tri: return length1 * length2 / 2;
                case enShape.Rec: return length1* length2;
                case enShape.Cir: return Math.PI * Math.Pow(length1, 2);
                default: return 0;
            }

          
        }
    }
}
