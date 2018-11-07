namespace TourabuTool
{
    partial class MainForm
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
            this.BetButton = new System.Windows.Forms.Button();
            this.BallotButton = new System.Windows.Forms.Button();
            this.AskButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BetButton
            // 
            this.BetButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BetButton.Location = new System.Drawing.Point(12, 12);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(80, 30);
            this.BetButton.TabIndex = 0;
            this.BetButton.Text = "每日賭賭";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // BallotButton
            // 
            this.BallotButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BallotButton.Location = new System.Drawing.Point(98, 12);
            this.BallotButton.Name = "BallotButton";
            this.BallotButton.Size = new System.Drawing.Size(80, 30);
            this.BallotButton.TabIndex = 1;
            this.BallotButton.Text = "本丸抽籤";
            this.BallotButton.UseVisualStyleBackColor = true;
            this.BallotButton.Click += new System.EventHandler(this.BallotButton_Click);
            // 
            // AskButton
            // 
            this.AskButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AskButton.Location = new System.Drawing.Point(184, 12);
            this.AskButton.Name = "AskButton";
            this.AskButton.Size = new System.Drawing.Size(80, 30);
            this.AskButton.TabIndex = 2;
            this.AskButton.Text = "本丸記事";
            this.AskButton.UseVisualStyleBackColor = true;
            this.AskButton.Click += new System.EventHandler(this.AskButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RecordButton.Location = new System.Drawing.Point(356, 12);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(80, 30);
            this.RecordButton.TabIndex = 3;
            this.RecordButton.Text = "更新紀錄";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InformationLabel.Location = new System.Drawing.Point(12, 55);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(0, 44);
            this.InformationLabel.TabIndex = 4;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComputeButton.Location = new System.Drawing.Point(270, 12);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(80, 30);
            this.ComputeButton.TabIndex = 5;
            this.ComputeButton.Text = "出陣助手";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 53);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.AskButton);
            this.Controls.Add(this.BallotButton);
            this.Controls.Add(this.BetButton);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TourabuTool.Properties.Settings.Default, "FormPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::TourabuTool.Properties.Settings.Default.FormPosition;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "TourabuTool 0.28";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.Button BallotButton;
        private System.Windows.Forms.Button AskButton;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button ComputeButton;
    }
}

