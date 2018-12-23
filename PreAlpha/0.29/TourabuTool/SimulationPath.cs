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
    public partial class SimulationPath : Form
    {
        // 讀取絕對路徑，並指向資料所在處
        String DataPath = System.Environment.CurrentDirectory + "\\SimulationPath\\";
        // 用於讀取本丸環境資料與刀男資料
        String HonnmaruDataPath;
        String HonnmaruNow;
        String SoundDataPath;
        String ToukennDataPath;
        // 放置語音間隔，單位分鐘
        int VoiceIntervalMin = 5;
        int VoiceIntervalMax = 60;
        // 音效間隔，單位分鐘
        int SoundIntervalMin = 0;
        int SoundIntervalMax = 1;

        public SimulationPath()
        {
            InitializeComponent();
        }
        // 初始便載入的設定與值
        private void SimulationPath_Load(object sender, EventArgs e)
        {
            // 設定使用者介面
            VoiceCheckBox.Checked = MainForm.mySettings.PathVoiceSetting;
            SoundCheckBox.Checked = MainForm.mySettings.PathSoundSetting;
            VolumeTrackBar.Value = MainForm.mySettings.PathVolumeSetting;
            VolumeLabel.Text = "Vol. " + MainForm.mySettings.PathVolumeSetting;
            VolumeSet();

            // 設定使用者介面，本丸環境
            HonnmaruComboBox.Items.Add("一般");
            HonnmaruComboBox.Items.Add("大廣間");
            HonnmaruComboBox.Items.Add("春季");
            HonnmaruComboBox.Items.Add("夏季");
            HonnmaruComboBox.Items.Add("秋季");
            HonnmaruComboBox.Items.Add("冬季");
            HonnmaruComboBox.Items.Add("夏夜");
            HonnmaruComboBox.Items.Add("秋夜");
            HonnmaruComboBox.Items.Add("冬夜-照明一");
            HonnmaruComboBox.Items.Add("冬夜-照明二");
            HonnmaruComboBox.Items.Add("冬夜-飾-照明一");
            HonnmaruComboBox.Items.Add("冬夜-飾-照明二");
            HonnmaruComboBox.Items.Add("雨季");
            HonnmaruComboBox.Items.Add("雨季-晴");
            HonnmaruComboBox.Items.Add("十五夜");
            HonnmaruComboBox.Items.Add("撒豆驅鬼節");
            HonnmaruComboBox.Items.Add("立秋-向日葵");
            HonnmaruComboBox.Items.Add("立冬-菊");

            HonnmaruComboBox.Text = MainForm.mySettings.PathHonnmaruSetting;

            // 抓取本丸環境資料
            RealTimeCheckBox.Checked = MainForm.mySettings.PathRealTimeSetting;
            HonnmaruSet();

            // 設定使用者介面，刀男
            ToukennComboBox.Items.Add("--");
            ToukennComboBox.Items.Add("3_三日月宗近");
            ToukennComboBox.Items.Add("85_加州清光");
            ToukennComboBox.Items.Add("86_加州清光-極");
            ToukennComboBox.Items.Add("89_歌仙兼定");
            ToukennComboBox.Items.Add("93_陸奧守吉行");
            ToukennComboBox.Items.Add("95_山姥切国広");
            ToukennComboBox.Items.Add("101_蜂須賀虎徹");

            ToukennComboBox.Text = MainForm.mySettings.PathToukennSetting;

            // 抓取刀男資料
            ToukennPictureBox.Parent = HonnmaruPictureBox;          
            ToukennPictureBox.BackColor = Color.Transparent;
            ToukennSet();

            // 計時器，用於放置語音，隨機間隔每5~60分鐘一次
            VoiceTimer.Interval = GetIntervalTime(VoiceIntervalMin, VoiceIntervalMax);
            VoiceTimer.Start();

            // 計時器，每三十分鐘檢查一次現實時間，如果有設置本丸時間隨現實時間，則會依此改動本丸環境
            RealTimeTimer.Interval = 10 * 60 * 1000;
            RealTimeTimer.Start();

            // 計時器，處理背景音效，隨機間隔每5~60分鐘一次
            SoundTimer.Interval = GetIntervalTime(SoundIntervalMin, SoundIntervalMax);
            SoundTimer.Start();
        }
        // 每次使用者更動使用習慣就要進行紀錄，設定是否要有刀男語音
        private void VoiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.mySettings.PathVoiceSetting = VoiceCheckBox.Checked;
        }
        // 每次使用者更動使用習慣就要進行紀錄，設定是否要有音效
        private void SoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.mySettings.PathSoundSetting = SoundCheckBox.Checked;
        }
        // 每次使用者更動使用習慣就要進行紀錄，設定音量大小
        // 同時對音量進行調整
        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            VolumeSet();
            VolumeLabel.Text = "Vol. " + VolumeTrackBar.Value;
            MainForm.mySettings.PathVolumeSetting = VolumeTrackBar.Value;
        }
        // 設置音量
        private void VolumeSet()
        {
            axWMP_voice.settings.volume = VolumeTrackBar.Value;
            axWMP_sound.settings.volume = VolumeTrackBar.Value;
        }
        // 每次改變指定，就要更換刀男，並記錄
        private void ToukennComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToukennSet();
            MainForm.mySettings.PathToukennSetting = ToukennComboBox.Text;
        }
        // 可依據使用者的選擇指定陪伴的刀男
        private void ToukennSet()
        {
            if (ToukennComboBox.Text == "--")
            {
                ToukennPictureBox.Image = null;
            }
            else
            {
                ToukennDataPath = ToukennComboBox.Text + "\\Normal.png";

                try
                {
                    ToukennPictureBox.Image = Image.FromFile(DataPath + ToukennDataPath);

                    // 讓刀男站在正中央，部份刀男需要額外修正，值越大越往右修正，負往左
                    // 按係數高至低排列
                    int newX = 0;
                    if (ToukennComboBox.Text == "89_歌仙兼定")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.11);
                    }
                    else if (ToukennComboBox.Text == "85_加州清光")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.08);
                    }
                    else if (ToukennComboBox.Text == "95_山姥切国広")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.04);
                    }
                    else if (ToukennComboBox.Text == "93_陸奧守吉行")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.018);
                    }
                    else
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width));
                    }

                    // 刀男的身高係數，後面乘上的小數點，值越小刀男越高，反之越矮
                    // 按係數低至高排列
                    int newY = 0;
                    if (ToukennComboBox.Text == "3_三日月宗近" || ToukennComboBox.Text == "89_歌仙兼定" || ToukennComboBox.Text == "93_陸奧守吉行")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.085);
                    }
                    else if (ToukennComboBox.Text == "101_蜂須賀虎徹" || ToukennComboBox.Text == "95_山姥切国広")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.11);
                    }
                    else if (ToukennComboBox.Text == "85_加州清光" || ToukennComboBox.Text == "86_加州清光-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.17);
                    }

                    ToukennPictureBox.Location = new Point(newX, newY);
                }
                catch
                {
                    MessageBox.Show("無法取得資料，無法更改刀男。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
        // 可依據使用者的選擇改變本丸環境，如果沒有設定隨現實時間的話
        private void HonnmaruComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HonnmaruNow = HonnmaruComboBox.Text;
            MainForm.mySettings.PathHonnmaruSetting = HonnmaruComboBox.Text;

            HonnmaruSet();
        }
        // 檢查現實時間，並對應更改本丸環境
        private void HonnmaruSet()
        {
            axWMP_sound.Ctlcontrols.stop();
            String LoopSoundData = "";
            
            // 檢查是否是與現實時間同步本丸環境
            if (RealTimeCheckBox.Checked == true)
            {
                // 讀取現實時間
                System.DateTime currentTime = new System.DateTime();
                currentTime = System.DateTime.Now;
                int month = currentTime.Month;  
                int day = currentTime.Day;
                int hour = currentTime.Hour;
                int minute = currentTime.Minute;

                // 目前的設計：6月：雨or晴→夏夜
                //             7月：夏→夏夜
                //             8月：夏→夏夜，8/7~8/9：立秋-向日葵→夏夜
                //             9月：秋→十五夜
                //             10月：秋→秋夜
                //             11月：秋→秋夜，11/7~11/8：立冬-菊→秋夜
                //             12月：冬→冬夜(四種)
                //             1月：冬→冬夜(四種)
                //             2月：冬→冬夜(四種)，2/1~2/5：撒豆驅鬼節→冬夜(四種)
                //             3月：春→冬夜(四種)，目前沒有春夜，所以先這樣將就
                //             4月：春→冬夜(四種)，目前沒有春夜，所以先這樣將就
                //             4月：春→夏夜，目前沒有春夜，所以先這樣將就
                // 日出日落時間：夏6~8月：5點、19點
                //               冬12~2月：7點、17點
                //               春3~5月、秋9~11月：6點、18點
                if (month == 6)
                {
                    // 白天or夜晚
                    if (hour >= 5 && hour <= 19) 
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        // 亂數取1~2之間
                        int res = rnd.Next(1, 3);

                        // 下雨與否
                        if (res == 1)
                        {
                            HonnmaruDataPath = "Home\\雨季.gif";
                            HonnmaruNow = "雨季";
                            LoopSoundData = "雨季";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\雨季-晴.gif";
                            HonnmaruNow = "雨季-晴";
                        }
                    }
                    else
                    {
                        HonnmaruDataPath = "Home\\夏夜.gif";
                        HonnmaruNow = "夏夜";
                    }
                }
                else if (month == 7)
                {
                    // 白天or夜晚
                    if (hour >= 5 && hour <= 19)
                    {
                        HonnmaruDataPath = "Home\\夏季.gif";
                        HonnmaruNow = "夏季";
                    }
                    else
                    {
                        HonnmaruDataPath = "Home\\夏夜.gif";
                        HonnmaruNow = "夏夜";
                    }
                }
                else if (month == 8)
                {
                    // 白天or夜晚
                    if (hour >= 5 && hour <= 19)
                    {
                        // 是否是特殊節日
                        if (day == 7 || day == 8 || day == 9)
                        {
                            HonnmaruDataPath = "Home\\立秋-向日葵.gif";
                            HonnmaruNow = "立秋-向日葵";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\夏季.gif";
                            HonnmaruNow = "夏季";
                        }
                    }
                    else
                    {
                        HonnmaruDataPath = "Home\\夏夜.gif";
                        HonnmaruNow = "夏夜";
                    }
                }
                else if (month == 9)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        HonnmaruDataPath = "Home\\秋季.gif";
                        HonnmaruNow = "秋季";
                    }
                    else
                    {
                        HonnmaruDataPath = "Home\\十五夜.gif";
                        HonnmaruNow = "十五夜";
                    }
                }
                else if (month == 10)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        HonnmaruDataPath = "Home\\秋季.gif";
                        HonnmaruNow = "秋季";
                    }
                    else
                    {
                        HonnmaruDataPath = "Home\\秋夜.gif";
                        HonnmaruNow = "秋夜";
                    }
                }
                else if (month == 11)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        // 是否是特殊節日
                        if (day == 7 || day == 8)
                        {
                            HonnmaruDataPath = "Home\\立冬-菊.gif";
                            HonnmaruNow = "立冬-菊";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\秋季.gif";
                            HonnmaruNow = "秋季";
                        }
                    }
                    else
                    {
                        HonnmaruDataPath = "Home\\秋夜.gif";
                        HonnmaruNow = "秋夜";
                    }
                }
                else if (month == 12)
                {
                    // 白天or夜晚
                    if (hour >= 7 && hour <= 17)
                    {
                        HonnmaruDataPath = "Home\\冬季.gif";
                        HonnmaruNow = "冬季";
                    }
                    else
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        // 亂數取1~4之間
                        int res = rnd.Next(1, 5);

                        // 使用哪種夜景
                        if (res == 1)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明一.gif";
                            HonnmaruNow = "冬夜-照明一";
                        }
                        else if (res == 2)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明二.gif";
                            HonnmaruNow = "冬夜-照明二";
                        }
                        else if (res == 3)
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明一.gif";
                            HonnmaruNow = "冬夜-飾-照明一";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明二.gif";
                            HonnmaruNow = "冬夜-飾-照明二";
                        }
                    }
                }
                else if (month == 1)
                {
                    // 白天or夜晚
                    if (hour >= 7 && hour <= 17)
                    {
                        HonnmaruDataPath = "Home\\冬季.gif";
                        HonnmaruNow = "冬季";
                    }
                    else
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        // 亂數取1~4之間
                        int res = rnd.Next(1, 5);

                        // 使用哪種夜景
                        if (res == 1)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明一.gif";
                            HonnmaruNow = "冬夜-照明一";
                        }
                        else if (res == 2)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明二.gif";
                            HonnmaruNow = "冬夜-照明二";
                        }
                        else if (res == 3)
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明一.gif";
                            HonnmaruNow = "冬夜-飾-照明一";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明二.gif";
                            HonnmaruNow = "冬夜-飾-照明二";
                        }
                    }
                }
                else if (month == 2)
                {
                    // 白天or夜晚
                    if (hour >= 7 && hour <= 17)
                    {
                        // 是否是特殊節日
                        if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
                        {
                            HonnmaruDataPath = "Home\\撒豆驅鬼節.gif";
                            HonnmaruNow = "撒豆驅鬼節";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\冬季.gif";
                            HonnmaruNow = "冬季";
                        }
                    }
                    else
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        // 亂數取1~4之間
                        int res = rnd.Next(1, 5);

                        // 使用哪種夜景
                        if (res == 1)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明一.gif";
                            HonnmaruNow = "冬夜-照明一";
                        }
                        else if (res == 2)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明二.gif";
                            HonnmaruNow = "冬夜-照明二";
                        }
                        else if (res == 3)
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明一.gif";
                            HonnmaruNow = "冬夜-飾-照明一";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明二.gif";
                            HonnmaruNow = "冬夜-飾-照明二";
                        }
                    }
                }
                else if (month == 3)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        HonnmaruDataPath = "Home\\春季.gif";
                        HonnmaruNow = "春季";
                    }
                    else
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        // 亂數取1~4之間
                        int res = rnd.Next(1, 5);

                        // 使用哪種夜景
                        if (res == 1)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明一.gif";
                            HonnmaruNow = "冬夜-照明一";
                        }
                        else if (res == 2)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明二.gif";
                            HonnmaruNow = "冬夜-照明二";
                        }
                        else if (res == 3)
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明一.gif";
                            HonnmaruNow = "冬夜-飾-照明一";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明二.gif";
                            HonnmaruNow = "冬夜-飾-照明二";
                        }
                    }
                }
                else if (month == 4)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        HonnmaruDataPath = "Home\\春季.gif";
                        HonnmaruNow = "春季";
                    }
                    else
                    {
                        Random rnd = new Random(Guid.NewGuid().GetHashCode());
                        // 亂數取1~4之間
                        int res = rnd.Next(1, 5);

                        // 使用哪種夜景
                        if (res == 1)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明一.gif";
                            HonnmaruNow = "冬夜-照明一";
                        }
                        else if (res == 2)
                        {
                            HonnmaruDataPath = "Home\\冬夜-照明二.gif";
                            HonnmaruNow = "冬夜-照明二";
                        }
                        else if (res == 3)
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明一.gif";
                            HonnmaruNow = "冬夜-飾-照明一";
                        }
                        else
                        {
                            HonnmaruDataPath = "Home\\冬夜-飾-照明二.gif";
                            HonnmaruNow = "冬夜-飾-照明二";
                        }
                    }
                }
                else if (month == 5)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        HonnmaruDataPath = "Home\\春季.gif";
                        HonnmaruNow = "春季";
                    }
                    else
                    {
                       HonnmaruDataPath = "Home\\夏夜.gif";
                       HonnmaruNow = "夏夜";
                    }
                }
            }
            else
            {
                HonnmaruDataPath = "Home\\" + MainForm.mySettings.PathHonnmaruSetting + ".gif";

                HonnmaruNow = MainForm.mySettings.PathHonnmaruSetting;

                if (MainForm.mySettings.PathHonnmaruSetting == "雨季")
                {
                    LoopSoundData = "雨季";
                }
            }

            // 有開啟音效選項，且有選擇音效是常駐loop的本丸環境
            if (SoundCheckBox.Checked == true && LoopSoundData != "")
            {
                // 呼叫撥放器
                // System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                //AxWMPLib.AxWindowsMediaPlayer sp = new AxWMPLib.AxWindowsMediaPlayer();
                axWMP_sound.settings.autoStart = false;
                axWMP_sound.settings.setMode("loop", true);
                axWMP_sound.settings.volume = VolumeTrackBar.Value;

                // 目前僅雨季有常駐loop音效
                if (LoopSoundData == "雨季") 
                {                   
                    SoundDataPath = DataPath + "Home\\Sound\\rain.mp3";
                }

                try
                {
                    axWMP_sound.URL = SoundDataPath;
                    axWMP_sound.Ctlcontrols.play();
                    //sp.SoundLocation = VoicePath;
                    //sp.Play();
                }
                catch
                {
                    MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            try
            {
                HonnmaruPictureBox.Image = Image.FromFile(DataPath + HonnmaruDataPath);
            }
            catch
            {
                MessageBox.Show("無法取得資料，無法更改本丸環境。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        // 每次更改是否隨現實時間的設定，都會直接開始檢查並設定本丸環境
        private void RealTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HonnmaruSet();
            MainForm.mySettings.PathRealTimeSetting = RealTimeCheckBox.Checked;
        }
        // 環境檢查，觸發了時間點
        private void RealTimeTimer_Tick(object sender, EventArgs e)
        {
            HonnmaruSet();
        }
        // 當觸發了背景聲音時
        private void SoundTimer_Tick(object sender, EventArgs e)
        {
            SoundSet();

            // 下次的觸發點
            SoundTimer.Interval = GetIntervalTime(SoundIntervalMin, SoundIntervalMax);
        }
        // 音效設置：一般：雀鳴
        //           十五夜、秋夜：秋蟲鳴
        //           雨季：雨(loop)
        //           雨季-晴：蛙鳴
        //           春季：鳥鳴
        //           夏夜：夏蟲鳴
        //           夏季：風鈴
        //           撒豆驅鬼節：鴉鳴
        // 雨季因為是loop的關係，在本丸環境設置時即完成，不會在此設定
        private void SoundSet()
        {
            // 有開啟音效選項
            if (SoundCheckBox.Checked == true)
            {
                // 呼叫撥放器
                // System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                //AxWMPLib.AxWindowsMediaPlayer sp = new AxWMPLib.AxWindowsMediaPlayer();
                axWMP_sound.settings.autoStart = false;
                axWMP_sound.settings.setMode("loop", false);
                axWMP_sound.settings.volume = VolumeTrackBar.Value;

                if (HonnmaruNow == "一般") 
                {
                    SoundDataPath = DataPath + "Home\\Sound\\sparrow.mp3";
                }
                else if (HonnmaruNow == "十五夜" || HonnmaruNow == "秋夜")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\insect.mp3";
                }
                else if (HonnmaruNow == "雨季-晴")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\frog.mp3";
                }
                else if (HonnmaruNow == "春季")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\bird.mp3";
                }
                else if (HonnmaruNow == "夏夜")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\insect.mp3";
                }
                else if (HonnmaruNow == "夏季")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\wind_bell.mp3";
                }
                else if (HonnmaruNow == "撒豆驅鬼節")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\crow.mp3";
                }

                try
                {
                    axWMP_sound.URL = SoundDataPath;
                    axWMP_sound.Ctlcontrols.play();
                    //sp.SoundLocation = VoicePath;
                    //sp.Play();
                }
                catch
                {
                    MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // 放置語音部份，取得時間點
        private int GetIntervalTime(int min_minute, int max_minute)
        {
            // 取real亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            // 時間單位為毫秒，故1000才是1秒，60*1000才是1分鐘
            return rnd.Next(min_minute*60*1000, max_minute*60*1000 + 1);
        }
        // 放置語音部份，觸發了時間點
        private void VoiceTimer_Tick(object sender, EventArgs e)
        {
            // 有開啟語音選項
            if (VoiceCheckBox.Checked == true) 
            {
                // 呼叫撥放器
                // System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                //AxWMPLib.AxWindowsMediaPlayer sp = new AxWMPLib.AxWindowsMediaPlayer();
                axWMP_voice.settings.autoStart = false;
                axWMP_voice.settings.volume = VolumeTrackBar.Value;

                try
                {
                    String VoicePath = DataPath + MainForm.mySettings.PathToukennSetting + "\\time.wav";
                    axWMP_voice.URL = VoicePath;
                    axWMP_voice.Ctlcontrols.play();
                    //sp.SoundLocation = VoicePath;
                    //sp.Play();
                }
                catch
                {
                    MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // 下次的觸發點
            VoiceTimer.Interval = GetIntervalTime(VoiceIntervalMin, VoiceIntervalMax);
        }
        // 點擊語音部分
        private void ToukennPictureBox_MouseClick(object sender, MouseEventArgs e)
        {           
            // 先檢查確實點在刀男身上，並且有開起語音選項
            if (HitTest(ToukennPictureBox, e.X, e.Y) && VoiceCheckBox.Checked == true) 
            {
                // 呼叫撥放器
                //System.Media.SoundPlayer sp = new System.Media.SoundPlayer(); 
                //axWMPLib.AxWindowsMediaPlayer sp = new AxWMPLib.AxWindowsMediaPlayer();
                axWMP_voice.settings.autoStart = false;
                axWMP_voice.settings.volume = VolumeTrackBar.Value;

                // 取real亂數
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                // 亂數範圍從1~3
                int num = rnd.Next(1, 4);

                // 路徑目前先用指定的，之後要改成讀參數式的
                if (num == 1)
                {
                    try
                    {
                        String VoicePath = DataPath + MainForm.mySettings.PathToukennSetting + "\\touch_1.wav";
                        axWMP_voice.URL = VoicePath;
                        axWMP_voice.Ctlcontrols.play();
                        //sp.SoundLocation = VoicePath;
                        //sp.Play();
                    }
                    catch
                    {
                        MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (num == 2)
                {
                    try
                    {
                        String VoicePath = DataPath + MainForm.mySettings.PathToukennSetting + "\\touch_2.wav";
                        axWMP_voice.URL = VoicePath;
                        axWMP_voice.Ctlcontrols.play();
                        //sp.SoundLocation = VoicePath;
                        //sp.Play();
                    }
                    catch
                    {
                        MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    try
                    {
                        String VoicePath = DataPath + MainForm.mySettings.PathToukennSetting + "\\touch_3.wav";
                        axWMP_voice.URL = VoicePath;
                        axWMP_voice.Ctlcontrols.play();
                        //sp.SoundLocation = VoicePath;
                        //sp.Play();
                    }
                    catch
                    {
                        MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        // 檢查確實點在刀男身上
        private bool HitTest(PictureBox man, int mouse_x, int mouse_y)
        {
            // 先假定不是點在刀男身上
            var result = false;

            // 如果找不到對象
            if (man.Image == null)
            {
                return result;
            }

            // 抓取方法
            var method = typeof(PictureBox).GetMethod("ImageRectangleFromSizeMode", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var r = (Rectangle)method.Invoke(man, new object[] { man.SizeMode });
            
            // 開始判斷
            using (var bm = new Bitmap(r.Width, r.Height))
            {
                using (var g = Graphics.FromImage(bm))
                {
                    g.DrawImage(man.Image, 0, 0, r.Width, r.Height);
                }
                if (r.Contains(mouse_x, mouse_y) && bm.GetPixel(mouse_x - r.X, mouse_y - r.Y).A != 0)
                {
                    result = true;
                }
            }
            return result;
        } 
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void SimulationPath_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 設定本子視窗關閉
            MainForm.FormOpenList[5] = false;
            // 第一行mySettings後的變數要換成於專案Settings中設定的名稱
            MainForm.mySettings.PathPosition = new Point(this.Location.X, this.Location.Y);
            MainForm.mySettings.Save();
        }
    }
}
