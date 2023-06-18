namespace MusicPlayerX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_perv = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.tracklist = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.volume_lbl = new System.Windows.Forms.Label();
            this.hunnid = new System.Windows.Forms.Label();
            this.track_start = new System.Windows.Forms.Label();
            this.track_end = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_perv
            // 
            this.btn_perv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_perv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perv.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perv.Location = new System.Drawing.Point(19, 339);
            this.btn_perv.Name = "btn_perv";
            this.btn_perv.Size = new System.Drawing.Size(90, 42);
            this.btn_perv.TabIndex = 0;
            this.btn_perv.Text = "Perv";
            this.btn_perv.UseVisualStyleBackColor = false;
            this.btn_perv.Click += new System.EventHandler(this.btn_perv_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(125, 339);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(90, 42);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(230, 339);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(90, 42);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Location = new System.Drawing.Point(335, 339);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(90, 42);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(440, 339);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(90, 42);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(545, 339);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(159, 42);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.button2_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(19, 312);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(696, 21);
            this.p_bar.TabIndex = 6;
            this.p_bar.Click += new System.EventHandler(this.p_bar_Click);
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // tracklist
            // 
            this.tracklist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tracklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tracklist.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracklist.FormattingEnabled = true;
            this.tracklist.ItemHeight = 19;
            this.tracklist.Location = new System.Drawing.Point(198, 95);
            this.tracklist.Name = "tracklist";
            this.tracklist.Size = new System.Drawing.Size(431, 152);
            this.tracklist.TabIndex = 7;
            this.tracklist.SelectedIndexChanged += new System.EventHandler(this.tracklist_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pic_art.Location = new System.Drawing.Point(19, 95);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(164, 164);
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            this.pic_art.Click += new System.EventHandler(this.pic_art_Click);
            // 
            // track_volume
            // 
            this.track_volume.BackColor = System.Drawing.Color.DarkTurquoise;
            this.track_volume.Location = new System.Drawing.Point(635, 95);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(69, 164);
            this.track_volume.TabIndex = 10;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // volume_lbl
            // 
            this.volume_lbl.BackColor = System.Drawing.Color.DarkTurquoise;
            this.volume_lbl.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volume_lbl.Location = new System.Drawing.Point(635, 193);
            this.volume_lbl.Name = "volume_lbl";
            this.volume_lbl.Size = new System.Drawing.Size(80, 23);
            this.volume_lbl.TabIndex = 0;
            this.volume_lbl.Text = "Volume";
            this.volume_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.volume_lbl.Click += new System.EventHandler(this.volume_lbl_Click);
            // 
            // hunnid
            // 
            this.hunnid.BackColor = System.Drawing.Color.DarkTurquoise;
            this.hunnid.Font = new System.Drawing.Font("Russo One", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hunnid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hunnid.Location = new System.Drawing.Point(635, 0);
            this.hunnid.Name = "hunnid";
            this.hunnid.Size = new System.Drawing.Size(80, 23);
            this.hunnid.TabIndex = 11;
            this.hunnid.Text = "50%";
            this.hunnid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hunnid.Click += new System.EventHandler(this.hunnid_Click);
            // 
            // track_start
            // 
            this.track_start.AllowDrop = true;
            this.track_start.AutoSize = true;
            this.track_start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.track_start.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_start.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.track_start.Location = new System.Drawing.Point(13, 19);
            this.track_start.Name = "track_start";
            this.track_start.Size = new System.Drawing.Size(116, 36);
            this.track_start.TabIndex = 12;
            this.track_start.Text = "00:00";
            // 
            // track_end
            // 
            this.track_end.AllowDrop = true;
            this.track_end.AutoSize = true;
            this.track_end.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.track_end.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_end.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.track_end.Location = new System.Drawing.Point(599, 19);
            this.track_end.Name = "track_end";
            this.track_end.Size = new System.Drawing.Size(116, 36);
            this.track_end.TabIndex = 13;
            this.track_end.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.hunnid);
            this.panel1.Controls.Add(this.volume_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 221);
            this.panel1.TabIndex = 14;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(727, 66);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(727, 414);
            this.Controls.Add(this.track_end);
            this.Controls.Add(this.track_start);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.tracklist);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_perv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_perv;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox tracklist;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label volume_lbl;
        private System.Windows.Forms.Label hunnid;
        private System.Windows.Forms.Label track_start;
        private System.Windows.Forms.Label track_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

