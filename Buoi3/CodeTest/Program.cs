using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //TienDien td = new TienDien();
            //double bill = td.TinhTienDien(55);
            //Console.WriteLine("Electricity bill: {0:0.00} VND\n", bill);
            //Console.ReadLine();

            AmLich a = new AmLich();

            string lunarYear = a.QuyUocAmLich(2020);
            Console.WriteLine("Lunar year: " + lunarYear);
            Console.ReadLine();
        }
    }
}
