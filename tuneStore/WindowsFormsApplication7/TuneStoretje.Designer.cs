namespace WindowsFormsApplication7
{
    partial class TuneStore
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuTune = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTuneExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpLocate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTuneLocation = new System.Windows.Forms.TextBox();
            this.tbxCurrentSelection = new System.Windows.Forms.TextBox();
            this.cmbAvailableSongs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNowPlaying = new System.Windows.Forms.TextBox();
            this.btnOpenPlaylist = new System.Windows.Forms.Button();
            this.btnSavePlaylist = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rtbTotalTunes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalTunes = new System.Windows.Forms.Label();
            this.cldMain = new System.Windows.Forms.ColorDialog();
            this.ofdSong = new System.Windows.Forms.OpenFileDialog();
            this.sfdPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.ofdPlaylist = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTune,
            this.menuFile,
            this.editToolStripMenuItem,
            this.menuHelp,
            this.menuDebug});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(573, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuTune
            // 
            this.menuTune.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTuneExit});
            this.menuTune.Name = "menuTune";
            this.menuTune.Size = new System.Drawing.Size(73, 20);
            this.menuTune.Text = "TuneStore";
            // 
            // menuTuneExit
            // 
            this.menuTuneExit.Name = "menuTuneExit";
            this.menuTuneExit.Size = new System.Drawing.Size(92, 22);
            this.menuTuneExit.Text = "Exit";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(98, 22);
            this.menuFileSave.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout,
            this.menuHelpLocate});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(109, 22);
            this.menuHelpAbout.Text = "About";
            // 
            // menuHelpLocate
            // 
            this.menuHelpLocate.Name = "menuHelpLocate";
            this.menuHelpLocate.Size = new System.Drawing.Size(109, 22);
            this.menuHelpLocate.Text = "Locate";
            // 
            // menuDebug
            // 
            this.menuDebug.Name = "menuDebug";
            this.menuDebug.Size = new System.Drawing.Size(54, 20);
            this.menuDebug.Text = "Debug";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(213, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 44);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(113, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(85, 44);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 27);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 44);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Volume:";
            // 
            // trbVolume
            // 
            this.trbVolume.Location = new System.Drawing.Point(94, 98);
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(204, 45);
            this.trbVolume.TabIndex = 27;
            this.trbVolume.TickFrequency = 10;
            this.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tune location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Current selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "List of available songs:";
            // 
            // tbxTuneLocation
            // 
            this.tbxTuneLocation.Location = new System.Drawing.Point(29, 160);
            this.tbxTuneLocation.Name = "tbxTuneLocation";
            this.tbxTuneLocation.Size = new System.Drawing.Size(269, 20);
            this.tbxTuneLocation.TabIndex = 31;
            // 
            // tbxCurrentSelection
            // 
            this.tbxCurrentSelection.Location = new System.Drawing.Point(29, 212);
            this.tbxCurrentSelection.Name = "tbxCurrentSelection";
            this.tbxCurrentSelection.Size = new System.Drawing.Size(269, 20);
            this.tbxCurrentSelection.TabIndex = 32;
            // 
            // cmbAvailableSongs
            // 
            this.cmbAvailableSongs.FormattingEnabled = true;
            this.cmbAvailableSongs.Location = new System.Drawing.Point(29, 266);
            this.cmbAvailableSongs.Name = "cmbAvailableSongs";
            this.cmbAvailableSongs.Size = new System.Drawing.Size(269, 21);
            this.cmbAvailableSongs.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Now playing:";
            // 
            // tbxNowPlaying
            // 
            this.tbxNowPlaying.Location = new System.Drawing.Point(386, 43);
            this.tbxNowPlaying.Name = "tbxNowPlaying";
            this.tbxNowPlaying.Size = new System.Drawing.Size(175, 20);
            this.tbxNowPlaying.TabIndex = 35;
            // 
            // btnOpenPlaylist
            // 
            this.btnOpenPlaylist.Location = new System.Drawing.Point(332, 139);
            this.btnOpenPlaylist.Name = "btnOpenPlaylist";
            this.btnOpenPlaylist.Size = new System.Drawing.Size(92, 56);
            this.btnOpenPlaylist.TabIndex = 36;
            this.btnOpenPlaylist.Text = "Open playlist";
            this.btnOpenPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnSavePlaylist
            // 
            this.btnSavePlaylist.Location = new System.Drawing.Point(469, 141);
            this.btnSavePlaylist.Name = "btnSavePlaylist";
            this.btnSavePlaylist.Size = new System.Drawing.Size(92, 56);
            this.btnSavePlaylist.TabIndex = 37;
            this.btnSavePlaylist.Text = "Save playlist";
            this.btnSavePlaylist.UseVisualStyleBackColor = true;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(331, 231);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(92, 56);
            this.btnAddSong.TabIndex = 38;
            this.btnAddSong.Text = "Add a song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.Location = new System.Drawing.Point(469, 228);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(92, 56);
            this.btnSelectSong.TabIndex = 39;
            this.btnSelectSong.Text = "Select song";
            this.btnSelectSong.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(401, 177);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 69);
            this.btnStop.TabIndex = 39;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // rtbTotalTunes
            // 
            this.rtbTotalTunes.Location = new System.Drawing.Point(29, 346);
            this.rtbTotalTunes.Name = "rtbTotalTunes";
            this.rtbTotalTunes.Size = new System.Drawing.Size(532, 102);
            this.rtbTotalTunes.TabIndex = 40;
            this.rtbTotalTunes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total tunes in store:";
            // 
            // lblTotalTunes
            // 
            this.lblTotalTunes.AutoSize = true;
            this.lblTotalTunes.Location = new System.Drawing.Point(132, 330);
            this.lblTotalTunes.Name = "lblTotalTunes";
            this.lblTotalTunes.Size = new System.Drawing.Size(16, 13);
            this.lblTotalTunes.TabIndex = 42;
            this.lblTotalTunes.Text = "...";
            // 
            // ofdSong
            // 
            this.ofdSong.FileName = "openFileDialog1";
            // 
            // ofdPlaylist
            // 
            this.ofdPlaylist.FileName = "openFileDialog1";
            // 
            // TuneStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 467);
            this.Controls.Add(this.lblTotalTunes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbTotalTunes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnSavePlaylist);
            this.Controls.Add(this.btnOpenPlaylist);
            this.Controls.Add(this.tbxNowPlaying);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAvailableSongs);
            this.Controls.Add(this.tbxCurrentSelection);
            this.Controls.Add(this.tbxTuneLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TuneStore";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuTune;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuDebug;
        private System.Windows.Forms.ToolStripMenuItem menuTuneExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuHelpLocate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTuneLocation;
        private System.Windows.Forms.TextBox tbxCurrentSelection;
        private System.Windows.Forms.ComboBox cmbAvailableSongs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNowPlaying;
        private System.Windows.Forms.Button btnOpenPlaylist;
        private System.Windows.Forms.Button btnSavePlaylist;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnSelectSong;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox rtbTotalTunes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalTunes;
        private System.Windows.Forms.ColorDialog cldMain;
        private System.Windows.Forms.OpenFileDialog ofdSong;
        private System.Windows.Forms.SaveFileDialog sfdPlaylist;
        private System.Windows.Forms.OpenFileDialog ofdPlaylist;
    }
}

