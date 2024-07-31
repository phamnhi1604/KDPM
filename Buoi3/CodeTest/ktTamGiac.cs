using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class ktTamGiac
    {
        public string XacDinhTamGiac(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return "Không phải tam giác";

            if (a + b <= c || a + c <= b || b + c <= a)
                return "Không phải tam giác";

            if (a == b && b == c)
                return "Tam giác đều";

            if (a == b || a == c || b == c)
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    return "Tam giác vuông cân";
                return "Tam giác cân";
            }

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                return "Tam giác vuông";

            return "Tam giác thường";
        }
    }
}
