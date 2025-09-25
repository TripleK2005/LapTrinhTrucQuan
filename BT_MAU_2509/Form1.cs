using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_MAU_2509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cboDrive.Items.AddRange(Directory.GetLogicalDrives());
            if (cboDrive.Items.Count > 0)
                cboDrive.SelectedIndex = 0;
        }

        private void cboDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboFolder.Items.Clear();
                string[] dirs = Directory.GetDirectories(cboDrive.SelectedItem.ToString());
                foreach (string d in dirs)
                {
                    cboFolder.Items.Add(d);
                }
                if (cboFolder.Items.Count > 0)
                    cboFolder.SelectedIndex = 0;
            }
            catch { }
        }

        private void cboFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstSongs.Items.Clear();
                string[] files = Directory.GetFiles(cboFolder.SelectedItem.ToString(), "*.mp3");
                foreach (string f in files)
                {
                    lstSongs.Items.Add(Path.GetFileName(f));
                }
            }
            catch { }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSongs.SelectedItem == null) return;

            string folder = cboFolder.SelectedItem.ToString();
            string songFile = Path.Combine(folder, lstSongs.SelectedItem.ToString());

            // phát nhạc
            axWmp.URL = songFile;
            axWmp.Ctlcontrols.play();

            // load lời (txt hoặc rtf) nếu có
            string nameNoExt = Path.GetFileNameWithoutExtension(songFile);
            string lyricTxt = Path.Combine(folder, nameNoExt + ".txt");
            string lyricRtf = Path.Combine(folder, nameNoExt + ".rtf");

            rtbLyrics.Clear();
            if (File.Exists(lyricTxt))
            {
                rtbLyrics.Text = File.ReadAllText(lyricTxt);
            }
            else if (File.Exists(lyricRtf))
            {
                rtbLyrics.LoadFile(lyricRtf);
            }
        }
    }
}
