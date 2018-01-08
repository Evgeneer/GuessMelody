using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.subfolders = cbSubfolders.Checked;
            Victorina.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        void Set()
        {
            cbSubfolders.Checked = Victorina.subfolders;
            cbGameDuration.Text = Victorina.gameDuration.ToString();
            cbMusicDuration.Text = Victorina.musicDuration.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbSubfolders.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            lbMusic.Items.Clear();
            lbMusic.Items.AddRange(Victorina.list.ToArray());
            Set();
        }
    }
}
