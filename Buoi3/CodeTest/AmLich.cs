using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class AmLich
    {
        public string QuyUocAmLich(int year)
        {

            string[] thienCan = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] diaChi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            int canIndex = (year - 4) % 10;
            int chiIndex = (year - 4) % 12;

            return thienCan[canIndex] + " " + diaChi[chiIndex];
        }
    }
}
