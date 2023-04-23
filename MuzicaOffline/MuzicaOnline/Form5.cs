using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MuzicaOnline
{
    public partial class AlbumInfo1 : Form
    {
        private SoundPlayer sound1, sound2, sound3, sound4, sound5, sound6, sound7, sound8;

        public AlbumInfo1()
        {
            InitializeComponent();
            sound1 = new SoundPlayer("01. Fireworks (I'm The One).wav");
            sound2 = new SoundPlayer("02. The Leaders.wav");
            sound3 = new SoundPlayer("03. Time Of Love.wav");
            sound4 = new SoundPlayer("04. Take Me Home.wav");
            sound5 = new SoundPlayer("05. Celebrate.wav");
            sound6 = new SoundPlayer("06. Take Me Home (English Version).wav");
            sound7 = new SoundPlayer("07. I'm The One (HEAT-TOPPING Version).wav");
            sound8 = new SoundPlayer();
            Video.URL = "ATEEZ(에이티즈) – ‘불놀이야 (Im The One)’ Performance Preview.mp4";
            Video.Ctlcontrols.stop();
        }

        private void Play1_CheckedChanged(object sender, EventArgs e)
        {
            if (Play1.Checked)
            {
                Play1.Text = "⬛";
                sound1.Play();
            }
            else
            {
                Play1.Text = "▶️";
                sound1.Stop();
            }
        }

        private void Play2_CheckedChanged(object sender, EventArgs e)
        {
            if (Play2.Checked)
            {
                Play2.Text = "⬛";
                sound2.Play();
            }
            else
            {
                Play2.Text = "▶️";
                sound2.Stop();
            }
        }

        private void Play3_CheckedChanged(object sender, EventArgs e)
        {
            if (Play3.Checked)
            {
                Play3.Text = "⬛";
                sound3.Play();
            }
            else
            {
                Play3.Text = "▶️";
                sound3.Stop();
            }
        }

        private void Play4_CheckedChanged(object sender, EventArgs e)
        {
            if (Play4.Checked)
            {
                Play4.Text = "⬛";
                sound4.Play();
            }
            else
            {
                Play4.Text = "▶️";
                sound4.Stop();
            }
        }

        private void Play5_CheckedChanged(object sender, EventArgs e)
        {
            if (Play5.Checked)
            {
                Play5.Text = "⬛";
                sound5.Play();
            }
            else
            {
                Play5.Text = "▶️";
                sound5.Stop();
            }
        }

        private void Play6_CheckedChanged(object sender, EventArgs e)
        {
            if (Play6.Checked)
            {
                Play6.Text = "⬛";
                sound6.Play();
            }
            else
            {
                Play6.Text = "▶️";
                sound6.Stop();
            }
        }

        private void Play7_CheckedChanged(object sender, EventArgs e)
        {
            if (Play7.Checked)
            {
                Play7.Text = "⬛";
                sound7.Play();
            }
            else
            {
                Play7.Text = "▶️";
                sound7.Stop();
            }
        }

        private void Play8_CheckedChanged(object sender, EventArgs e)
        {
            if (Play8.Checked)
            {
                Play8.Text = "⬛";
                sound8.Play();
            }
            else
            {
                Play8.Text = "▶️";
                sound8.Stop();
            }
        }

       
    }
}
