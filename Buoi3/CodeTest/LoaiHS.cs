using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class LoaiHS
    {
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemRenLuyen { get; set; }

        public LoaiHS(double diemToan, double diemLy, double diemHoa, double diemRenLuyen)
        {
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            DiemRenLuyen = diemRenLuyen;
        }

        public double TinhDiemTrungBinh()
        {
            return (DiemToan + DiemLy + DiemHoa) / 3;
        }

        public string XepLoaiHocLuc()
        {
            double dtb = TinhDiemTrungBinh();
            if (dtb >= 8.0 && dtb <= 10)
                return "Giỏi";
            else if (dtb >= 6.5)
                return "Khá";
            else if (dtb >= 5.0)
                return "Trung Bình";
            else
                return "Yếu";
        }

        public string XepLoaiRenLuyen()
        {
            if (DiemRenLuyen >= 8.0 && DiemRenLuyen <= 10)
                return "Tốt";
            else if (DiemRenLuyen >= 6.5)
                return "Khá";
            else if (DiemRenLuyen >= 5.0)
                return "Trung Bình";
            else
                return "Yếu";
        }

        public string XepLoaiCuoiCung()
        {
            if (DiemToan < 3.0 || DiemLy < 3.0 || DiemHoa < 3.0)
                return "Yếu";

            string hocLuc = XepLoaiHocLuc();
            string renLuyen = XepLoaiRenLuyen();

            if (hocLuc == "Giỏi" && renLuyen == "Tốt")
                return "Giỏi";
            if (hocLuc == "Khá" && (renLuyen == "Tốt" || renLuyen == "Khá"))
                return "Khá";
            if (hocLuc == "Trung Bình" && (renLuyen == "Tốt" || renLuyen == "Khá" || renLuyen == "Trung Bình"))
                return "Trung Bình";

            if (hocLuc == "Giỏi")
                return "Khá";
            if (hocLuc == "Khá")
                return "Trung Bình";

            return "Yếu";
        }
    }
}
