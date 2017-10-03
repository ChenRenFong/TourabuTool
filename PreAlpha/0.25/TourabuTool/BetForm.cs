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
        // 此按鈕表示預設值為隨機鍛刀範圍
        private void ToukenButton_Click(object sender, EventArgs e)
        {
            CharcoalNumTwoTextBox.Text = "999";
            SteelNumTwoTextBox.Text = "999";
            WaterNumTwoTextBox.Text = "999";
            StoneNumTwoTextBox.Text = "999";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為隨機刀裝範圍
        private void TousouButton_Click(object sender, EventArgs e)
        {
            CharcoalNumTwoTextBox.Text = "299";
            SteelNumTwoTextBox.Text = "299";
            WaterNumTwoTextBox.Text = "299";
            StoneNumTwoTextBox.Text = "299";

            OkButton_Click(sender, e);
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
            ResultLabel.Text = "木炭 " + rnd.Next(charcoalLow, charcoalHigh + 1).ToString() + "               " +
                               "玉鋼 " + rnd.Next(steelLow, steelHigh + 1).ToString() + "               " +
                               "冷材 " + rnd.Next(waterLow, waterHigh + 1).ToString() + "               " +
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
            if ((CharcoalNumTwoTextBox.Text.ToString() == "") || (int.Parse(CharcoalNumTwoTextBox.Text.ToString()) > 999))
            {
                CharcoalNumTwoTextBox.Text = "999";
            }
            // 玉鋼
            if ((SteelNumOneTextBox.Text.ToString() == "") || (int.Parse(SteelNumOneTextBox.Text.ToString()) < 50))
            {
                SteelNumOneTextBox.Text = "50";
            }
            if ((SteelNumTwoTextBox.Text.ToString() == "") || (int.Parse(SteelNumTwoTextBox.Text.ToString()) > 999))
            {
                SteelNumTwoTextBox.Text = "999";
            }
            // 冷材
            if ((WaterNumOneTextBox.Text.ToString() == "") || (int.Parse(WaterNumOneTextBox.Text.ToString()) < 50))
            {
                WaterNumOneTextBox.Text = "50";
            }
            if ((WaterNumTwoTextBox.Text.ToString() == "") || (int.Parse(WaterNumTwoTextBox.Text.ToString()) > 999))
            {
                WaterNumTwoTextBox.Text = "999";
            }
            // 砥石
            if ((StoneNumOneTextBox.Text.ToString() == "") || (int.Parse(StoneNumOneTextBox.Text.ToString()) < 50))
            {
                StoneNumOneTextBox.Text = "50";
            }
            if ((StoneNumTwoTextBox.Text.ToString() == "") || (int.Parse(StoneNumTwoTextBox.Text.ToString()) > 999))
            {
                StoneNumTwoTextBox.Text = "999";
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
        // 此按鈕表示預設值為短刀鍛刀範圍
        private void Tantou_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "50";
            
            CharcoalNumTwoTextBox.Text = "350";
            SteelNumTwoTextBox.Text = "350";
            WaterNumTwoTextBox.Text = "350";
            StoneNumTwoTextBox.Text = "350";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為脇差鍛刀範圍
        private void Wakizasi_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "100";
            SteelNumOneTextBox.Text = "100";
            WaterNumOneTextBox.Text = "100";
            StoneNumOneTextBox.Text = "100";

            CharcoalNumTwoTextBox.Text = "400";
            SteelNumTwoTextBox.Text = "400";
            WaterNumTwoTextBox.Text = "650";
            StoneNumTwoTextBox.Text = "650";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為打刀鍛刀範圍
        private void Uchigatana_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "250";
            SteelNumOneTextBox.Text = "250";
            WaterNumOneTextBox.Text = "250";
            StoneNumOneTextBox.Text = "250";

            CharcoalNumTwoTextBox.Text = "950";
            SteelNumTwoTextBox.Text = "950";
            WaterNumTwoTextBox.Text = "950";
            StoneNumTwoTextBox.Text = "950";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為太刀鍛刀範圍
        private void Tachi_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "350";
            SteelNumOneTextBox.Text = "350";
            WaterNumOneTextBox.Text = "350";
            StoneNumOneTextBox.Text = "350";

            CharcoalNumTwoTextBox.Text = "950";
            SteelNumTwoTextBox.Text = "950";
            WaterNumTwoTextBox.Text = "950";
            StoneNumTwoTextBox.Text = "950";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為大太刀鍛刀範圍
        private void Ootachi_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "525";
            SteelNumOneTextBox.Text = "600";
            WaterNumOneTextBox.Text = "510";
            StoneNumOneTextBox.Text = "510";

            CharcoalNumTwoTextBox.Text = "600";
            SteelNumTwoTextBox.Text = "680";
            WaterNumTwoTextBox.Text = "760";
            StoneNumTwoTextBox.Text = "595";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為槍鍛刀範圍
        private void Yari_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "400";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "500";
            StoneNumOneTextBox.Text = "500";

            CharcoalNumTwoTextBox.Text = "600";
            SteelNumTwoTextBox.Text = "350";
            WaterNumTwoTextBox.Text = "600";
            StoneNumTwoTextBox.Text = "700";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為薙刀鍛刀範圍
        private void Naginata_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "500";
            SteelNumOneTextBox.Text = "500";
            WaterNumOneTextBox.Text = "700";
            StoneNumOneTextBox.Text = "700";

            CharcoalNumTwoTextBox.Text = "660";
            SteelNumTwoTextBox.Text = "660";
            WaterNumTwoTextBox.Text = "760";
            StoneNumTwoTextBox.Text = "760";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為輕步兵刀裝範圍
        private void Hohei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "50";

            CharcoalNumTwoTextBox.Text = "50";
            SteelNumTwoTextBox.Text = "50";
            WaterNumTwoTextBox.Text = "50";
            StoneNumTwoTextBox.Text = "50";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為輕騎兵刀裝範圍
        private void Kihei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "50";

            CharcoalNumTwoTextBox.Text = "50";
            SteelNumTwoTextBox.Text = "50";
            WaterNumTwoTextBox.Text = "50";
            StoneNumTwoTextBox.Text = "50";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為重步兵刀裝範圍
        private void Oohohei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "250";
            SteelNumOneTextBox.Text = "100";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "50";

            CharcoalNumTwoTextBox.Text = "250";
            SteelNumTwoTextBox.Text = "150";
            WaterNumTwoTextBox.Text = "50";
            StoneNumTwoTextBox.Text = "50";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為重騎兵刀裝範圍
        private void Ookihei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "150";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "150";
            StoneNumOneTextBox.Text = "100";

            CharcoalNumTwoTextBox.Text = "150";
            SteelNumTwoTextBox.Text = "100";
            WaterNumTwoTextBox.Text = "250";
            StoneNumTwoTextBox.Text = "150";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為精銳兵刀裝範圍
        private void Seieihei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "150";
            SteelNumOneTextBox.Text = "100";
            WaterNumOneTextBox.Text = "250";
            StoneNumOneTextBox.Text = "150";

            CharcoalNumTwoTextBox.Text = "200";
            SteelNumTwoTextBox.Text = "100";
            WaterNumTwoTextBox.Text = "250";
            StoneNumTwoTextBox.Text = "150";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為槍兵刀裝範圍
        private void Yarihei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "100";

            CharcoalNumTwoTextBox.Text = "50";
            SteelNumTwoTextBox.Text = "50";
            WaterNumTwoTextBox.Text = "50";
            StoneNumTwoTextBox.Text = "250";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為盾兵刀裝範圍
        private void Tatehei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "50";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "250";

            CharcoalNumTwoTextBox.Text = "70";
            SteelNumTwoTextBox.Text = "50";
            WaterNumTwoTextBox.Text = "50";
            StoneNumTwoTextBox.Text = "250";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為銃兵刀裝範圍
        private void Jyuuhei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "100";
            SteelNumOneTextBox.Text = "200";
            WaterNumOneTextBox.Text = "100";
            StoneNumOneTextBox.Text = "100";

            CharcoalNumTwoTextBox.Text = "150";
            SteelNumTwoTextBox.Text = "250";
            WaterNumTwoTextBox.Text = "150";
            StoneNumTwoTextBox.Text = "150";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為弓兵刀裝範圍
        private void Kyuuhei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "150";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "150";

            CharcoalNumTwoTextBox.Text = "50";
            SteelNumTwoTextBox.Text = "150";
            WaterNumTwoTextBox.Text = "50";
            StoneNumTwoTextBox.Text = "250";

            OkButton_Click(sender, e);
        }
        // 此按鈕表示預設值為投石兵刀裝範圍
        private void Ishihei_Click(object sender, EventArgs e)
        {
            CharcoalNumOneTextBox.Text = "50";
            SteelNumOneTextBox.Text = "100";
            WaterNumOneTextBox.Text = "50";
            StoneNumOneTextBox.Text = "60";

            CharcoalNumTwoTextBox.Text = "50";
            SteelNumTwoTextBox.Text = "120";
            WaterNumTwoTextBox.Text = "60";
            StoneNumTwoTextBox.Text = "75";

            OkButton_Click(sender, e);
        }
    }
}
