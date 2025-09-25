using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_4_2509
{
    public class BaiTapDienTu
    {
        private string deBai;
        private string dapAn;
        private List<string> dapAnTungCau;
        public BaiTapDienTu() { }
        public BaiTapDienTu(string deBai, string dapAn) { }
        public BaiTapDienTu(string deBai, string dapAn, List<string> dapAnTungCau) { }
        public string DeBai { get; set; }
        public string DapAn { get; set; }
        public List<string> DapAnTungCau { get; set; }
    }
}
