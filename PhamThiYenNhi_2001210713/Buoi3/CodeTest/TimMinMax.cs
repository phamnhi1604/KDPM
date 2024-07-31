using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class TimMinMax
    {
        public void FMinMax(int a, int b, int c, out int max, out int min)
        {
            max = a;
            min = a;

            // So sánh và cập nhật giá trị max
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            // So sánh và cập nhật giá trị min
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }

            max = Math.Max(a, Math.Max(b, c));

        }
    }
}
