namespace TourabuTool
{
    partial class AskFormSetting
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
            this.messageText = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.DialogForSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageText.Location = new System.Drawing.Point(12, 9);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(125, 17);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "目前記錄儲存路徑：";
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(143, 9);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pathText.Size = new System.Drawing.Size(322, 22);
            this.pathText.TabIndex = 1;
            this.pathText.TabStop = false;
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(390, 60);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(75, 23);
            this.DefaultButton.TabIndex = 2;
            this.DefaultButton.Text = "恢復預設";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(15, 60);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(98, 23);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "指定記錄位置";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // AskFormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 95);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.messageText);
            this.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskFormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskFormSetting_FormClosing);
            this.Load += new System.EventHandler(this.AskFormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.OpenFileDialog DialogForSelectFile;
    }
}