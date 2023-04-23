using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class CheckNums
    {
        public bool CheckCircle(float radius)
        {
            if (radius >= 0) return true;
            return false;
        }

        public bool CheckTriangle(float a, float b, float c)
        {
            if ((a + b > c) & (a + c > b) & (b + c > a) & (a > 0) & (b > 0)&(c > 0)) return true;
            return false;
        }

        public bool CheckRectangular(float a, float b, float c)
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                return true;
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                return true;
            }
            else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return true;
            }
            return false;
        }

    }
}
