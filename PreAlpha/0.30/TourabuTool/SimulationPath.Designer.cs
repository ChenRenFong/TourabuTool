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
            this.HonnmaruComboBox = new System.Windows.Forms.ComboBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.HonnmaruPictureBox = new System.Windows.Forms.PictureBox();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.axWMP_voice = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWMP_sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.SoundTimer = new System.Windows.Forms.Timer(this.components);
            this.UiShowLabel = new System.Windows.Forms.Label();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.TutorialLabel = new System.Windows.Forms.Label();
            this.AlwaysSoundTimer = new System.Windows.Forms.Timer(this.components);
            this.axWMP_always_sound = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.HonnmaruPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_voice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_always_sound)).BeginInit();
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
            // HonnmaruComboBox
            // 
            this.HonnmaruComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HonnmaruComboBox.FormattingEnabled = true;
            this.HonnmaruComboBox.Location = new System.Drawing.Point(94, 615);
            this.HonnmaruComboBox.Name = "HonnmaruComboBox";
            this.HonnmaruComboBox.Size = new System.Drawing.Size(159, 28);
            this.HonnmaruComboBox.TabIndex = 4;
            this.HonnmaruComboBox.SelectedIndexChanged += new System.EventHandler(this.HonnmaruComboBox_SelectedIndexChanged);
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
            this.HonnmaruPictureBox.Location = new System.Drawing.Point(0, 0);
            this.HonnmaruPictureBox.Name = "HonnmaruPictureBox";
            this.HonnmaruPictureBox.Size = new System.Drawing.Size(1024, 582);
            this.HonnmaruPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HonnmaruPictureBox.TabIndex = 2;
            this.HonnmaruPictureBox.TabStop = false;
            this.HonnmaruPictureBox.DoubleClick += new System.EventHandler(this.HonnmaruPictureBox_DoubleClick);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(812, 618);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(136, 45);
            this.VolumeTrackBar.TabIndex = 11;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(945, 618);
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
            this.VoiceCheckBox.Location = new System.Drawing.Point(680, 617);
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
            this.SoundCheckBox.Location = new System.Drawing.Point(746, 617);
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
            this.axWMP_voice.Location = new System.Drawing.Point(4, 12);
            this.axWMP_voice.Name = "axWMP_voice";
            this.axWMP_voice.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP_voice.OcxState")));
            this.axWMP_voice.Size = new System.Drawing.Size(37, 37);
            this.axWMP_voice.TabIndex = 13;
            this.axWMP_voice.Visible = false;
            // 
            // axWMP_sound
            // 
            this.axWMP_sound.Enabled = true;
            this.axWMP_sound.Location = new System.Drawing.Point(47, 12);
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
            // UiShowLabel
            // 
            this.UiShowLabel.Location = new System.Drawing.Point(0, 585);
            this.UiShowLabel.Name = "UiShowLabel";
            this.UiShowLabel.Size = new System.Drawing.Size(1024, 20);
            this.UiShowLabel.TabIndex = 15;
            this.UiShowLabel.Text = "︾";
            this.UiShowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UiShowLabel.Click += new System.EventHandler(this.UiShowLabel_Click);
            // 
            // TutorialButton
            // 
            this.TutorialButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TutorialButton.Location = new System.Drawing.Point(12, 615);
            this.TutorialButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Size = new System.Drawing.Size(76, 29);
            this.TutorialButton.TabIndex = 35;
            this.TutorialButton.Text = "簡單教學";
            this.TutorialButton.UseVisualStyleBackColor = true;
            this.TutorialButton.Click += new System.EventHandler(this.TutorialButton_Click);
            // 
            // TutorialLabel
            // 
            this.TutorialLabel.AutoSize = true;
            this.TutorialLabel.Location = new System.Drawing.Point(325, 618);
            this.TutorialLabel.Name = "TutorialLabel";
            this.TutorialLabel.Size = new System.Drawing.Size(281, 20);
            this.TutorialLabel.TabIndex = 36;
            this.TutorialLabel.Text = "滑鼠左鍵雙擊畫面可以與刀刀互動哦！";
            // 
            // AlwaysSoundTimer
            // 
            this.AlwaysSoundTimer.Tick += new System.EventHandler(this.AlwaysSoundTimer_Tick);
            // 
            // axWMP_always_sound
            // 
            this.axWMP_always_sound.Enabled = true;
            this.axWMP_always_sound.Location = new System.Drawing.Point(90, 12);
            this.axWMP_always_sound.Name = "axWMP_always_sound";
            this.axWMP_always_sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP_always_sound.OcxState")));
            this.axWMP_always_sound.Size = new System.Drawing.Size(37, 37);
            this.axWMP_always_sound.TabIndex = 37;
            this.axWMP_always_sound.Visible = false;
            // 
            // SimulationPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 657);
            this.Controls.Add(this.TutorialLabel);
            this.Controls.Add(this.TutorialButton);
            this.Controls.Add(this.UiShowLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.SoundCheckBox);
            this.Controls.Add(this.VoiceCheckBox);
            this.Controls.Add(this.HonnmaruPictureBox);
            this.Controls.Add(this.HonnmaruComboBox);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.axWMP_voice);
            this.Controls.Add(this.axWMP_sound);
            this.Controls.Add(this.axWMP_always_sound);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TourabuTool.Properties.Settings.Default, "PathPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::TourabuTool.Properties.Settings.Default.PathPosition;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationPath";
            this.Text = "模擬~！與心愛的刀男永遠在一起~！（自己點︾再點簡單教學，打開教學視窗自己看著教學客製化啦！我懶得維護那麼多刀男的資料了！）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationPath_FormClosing);
            this.Load += new System.EventHandler(this.SimulationPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HonnmaruPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_voice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_always_sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer VoiceTimer;
        private System.Windows.Forms.Timer RealTimeTimer;
        private System.Windows.Forms.ComboBox HonnmaruComboBox;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.PictureBox HonnmaruPictureBox;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.CheckBox VoiceCheckBox;
        private System.Windows.Forms.CheckBox SoundCheckBox;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_voice;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_sound;
        private System.Windows.Forms.Timer SoundTimer;
        private System.Windows.Forms.Label UiShowLabel;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.Label TutorialLabel;
        private System.Windows.Forms.Timer AlwaysSoundTimer;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_always_sound;
    }
}