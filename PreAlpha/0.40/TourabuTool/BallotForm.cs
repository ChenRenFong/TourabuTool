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
    public partial class BallotForm : Form
    {
        // 是否是刀派抽籤的狀態
        bool TouhaBallot = false;
        // 全刀劍的上限數量
        private const int max = 300;
        // 全刀劍的相關屬性
        // 0：刀名
        // 1：刀種：短刀，脇差，打刀，太刀，大太刀，槍，薙刀，劍
        // 2：刀派：無刀派，三條，三池，貞宗，青江，長船，虎徹，村正，古備前，來，兼定，左文字，堀川，粟田口，正宗，江，福岡一文字，豊後国行平
        private const int attributes = 3;
        // 用於全刀劍的資料庫儲存
        private string[,] List = new string[max, attributes];

        public BallotForm()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void BallotForm_Load(object sender, EventArgs e)
        {
            GetDataBase();

            TouhaComboBox.Items.Add("（不使用）");
            TouhaComboBox.Items.Add("無刀派");
            TouhaComboBox.Items.Add("三條");
            TouhaComboBox.Items.Add("三池");
            TouhaComboBox.Items.Add("貞宗");
            TouhaComboBox.Items.Add("青江");
            TouhaComboBox.Items.Add("長船");
            TouhaComboBox.Items.Add("虎徹");
            TouhaComboBox.Items.Add("村正");
            TouhaComboBox.Items.Add("古備前");
            TouhaComboBox.Items.Add("來");
            TouhaComboBox.Items.Add("兼定");
            TouhaComboBox.Items.Add("左文字");
            TouhaComboBox.Items.Add("堀川");
            TouhaComboBox.Items.Add("粟田口");
            TouhaComboBox.Items.Add("正宗");
            TouhaComboBox.Items.Add("江");
            TouhaComboBox.Items.Add("福岡一文字");
            TouhaComboBox.Items.Add("豊後国行平");

            TouhaComboBox.Text = "（不使用）";
        }
        // 取得刀劍亂舞全刀種的資料庫
        private void GetDataBase()
        {
            for (int num = 0; num < max; num++)
            {
                List[num, 0] = "";
                List[num, 1] = "";
                List[num, 2] = "";
            }

            List[3, 0] = "三日月宗近";        List[3, 1] = "太刀";       List[3, 2] = "三條";
            List[5, 0] = "小狐丸";            List[5, 1] = "太刀";       List[5, 2] = "三條";
            List[7, 0] = "石切丸";            List[7, 1] = "大太刀";     List[7, 2] = "三條";
            List[9, 0] = "岩融";              List[9, 1] = "薙刀";       List[9, 2] = "三條"; 
            List[11, 0] = "今剣";             List[11, 1] = "短刀";      List[11, 2] = "三條";
            List[13, 0] = "大典太光世";       List[13, 1] = "太刀";      List[13, 2] = "三池";
            List[15, 0] = "ソハヤノツルキ";   List[15, 1] = "太刀";      List[15, 2] = "三池";
            List[17, 0] = "数珠丸恒次";       List[17, 1] = "太刀";      List[17, 2] = "青江";
            List[19, 0] = "にっかり青江";     List[19, 1] = "脇差";      List[19, 2] = "青江";
            List[21, 0] = "鬼丸国綱";         List[21, 1] = "太刀";      List[21, 2] = "粟田口";
            List[23, 0] = "鳴狐";             List[23, 1] = "打刀";      List[23, 2] = "粟田口";
            List[25, 0] = "一期一振";         List[25, 1] = "太刀";      List[25, 2] = "粟田口";
            List[27, 0] = "鯰尾藤四郎";       List[27, 1] = "脇差";      List[27, 2] = "粟田口";
            List[29, 0] = "骨喰藤四郎";       List[29, 1] = "脇差";      List[29, 2] = "粟田口";
            List[31, 0] = "平野藤四郎";       List[31, 1] = "短刀";      List[31, 2] = "粟田口";
            List[33, 0] = "厚藤四郎";         List[33, 1] = "短刀";      List[33, 2] = "粟田口";
            List[35, 0] = "後藤藤四郎";       List[35, 1] = "短刀";      List[35, 2] = "粟田口";
            List[37, 0] = "信濃藤四郎";       List[37, 1] = "短刀";      List[37, 2] = "粟田口";
            List[39, 0] = "前田藤四郎";       List[39, 1] = "短刀";      List[39, 2] = "粟田口";
            List[41, 0] = "秋田藤四郎";       List[41, 1] = "短刀";      List[41, 2] = "粟田口";
            List[43, 0] = "博多藤四郎";       List[43, 1] = "短刀";      List[43, 2] = "粟田口";
            List[45, 0] = "乱藤四郎";         List[45, 1] = "短刀";      List[45, 2] = "粟田口";
            List[47, 0] = "五虎退";           List[47, 1] = "短刀";      List[47, 2] = "粟田口";
            List[49, 0] = "薬硏藤四郎";       List[49, 1] = "短刀";      List[49, 2] = "粟田口";
            List[51, 0] = "包丁藤四郎";       List[51, 1] = "短刀";      List[51, 2] = "粟田口";
            List[53, 0] = "大包平";           List[53, 1] = "太刀";      List[53, 2] = "古備前";
            List[55, 0] = "鶯丸";             List[55, 1] = "太刀";      List[55, 2] = "古備前";
            List[57, 0] = "明石国行";         List[57, 1] = "太刀";      List[57, 2] = "來";
            List[59, 0] = "蛍丸";             List[59, 1] = "大太刀";    List[59, 2] = "來";
            List[61, 0] = "愛染国俊";         List[61, 1] = "短刀";      List[61, 2] = "來";
            List[63, 0] = "千子村正";         List[63, 1] = "打刀";      List[63, 2] = "村正";
            List[65, 0] = "蜻蛉切";           List[65, 1] = "槍";        List[65, 2] = "村正";
            List[67, 0] = "物吉貞宗";         List[67, 1] = "脇差";      List[67, 2] = "貞宗";
            List[69, 0] = "太鼓鐘貞宗";       List[69, 1] = "短刀";      List[69, 2] = "貞宗";
            List[71, 0] = "亀甲貞宗";         List[71, 1] = "打刀";      List[71, 2] = "貞宗";
            List[73, 0] = "燭台切光忠";       List[73, 1] = "太刀";      List[73, 2] = "長船";
            List[75, 0] = "大般若長光";       List[75, 1] = "太刀";      List[75, 2] = "長船";
            List[77, 0] = "小竜景光";         List[77, 1] = "太刀";      List[77, 2] = "長船";
            List[79, 0] = "江雪左文字";       List[79, 1] = "太刀";      List[79, 2] = "左文字";
            List[81, 0] = "宗三左文字";       List[81, 1] = "太刀";      List[81, 2] = "左文字";
            List[83, 0] = "小夜左文字";       List[83, 1] = "短刀";      List[83, 2] = "左文字";
            List[85, 0] = "加州清光";         List[85, 1] = "打刀";      List[85, 2] = "無刀派";
            List[87, 0] = "大和守安定";       List[87, 1] = "打刀";      List[87, 2] = "無刀派";
            List[89, 0] = "歌仙兼定";         List[89, 1] = "打刀";      List[89, 2] = "兼定";
            List[91, 0] = "和泉守兼定";       List[91, 1] = "打刀";      List[91, 2] = "兼定";
            List[93, 0] = "陸奧守吉行";       List[93, 1] = "打刀";      List[93, 2] = "無刀派";
            List[95, 0] = "山姥切国広";       List[95, 1] = "打刀";      List[95, 2] = "堀川";
            List[97, 0] = "山伏国広";         List[97, 1] = "太刀";      List[97, 2] = "堀川";
            List[99, 0] = "堀川国広";         List[99, 1] = "脇差";      List[99, 2] = "堀川";
            List[101, 0] = "蜂須賀虎徹";      List[101, 1] = "打刀";     List[101, 2] = "虎徹";
            List[103, 0] = "浦島虎徹";        List[103, 1] = "脇差";     List[103, 2] = "虎徹";
            List[105, 0] = "長曽祢虎徹";      List[105, 1] = "打刀";     List[105, 2] = "虎徹";
            List[107, 0] = "髭切";            List[107, 1] = "太刀";     List[107, 2] = "無刀派";
            List[112, 0] = "膝丸";            List[112, 1] = "太刀";     List[112, 2] = "無刀派";
            List[116, 0] = "大俱利伽羅";      List[116, 1] = "打刀";     List[116, 2] = "無刀派";
            List[118, 0] = "へし切長谷部";    List[118, 1] = "打刀";     List[118, 2] = "無刀派";
            List[120, 0] = "不動行光";        List[120, 1] = "短刀";     List[120, 2] = "無刀派";
            List[122, 0] = "獅子王";          List[122, 1] = "太刀";     List[122, 2] = "無刀派";
            List[124, 0] = "小烏丸";          List[124, 1] = "太刀";     List[124, 2] = "無刀派";
            List[128, 0] = "同田貫正国";      List[128, 1] = "打刀";     List[128, 2] = "無刀派";
            List[130, 0] = "鶴丸国永";        List[130, 1] = "太刀";     List[130, 2] = "無刀派";
            List[132, 0] = "太郎太刀";        List[132, 1] = "大太刀";   List[132, 2] = "無刀派";
            List[134, 0] = "次郎太刀";        List[134, 1] = "大太刀";   List[134, 2] = "無刀派";
            List[136, 0] = "日本号";          List[136, 1] = "槍";       List[136, 2] = "無刀派";
            List[138, 0] = "御手杵";          List[138, 1] = "槍";       List[138, 2] = "無刀派";
            List[140, 0] = "巴形薙刀";        List[140, 1] = "薙刀";     List[140, 2] = "無刀派";
            List[142, 0] = "毛利藤四郎";      List[142, 1] = "短刀";     List[142, 2] = "粟田口";
            List[144, 0] = "篭手切江";        List[144, 1] = "脇差";     List[144, 2] = "江";
            List[146, 0] = "謙信景光";        List[146, 1] = "短刀";     List[146, 2] = "長船";
            List[148, 0] = "小豆長光";        List[148, 1] = "太刀";     List[148, 2] = "長船";
            List[150, 0] = "日向正宗";        List[150, 1] = "短刀";     List[150, 2] = "正宗";
            List[152, 0] = "靜形薙刀";        List[152, 1] = "薙刀";     List[152, 2] = "無刀派";
            List[154, 0] = "南泉一文字";      List[154, 1] = "打刀";     List[154, 2] = "福岡一文字";
            List[156, 0] = "千代金丸";        List[156, 1] = "太刀";     List[156, 2] = "無刀派";
            List[158, 0] = "山姥切長義";      List[158, 1] = "打刀";     List[158, 2] = "無刀派";
            List[160, 0] = "豐前江";          List[160, 1] = "打刀";     List[160, 2] = "江";
            List[162, 0] = "祢々切丸";        List[162, 1] = "大太刀";   List[162, 2] = "無刀派";
            List[164, 0] = "白山吉光";        List[164, 1] = "劍";       List[164, 2] = "粟田口";
            List[166, 0] = "南海太郎朝尊";    List[166, 1] = "打刀";     List[166, 2] = "無刀派";
            List[168, 0] = "肥前忠広";        List[168, 1] = "脇差";     List[168, 2] = "無刀派";
            List[170, 0] = "北谷菜切";        List[170, 1] = "短刀";     List[170, 2] = "無刀派";
            List[172, 0] = "桑名江";          List[172, 1] = "打刀";     List[172, 2] = "江";
            List[174, 0] = "水心子正秀";      List[174, 1] = "打刀";     List[174, 2] = "無刀派";
            List[176, 0] = "源清麿";          List[176, 1] = "打刀";     List[176, 2] = "無刀派";
            List[178, 0] = "松井江";          List[178, 1] = "打刀";     List[178, 2] = "江";
            List[180, 0] = "山鳥毛";          List[180, 1] = "太刀";     List[180, 2] = "福岡一文字";
            List[182, 0] = "古今伝授の太刀";  List[182, 1] = "太刀";     List[182, 2] = "豊後国行平";
            List[184, 0] = "地蔵行平";        List[184, 1] = "打刀";     List[184, 2] = "豊後国行平";
            List[186, 0] = "治金丸";          List[186, 1] = "脇差";     List[186, 2] = "無刀派";
        }
        // 當按鍵點下時，會先檢查當前標籤，再依據標籤執行抽籤動作
        private void BallotButton_Click(object sender, EventArgs e)
        {
            int num = 0;

            // 先檢查是否是刀派抽籤的狀態 
            if (TouhaBallot == false)
            {
                // 先檢查各種類都至少要勾一個
                if (TantouCheckBox.Checked == true || WakizasiCheckBox.Checked == true ||
                    UchigatanaCheckBox.Checked == true || TachiCheckBox.Checked == true ||
                    OotachiCheckBox.Checked == true || YariCheckBox.Checked == true ||
                    NaginataCheckBox.Checked == true || TsurugiCheckBox.Checked == true)
                {
                    num = GetNum();
                    InformationLabel.Text = num.ToString() + "   " + List[num, 0];
                }
                else
                {
                    InformationLabel.Text = "請至少選擇刀種或刀派！";
                }
            }
            else
            {
                num = GetNum();
                InformationLabel.Text = num.ToString() + "   " + List[num, 0];
            }
            
        }
        // 抽籤
        private int GetNum()
        {
            int num = 0;
            Random rnd = new Random();

            do
            {
                // 範圍為0~max-1，0開始是因為陣列的範圍為0~max-1，max是為了讓最後一個範圍內的數字也下去跑亂數
                num = rnd.Next(0, max);
            }
            while (CheckTag(num) == false);

            return num;
        }
        // 檢查標籤
        private bool CheckTag(int num)
        {
            if (List[num, 0] != "") 
            {
                if (TouhaBallot == false)
                {
                    if (((List[num, 1] == "短刀") && (TantouCheckBox.Checked == true)) ||
                    ((List[num, 1] == "脇差") && (WakizasiCheckBox.Checked == true)) ||
                    ((List[num, 1] == "打刀") && (UchigatanaCheckBox.Checked == true)) ||
                    ((List[num, 1] == "太刀") && (TachiCheckBox.Checked == true)) ||
                    ((List[num, 1] == "大太刀") && (OotachiCheckBox.Checked == true)) ||
                    ((List[num, 1] == "槍") && (YariCheckBox.Checked == true)) ||
                    ((List[num, 1] == "薙刀") && (NaginataCheckBox.Checked == true)) ||
                    ((List[num, 1] == "劍") && (TsurugiCheckBox.Checked == true)))
                    {
                        return true;
                    }
                }
                else
                {
                    if (TouhaComboBox.Text == List[num, 2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void BallotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 設定本子視窗關閉
            MainForm.FormOpenList[1] = false;
            // 第一行mySettings後的變數要換成於專案Settings中設定的名稱
            MainForm.mySettings.BallotPosition = new Point(this.Location.X, this.Location.Y);
            MainForm.mySettings.Save();
        }
        // 當改變所選取的刀派時，依據選擇來設定是否為刀派抽籤模式
        private void TouhaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TouhaComboBox.Text == "（不使用）")
            {
                TouhaBallot = false;
                TantouCheckBox.Enabled = true;
                WakizasiCheckBox.Enabled = true;
                UchigatanaCheckBox.Enabled = true;
                TachiCheckBox.Enabled = true;
                OotachiCheckBox.Enabled = true;
                YariCheckBox.Enabled = true;
                NaginataCheckBox.Enabled = true;
                TsurugiCheckBox.Enabled = true;
                AllChoose.Enabled = true;
                AllCancel.Enabled = true;
            }
            else
            {
                TouhaBallot = true;
                TantouCheckBox.Enabled = false;
                WakizasiCheckBox.Enabled = false;
                UchigatanaCheckBox.Enabled = false;
                TachiCheckBox.Enabled = false;
                OotachiCheckBox.Enabled = false;
                YariCheckBox.Enabled = false;
                NaginataCheckBox.Enabled = false;
                TsurugiCheckBox.Enabled = false;
                AllChoose.Enabled = false;
                AllCancel.Enabled = false;
            }
        }
        // 一次全選所有刀種，目前只能配合刀種選擇使用
        private void AllChoose_Click(object sender, EventArgs e)
        {
            TantouCheckBox.Checked = true;
            WakizasiCheckBox.Checked = true;
            UchigatanaCheckBox.Checked = true;
            TachiCheckBox.Checked = true;
            OotachiCheckBox.Checked = true;
            YariCheckBox.Checked = true;
            NaginataCheckBox.Checked = true;
            TsurugiCheckBox.Checked = true;
        }
        // 一次全不選所有刀種，目前只能配合刀種選擇使用
        private void AllCancel_Click(object sender, EventArgs e)
        {
            TantouCheckBox.Checked = false;
            WakizasiCheckBox.Checked = false;
            UchigatanaCheckBox.Checked = false;
            TachiCheckBox.Checked = false;
            OotachiCheckBox.Checked = false;
            YariCheckBox.Checked = false;
            NaginataCheckBox.Checked = false;
            TsurugiCheckBox.Checked = false;
        }
    }
}
