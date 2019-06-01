namespace TourabuTool
{
    partial class AskForm
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
            this.AskButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.CopyLabel = new System.Windows.Forms.Label();
            this.UpdoButton = new System.Windows.Forms.Button();
            this.ClearUpdoButton = new System.Windows.Forms.Button();
            this.SpadesButton = new System.Windows.Forms.Button();
            this.PlumButton = new System.Windows.Forms.Button();
            this.HeartButton = new System.Windows.Forms.Button();
            this.BrickButton = new System.Windows.Forms.Button();
            this.PokerDiceButton = new System.Windows.Forms.Button();
            this.SmallDiceButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.DialogForSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.ShowRecordButton = new System.Windows.Forms.Button();
            this.ClearShowButton = new System.Windows.Forms.Button();
            this.ReadMeShowButton = new System.Windows.Forms.Button();
            this.BackgroundWorkerForShowRecord = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // AskButton
            // 
            this.AskButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AskButton.Location = new System.Drawing.Point(776, 7);
            this.AskButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AskButton.Name = "AskButton";
            this.AskButton.Size = new System.Drawing.Size(50, 22);
            this.AskButton.TabIndex = 1;
            this.AskButton.Text = "GO";
            this.AskButton.UseVisualStyleBackColor = true;
            this.AskButton.Click += new System.EventHandler(this.AskButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputTextBox.Location = new System.Drawing.Point(12, 37);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextBox.Size = new System.Drawing.Size(870, 278);
            this.InputTextBox.TabIndex = 3;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputTextBox.Location = new System.Drawing.Point(12, 355);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(870, 278);
            this.OutputTextBox.TabIndex = 4;
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CopyLabel.Location = new System.Drawing.Point(142, 9);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(60, 17);
            this.CopyLabel.TabIndex = 2;
            this.CopyLabel.Text = "可複製：";
            // 
            // UpdoButton
            // 
            this.UpdoButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UpdoButton.Location = new System.Drawing.Point(12, 7);
            this.UpdoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdoButton.Name = "UpdoButton";
            this.UpdoButton.Size = new System.Drawing.Size(50, 22);
            this.UpdoButton.TabIndex = 5;
            this.UpdoButton.Text = "還原";
            this.UpdoButton.UseVisualStyleBackColor = true;
            this.UpdoButton.Click += new System.EventHandler(this.UpdoButton_Click);
            // 
            // ClearUpdoButton
            // 
            this.ClearUpdoButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearUpdoButton.Location = new System.Drawing.Point(68, 7);
            this.ClearUpdoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearUpdoButton.Name = "ClearUpdoButton";
            this.ClearUpdoButton.Size = new System.Drawing.Size(68, 22);
            this.ClearUpdoButton.TabIndex = 6;
            this.ClearUpdoButton.Text = "取消還原";
            this.ClearUpdoButton.UseVisualStyleBackColor = true;
            this.ClearUpdoButton.Click += new System.EventHandler(this.ClearUpdoButton_Click);
            // 
            // SpadesButton
            // 
            this.SpadesButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SpadesButton.Location = new System.Drawing.Point(208, 7);
            this.SpadesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpadesButton.Name = "SpadesButton";
            this.SpadesButton.Size = new System.Drawing.Size(38, 22);
            this.SpadesButton.TabIndex = 7;
            this.SpadesButton.Text = "♠";
            this.SpadesButton.UseVisualStyleBackColor = true;
            this.SpadesButton.Click += new System.EventHandler(this.SpadesButton_Click);
            // 
            // PlumButton
            // 
            this.PlumButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlumButton.Location = new System.Drawing.Point(252, 7);
            this.PlumButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlumButton.Name = "PlumButton";
            this.PlumButton.Size = new System.Drawing.Size(38, 22);
            this.PlumButton.TabIndex = 8;
            this.PlumButton.Text = "♣";
            this.PlumButton.UseVisualStyleBackColor = true;
            this.PlumButton.Click += new System.EventHandler(this.PlumButton_Click);
            // 
            // HeartButton
            // 
            this.HeartButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeartButton.Location = new System.Drawing.Point(296, 7);
            this.HeartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeartButton.Name = "HeartButton";
            this.HeartButton.Size = new System.Drawing.Size(38, 22);
            this.HeartButton.TabIndex = 9;
            this.HeartButton.Text = "♥";
            this.HeartButton.UseVisualStyleBackColor = true;
            this.HeartButton.Click += new System.EventHandler(this.HeartButton_Click);
            // 
            // BrickButton
            // 
            this.BrickButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BrickButton.Location = new System.Drawing.Point(340, 7);
            this.BrickButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrickButton.Name = "BrickButton";
            this.BrickButton.Size = new System.Drawing.Size(38, 22);
            this.BrickButton.TabIndex = 10;
            this.BrickButton.Text = "♦";
            this.BrickButton.UseVisualStyleBackColor = true;
            this.BrickButton.Click += new System.EventHandler(this.BrickButton_Click);
            // 
            // PokerDiceButton
            // 
            this.PokerDiceButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokerDiceButton.Location = new System.Drawing.Point(384, 7);
            this.PokerDiceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PokerDiceButton.Name = "PokerDiceButton";
            this.PokerDiceButton.Size = new System.Drawing.Size(72, 22);
            this.PokerDiceButton.TabIndex = 11;
            this.PokerDiceButton.Text = "(poker)";
            this.PokerDiceButton.UseVisualStyleBackColor = true;
            this.PokerDiceButton.Click += new System.EventHandler(this.PokerDiceButton_Click);
            // 
            // SmallDiceButton
            // 
            this.SmallDiceButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SmallDiceButton.Location = new System.Drawing.Point(462, 7);
            this.SmallDiceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmallDiceButton.Name = "SmallDiceButton";
            this.SmallDiceButton.Size = new System.Drawing.Size(72, 22);
            this.SmallDiceButton.TabIndex = 12;
            this.SmallDiceButton.Text = "(diceNum)";
            this.SmallDiceButton.UseVisualStyleBackColor = true;
            this.SmallDiceButton.Click += new System.EventHandler(this.SmallDiceButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SettingButton.Location = new System.Drawing.Point(832, 7);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(50, 22);
            this.SettingButton.TabIndex = 13;
            this.SettingButton.Text = "設定";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ShowRecordButton
            // 
            this.ShowRecordButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowRecordButton.Location = new System.Drawing.Point(12, 326);
            this.ShowRecordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowRecordButton.Name = "ShowRecordButton";
            this.ShowRecordButton.Size = new System.Drawing.Size(68, 22);
            this.ShowRecordButton.TabIndex = 14;
            this.ShowRecordButton.Text = "顯示紀錄";
            this.ShowRecordButton.UseVisualStyleBackColor = true;
            this.ShowRecordButton.Click += new System.EventHandler(this.ShowRecordButton_Click);
            // 
            // ClearShowButton
            // 
            this.ClearShowButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearShowButton.Location = new System.Drawing.Point(86, 326);
            this.ClearShowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearShowButton.Name = "ClearShowButton";
            this.ClearShowButton.Size = new System.Drawing.Size(68, 22);
            this.ClearShowButton.TabIndex = 15;
            this.ClearShowButton.Text = "清空顯示";
            this.ClearShowButton.UseVisualStyleBackColor = true;
            this.ClearShowButton.Click += new System.EventHandler(this.ClearShowButton_Click);
            // 
            // ReadMeShowButton
            // 
            this.ReadMeShowButton.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReadMeShowButton.Location = new System.Drawing.Point(160, 326);
            this.ReadMeShowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReadMeShowButton.Name = "ReadMeShowButton";
            this.ReadMeShowButton.Size = new System.Drawing.Size(68, 22);
            this.ReadMeShowButton.TabIndex = 16;
            this.ReadMeShowButton.Text = "顯示說明";
            this.ReadMeShowButton.UseVisualStyleBackColor = true;
            this.ReadMeShowButton.Click += new System.EventHandler(this.ReadMeShowButton_Click);
            // 
            // BackgroundWorkerForShowRecord
            // 
            this.BackgroundWorkerForShowRecord.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerForShowRecord_DoWork);
            this.BackgroundWorkerForShowRecord.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerForShowRecord_RunWorkerCompleted);
            // 
            // AskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 645);
            this.Controls.Add(this.ReadMeShowButton);
            this.Controls.Add(this.ClearShowButton);
            this.Controls.Add(this.ShowRecordButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.SmallDiceButton);
            this.Controls.Add(this.PokerDiceButton);
            this.Controls.Add(this.BrickButton);
            this.Controls.Add(this.HeartButton);
            this.Controls.Add(this.PlumButton);
            this.Controls.Add(this.SpadesButton);
            this.Controls.Add(this.ClearUpdoButton);
            this.Controls.Add(this.UpdoButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.AskButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TourabuTool.Properties.Settings.Default, "AskPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::TourabuTool.Properties.Settings.Default.AskPosition;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自娛娛人~";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskForm_FormClosing);
            this.Load += new System.EventHandler(this.AskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AskButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label CopyLabel;
        private System.Windows.Forms.Button UpdoButton;
        private System.Windows.Forms.Button ClearUpdoButton;
        private System.Windows.Forms.Button SpadesButton;
        private System.Windows.Forms.Button PlumButton;
        private System.Windows.Forms.Button HeartButton;
        private System.Windows.Forms.Button BrickButton;
        private System.Windows.Forms.Button PokerDiceButton;
        private System.Windows.Forms.Button SmallDiceButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.OpenFileDialog DialogForSelectFile;
        private System.Windows.Forms.Button ShowRecordButton;
        private System.Windows.Forms.Button ClearShowButton;
        private System.Windows.Forms.Button ReadMeShowButton;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerForShowRecord;
    }
}