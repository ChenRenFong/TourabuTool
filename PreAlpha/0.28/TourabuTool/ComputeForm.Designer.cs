﻿namespace TourabuTool
{
    partial class ComputeForm
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
            this.MemberNumberLabel = new System.Windows.Forms.Label();
            this.MemberNumberComboBox = new System.Windows.Forms.ComboBox();
            this.BattleScoreLabel = new System.Windows.Forms.Label();
            this.BattleScoreComboBox = new System.Windows.Forms.ComboBox();
            this.MaxMemberLevelLabel = new System.Windows.Forms.Label();
            this.MaxMemberLevelComboBox = new System.Windows.Forms.ComboBox();
            this.ExtraInformationLabel = new System.Windows.Forms.Label();
            this.ExtraInformationNormalLabel = new System.Windows.Forms.Label();
            this.ExtraInformationNormalBossLabel = new System.Windows.Forms.Label();
            this.ExtraInformationPoliceLabel = new System.Windows.Forms.Label();
            this.ExtraInformationNormalTextBox = new System.Windows.Forms.TextBox();
            this.ExtraInformationNormalBossTextBox = new System.Windows.Forms.TextBox();
            this.ExtraInformationPoliceTextBox = new System.Windows.Forms.TextBox();
            this.OperateLabel = new System.Windows.Forms.Label();
            this.OperateComboBox = new System.Windows.Forms.ComboBox();
            this.FunctionDetailButton = new System.Windows.Forms.Button();
            this.OneBattleTimeLabel = new System.Windows.Forms.Label();
            this.OneBattleTimeTextBox = new System.Windows.Forms.TextBox();
            this.MapCountLabel = new System.Windows.Forms.Label();
            this.MapCountTextBox = new System.Windows.Forms.TextBox();
            this.AverageBattleCountLabel = new System.Windows.Forms.Label();
            this.AverageBattleCountTextBox = new System.Windows.Forms.TextBox();
            this.OneBattleAverageExpLabel = new System.Windows.Forms.Label();
            this.OneBattleAverageExpTextBox = new System.Windows.Forms.TextBox();
            this.OneBossAverageExpLabel = new System.Windows.Forms.Label();
            this.OneBossAverageExpTextBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MemberNumberLabel
            // 
            this.MemberNumberLabel.AutoSize = true;
            this.MemberNumberLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNumberLabel.Location = new System.Drawing.Point(27, 31);
            this.MemberNumberLabel.Name = "MemberNumberLabel";
            this.MemberNumberLabel.Size = new System.Drawing.Size(92, 16);
            this.MemberNumberLabel.TabIndex = 13;
            this.MemberNumberLabel.Text = "隊伍成員數量：";
            // 
            // MemberNumberComboBox
            // 
            this.MemberNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MemberNumberComboBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNumberComboBox.FormattingEnabled = true;
            this.MemberNumberComboBox.Location = new System.Drawing.Point(125, 28);
            this.MemberNumberComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberNumberComboBox.Name = "MemberNumberComboBox";
            this.MemberNumberComboBox.Size = new System.Drawing.Size(38, 24);
            this.MemberNumberComboBox.TabIndex = 16;
            // 
            // BattleScoreLabel
            // 
            this.BattleScoreLabel.AutoSize = true;
            this.BattleScoreLabel.Location = new System.Drawing.Point(27, 63);
            this.BattleScoreLabel.Name = "BattleScoreLabel";
            this.BattleScoreLabel.Size = new System.Drawing.Size(92, 16);
            this.BattleScoreLabel.TabIndex = 17;
            this.BattleScoreLabel.Text = "平均戰鬥評價：";
            // 
            // BattleScoreComboBox
            // 
            this.BattleScoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BattleScoreComboBox.FormattingEnabled = true;
            this.BattleScoreComboBox.Location = new System.Drawing.Point(125, 60);
            this.BattleScoreComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BattleScoreComboBox.Name = "BattleScoreComboBox";
            this.BattleScoreComboBox.Size = new System.Drawing.Size(74, 24);
            this.BattleScoreComboBox.TabIndex = 18;
            // 
            // MaxMemberLevelLabel
            // 
            this.MaxMemberLevelLabel.AutoSize = true;
            this.MaxMemberLevelLabel.Location = new System.Drawing.Point(27, 96);
            this.MaxMemberLevelLabel.Name = "MaxMemberLevelLabel";
            this.MaxMemberLevelLabel.Size = new System.Drawing.Size(92, 16);
            this.MaxMemberLevelLabel.TabIndex = 19;
            this.MaxMemberLevelLabel.Text = "隊中最高等級：";
            // 
            // MaxMemberLevelComboBox
            // 
            this.MaxMemberLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaxMemberLevelComboBox.FormattingEnabled = true;
            this.MaxMemberLevelComboBox.Location = new System.Drawing.Point(125, 93);
            this.MaxMemberLevelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxMemberLevelComboBox.Name = "MaxMemberLevelComboBox";
            this.MaxMemberLevelComboBox.Size = new System.Drawing.Size(59, 24);
            this.MaxMemberLevelComboBox.TabIndex = 20;
            // 
            // ExtraInformationLabel
            // 
            this.ExtraInformationLabel.AutoSize = true;
            this.ExtraInformationLabel.Location = new System.Drawing.Point(332, 218);
            this.ExtraInformationLabel.Name = "ExtraInformationLabel";
            this.ExtraInformationLabel.Size = new System.Drawing.Size(92, 16);
            this.ExtraInformationLabel.TabIndex = 21;
            this.ExtraInformationLabel.Text = "額外經驗加成：";
            // 
            // ExtraInformationNormalLabel
            // 
            this.ExtraInformationNormalLabel.AutoSize = true;
            this.ExtraInformationNormalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ExtraInformationNormalLabel.Location = new System.Drawing.Point(332, 251);
            this.ExtraInformationNormalLabel.Name = "ExtraInformationNormalLabel";
            this.ExtraInformationNormalLabel.Size = new System.Drawing.Size(68, 16);
            this.ExtraInformationNormalLabel.TabIndex = 22;
            this.ExtraInformationNormalLabel.Text = "一般戰鬥：";
            // 
            // ExtraInformationNormalBossLabel
            // 
            this.ExtraInformationNormalBossLabel.AutoSize = true;
            this.ExtraInformationNormalBossLabel.Location = new System.Drawing.Point(332, 286);
            this.ExtraInformationNormalBossLabel.Name = "ExtraInformationNormalBossLabel";
            this.ExtraInformationNormalBossLabel.Size = new System.Drawing.Size(69, 16);
            this.ExtraInformationNormalBossLabel.TabIndex = 23;
            this.ExtraInformationNormalBossLabel.Text = "一般Boss：";
            // 
            // ExtraInformationPoliceLabel
            // 
            this.ExtraInformationPoliceLabel.AutoSize = true;
            this.ExtraInformationPoliceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ExtraInformationPoliceLabel.Location = new System.Drawing.Point(332, 321);
            this.ExtraInformationPoliceLabel.Name = "ExtraInformationPoliceLabel";
            this.ExtraInformationPoliceLabel.Size = new System.Drawing.Size(68, 16);
            this.ExtraInformationPoliceLabel.TabIndex = 26;
            this.ExtraInformationPoliceLabel.Text = "檢非違使：";
            // 
            // ExtraInformationNormalTextBox
            // 
            this.ExtraInformationNormalTextBox.Location = new System.Drawing.Point(406, 248);
            this.ExtraInformationNormalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtraInformationNormalTextBox.Name = "ExtraInformationNormalTextBox";
            this.ExtraInformationNormalTextBox.Size = new System.Drawing.Size(68, 23);
            this.ExtraInformationNormalTextBox.TabIndex = 27;
            this.ExtraInformationNormalTextBox.Text = "1.0";
            this.ExtraInformationNormalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExtraInformationNormalTextBox_KeyPress);
            // 
            // ExtraInformationNormalBossTextBox
            // 
            this.ExtraInformationNormalBossTextBox.Location = new System.Drawing.Point(407, 283);
            this.ExtraInformationNormalBossTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtraInformationNormalBossTextBox.Name = "ExtraInformationNormalBossTextBox";
            this.ExtraInformationNormalBossTextBox.Size = new System.Drawing.Size(68, 23);
            this.ExtraInformationNormalBossTextBox.TabIndex = 28;
            this.ExtraInformationNormalBossTextBox.Text = "1.0";
            this.ExtraInformationNormalBossTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExtraInformationNormalBossTextBox_KeyPress);
            // 
            // ExtraInformationPoliceTextBox
            // 
            this.ExtraInformationPoliceTextBox.Location = new System.Drawing.Point(406, 318);
            this.ExtraInformationPoliceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtraInformationPoliceTextBox.Name = "ExtraInformationPoliceTextBox";
            this.ExtraInformationPoliceTextBox.Size = new System.Drawing.Size(68, 23);
            this.ExtraInformationPoliceTextBox.TabIndex = 31;
            this.ExtraInformationPoliceTextBox.Text = "1.0";
            this.ExtraInformationPoliceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExtraInformationPoliceTextBox_KeyPress);
            // 
            // OperateLabel
            // 
            this.OperateLabel.AutoSize = true;
            this.OperateLabel.Location = new System.Drawing.Point(27, 151);
            this.OperateLabel.Name = "OperateLabel";
            this.OperateLabel.Size = new System.Drawing.Size(68, 16);
            this.OperateLabel.TabIndex = 32;
            this.OperateLabel.Text = "操作模式：";
            // 
            // OperateComboBox
            // 
            this.OperateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperateComboBox.FormattingEnabled = true;
            this.OperateComboBox.Location = new System.Drawing.Point(101, 148);
            this.OperateComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OperateComboBox.Name = "OperateComboBox";
            this.OperateComboBox.Size = new System.Drawing.Size(117, 24);
            this.OperateComboBox.TabIndex = 33;
            // 
            // FunctionDetailButton
            // 
            this.FunctionDetailButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FunctionDetailButton.Location = new System.Drawing.Point(386, 23);
            this.FunctionDetailButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FunctionDetailButton.Name = "FunctionDetailButton";
            this.FunctionDetailButton.Size = new System.Drawing.Size(95, 29);
            this.FunctionDetailButton.TabIndex = 34;
            this.FunctionDetailButton.Text = "詳細計算公式";
            this.FunctionDetailButton.UseVisualStyleBackColor = true;
            // 
            // OneBattleTimeLabel
            // 
            this.OneBattleTimeLabel.AutoSize = true;
            this.OneBattleTimeLabel.Location = new System.Drawing.Point(27, 218);
            this.OneBattleTimeLabel.Name = "OneBattleTimeLabel";
            this.OneBattleTimeLabel.Size = new System.Drawing.Size(164, 16);
            this.OneBattleTimeLabel.TabIndex = 35;
            this.OneBattleTimeLabel.Text = "平均單場戰鬥需時（分鐘）：";
            // 
            // OneBattleTimeTextBox
            // 
            this.OneBattleTimeTextBox.Location = new System.Drawing.Point(197, 215);
            this.OneBattleTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OneBattleTimeTextBox.Name = "OneBattleTimeTextBox";
            this.OneBattleTimeTextBox.Size = new System.Drawing.Size(66, 23);
            this.OneBattleTimeTextBox.TabIndex = 36;
            this.OneBattleTimeTextBox.Text = "1.4";
            this.OneBattleTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneBattleTimeTextBox_KeyPress);
            // 
            // MapCountLabel
            // 
            this.MapCountLabel.AutoSize = true;
            this.MapCountLabel.Location = new System.Drawing.Point(27, 264);
            this.MapCountLabel.Name = "MapCountLabel";
            this.MapCountLabel.Size = new System.Drawing.Size(104, 16);
            this.MapCountLabel.TabIndex = 37;
            this.MapCountLabel.Text = "進入該地圖次數：";
            // 
            // MapCountTextBox
            // 
            this.MapCountTextBox.Location = new System.Drawing.Point(137, 261);
            this.MapCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapCountTextBox.Name = "MapCountTextBox";
            this.MapCountTextBox.Size = new System.Drawing.Size(66, 23);
            this.MapCountTextBox.TabIndex = 38;
            this.MapCountTextBox.Text = "24";
            this.MapCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MapCountTextBox_KeyPress);
            // 
            // AverageBattleCountLabel
            // 
            this.AverageBattleCountLabel.AutoSize = true;
            this.AverageBattleCountLabel.Location = new System.Drawing.Point(27, 297);
            this.AverageBattleCountLabel.Name = "AverageBattleCountLabel";
            this.AverageBattleCountLabel.Size = new System.Drawing.Size(140, 16);
            this.AverageBattleCountLabel.TabIndex = 39;
            this.AverageBattleCountLabel.Text = "該地圖中平均戰鬥場數：";
            // 
            // AverageBattleCountTextBox
            // 
            this.AverageBattleCountTextBox.Location = new System.Drawing.Point(173, 294);
            this.AverageBattleCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AverageBattleCountTextBox.Name = "AverageBattleCountTextBox";
            this.AverageBattleCountTextBox.Size = new System.Drawing.Size(66, 23);
            this.AverageBattleCountTextBox.TabIndex = 40;
            this.AverageBattleCountTextBox.Text = "4";
            this.AverageBattleCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AverageBattleCountTextBox_KeyPress);
            // 
            // OneBattleAverageExpLabel
            // 
            this.OneBattleAverageExpLabel.AutoSize = true;
            this.OneBattleAverageExpLabel.Location = new System.Drawing.Point(27, 347);
            this.OneBattleAverageExpLabel.Name = "OneBattleAverageExpLabel";
            this.OneBattleAverageExpLabel.Size = new System.Drawing.Size(164, 16);
            this.OneBattleAverageExpLabel.TabIndex = 41;
            this.OneBattleAverageExpLabel.Text = "該地圖中平均單場戰鬥經驗：";
            // 
            // OneBattleAverageExpTextBox
            // 
            this.OneBattleAverageExpTextBox.Location = new System.Drawing.Point(197, 344);
            this.OneBattleAverageExpTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OneBattleAverageExpTextBox.Name = "OneBattleAverageExpTextBox";
            this.OneBattleAverageExpTextBox.Size = new System.Drawing.Size(66, 23);
            this.OneBattleAverageExpTextBox.TabIndex = 42;
            this.OneBattleAverageExpTextBox.Text = "500";
            this.OneBattleAverageExpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneBattleAverageExpTextBox_KeyPress);
            // 
            // OneBossAverageExpLabel
            // 
            this.OneBossAverageExpLabel.AutoSize = true;
            this.OneBossAverageExpLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OneBossAverageExpLabel.Location = new System.Drawing.Point(27, 381);
            this.OneBossAverageExpLabel.Name = "OneBossAverageExpLabel";
            this.OneBossAverageExpLabel.Size = new System.Drawing.Size(165, 16);
            this.OneBossAverageExpLabel.TabIndex = 43;
            this.OneBossAverageExpLabel.Text = "該地圖中平均單場Boss經驗：";
            // 
            // OneBossAverageExpTextBox
            // 
            this.OneBossAverageExpTextBox.Location = new System.Drawing.Point(197, 378);
            this.OneBossAverageExpTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OneBossAverageExpTextBox.Name = "OneBossAverageExpTextBox";
            this.OneBossAverageExpTextBox.Size = new System.Drawing.Size(66, 23);
            this.OneBossAverageExpTextBox.TabIndex = 44;
            this.OneBossAverageExpTextBox.Text = "1500";
            this.OneBossAverageExpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneBossAverageExpTextBox_KeyPress);
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GoButton.Location = new System.Drawing.Point(30, 456);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(85, 87);
            this.GoButton.TabIndex = 45;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputTextBox.Location = new System.Drawing.Point(137, 438);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(344, 140);
            this.OutputTextBox.TabIndex = 46;
            // 
            // ComputeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 607);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.OneBossAverageExpTextBox);
            this.Controls.Add(this.OneBossAverageExpLabel);
            this.Controls.Add(this.OneBattleAverageExpTextBox);
            this.Controls.Add(this.OneBattleAverageExpLabel);
            this.Controls.Add(this.AverageBattleCountTextBox);
            this.Controls.Add(this.AverageBattleCountLabel);
            this.Controls.Add(this.MapCountTextBox);
            this.Controls.Add(this.MapCountLabel);
            this.Controls.Add(this.OneBattleTimeTextBox);
            this.Controls.Add(this.OneBattleTimeLabel);
            this.Controls.Add(this.FunctionDetailButton);
            this.Controls.Add(this.OperateComboBox);
            this.Controls.Add(this.OperateLabel);
            this.Controls.Add(this.ExtraInformationPoliceTextBox);
            this.Controls.Add(this.ExtraInformationNormalBossTextBox);
            this.Controls.Add(this.ExtraInformationNormalTextBox);
            this.Controls.Add(this.ExtraInformationPoliceLabel);
            this.Controls.Add(this.ExtraInformationNormalBossLabel);
            this.Controls.Add(this.ExtraInformationNormalLabel);
            this.Controls.Add(this.ExtraInformationLabel);
            this.Controls.Add(this.MaxMemberLevelComboBox);
            this.Controls.Add(this.MaxMemberLevelLabel);
            this.Controls.Add(this.BattleScoreComboBox);
            this.Controls.Add(this.BattleScoreLabel);
            this.Controls.Add(this.MemberNumberComboBox);
            this.Controls.Add(this.MemberNumberLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TourabuTool.Properties.Settings.Default, "ComputePosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::TourabuTool.Properties.Settings.Default.ComputePosition;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputeForm";
            this.Text = "出陣計算器（懶人模式目前尚未完成，自定義模式僅實現部分計算功能）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComputeForm_FormClosing);
            this.Load += new System.EventHandler(this.ComputeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberNumberLabel;
        private System.Windows.Forms.ComboBox MemberNumberComboBox;
        private System.Windows.Forms.Label BattleScoreLabel;
        private System.Windows.Forms.ComboBox BattleScoreComboBox;
        private System.Windows.Forms.Label MaxMemberLevelLabel;
        private System.Windows.Forms.ComboBox MaxMemberLevelComboBox;
        private System.Windows.Forms.Label ExtraInformationLabel;
        private System.Windows.Forms.Label ExtraInformationNormalLabel;
        private System.Windows.Forms.Label ExtraInformationNormalBossLabel;
        private System.Windows.Forms.Label ExtraInformationPoliceLabel;
        private System.Windows.Forms.TextBox ExtraInformationNormalTextBox;
        private System.Windows.Forms.TextBox ExtraInformationNormalBossTextBox;
        private System.Windows.Forms.TextBox ExtraInformationPoliceTextBox;
        private System.Windows.Forms.Label OperateLabel;
        private System.Windows.Forms.ComboBox OperateComboBox;
        private System.Windows.Forms.Button FunctionDetailButton;
        private System.Windows.Forms.Label OneBattleTimeLabel;
        private System.Windows.Forms.TextBox OneBattleTimeTextBox;
        private System.Windows.Forms.Label MapCountLabel;
        private System.Windows.Forms.TextBox MapCountTextBox;
        private System.Windows.Forms.Label AverageBattleCountLabel;
        private System.Windows.Forms.TextBox AverageBattleCountTextBox;
        private System.Windows.Forms.Label OneBattleAverageExpLabel;
        private System.Windows.Forms.TextBox OneBattleAverageExpTextBox;
        private System.Windows.Forms.Label OneBossAverageExpLabel;
        private System.Windows.Forms.TextBox OneBossAverageExpTextBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox OutputTextBox;

    }
}