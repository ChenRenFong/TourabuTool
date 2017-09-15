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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckNecessaryData();
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 留意，第一行new的變數要換成namespace的名稱，第二行mySettings的變數也要換成於專案Settings中設定的名稱
            Properties.Settings mySettings = new TourabuTool.Properties.Settings(); 
            mySettings.FormPosition = new Point(this.Location.X, this.Location.Y); 
            mySettings.Save();
        }
        // 檢查必要資料是否存在，以決定是否重新創建
        private void CheckNecessaryData()
        {
            // 檢查名為Record的資料夾是否存在，不存在就創一個
            if (!System.IO.Directory.Exists(@"Record"))
            {
                System.IO.Directory.CreateDirectory(@"Record");
            }
            // 檢查Record的資料夾中是否存在record.txt，不存在就創一個
            if (!System.IO.File.Exists(@"Record\record.txt"))
            {
                System.IO.File.CreateText(@"Record\record.txt");
            }
        }
        // 跳出視窗，供使用者輸入想要的隨機範圍，以供賭刀
        private void BetButton_Click(object sender, EventArgs e)
        {
            BetForm Bet = new BetForm();
            Bet.Show();
        }
        // 跳出視窗，供使用者對本丸成員進行抽籤
        private void BallotButton_Click(object sender, EventArgs e)
        {
            BallotForm GoBallot = new BallotForm();
            GoBallot.Show();
        }
        // 跳出視窗，執行仿噗浪的BZ做出來的功能，預計加入一些自發的改良
        private void AskButton_Click(object sender, EventArgs e)
        {
            AskForm AskSome = new AskForm();
            AskSome.Show();
        }
        // 跳出視窗，顯示歷來的更新紀錄
        private void RecordButton_Click(object sender, EventArgs e)
        {
            ReadMeForm ReadMe = new ReadMeForm();
            ReadMe.Show();
        }
    }
}
