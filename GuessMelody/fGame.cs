﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        int musicDuration = Victorina.musicDuration;
        Random rnd = new Random();
        bool[] players = new bool[2];

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension (WMP.URL);
                Victorina.list.RemoveAt(n);
                lblMelodyCount.Text = Victorina.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
            timer1.Start();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Maximum = Victorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if(progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if(players[0] == false && e.KeyData == Keys.A)
            {
                GamePause();
                players[0] = true;
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Is Player 1 right?";
                if (fm.ShowDialog()==DialogResult.Yes)
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }

            if (players[1] == false && e.KeyData == Keys.L)
            {
                GamePause();
                players[1] = true;
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Is Player 2 right?";
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
        }
    }
}
