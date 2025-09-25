using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT_4_2509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();

            bt.DeBai = "My grandfather was born in China. He came from a very poor family and was (1) _____ of seven children. " +
                       "His parents lived on a small farm. " +
                       "My mother was (7) _____ oldest. My grandmother died recently, and my grandfather lives alone now. " +
                       "He is almost 80, (8) _____ he is still very active and interested in everything (9) _____ is going on. " +
                       "He reads the papers and (10) _____ television even though his eyesight is fairly poor.";

            bt.DapAn = "My grandfather was born in China. He came from a very poor family and was (1) one of seven children. " +
                       "His parents lived on a small farm. " +
                       "My mother was (7) the oldest. My grandmother died recently, and my grandfather lives alone now. " +
                       "He is almost 80, (8) but he is still very active and interested in everything (9) that is going on. " +
                       "He reads the papers and (10) watches television even though his eyesight is fairly poor.";

            List<string> lists = new List<string>()
            {
                "one", "on", "left", "then", "as",
                "married", "the", "but", "that", "watches"
            };

            bt.DapAnTungCau = lists;

            FormDienTu btdt = new FormDienTu(bt);
            btdt.Show();
        }

        private void baiDienTu1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu
            {
                DeBai = "Last weekend my friends and I went camping in the mountains. " +
                "We started early in the morning and (1) _____ a bus to the campsite. " +
                "The weather was nice and the sun (2) _____. " +
                "We (3) _____ our tents near a small river and then (4) _____ lunch together. " +
                "In the afternoon we (5) _____ football and (6) _____ songs by the fire. " +
                "At night the sky was full of stars, so we (7) _____ many photos. " +
                "The next morning we (8) _____ up early, (9) _____ breakfast and (10) _____ home happily.";


                DapAn = "Last weekend my friends and I went camping in the mountains. " +
                "We started early in the morning and (1) took a bus to the campsite. " +
                "The weather was nice and the sun (2) was shining. " +
                "We (3) put up our tents near a small river and then (4) had lunch together. " +
                "In the afternoon we (5) played football and (6) sang songs by the fire. " +
                "At night the sky was full of stars, so we (7) took many photos. " +
                "The next morning we (8) woke up early, (9) made breakfast and (10) went home happily.";


                DapAnTungCau = new List<string>()
                    {
                        "took",      
                        "was shining", 
                        "put up",    
                        "had",       
                        "played",    
                        "sang",      
                        "took",      
                        "woke",      
                        "made",      
                        "went"       
                    }

            };

            FormDienTu btdt = new FormDienTu(bt);
            btdt.Show();
        }
    }
}
