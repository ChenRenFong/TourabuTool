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
    public partial class ReadMeForm : Form
    {
        public ReadMeForm()
        {
            InitializeComponent();
        }
        // 初始便載入的設定與值
        private void ReadMeForm_Load(object sender, EventArgs e)
        {
            InformationTextBox.Text = "2017年12月19日" + "\r\n" +
                                      "新增刀男：150 日向正宗。" + "\r\n\r\n" + 
                                      
                                      "2017年10月3日" + "\r\n" +
                                      "改版：0.25：" + "\r\n" +
                                      "新增刀男：148 小豆長光。" + "\r\n" +
                                      "本丸記事：新增新的指令\"(dice6)\"，與對應的複製按鈕。" + "\r\n\r\n" +
                
                                      "2017年9月19日" + "\r\n" +
                                      "改版：0.24：" + "\r\n" +
                                      "新增刀男：146 謙信景光。" + "\r\n" +
                                      "本丸抽籤：新增可抽籤抽出指定刀派的刀男。" + "\r\n" +
                                      "每日賭賭：新增多個懶人按鈕，按下即可自動填入相應要求的耗材數值，並依據耗材數值產生隨機一組公式。" + "\r\n\r\n" +
                                      
                                      "2017年8月16日" + "\r\n" +
                                      "改版：0.23" + "\r\n" +
                                      "功能更名：全員抽籤 → 本丸抽籤。" + "\r\n" +
                                      "本丸抽籤：新增可依據刀種以及開放極化與否，來做為標籤依據，進行抽籤。" + "\r\n" +
                                      "新增刀男：144 篭手切江。" + "\r\n\r\n" + 
                                      
                                      "2017年8月8日" + "\r\n" +
                                      "新增刀男：77 小竜景光。" + "\r\n" +
                                      "新增刀男：142 毛利藤四郎。" + "\r\n\r\n" + 
                                      
                                      "2017年7月4日" + "\r\n" +
                                      "新增刀男：140 巴形薙刀。" + "\r\n\r\n" + 
                                      
                                      "2017年2月2日" + "\r\n" +
                                      "新增刀男：63 千子村正。" + "\r\n\r\n" + 
                                      
                                      "2016年12月23日" + "\r\n" +
                                      "新增刀男：53 大包平。" + "\r\n\r\n" + 
                                      
                                      "2016年11月30日" + "\r\n" +
                                      "改版：0.22：" + "\r\n" +
                                      "功能更名：本丸問事 → 本丸記事。" + "\r\n" +
                                      "本丸記事：將特殊字元與指令製作出個別的複製按鈕，按下即可複製，並將原本的指令\"(pdddd)\"改成\"(poker)\"。" + "\r\n" +
                                      "每日賭賭：新增懶人按鈕\"鍛刀\"＆\"刀裝\"，按下即可自動填入最大值與最小值，並進行了功能的改良。" + "\r\n\r\n" +
                                      
                                      "2016年11月18日" + "\r\n" +
                                      "新增刀男：124 小烏丸。" + "\r\n\r\n" + 
                                      
                                      "2016年10月19日" + "\r\n" +
                                      "新增刀男：51 包丁藤四郎。" + "\r\n\r\n" + 
                                      
                                      "2016年9月21日" + "\r\n" +
                                      "刀男更正：笑面青江 → にっかり青江。" + "\r\n" +
                                      "刀男更正：壓切長谷部 → へし切長谷部。" + "\r\n" +
                                      "新增刀男：13 大典太光世。" + "\r\n" +
                                      "新增刀男：15 ソハヤノツルキ。" + "\r\n" +
                                      "新增刀男：71 龜甲貞宗。" + "\r\n\r\n" +
                                      
                                      "2016年7月6日" + "\r\n" +
                                      "改版：0.21：" + "\r\n" +
                                      "新增刀男：69 太鼓鐘貞宗。" + "\r\n" +
                                      "本丸問事：新增\"還原\"＆\"取消還原\"的功能，並改變排版。" + "\r\n\r\n" +
                                      
                                      "2016年4月20日" + "\r\n" +
                                      "改版：0.20：" + "\r\n" +
                                      "主要針對介面做大幅度的精簡，並且移除或合併，甚至是改良了一些功能。" + "\r\n\r\n" +
                                      
                                      "2016年4月18日" + "\r\n" +
                                      "新增功能：本丸問事：" + "\r\n" +
                                      "靈感來源自噗浪的BZ，並且能夠達成類似的功能，所有遊玩娛樂過的紀錄，可在與TourabuTool.exe同一資料夾下的Record資料夾中的record.txt之中找到。" + "\r\n\r\n" +
                                      
                                      "2016年4月13日" + "\r\n" +
                                      "新增刀男：37 信濃藤四郎。" + "\r\n\r\n" +
                                      
                                      "2016年3月18日" + "\r\n" +
                                      "新增刀男：17 數珠丸恒次。" + "\r\n\r\n" +
                                      
                                      "2016年2月16日" + "\r\n" +
                                      "新增刀男：120 不動行光。" + "\r\n\r\n" +
                                      
                                      "2015年12月30日" + "\r\n" +
                                      "新增刀男：107 髭切。" + "\r\n\r\n" +
                                      
                                      "2015年12月29日" + "\r\n" +
                                      "新增刀男：112 膝丸。"; 
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 留意，第一行new的變數要換成namespace的名稱，第二行mySettings的變數也要換成於專案Settings中設定的名稱
            Properties.Settings mySettings = new TourabuTool.Properties.Settings();
            mySettings.ReadMePosition = new Point(this.Location.X, this.Location.Y);
            mySettings.Save();
        }
    }
}
