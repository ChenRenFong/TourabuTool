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
    public partial class ComputeForm : Form
    {
        // 刀劍等級的上限+1
        private const int maxLv = 100;
        // 目前所有可出陣地圖的總數量，不含活動地圖
        // +2：6-4地圖有三種變化
        // +2：7-4地圖有三種變化
        private const int maps = 7*4 +2 +2;
        // 儲存隊中最高等級刀劍男士與對應的檢非違使經驗值之資料庫資料
        private int[,] PoliceExpList = new int[maxLv, 1];
        // 地圖經驗清單
        // 0：地圖代號
        // 1：一般戰鬥平均單場經驗
        // 2：Boss戰鬥平均單場經驗
        // 3：地圖中平均戰鬥場數
        private string[,] MapExpList = new string[maps, 4];
        
        public ComputeForm()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void ComputeForm_Load(object sender, EventArgs e)
        {
            GetDataBase();
            InitialSetting();
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void ComputeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 設定本子視窗關閉
            MainForm.FormOpenList[4] = false;
            // 第一行mySettings後的變數要換成於專案Settings中設定的名稱
            MainForm.mySettings.ComputePosition = new Point(this.Location.X, this.Location.Y);
            MainForm.mySettings.Save();
        }
        // 取得出陣相關的資料庫
        private void GetDataBase()
        {
            // 10等之前不會遭遇檢非違使
            for (int num = 0; num < 9; num++)
            {
                PoliceExpList[num, 0] = 0;
            }
            // 10等後才會遭遇檢非違使
            PoliceExpList[10, 0] = 55;
            PoliceExpList[11, 0] = 60;
            PoliceExpList[12, 0] = 66;
            PoliceExpList[13, 0] = 71;
            PoliceExpList[14, 0] = 77;
            PoliceExpList[15, 0] = 82;
            PoliceExpList[16, 0] = 88;
            PoliceExpList[17, 0] = 93;
            PoliceExpList[18, 0] = 99;
            PoliceExpList[19, 0] = 104;
            PoliceExpList[20, 0] = 110;
            PoliceExpList[21, 0] = 115;
            PoliceExpList[22, 0] = 121;
            PoliceExpList[23, 0] = 126;
            PoliceExpList[24, 0] = 132;
            PoliceExpList[25, 0] = 137;
            PoliceExpList[26, 0] = 143;
            PoliceExpList[27, 0] = 148;
            PoliceExpList[28, 0] = 154;
            PoliceExpList[29, 0] = 159;
            PoliceExpList[30, 0] = 165;
            PoliceExpList[31, 0] = 170;
            PoliceExpList[32, 0] = 176;
            PoliceExpList[33, 0] = 181;
            PoliceExpList[34, 0] = 187;
            PoliceExpList[35, 0] = 192;
            PoliceExpList[36, 0] = 198;
            PoliceExpList[37, 0] = 203;
            PoliceExpList[38, 0] = 209;
            PoliceExpList[39, 0] = 214;
            PoliceExpList[40, 0] = 220;
            PoliceExpList[41, 0] = 225;
            PoliceExpList[42, 0] = 231;
            PoliceExpList[43, 0] = 236;
            PoliceExpList[44, 0] = 242;
            PoliceExpList[45, 0] = 247;
            PoliceExpList[46, 0] = 253;
            PoliceExpList[47, 0] = 258;
            PoliceExpList[48, 0] = 264;
            PoliceExpList[49, 0] = 269;
            PoliceExpList[50, 0] = 275;
            PoliceExpList[51, 0] = 280;
            PoliceExpList[52, 0] = 286;
            PoliceExpList[53, 0] = 291;
            PoliceExpList[54, 0] = 297;
            PoliceExpList[55, 0] = 302;
            PoliceExpList[56, 0] = 308;
            PoliceExpList[57, 0] = 313;
            PoliceExpList[58, 0] = 319;
            PoliceExpList[59, 0] = 324;
            PoliceExpList[60, 0] = 330;
            PoliceExpList[61, 0] = 335;
            PoliceExpList[62, 0] = 341;
            PoliceExpList[63, 0] = 346;
            PoliceExpList[64, 0] = 352;
            PoliceExpList[65, 0] = 357;
            PoliceExpList[66, 0] = 363;
            PoliceExpList[67, 0] = 368;
            PoliceExpList[68, 0] = 374;
            PoliceExpList[69, 0] = 379;
            PoliceExpList[70, 0] = 385;
            PoliceExpList[71, 0] = 390;
            PoliceExpList[72, 0] = 396;
            PoliceExpList[73, 0] = 401;
            PoliceExpList[74, 0] = 407;
            PoliceExpList[75, 0] = 412;
            PoliceExpList[76, 0] = 418;
            PoliceExpList[77, 0] = 423;
            PoliceExpList[78, 0] = 429;
            PoliceExpList[79, 0] = 434;
            PoliceExpList[80, 0] = 440;
            PoliceExpList[81, 0] = 445;
            PoliceExpList[82, 0] = 451;
            PoliceExpList[83, 0] = 456;
            PoliceExpList[84, 0] = 462;
            PoliceExpList[85, 0] = 467;
            PoliceExpList[86, 0] = 473;
            PoliceExpList[87, 0] = 478;
            PoliceExpList[88, 0] = 484;
            PoliceExpList[89, 0] = 489;
            PoliceExpList[90, 0] = 495;
            PoliceExpList[91, 0] = 500;
            PoliceExpList[92, 0] = 506;
            PoliceExpList[93, 0] = 511;
            PoliceExpList[94, 0] = 517;
            PoliceExpList[95, 0] = 522;
            PoliceExpList[96, 0] = 528;
            PoliceExpList[97, 0] = 533;
            PoliceExpList[98, 0] = 539;
            PoliceExpList[99, 0] = 544;
            // 初始化
            for (int num = 0; num < maps; num++)
            {
                MapExpList[num, 0] = "";
                MapExpList[num, 1] = "0";
                MapExpList[num, 2] = "0";
                MapExpList[num, 3] = "1";
            }
            // 平均經驗算式：加總（經驗 *（該經驗的所有場數 / 該地圖中所有戰鬥場數）），注意！一般戰鬥與Boss戰鬥為分開計算！
            // 平均場數算式：( 走到底的最大場數 + 走到底的最小場數 ) / 2，注意！並不將Boss戰鬥加入場數計算中！
            // 1圖
            MapExpList[0, 0] = "1-1";       MapExpList[0, 1] = "30";      MapExpList[0, 2] = "90";      MapExpList[0, 3] = "1.5";
            MapExpList[1, 0] = "1-2";       MapExpList[1, 1] = "50";      MapExpList[1, 2] = "150";     MapExpList[1, 3] = "1";
            MapExpList[2, 0] = "1-3";       MapExpList[2, 1] = "80";      MapExpList[2, 2] = "240";     MapExpList[2, 3] = "1.5";
            MapExpList[3, 0] = "1-4";       MapExpList[3, 1] = "100";     MapExpList[3, 2] = "300";     MapExpList[3, 3] = "2.5";
            // 2圖
            MapExpList[4, 0] = "2-1";       MapExpList[4, 1] = "120";     MapExpList[4, 2] = "360";     MapExpList[4, 3] = "1.5";
            MapExpList[5, 0] = "2-2";       MapExpList[5, 1] = "140";     MapExpList[5, 2] = "420";     MapExpList[5, 3] = "2";
            MapExpList[6, 0] = "2-3";       MapExpList[6, 1] = "170";     MapExpList[6, 2] = "510";     MapExpList[6, 3] = "2.5";
            MapExpList[7, 0] = "2-4";       MapExpList[7, 1] = "200";     MapExpList[7, 2] = "600";     MapExpList[7, 3] = "2.5";
            // 3圖
            MapExpList[8, 0] = "3-1";       MapExpList[8, 1] = "230";     MapExpList[8, 2] = "690";     MapExpList[8, 3] = "1.5";
            MapExpList[9, 0] = "3-2";       MapExpList[9, 1] = "250";     MapExpList[9, 2] = "750";     MapExpList[9, 3] = "2.5";
            MapExpList[10, 0] = "3-3";      MapExpList[10, 1] = "280";    MapExpList[10, 2] = "840";    MapExpList[10, 3] = "2.5";
            MapExpList[11, 0] = "3-4";      MapExpList[11, 1] = "320";    MapExpList[11, 2] = "960";    MapExpList[11, 3] = "2.5";
            // 4圖
            MapExpList[12, 0] = "4-1";      MapExpList[12, 1] = "360";    MapExpList[12, 2] = "1080";   MapExpList[12, 3] = "3";
            MapExpList[13, 0] = "4-2";      MapExpList[13, 1] = "390";    MapExpList[13, 2] = "1170";   MapExpList[13, 3] = "3.5";
            MapExpList[14, 0] = "4-3";      MapExpList[14, 1] = "400";    MapExpList[14, 2] = "1200";   MapExpList[14, 3] = "4.5";
            MapExpList[15, 0] = "4-4";      MapExpList[15, 1] = "420";    MapExpList[15, 2] = "1260";   MapExpList[15, 3] = "5";
            // 5圖
            MapExpList[16, 0] = "5-1";      MapExpList[16, 1] = "440";    MapExpList[16, 2] = "1320";   MapExpList[16, 3] = "4.5";
            MapExpList[17, 0] = "5-2";      MapExpList[17, 1] = "460";    MapExpList[17, 2] = "1380";   MapExpList[17, 3] = "3.5";
            MapExpList[18, 0] = "5-3";      MapExpList[18, 1] = "480";    MapExpList[18, 2] = "1440";   MapExpList[18, 3] = "4.5";
            MapExpList[19, 0] = "5-4";      MapExpList[19, 1] = "500";    MapExpList[19, 2] = "1500";   MapExpList[19, 3] = "5.5";
            // 6圖
            // 6-2一般戰鬥：520*(7/16) + 250*(7/16) + 550*(1/16) + 580*(1/16)
            // 6-3一般戰鬥：530*(4/13) + 270*(6/13) + 560*(1/13) + 590*(1/13) + 620*(1/13)
            // 6-4-1一般戰鬥：530*(1/7) + 270*(4/7) + 560*(2/7)
            // 6-4-2一般戰鬥：530*(1/11) + 270*(4/11) + 560*(6/11)
            // 6-4-3一般戰鬥：220*(6/16) + 190*(10/16)
            MapExpList[20, 0] = "6-1";      MapExpList[20, 1] = "510";    MapExpList[20, 2] = "1600";   MapExpList[20, 3] = "4.5";
            MapExpList[21, 0] = "6-2";      MapExpList[21, 1] = "407.5";  MapExpList[21, 2] = "1620";   MapExpList[21, 3] = "7.5";
            MapExpList[22, 0] = "6-3";      MapExpList[22, 1] = "423.8";  MapExpList[22, 2] = "1640";   MapExpList[22, 3] = "9.5";
            MapExpList[23, 0] = "6-4-1";    MapExpList[23, 1] = "390";    MapExpList[23, 2] = "1060";   MapExpList[23, 3] = "6";
            MapExpList[24, 0] = "6-4-2";    MapExpList[24, 1] = "451.8";  MapExpList[24, 2] = "1060";   MapExpList[24, 3] = "7";
            MapExpList[25, 0] = "6-4-3";    MapExpList[25, 1] = "201.3";  MapExpList[25, 2] = "1880";   MapExpList[25, 3] = "8";
            // 7圖
            // 7-1一般戰鬥：300*(3/11) + 400*(4/11) + 1000*(4/11)
            // 7-2一般戰鬥：200*(1/13) + 300*(2/13) + 400*(3/13) + 550*(4/13) + 1000*(3/13)
            // 7-3一般戰鬥：500*(8/13) + 600*(2/13) + 1000*(2/13) + 1500*(1/13)
            MapExpList[26, 0] = "7-1";      MapExpList[26, 1] = "590.9";  MapExpList[26, 2] = "3000";   MapExpList[26, 3] = "4";
            MapExpList[27, 0] = "7-2";      MapExpList[27, 1] = "553.8";  MapExpList[27, 2] = "3000";   MapExpList[27, 3] = "5";
            MapExpList[28, 0] = "7-3";      MapExpList[28, 1] = "669.2";  MapExpList[28, 2] = "3000";   MapExpList[28, 3] = "5";
            MapExpList[29, 0] = "7-4-L";    MapExpList[29, 1] = "400";    MapExpList[29, 2] = "2000";   MapExpList[29, 3] = "10";
            MapExpList[30, 0] = "7-4-M";    MapExpList[30, 1] = "800";    MapExpList[30, 2] = "4000";   MapExpList[30, 3] = "7";
            MapExpList[31, 0] = "7-4-S";    MapExpList[31, 1] = "1200";   MapExpList[31, 2] = "6000";   MapExpList[31, 3] = "4";
        }
        // 對介面內容做出初始化設定
        private void InitialSetting()
        {
            for (int num = 1; num <= 6; num++)
            {
                MemberNumberComboBox.Items.Add(num.ToString());
            }
            MemberNumberComboBox.Text = "6";           

            BattleScoreComboBox.Items.Add("S");
            BattleScoreComboBox.Items.Add("A");
            BattleScoreComboBox.Items.Add("B");
            BattleScoreComboBox.Items.Add("C");
            BattleScoreComboBox.Items.Add("一騎打");
            BattleScoreComboBox.Items.Add("敗北");

            BattleScoreComboBox.Text = "A";

            for (int num = 1; num <= 99; num++)
            {
                MaxMemberLevelComboBox.Items.Add(num.ToString());
            }
            MaxMemberLevelComboBox.Text = "82";

            OperateComboBox.Items.Add("懶人模式");
            OperateComboBox.Items.Add("自定義模式");

            // 由於懶人模式目前未實現完成，因此預設模式暫時為自定義模式
            // OperateComboBox.Text = "懶人模式";
            OperateComboBox.Text = "自定義模式";
        }
        // 防呆檢測
        private void Checker()
        {

        }
        // 計算結果
        // 結果：隊員平均搶譽機率、每次地圖進出需時、完成所有出陣次數總需時、
        //       隊長單場戰鬥+單次地圖+所有出陣+單場檢非違使+單場BOSS經驗、
        //       隊員單場戰鬥+單次地圖+所有出陣+單場檢非違使+單場BOSS經驗、
        // 額外顯示：對應檢非經驗、戰鬥評價加成
        private void GoButton_Click(object sender, EventArgs e)
        {
            Checker();

            double MvpRate, BattleRankScore, MapTime, AllTime, PoliceExp;
            int LeaderOneBattleExp, LeaderOneMapExp, LeaderAllExp, LeaderOnePoliceExp, LeaderOneBossExp;
            int OneBattleExp, OneMapExp, AllExp, OnePoliceExp, OneBossExp;

            // 暫存器
            double LeaderMvpExp, LeaderNoMvpExp, MvpExp, NoMvpExp;

            // 隊員平均搶譽機率：1 / 隊員數
            MvpRate = 1.0 / double.Parse(MemberNumberComboBox.Text);

            // 戰鬥評價加成
            if (BattleScoreComboBox.Text == "S" | BattleScoreComboBox.Text == "A") 
            {
                BattleRankScore = 1.2;
            }
            else if (BattleScoreComboBox.Text == "B" | BattleScoreComboBox.Text == "C" | BattleScoreComboBox.Text == "一騎打")
            {
                BattleRankScore = 1.0;
            }
            else if (BattleScoreComboBox.Text == "敗北")
            {
                BattleRankScore = 0.8;
            }
            else
            {
                BattleRankScore = 0;
            }

            // 對應檢非違使經驗
            PoliceExp = PoliceExpList[int.Parse(MaxMemberLevelComboBox.Text), 0];

            // 每次地圖進出需時：單場戰鬥需時 * 該地圖平均戰鬥場數
            MapTime = double.Parse(OneBattleTimeTextBox.Text) * double.Parse(AverageBattleCountTextBox.Text);

            // 完成所有出陣次數總需時：每次地圖進出需時 * 進出地圖次數
            AllTime = MapTime * int.Parse(MapCountTextBox.Text);

            // 反之，知道需時，求進出地圖次數：需時 / ( 單場戰鬥需時 * 該地圖平均戰鬥場數 )

            // 隊長

            // 隊長單場戰鬥經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場戰鬥平均經驗 * 隊長加成 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場戰鬥平均經驗 * 隊長加成 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            LeaderMvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * 1.5 * 2 * BattleRankScore * (1 * MvpRate);
            LeaderNoMvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * 1.5 * BattleRankScore * (1 * (1 - MvpRate));
            LeaderOneBattleExp = (int)((LeaderMvpExp + LeaderNoMvpExp) * double.Parse(ExtraInformationNormalTextBox.Text));

            // 隊長單次地圖經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場戰鬥平均經驗 * 隊長加成 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場戰鬥平均經驗 * 隊長加成 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            LeaderMvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * 1.5 * 2 * BattleRankScore * (int.Parse(AverageBattleCountTextBox.Text) * MvpRate);
            LeaderNoMvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * 1.5 * BattleRankScore * (int.Parse(AverageBattleCountTextBox.Text) * (1 - MvpRate));
            LeaderOneMapExp = (int)((LeaderMvpExp + LeaderNoMvpExp) * double.Parse(ExtraInformationNormalTextBox.Text));

            // 隊長所有出陣經驗：單次地圖經驗 * 進出地圖次數
            LeaderAllExp = LeaderOneMapExp * int.Parse(MapCountTextBox.Text);

            // 隊長單場檢非違使經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場檢非違使經驗 * 隊長加成 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場檢非違使經驗 * 隊長加成 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            LeaderMvpExp = PoliceExp * 1.5 * 2 * BattleRankScore * (1 * MvpRate);
            LeaderNoMvpExp = PoliceExp * 1.5 * BattleRankScore * (1 * (1 - MvpRate));
            LeaderOnePoliceExp = (int)((LeaderMvpExp + LeaderNoMvpExp) * double.Parse(ExtraInformationPoliceTextBox.Text));
            
            // 隊長單場BOSS經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場BOSS平均經驗 * 隊長加成 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場BOSS平均經驗 * 隊長加成 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            LeaderMvpExp = double.Parse(OneBossAverageExpTextBox.Text) * 1.5 * 2 * BattleRankScore * (1 * MvpRate);
            LeaderNoMvpExp = double.Parse(OneBossAverageExpTextBox.Text) * 1.5 * BattleRankScore * (1 * (1 - MvpRate));
            LeaderOneBossExp = (int)((LeaderMvpExp + LeaderNoMvpExp) * double.Parse(ExtraInformationNormalBossTextBox.Text));

            // 隊員

            // 隊員單場戰鬥經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場戰鬥平均經驗 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場戰鬥平均經驗 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            MvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * 2 * BattleRankScore * (1 * MvpRate);
            NoMvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * BattleRankScore * (1 * (1 - MvpRate));
            OneBattleExp = (int)((MvpExp + NoMvpExp) * double.Parse(ExtraInformationNormalTextBox.Text));

            // 隊員單次地圖經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場戰鬥平均經驗 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場戰鬥平均經驗 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            MvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * 2 * BattleRankScore * (int.Parse(AverageBattleCountTextBox.Text) * MvpRate);
            NoMvpExp = double.Parse(OneBattleAverageExpTextBox.Text) * BattleRankScore * (int.Parse(AverageBattleCountTextBox.Text) * (1 - MvpRate));
            OneMapExp = (int)((MvpExp + NoMvpExp) * double.Parse(ExtraInformationNormalTextBox.Text));

            // 隊員所有出陣經驗：單次地圖經驗 * 進出地圖次數
            AllExp = OneMapExp * int.Parse(MapCountTextBox.Text);

            // 隊員單場檢非違使經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場檢非違使經驗 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場檢非違使經驗 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            MvpExp = PoliceExp * 2 * BattleRankScore * (1 * MvpRate);
            NoMvpExp = PoliceExp * BattleRankScore * (1 * (1 - MvpRate));
            OnePoliceExp = (int)((MvpExp + NoMvpExp) * double.Parse(ExtraInformationPoliceTextBox.Text));

            // 隊員單場BOSS經驗：(搶譽經驗+非搶譽經驗) * 額外加成
            // 搶譽經驗：單場BOSS平均經驗 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )
            // 非搶譽經驗：單場BOSS平均經驗 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )
            MvpExp = double.Parse(OneBossAverageExpTextBox.Text) * 2 * BattleRankScore * (1 * MvpRate);
            NoMvpExp = double.Parse(OneBossAverageExpTextBox.Text) * BattleRankScore * (1 * (1 - MvpRate));
            OneBossExp = (int)((MvpExp + NoMvpExp) * double.Parse(ExtraInformationNormalBossTextBox.Text));

            OutputTextBox.Text = "總需時： " + AllTime.ToString() + "分鐘" + "\r\n" +
                                 "單次地圖需時： " + MapTime.ToString() + "分鐘" + "\r\n" +
                                 "\r\n" +
                                 "隊長總經驗： " + LeaderAllExp.ToString() + "\r\n" +
                                 "隊員總經驗： " + AllExp.ToString() + "\r\n" +
                                 "\r\n" +
                                 "隊長單次地圖經驗： " + LeaderOneMapExp.ToString() + "\r\n" +
                                 "隊員單次地圖經驗： " + OneMapExp.ToString() + "\r\n" +
                                 "\r\n" +
                                 "隊長單場BOSS經驗： " + LeaderOneBossExp.ToString() + "\r\n" +
                                 "隊員單場BOSS經驗： " + OneBossExp.ToString() + "\r\n" +
                                 "\r\n" +
                                 "隊長單場檢非經驗： " + LeaderOnePoliceExp.ToString() + "\r\n" +
                                 "隊員單場檢非經驗： " + OnePoliceExp.ToString() + "\r\n" +
                                 "\r\n" +
                                 "隊長單場戰鬥經驗： " + LeaderOneBattleExp.ToString() + "\r\n" +
                                 "隊員單場戰鬥經驗： " + OneBattleExp.ToString() + "\r\n" +
                                 "\r\n" +
                                 "額外資訊：" + "\r\n" +
                                 "隊員平均搶譽機率： " + MvpRate.ToString() + "\r\n" +
                                 "戰鬥評價加成數值： " + BattleRankScore.ToString() + "\r\n" +
                                 "對應檢非違使經驗： " + PoliceExp.ToString();
        }
        // 只允許輸入數字、刪除鍵、小數點
        private void ExtraInformationNormalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void ExtraInformationNormalBossTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void ExtraInformationEventTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void ExtraInformationEventBossTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void ExtraInformationPoliceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void OneBattleTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void MapCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 本項目例外，不允許小數點
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void AverageBattleCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 本項目例外，不允許小數點
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void OneBattleAverageExpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 本項目例外，不允許小數點
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void OneBossAverageExpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 本項目例外，不允許小數點
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
