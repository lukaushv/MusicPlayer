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

namespace MusicPlayerX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
        }

        string[] paths, files;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Multiselect= true };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    tracklist.Items.Add(files[i]);

                }
            }
        }

        private void tracklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[tracklist.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[tracklist.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pic_art_Click(object sender, EventArgs e)
        {

        }

        private void hunnid_Click(object sender, EventArgs e)
        {

        }

        private void btn_perv_Click(object sender, EventArgs e)
        {
            if (tracklist.SelectedIndex > 0)
            {
                tracklist.SelectedIndex = tracklist.SelectedIndex-1;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (tracklist.SelectedIndex < tracklist.Items.Count - 1)
            {
                tracklist.SelectedIndex = tracklist.SelectedIndex+1;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void p_bar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                try
                {
                    track_start.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                    track_end.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = track_volume.Value;
            hunnid.Text = track_volume.Value.ToString()+"%";
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.
                duration * e.X / p_bar.Width;
        }

        private void volume_lbl_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
