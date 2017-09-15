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
    public partial class BetForm : Form
    {
        bool touken = true;
        bool tousou = false;

        public BetForm()
        {
            InitializeComponent();
        }

        private void BetForm_Load(object sender, EventArgs e)
        {

        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void BetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 留意，第一行new的變數要換成namespace的名稱，第二行mySettings的變數也要換成於專案Settings中設定的名稱
            Properties.Settings mySettings = new TourabuTool.Properties.Settings();
            mySettings.BetPosition = new Point(this.Location.X, this.Location.Y);
            mySettings.Save();
        }
        // 此按鈕表示預設值為鍛刀範圍
        private void ToukenButton_Click(object sender, EventArgs e)
        {
            touken = true;
            tousou = false;

            CharcoalNumTwoTextBox.Text = "999";
            SteelNumTwoTextBox.Text = "999";
            WaterNumTwoTextBox.Text = "999";
            StoneNumTwoTextBox.Text = "999";
        }
        // 此按鈕表示預設值為刀裝範圍
        private void TousouButton_Click(object sender, EventArgs e)
        {
            touken = false;
            tousou = true;

            CharcoalNumTwoTextBox.Text = "299";
            SteelNumTwoTextBox.Text = "299";
            WaterNumTwoTextBox.Text = "299";
            StoneNumTwoTextBox.Text = "299";
        }
        // 當此按鈕按下，會先確認值都輸入了，並且在規定範圍內，才開始跑亂數
        private void OkButton_Click(object sender, EventArgs e)
        {
            CheckValue();

            int charcoalLow = int.Parse(CharcoalNumOneTextBox.Text.ToString());
            int steelLow = int.Parse(SteelNumOneTextBox.Text.ToString());
            int waterLow = int.Parse(WaterNumOneTextBox.Text.ToString());
            int stoneLow = int.Parse(StoneNumOneTextBox.Text.ToString());
            int charcoalHigh = int.Parse(CharcoalNumTwoTextBox.Text.ToString());
            int steelHigh = int.Parse(SteelNumTwoTextBox.Text.ToString());
            int waterHigh = int.Parse(WaterNumTwoTextBox.Text.ToString());
            int stoneHigh = int.Parse(StoneNumTwoTextBox.Text.ToString());
            Random rnd = new Random();

            // 亂數範圍為Low~High，+1是因為不+1最後一個範圍內的數字不會下去跑亂數
            ResultLabel.Text = "木炭 " + rnd.Next(charcoalLow, charcoalHigh + 1).ToString() + "     " +
                               "玉鋼 " + rnd.Next(steelLow, steelHigh + 1).ToString() + "     " +
                               "冷材 " + rnd.Next(waterLow, waterHigh + 1).ToString() + "     " +
                               "砥石 " + rnd.Next(stoneLow, stoneHigh + 1).ToString();
        }
        // 檢查是否都有輸入了值，且要在規定範圍內，沒有的話自動填入預設值
        private void CheckValue()
        {
            // 木炭
            if ((CharcoalNumOneTextBox.Text.ToString() == "") || (int.Parse(CharcoalNumOneTextBox.Text.ToString()) < 50))
            {
                CharcoalNumOneTextBox.Text = "50";
            }
            if ((CharcoalNumTwoTextBox.Text.ToString() == "") || (int.Parse(CharcoalNumTwoTextBox.Text.ToString()) > 299) || (int.Parse(CharcoalNumTwoTextBox.Text.ToString()) > 999))
            {
                if (touken) 
                {
                    CharcoalNumTwoTextBox.Text = "999";
                }
                else 
                {
                    CharcoalNumTwoTextBox.Text = "299";
                }
            }
            // 玉鋼
            if ((SteelNumOneTextBox.Text.ToString() == "") || (int.Parse(SteelNumOneTextBox.Text.ToString()) < 50))
            {
                SteelNumOneTextBox.Text = "50";
            }
            if ((SteelNumTwoTextBox.Text.ToString() == "") || (int.Parse(SteelNumTwoTextBox.Text.ToString()) > 299) || (int.Parse(SteelNumTwoTextBox.Text.ToString()) > 999))
            {
                if (touken)
                {
                    SteelNumTwoTextBox.Text = "999";
                }
                else
                {
                    SteelNumTwoTextBox.Text = "299";
                }
            }
            // 冷材
            if ((WaterNumOneTextBox.Text.ToString() == "") || (int.Parse(WaterNumOneTextBox.Text.ToString()) < 50))
            {
                WaterNumOneTextBox.Text = "50";
            }
            if ((WaterNumTwoTextBox.Text.ToString() == "") || (int.Parse(WaterNumTwoTextBox.Text.ToString()) > 299) || (int.Parse(WaterNumTwoTextBox.Text.ToString()) > 999))
            {
                if (touken)
                {
                    WaterNumTwoTextBox.Text = "999";
                }
                else
                {
                    WaterNumTwoTextBox.Text = "299";
                } 
            }
            // 砥石
            if ((StoneNumOneTextBox.Text.ToString() == "") || (int.Parse(StoneNumOneTextBox.Text.ToString()) < 50))
            {
                StoneNumOneTextBox.Text = "50";
            }
            if ((StoneNumTwoTextBox.Text.ToString() == "") || (int.Parse(StoneNumTwoTextBox.Text.ToString()) > 299) || (int.Parse(StoneNumTwoTextBox.Text.ToString()) > 999))
            {
                if (touken)
                {
                    StoneNumTwoTextBox.Text = "999";
                }
                else
                {
                    StoneNumTwoTextBox.Text = "299";
                } 
            }
        }
        // 禁止數字與刪除鍵以外的輸入
        private void CharcoalNumOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
        private void CharcoalNumTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void SteelNumOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void SteelNumTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void WaterNumOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void WaterNumTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void StoneNumOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void StoneNumTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
