using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TourabuTool
{
    public partial class AskFormSetting : Form
    {
        public AskFormSetting()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void AskFormSetting_Load(object sender, EventArgs e)
        {
            pathText.Text = AskForm.savePath;
        }
        // 將設定項目全部恢復預設
        // 還原項目：紀錄的儲存路徑
        private void DefaultButton_Click(object sender, EventArgs e)
        {
            AskForm.savePath = System.Environment.CurrentDirectory + "\\Record\\record.txt";
            // 還原後更新顯示資訊
            pathText.Text = AskForm.savePath;
        }
        // 改變記錄的存放位置或者是與檔名
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (DialogForSelectFile.ShowDialog() == DialogResult.OK)
            {
                AskForm.savePath = DialogForSelectFile.FileName.ToString();
                // 更新顯示資訊
                pathText.Text = AskForm.savePath;
            }
        }
        // 將設定存至系統變數
        private void AskFormSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.mySettings.SavePath = pathText.Text;
            MainForm.mySettings.Save();
        }
    }
}
