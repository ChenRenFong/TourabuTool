namespace TourabuTool
{
    partial class SimulationPath
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationPath));
            this.VoiceTimer = new System.Windows.Forms.Timer(this.components);
            this.RealTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.RealTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.HonnmaruComboBox = new System.Windows.Forms.ComboBox();
            this.ToukennComboBox = new System.Windows.Forms.ComboBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.HonnmaruPictureBox = new System.Windows.Forms.PictureBox();
            this.ToukennPictureBox = new System.Windows.Forms.PictureBox();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.axWMP_voice = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWMP_sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.SoundTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HonnmaruPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToukennPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_voice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_sound)).BeginInit();
            this.SuspendLayout();
            // 
            // VoiceTimer
            // 
            this.VoiceTimer.Tick += new System.EventHandler(this.VoiceTimer_Tick);
            // 
            // RealTimeTimer
            // 
            this.RealTimeTimer.Tick += new System.EventHandler(this.RealTimeTimer_Tick);
            // 
            // RealTimeCheckBox
            // 
            this.RealTimeCheckBox.AutoSize = true;
            this.RealTimeCheckBox.Checked = true;
            this.RealTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RealTimeCheckBox.Location = new System.Drawing.Point(12, 12);
            this.RealTimeCheckBox.Name = "RealTimeCheckBox";
            this.RealTimeCheckBox.Size = new System.Drawing.Size(204, 24);
            this.RealTimeCheckBox.TabIndex = 3;
            this.RealTimeCheckBox.Text = "與現實時間同步本丸環境";
            this.RealTimeCheckBox.UseVisualStyleBackColor = true;
            this.RealTimeCheckBox.CheckedChanged += new System.EventHandler(this.RealTimeCheckBox_CheckedChanged);
            // 
            // HonnmaruComboBox
            // 
            this.HonnmaruComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HonnmaruComboBox.FormattingEnabled = true;
            this.HonnmaruComboBox.Location = new System.Drawing.Point(223, 10);
            this.HonnmaruComboBox.Name = "HonnmaruComboBox";
            this.HonnmaruComboBox.Size = new System.Drawing.Size(159, 28);
            this.HonnmaruComboBox.TabIndex = 4;
            this.HonnmaruComboBox.SelectedIndexChanged += new System.EventHandler(this.HonnmaruComboBox_SelectedIndexChanged);
            // 
            // ToukennComboBox
            // 
            this.ToukennComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToukennComboBox.FormattingEnabled = true;
            this.ToukennComboBox.Location = new System.Drawing.Point(783, 10);
            this.ToukennComboBox.Name = "ToukennComboBox";
            this.ToukennComboBox.Size = new System.Drawing.Size(159, 28);
            this.ToukennComboBox.TabIndex = 5;
            this.ToukennComboBox.SelectedIndexChanged += new System.EventHandler(this.ToukennComboBox_SelectedIndexChanged);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(135, 167);
            // 
            // HonnmaruPictureBox
            // 
            this.HonnmaruPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HonnmaruPictureBox.Location = new System.Drawing.Point(0, 50);
            this.HonnmaruPictureBox.Name = "HonnmaruPictureBox";
            this.HonnmaruPictureBox.Size = new System.Drawing.Size(955, 582);
            this.HonnmaruPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HonnmaruPictureBox.TabIndex = 2;
            this.HonnmaruPictureBox.TabStop = false;
            // 
            // ToukennPictureBox
            // 
            this.ToukennPictureBox.Location = new System.Drawing.Point(0, 50);
            this.ToukennPictureBox.Name = "ToukennPictureBox";
            this.ToukennPictureBox.Size = new System.Drawing.Size(490, 582);
            this.ToukennPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ToukennPictureBox.TabIndex = 7;
            this.ToukennPictureBox.TabStop = false;
            this.ToukennPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToukennPictureBox_MouseClick);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(617, 12);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(84, 45);
            this.VolumeTrackBar.TabIndex = 11;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(698, 13);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(34, 20);
            this.VolumeLabel.TabIndex = 12;
            this.VolumeLabel.Text = "Vol";
            // 
            // VoiceCheckBox
            // 
            this.VoiceCheckBox.AutoSize = true;
            this.VoiceCheckBox.Checked = true;
            this.VoiceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VoiceCheckBox.Location = new System.Drawing.Point(485, 12);
            this.VoiceCheckBox.Name = "VoiceCheckBox";
            this.VoiceCheckBox.Size = new System.Drawing.Size(60, 24);
            this.VoiceCheckBox.TabIndex = 8;
            this.VoiceCheckBox.Text = "聲音";
            this.VoiceCheckBox.UseVisualStyleBackColor = true;
            this.VoiceCheckBox.CheckedChanged += new System.EventHandler(this.VoiceCheckBox_CheckedChanged);
            // 
            // SoundCheckBox
            // 
            this.SoundCheckBox.AutoSize = true;
            this.SoundCheckBox.Checked = true;
            this.SoundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundCheckBox.Location = new System.Drawing.Point(551, 12);
            this.SoundCheckBox.Name = "SoundCheckBox";
            this.SoundCheckBox.Size = new System.Drawing.Size(60, 24);
            this.SoundCheckBox.TabIndex = 9;
            this.SoundCheckBox.Text = "音效";
            this.SoundCheckBox.UseVisualStyleBackColor = true;
            this.SoundCheckBox.CheckedChanged += new System.EventHandler(this.SoundCheckBox_CheckedChanged);
            // 
            // axWMP_voice
            // 
            this.axWMP_voice.Enabled = true;
            this.axWMP_voice.Location = new System.Drawing.Point(0, 595);
            this.axWMP_voice.Name = "axWMP_voice";
            this.axWMP_voice.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP_voice.OcxState")));
            this.axWMP_voice.Size = new System.Drawing.Size(37, 37);
            this.axWMP_voice.TabIndex = 13;
            this.axWMP_voice.Visible = false;
            // 
            // axWMP_sound
            // 
            this.axWMP_sound.Enabled = true;
            this.axWMP_sound.Location = new System.Drawing.Point(0, 595);
            this.axWMP_sound.Name = "axWMP_sound";
            this.axWMP_sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP_sound.OcxState")));
            this.axWMP_sound.Size = new System.Drawing.Size(37, 37);
            this.axWMP_sound.TabIndex = 14;
            this.axWMP_sound.Visible = false;
            // 
            // SoundTimer
            // 
            this.SoundTimer.Tick += new System.EventHandler(this.SoundTimer_Tick);
            // 
            // SimulationPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 631);
            this.Controls.Add(this.ToukennPictureBox);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.SoundCheckBox);
            this.Controls.Add(this.VoiceCheckBox);
            this.Controls.Add(this.HonnmaruPictureBox);
            this.Controls.Add(this.ToukennComboBox);
            this.Controls.Add(this.HonnmaruComboBox);
            this.Controls.Add(this.RealTimeCheckBox);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.axWMP_voice);
            this.Controls.Add(this.axWMP_sound);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TourabuTool.Properties.Settings.Default, "PathPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::TourabuTool.Properties.Settings.Default.PathPosition;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationPath";
            this.Text = "模擬~！與心愛的男人永遠在一起~！";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationPath_FormClosing);
            this.Load += new System.EventHandler(this.SimulationPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HonnmaruPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToukennPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_voice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer VoiceTimer;
        private System.Windows.Forms.Timer RealTimeTimer;
        private System.Windows.Forms.CheckBox RealTimeCheckBox;
        private System.Windows.Forms.ComboBox HonnmaruComboBox;
        private System.Windows.Forms.ComboBox ToukennComboBox;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.PictureBox HonnmaruPictureBox;
        private System.Windows.Forms.PictureBox ToukennPictureBox;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.CheckBox VoiceCheckBox;
        private System.Windows.Forms.CheckBox SoundCheckBox;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_voice;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_sound;
        private System.Windows.Forms.Timer SoundTimer;
    }
}