using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1809_BAI2
{
    internal class MonHoc
    {
        public string TenMon { get; set; }
        public int SoTC { get; set; }
        public float Diem { get; set; }
        public MonHoc()
        {
            TenMon = "";
            SoTC = 0;
            Diem = 0;
        }
        public MonHoc(string tenMon, int soTC, float diem)
        {
            TenMon = tenMon;
            SoTC = soTC;
            Diem = diem;
        }
        public override string ToString()
        {
            return $"Môn học:{TenMon} ----- Số tín chỉ: {SoTC} ----- Điểm: {Diem}";
        }

        public float getDiem()
        {
            return Diem;
        }
        public int getSoTC()
        {
            return SoTC;
        }
    }
}
