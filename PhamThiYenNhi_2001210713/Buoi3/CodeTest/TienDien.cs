using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class TienDien
    {
        public double TinhTienDien(int kWh)
        {
            double total = 0;

            if (kWh > 400)
            {
                total += (kWh - 400) * 2927;
                kWh = 400;
            }
            if (kWh > 300)
            {
                total += (kWh - 300) * 2834;
                kWh = 300;
            }
            if (kWh > 200)
            {
                total += (kWh - 200) * 2536;
                kWh = 200;
            }
            if (kWh > 100)
            {
                total += (kWh - 100) * 2014;
                kWh = 100;
            }
            if (kWh > 50)
            {
                total += (kWh - 50) * 1734;
                kWh = 50;
            }
            if (kWh > 0)
            {
                total += kWh * 1678;
            }

            return total * 0.1;
        }
    }
}
