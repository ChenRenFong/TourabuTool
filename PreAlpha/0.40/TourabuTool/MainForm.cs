using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TourabuTool
{
    public partial class MainForm : Form
    {
        // 有關於每次開起於上次結束的位置，new後的變數要換成namespace的名稱，第二行mySettings的變數也要換成於專案Settings中設定的名稱
        // 記得Settings.settings的存取修飾詞要改成public，在Settings.settings的頁面有下拉式選單可以選擇
        public static Properties.Settings mySettings = new TourabuTool.Properties.Settings(); 
        // 目前共有多少子視窗（子功能）
        // 編號代表的子視窗：0=賭資材；1=抽刀男；2=更新紀錄；3=出陣計算器；
        const int FormMax = 4;
        // 防止子視窗多開的開啟紀錄表單
        public static bool[] FormOpenList = new bool[FormMax];
        // 防止子視窗多開的開啟紀錄表單
        Form[] FormList = new Form[FormMax];

        public MainForm()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FormMax; i++ )
            {
                FormOpenList[i] = false;
            }
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 第一行mySettings後的變數要換成於專案Settings中設定的名稱
            mySettings.FormPosition = new Point(this.Location.X, this.Location.Y); 
            mySettings.Save();
        }
        // 跳出視窗，供使用者輸入想要的隨機範圍，以供賭刀
        private void BetButton_Click(object sender, EventArgs e)
        {
            if (FormOpenList[0] == false)
            {
                FormOpenList[0] = true;
                BetForm Bet = new BetForm();
                FormList[0] = Bet;
                Bet.Show();
            }
            else
            {
                FormList[0].Activate();
            }
        }
        // 跳出視窗，供使用者對本丸成員進行抽籤
        private void BallotButton_Click(object sender, EventArgs e)
        {
            if (FormOpenList[1] == false)
            {
                FormOpenList[1] = true;
                BallotForm GoBallot = new BallotForm();
                FormList[1] = GoBallot;
                GoBallot.Show();
            }
            else
            {
                FormList[1].Activate();
            }
        }
        // 跳出視窗，顯示歷來的更新紀錄
        private void RecordButton_Click(object sender, EventArgs e)
        {
            if (FormOpenList[2] == false)
            {
                FormOpenList[2] = true;
                ReadMeForm ReadMe = new ReadMeForm();
                FormList[2] = ReadMe;
                ReadMe.Show();
            }
            else
            {
                FormList[2].Activate();
            } 
        }
        // 跳出視窗，執行出陣計算器
        private void ComputeButton_Click(object sender, EventArgs e)
        {
            if (FormOpenList[3] == false)
            {
                FormOpenList[3] = true;
                ComputeForm Compute = new ComputeForm();
                FormList[3] = Compute;
                Compute.Show();
            }
            else
            {
                FormList[3].Activate();
            } 
        }
    }
}
