namespace TourabuTool
{
    partial class SimulationPathTutorial
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
            this.InformationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InformationTextBox
            // 
            this.InformationTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InformationTextBox.Location = new System.Drawing.Point(12, 12);
            this.InformationTextBox.MaxLength = 327670;
            this.InformationTextBox.Multiline = true;
            this.InformationTextBox.Name = "InformationTextBox";
            this.InformationTextBox.ReadOnly = true;
            this.InformationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InformationTextBox.Size = new System.Drawing.Size(269, 246);
            this.InformationTextBox.TabIndex = 1;
            this.InformationTextBox.TabStop = false;
            // 
            // SimulationPathTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 272);
            this.Controls.Add(this.InformationTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationPathTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "簡單教學";
            this.Load += new System.EventHandler(this.SimulationPathTutorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InformationTextBox;
    }
}