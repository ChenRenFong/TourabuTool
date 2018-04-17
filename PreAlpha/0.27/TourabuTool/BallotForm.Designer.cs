namespace TourabuTool
{
    partial class BallotForm
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
            this.BallotButton = new System.Windows.Forms.Button();
            this.TantouCheckBox = new System.Windows.Forms.CheckBox();
            this.WakizasiCheckBox = new System.Windows.Forms.CheckBox();
            this.UchigatanaCheckBox = new System.Windows.Forms.CheckBox();
            this.TachiCheckBox = new System.Windows.Forms.CheckBox();
            this.OotachiCheckBox = new System.Windows.Forms.CheckBox();
            this.YariCheckBox = new System.Windows.Forms.CheckBox();
            this.NaginataCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.TouhaComboBox = new System.Windows.Forms.ComboBox();
            this.TouhaOnlyLabel = new System.Windows.Forms.Label();
            this.AllChoose = new System.Windows.Forms.Button();
            this.AllCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BallotButton
            // 
            this.BallotButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BallotButton.Location = new System.Drawing.Point(502, 13);
            this.BallotButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BallotButton.Name = "BallotButton";
            this.BallotButton.Size = new System.Drawing.Size(50, 56);
            this.BallotButton.TabIndex = 2;
            this.BallotButton.Text = "GO";
            this.BallotButton.UseVisualStyleBackColor = true;
            this.BallotButton.Click += new System.EventHandler(this.BallotButton_Click);
            // 
            // TantouCheckBox
            // 
            this.TantouCheckBox.AutoSize = true;
            this.TantouCheckBox.Checked = true;
            this.TantouCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TantouCheckBox.Location = new System.Drawing.Point(86, 52);
            this.TantouCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TantouCheckBox.Name = "TantouCheckBox";
            this.TantouCheckBox.Size = new System.Drawing.Size(51, 20);
            this.TantouCheckBox.TabIndex = 3;
            this.TantouCheckBox.Text = "短刀";
            this.TantouCheckBox.UseVisualStyleBackColor = true;
            // 
            // WakizasiCheckBox
            // 
            this.WakizasiCheckBox.AutoSize = true;
            this.WakizasiCheckBox.Checked = true;
            this.WakizasiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WakizasiCheckBox.Location = new System.Drawing.Point(143, 52);
            this.WakizasiCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WakizasiCheckBox.Name = "WakizasiCheckBox";
            this.WakizasiCheckBox.Size = new System.Drawing.Size(51, 20);
            this.WakizasiCheckBox.TabIndex = 4;
            this.WakizasiCheckBox.Text = "脇差";
            this.WakizasiCheckBox.UseVisualStyleBackColor = true;
            // 
            // UchigatanaCheckBox
            // 
            this.UchigatanaCheckBox.AutoSize = true;
            this.UchigatanaCheckBox.Checked = true;
            this.UchigatanaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UchigatanaCheckBox.Location = new System.Drawing.Point(200, 52);
            this.UchigatanaCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UchigatanaCheckBox.Name = "UchigatanaCheckBox";
            this.UchigatanaCheckBox.Size = new System.Drawing.Size(51, 20);
            this.UchigatanaCheckBox.TabIndex = 5;
            this.UchigatanaCheckBox.Text = "打刀";
            this.UchigatanaCheckBox.UseVisualStyleBackColor = true;
            // 
            // TachiCheckBox
            // 
            this.TachiCheckBox.AutoSize = true;
            this.TachiCheckBox.Checked = true;
            this.TachiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TachiCheckBox.Location = new System.Drawing.Point(257, 52);
            this.TachiCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TachiCheckBox.Name = "TachiCheckBox";
            this.TachiCheckBox.Size = new System.Drawing.Size(51, 20);
            this.TachiCheckBox.TabIndex = 6;
            this.TachiCheckBox.Text = "太刀";
            this.TachiCheckBox.UseVisualStyleBackColor = true;
            // 
            // OotachiCheckBox
            // 
            this.OotachiCheckBox.AutoSize = true;
            this.OotachiCheckBox.Checked = true;
            this.OotachiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OotachiCheckBox.Location = new System.Drawing.Point(314, 52);
            this.OotachiCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OotachiCheckBox.Name = "OotachiCheckBox";
            this.OotachiCheckBox.Size = new System.Drawing.Size(63, 20);
            this.OotachiCheckBox.TabIndex = 7;
            this.OotachiCheckBox.Text = "大太刀";
            this.OotachiCheckBox.UseVisualStyleBackColor = true;
            // 
            // YariCheckBox
            // 
            this.YariCheckBox.AutoSize = true;
            this.YariCheckBox.Checked = true;
            this.YariCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.YariCheckBox.Location = new System.Drawing.Point(383, 52);
            this.YariCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YariCheckBox.Name = "YariCheckBox";
            this.YariCheckBox.Size = new System.Drawing.Size(39, 20);
            this.YariCheckBox.TabIndex = 8;
            this.YariCheckBox.Text = "槍";
            this.YariCheckBox.UseVisualStyleBackColor = true;
            // 
            // NaginataCheckBox
            // 
            this.NaginataCheckBox.AutoSize = true;
            this.NaginataCheckBox.Checked = true;
            this.NaginataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NaginataCheckBox.Location = new System.Drawing.Point(428, 52);
            this.NaginataCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NaginataCheckBox.Name = "NaginataCheckBox";
            this.NaginataCheckBox.Size = new System.Drawing.Size(51, 20);
            this.NaginataCheckBox.TabIndex = 9;
            this.NaginataCheckBox.Text = "薙刀";
            this.NaginataCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 53);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(68, 16);
            this.TypeLabel.TabIndex = 12;
            this.TypeLabel.Text = "刀種選擇：";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InformationLabel.Location = new System.Drawing.Point(12, 76);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(0, 61);
            this.InformationLabel.TabIndex = 14;
            // 
            // TouhaComboBox
            // 
            this.TouhaComboBox.FormattingEnabled = true;
            this.TouhaComboBox.Location = new System.Drawing.Point(383, 15);
            this.TouhaComboBox.Name = "TouhaComboBox";
            this.TouhaComboBox.Size = new System.Drawing.Size(96, 24);
            this.TouhaComboBox.TabIndex = 15;
            this.TouhaComboBox.Text = "（不使用）";
            this.TouhaComboBox.SelectedIndexChanged += new System.EventHandler(this.TouhaComboBox_SelectedIndexChanged);
            // 
            // TouhaOnlyLabel
            // 
            this.TouhaOnlyLabel.AutoSize = true;
            this.TouhaOnlyLabel.Location = new System.Drawing.Point(309, 18);
            this.TouhaOnlyLabel.Name = "TouhaOnlyLabel";
            this.TouhaOnlyLabel.Size = new System.Drawing.Size(68, 16);
            this.TouhaOnlyLabel.TabIndex = 16;
            this.TouhaOnlyLabel.Text = "刀派抽籤：";
            // 
            // AllChoose
            // 
            this.AllChoose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AllChoose.Location = new System.Drawing.Point(12, 13);
            this.AllChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllChoose.Name = "AllChoose";
            this.AllChoose.Size = new System.Drawing.Size(65, 25);
            this.AllChoose.TabIndex = 17;
            this.AllChoose.Text = "全刀種";
            this.AllChoose.UseVisualStyleBackColor = true;
            this.AllChoose.Click += new System.EventHandler(this.AllChoose_Click);
            // 
            // AllCancel
            // 
            this.AllCancel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AllCancel.Location = new System.Drawing.Point(83, 13);
            this.AllCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllCancel.Name = "AllCancel";
            this.AllCancel.Size = new System.Drawing.Size(65, 25);
            this.AllCancel.TabIndex = 18;
            this.AllCancel.Text = "全不選";
            this.AllCancel.UseVisualStyleBackColor = true;
            this.AllCancel.Click += new System.EventHandler(this.AllCancel_Click);
            // 
            // BallotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 151);
            this.Controls.Add(this.AllCancel);
            this.Controls.Add(this.AllChoose);
            this.Controls.Add(this.TouhaOnlyLabel);
            this.Controls.Add(this.TouhaComboBox);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NaginataCheckBox);
            this.Controls.Add(this.YariCheckBox);
            this.Controls.Add(this.OotachiCheckBox);
            this.Controls.Add(this.TachiCheckBox);
            this.Controls.Add(this.UchigatanaCheckBox);
            this.Controls.Add(this.WakizasiCheckBox);
            this.Controls.Add(this.TantouCheckBox);
            this.Controls.Add(this.BallotButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TourabuTool.Properties.Settings.Default, "BallotPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::TourabuTool.Properties.Settings.Default.BallotPosition;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BallotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽籤吧！（目前刀派抽籤無法與刀種選擇的標籤一起使用）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BallotForm_FormClosing);
            this.Load += new System.EventHandler(this.BallotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BallotButton;
        private System.Windows.Forms.CheckBox TantouCheckBox;
        private System.Windows.Forms.CheckBox WakizasiCheckBox;
        private System.Windows.Forms.CheckBox UchigatanaCheckBox;
        private System.Windows.Forms.CheckBox TachiCheckBox;
        private System.Windows.Forms.CheckBox OotachiCheckBox;
        private System.Windows.Forms.CheckBox YariCheckBox;
        private System.Windows.Forms.CheckBox NaginataCheckBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.ComboBox TouhaComboBox;
        private System.Windows.Forms.Label TouhaOnlyLabel;
        private System.Windows.Forms.Button AllChoose;
        private System.Windows.Forms.Button AllCancel;
    }
}