﻿using System;
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
            // 2019/2/22修正了讀取模擬通路資料時的部分錯誤
            InformationTextBox.Text = "2019年4月28日" + "\r\n" +
                                      "模擬通路：增加景趣與更多刀男資料。" + "\r\n\r\n" + 
                                      
                                      "2019年4月27日" + "\r\n" +
                                      "新增刀男：166 南海太郎朝尊。" + "\r\n" +
                                      "新增刀男：168 肥前忠広。" + "\r\n" +
                                      "模擬通路：增加更多刀男資料。" + "\r\n\r\n" +
                                      
                                      "2019年2月19日" + "\r\n" +
                                      "新增新刀種資料：劍，包含每日賭賭以及本丸抽籤中新增相關數據。" + "\r\n" +
                                      "新增刀男：164 白山吉光。" + "\r\n" +
                                      "模擬通路：增加更多刀男資料。" + "\r\n\r\n" + 
                                      
                                      "2019年1月27日" + "\r\n" +
                                      "模擬通路：增加景趣與更多刀男資料。" + "\r\n\r\n" + 
                                      
                                      "2019年1月22日" + "\r\n" +
                                      "本丸記事：指令(dice6)改成(diceNum)，其亂數範圍從1~6更改至0~9。" + "\r\n" +
                                      "出陣助手：新增地圖8-1的資料。" + "\r\n" +
                                      "模擬通路：增加更多刀男資料。" + "\r\n\r\n" + 

                                      "2019年1月21日" + "\r\n" +
                                      "模擬通路：增加更多刀男資料。" +  "\r\n\r\n" +

                                      "2018年12月23日" + "\r\n" +
                                      "改版：0.29：" + "\r\n" +
                                      "新增刀男：162 祢々切丸。" + "\r\n" +
                                      "刀男更正：長曾彌虎徹 → 長曾祢虎徹。" + "\r\n" +
                                      "刀男更正：山姥切國廣 → 山姥切国広。" + "\r\n" +
                                      "刀男更正：山伏國廣 → 山伏国広。" + "\r\n" +
                                      "刀男更正：堀川國廣 → 堀川国広。" + "\r\n" +
                                      "刀男更正：同田貫正國 → 同田貫正国。" + "\r\n" +
                                      "刀男更正：鶴丸國永 → 鶴丸国永。" + "\r\n" +
                                      "刀男更正：明石國行 → 明石国行。" + "\r\n" +
                                      "刀男更正：愛染國俊 → 愛染国俊。" + "\r\n" +
                                      "新增功能：模擬通路：" + "\r\n" +
                                      "只是想與心愛的男人一直一直在一起，就只是這樣的一個小小心願而已。" + "\r\n\r\n" +
                                      
                                      "2018年11月28日" + "\r\n" +
                                      "新增刀男：160 豐前江。" + "\r\n" +
                                      "刀派增加：江。" + "\r\n" +
                                      "刀派更正：篭手切江：無刀派 → 江。" + "\r\n" +
                                      "出陣助手：完善功能。" + "\r\n\r\n" + 
                                      
                                      "2018年11月7日" + "\r\n" +
                                      "改版：0.28：" + "\r\n" +
                                      "新增刀男：158 山姥切長義。" + "\r\n" +
                                      "新增功能：出陣助手：" + "\r\n" +
                                      "針對出陣可得經驗、需求時間等資訊進行推估計算，以方便對出陣做出評估與規劃。" + "\r\n\r\n" + 
                
                                      "2018年6月28日" + "\r\n" +
                                      "新增刀男：156 千代金丸。" + "\r\n\r\n" + 

                                      "2018年4月24日" + "\r\n" +
                                      "新增刀男：154 南泉一文字。" + "\r\n\r\n" + 
                                      
                                      "2018年4月17日" + "\r\n" +
                                      "改版：0.27：" + "\r\n" +
                                      "新增刀男：152 靜形薙刀。" + "\r\n" +
                                      "本丸抽籤：考量今後全刀劍都會極化，因此摘除以極化為標籤進行抽籤的功能，並新增懶人按鈕。" + "\r\n" +
                                      "本丸記事：修正顯示紀錄時，可能會暫時顯示沒有回應的問題。" + "\r\n\r\n" + 
                
                                      "2018年1月31日" + "\r\n" +
                                      "改版：0.26：" + "\r\n" +
                                      "修正了子視窗部分有問題的功能。" + "\r\n" +
                                      "本丸記事：可以自訂記錄檔的儲存路徑與檔名，結果顯示的部分新增了數個操作功能，並且對結果的顯示做了些許調整。" + "\r\n\r\n" + 
                
                                      "2017年12月19日" + "\r\n" +
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
        private void ReadMeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 設定本子視窗關閉
            MainForm.FormOpenList[3] = false;
            // 第一行mySettings後的變數要換成於專案Settings中設定的名稱
            MainForm.mySettings.ReadMePosition = new Point(this.Location.X, this.Location.Y);
            MainForm.mySettings.Save();
        }
    }
}
