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
        // 放置語音間隔，單位分鐘
        int VoiceIntervalMin = 5;
        int VoiceIntervalMax = 40;
        // 音效間隔，單位分鐘
        int SoundIntervalMin = 5;
        int SoundIntervalMax = 40;
        // 常駐音效間隔，單位秒
        int Interval = 0;
        int AlwaysSoundIntervalMin = 1;

        public SimulationPath()
        {
            InitializeComponent();
        }
        // 初始便載入的設定與值
        private void SimulationPath_Load(object sender, EventArgs e)
        {
            // 設定使用者介面與音訊音量設定
            this.Size = new Size(this.Size.Width, 630);
            VoiceCheckBox.Checked = MainForm.mySettings.PathVoiceSetting;
            SoundCheckBox.Checked = MainForm.mySettings.PathSoundSetting;
            VolumeTrackBar.Value = MainForm.mySettings.PathVolumeSetting;
            VolumeLabel.Text = "Vol. " + MainForm.mySettings.PathVolumeSetting;
            VolumeSet();

            // 設定使用者介面，本丸環境模式指定並進行顯示設置
            HonnmaruComboBox.Items.Add("常駐時節景趣");
            HonnmaruComboBox.Items.Add("現實時節景趣");
            HonnmaruComboBox.Text = MainForm.mySettings.HonnmaruStatusSetting;
            HonnmaruSet();

            // 計時器，用於放置語音，隨機間隔每5~40分鐘一次
            VoiceTimer.Interval = GetIntervalTime(VoiceIntervalMin, VoiceIntervalMax);
            VoiceTimer.Start();

            // 計時器，每分鐘檢查一次現實時間，如果有設置本丸時間隨現實時間，則會依此改動本丸環境
            RealTimeTimer.Interval = 1 * 60 * 1000;
            RealTimeTimer.Start();

            // 計時器，處理背景音效，隨機間隔每5~40分鐘一次
            SoundTimer.Interval = GetIntervalTime(SoundIntervalMin, SoundIntervalMax);
            SoundTimer.Start();

            // 計時器，處理常駐背景音效，間格為音效長度+1秒以上，多多少由Interval決定
            AlwaysSoundTimer.Interval = GetIntervalTimeSecond(AlwaysSoundIntervalMin, AlwaysSoundIntervalMin + Interval);
            AlwaysSoundTimer.Start();
        }
        // 每次使用者更動使用習慣就要進行紀錄，設定是否要有刀男語音
        private void VoiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.mySettings.PathVoiceSetting = VoiceCheckBox.Checked;

            if (VoiceCheckBox.Checked == true)
            {
                axWMP_voice.settings.volume = VolumeTrackBar.Value;
            }
            else
            {
                axWMP_voice.settings.volume = 0;
            }
        }
        // 每次使用者更動使用習慣就要進行紀錄，設定是否要有音效
        private void SoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.mySettings.PathSoundSetting = SoundCheckBox.Checked;

            if (SoundCheckBox.Checked == true)
            {
                axWMP_sound.settings.volume = VolumeTrackBar.Value;
                axWMP_always_sound.settings.volume = VolumeTrackBar.Value;
            }
            else
            {
                axWMP_sound.settings.volume = 0;
                axWMP_always_sound.settings.volume = 0;
            }
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
            // 唯有設定有要啟用該聲音或音效時，才須要設定，不然要讓他保持音量0
            if (VoiceCheckBox.Checked == true)
            {
                axWMP_voice.settings.volume = VolumeTrackBar.Value;
            }
            else
            {
                axWMP_voice.settings.volume = 0;
            }

            if (SoundCheckBox.Checked == true)
            {
                axWMP_sound.settings.volume = VolumeTrackBar.Value;
                axWMP_always_sound.settings.volume = VolumeTrackBar.Value;
            }
            else
            {
                axWMP_sound.settings.volume = 0;
                axWMP_always_sound.settings.volume = 0;
            }
        }
        // 可依據使用者的選擇改變本丸環境模式
        private void HonnmaruComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            MainForm.mySettings.HonnmaruStatusSetting = HonnmaruComboBox.Text;
            HonnmaruSet();
        }
        // 檢查本丸環境模式，並依據其設定做出本丸環境顯示
        private void HonnmaruSet()
        {
            // 如果環境不是目標環境才需要改，預設是目標環境，所以設置不需改變環境，以下會確認是否要改
            bool needTochange = false;

            // 檢查是否是與現實時間同步本丸環境
            if (HonnmaruComboBox.Text == "現實時節景趣")
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
                //             2月：冬→冬夜(四種)，2/1~2/2：撒豆驅鬼節→冬夜(四種)，2/3~2/5：立春-梅→撒豆驅鬼節→冬夜(四種)
                //             3月：春→冬夜(四種)，目前沒有春夜，所以先這樣將就
                //             4月：春→冬夜(四種)，目前沒有春夜，所以先這樣將就
                //             5月：春→夏夜，目前沒有春夜，所以先這樣將就，5/5~5/7：立夏-藤
                // 日出日落時間：夏6~8月：5點、19點
                //               冬12~2月：7點、17點
                //               春3~5月、秋9~11月：6點、18點
                // 傍晚時分：日落前兩個小時
                if (month == 6)
                {
                    // 白天or夜晚
                    if (hour >= 5 && hour <= 19)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "雨季" && HonnmaruNow != "雨季-晴")
                        {
                            needTochange = true;

                            Random rnd = new Random(Guid.NewGuid().GetHashCode());
                            // 亂數取1~2之間
                            int res = rnd.Next(1, 3);

                            // 下雨與否
                            if (res == 1)
                            {
                                HonnmaruDataPath = "RealWorldTime\\雨季\\景趣.png";
                                HonnmaruNow = "雨季";
                            }
                            else
                            {
                                HonnmaruDataPath = "RealWorldTime\\雨季-晴\\景趣.png";
                                HonnmaruNow = "雨季-晴";
                            }
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "夏夜")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\夏夜\\景趣.png";
                            HonnmaruNow = "夏夜";
                        }
                    }
                }
                else if (month == 7)
                {
                    // 白天or夜晚
                    if (hour >= 5 && hour <= 19)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "夏季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\夏季\\景趣.png";
                            HonnmaruNow = "夏季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "夏夜")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\夏夜\\景趣.png";
                            HonnmaruNow = "夏夜";
                        }
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
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "立秋-向日葵")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\立秋-向日葵\\景趣.png";
                                HonnmaruNow = "立秋-向日葵";
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "夏季")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\夏季\\景趣.png";
                                HonnmaruNow = "夏季";
                            }
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "夏夜")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\夏夜\\景趣.png";
                            HonnmaruNow = "夏夜";
                        }
                    }
                }
                else if (month == 9)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "秋季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\秋季\\景趣.png";
                            HonnmaruNow = "秋季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "十五夜")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\十五夜\\景趣.png";
                            HonnmaruNow = "十五夜";
                        }
                    }
                }
                else if (month == 10)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "秋季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\秋季\\景趣.png";
                            HonnmaruNow = "秋季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "秋夜")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\秋夜\\景趣.png";
                            HonnmaruNow = "秋夜";
                        }
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
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "立冬-菊")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\立冬-菊\\景趣.png";
                                HonnmaruNow = "立冬-菊";
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "秋季")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\秋季\\景趣.png";
                                HonnmaruNow = "秋季";
                            }
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "秋夜")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\秋夜\\景趣.png";
                            HonnmaruNow = "秋夜";
                        }
                    }
                }
                else if (month == 12)
                {
                    // 白天or夜晚
                    if (hour >= 7 && hour <= 17)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\冬季\\景趣.png";
                            HonnmaruNow = "冬季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬夜-照明一" && HonnmaruNow != "冬夜-照明二" && HonnmaruNow != "冬夜-飾-照明一" && HonnmaruNow != "冬夜-飾-照明二")
                        {
                            needTochange = true;

                            Random rnd = new Random(Guid.NewGuid().GetHashCode());
                            // 亂數取1~4之間
                            int res = rnd.Next(1, 5);

                            // 使用哪種夜景
                            if (res == 1)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-照明一";
                            }
                            else if (res == 2)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-照明二";
                            }
                            else if (res == 3)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明一";
                            }
                            else
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明二";
                            }
                        }
                    }
                }
                else if (month == 1)
                {
                    // 白天or夜晚
                    if (hour >= 7 && hour <= 17)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\冬季\\景趣.png";
                            HonnmaruNow = "冬季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬夜-照明一" && HonnmaruNow != "冬夜-照明二" && HonnmaruNow != "冬夜-飾-照明一" && HonnmaruNow != "冬夜-飾-照明二")
                        {
                            needTochange = true;

                            Random rnd = new Random(Guid.NewGuid().GetHashCode());
                            // 亂數取1~4之間
                            int res = rnd.Next(1, 5);

                            // 使用哪種夜景
                            if (res == 1)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-照明一";
                            }
                            else if (res == 2)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-照明二";
                            }
                            else if (res == 3)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明一";
                            }
                            else
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明二";
                            }
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
                            // 此時段剛好兩種特殊節日，繼續細分
                            if (day == 1 || day == 2)
                            {
                                // 先判斷使否已經是目標佈景，否才須要換
                                if (HonnmaruNow != "撒豆驅鬼節")
                                {
                                    needTochange = true;

                                    HonnmaruDataPath = "RealWorldTime\\撒豆驅鬼節\\景趣.png";
                                    HonnmaruNow = "撒豆驅鬼節";
                                }
                            }
                            else
                            {
                                // 此幾日有傍晚時分，因此再次檢查時間
                                if (hour >= 15 && hour <= 17)
                                {
                                    // 先判斷使否已經是目標佈景，否才須要換
                                    if (HonnmaruNow != "撒豆驅鬼節")
                                    {
                                        needTochange = true;

                                        HonnmaruDataPath = "RealWorldTime\\撒豆驅鬼節\\景趣.png";
                                        HonnmaruNow = "撒豆驅鬼節";
                                    }
                                }
                                else
                                {
                                    // 先判斷使否已經是目標佈景，否才須要換
                                    if (HonnmaruNow != "立春-梅")
                                    {
                                        needTochange = true;

                                        HonnmaruDataPath = "RealWorldTime\\立春-梅\\景趣.png";
                                        HonnmaruNow = "立春-梅";
                                    }
                                }
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "冬季")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\冬季\\景趣.png";
                                HonnmaruNow = "冬季";
                            }
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬夜-照明一" && HonnmaruNow != "冬夜-照明二" && HonnmaruNow != "冬夜-飾-照明一" && HonnmaruNow != "冬夜-飾-照明二")
                        {
                            needTochange = true;

                            Random rnd = new Random(Guid.NewGuid().GetHashCode());
                            // 亂數取1~4之間
                            int res = rnd.Next(1, 5);

                            // 使用哪種夜景
                            if (res == 1)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-照明一";
                            }
                            else if (res == 2)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-照明二";
                            }
                            else if (res == 3)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明一";
                            }
                            else
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明二";
                            }
                        }
                    }
                }
                else if (month == 3)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "春季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\春季\\景趣.png";
                            HonnmaruNow = "春季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬夜-照明一" && HonnmaruNow != "冬夜-照明二" && HonnmaruNow != "冬夜-飾-照明一" && HonnmaruNow != "冬夜-飾-照明二")
                        {
                            needTochange = true;

                            Random rnd = new Random(Guid.NewGuid().GetHashCode());
                            // 亂數取1~4之間
                            int res = rnd.Next(1, 5);

                            // 使用哪種夜景
                            if (res == 1)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-照明一";
                            }
                            else if (res == 2)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-照明二";
                            }
                            else if (res == 3)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明一";
                            }
                            else
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明二";
                            }
                        }
                    }
                }
                else if (month == 4)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "春季")
                        {
                            needTochange = true;

                            HonnmaruDataPath = "RealWorldTime\\春季\\景趣.png";
                            HonnmaruNow = "春季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "冬夜-照明一" && HonnmaruNow != "冬夜-照明二" && HonnmaruNow != "冬夜-飾-照明一" && HonnmaruNow != "冬夜-飾-照明二")
                        {
                            needTochange = true;

                            Random rnd = new Random(Guid.NewGuid().GetHashCode());
                            // 亂數取1~4之間
                            int res = rnd.Next(1, 5);

                            // 使用哪種夜景
                            if (res == 1)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-照明一";
                            }
                            else if (res == 2)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-照明二";
                            }
                            else if (res == 3)
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明一\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明一";
                            }
                            else
                            {
                                HonnmaruDataPath = "RealWorldTime\\冬夜-飾-照明二\\景趣.png";
                                HonnmaruNow = "冬夜-飾-照明二";
                            }
                        }
                    }
                }
                else if (month == 5)
                {
                    // 白天or夜晚
                    if (hour >= 6 && hour <= 18)
                    {
                        // 是否是特殊節日
                        if (day == 5 || day == 6 || day == 7)
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "立夏-藤")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\立夏-藤\\景趣.png";
                                HonnmaruNow = "立夏-藤";
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "春季")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\春季\\景趣.png";
                                HonnmaruNow = "春季";
                            }
                        }
                    }
                    else
                    {
                        // 是否是特殊節日
                        if (day == 5 || day == 6 || day == 7)
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "立夏-藤")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\立夏-藤\\景趣.png";
                                HonnmaruNow = "立夏-藤";
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "夏夜")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "RealWorldTime\\夏夜\\景趣.png";
                                HonnmaruNow = "夏夜";
                            }
                        }
                    }
                }
            }
            else
            {
                if (HonnmaruNow != "Default")
                {
                    needTochange = true;

                    HonnmaruDataPath = "Default\\景趣.png";
                    HonnmaruNow = "Default";
                }
            }

            // 嘗試改變本丸環境顯示
            if (needTochange)
            {
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
        // 當觸發了常駐背景聲音時
        private void AlwaysSoundTimer_Tick(object sender, EventArgs e)
        {
            AlwaysSoundSet();

            // 下次的觸發點
            AlwaysSoundTimer.Interval = GetIntervalTimeSecond(AlwaysSoundIntervalMin, AlwaysSoundIntervalMin + Interval);
        }
        // 音效設置：一般：雀鳴
        //           十五夜、秋夜：蟲鳴
        //           雨季-晴：蛙鳴
        //           春季、立春-梅：鳥鳴
        //           夏夜：蟲鳴
        //           夏季：風鈴
        //           撒豆驅鬼節：鴉鳴
        private void SoundSet()
        {
            axWMP_sound.settings.autoStart = false;
            axWMP_sound.settings.setMode("loop", false);
            axWMP_sound.Ctlcontrols.stop();

            if (HonnmaruNow == "Default")
            {
                SoundDataPath = DataPath + HonnmaruNow + "\\sound_1.mp3";
            }
            else {
                SoundDataPath = DataPath + "RealWorldTime\\" + HonnmaruNow + "\\sound_1.mp3";
            }

            try
            {
                axWMP_sound.URL = SoundDataPath;
                axWMP_sound.Ctlcontrols.play();
            }
            catch
            {
                // do nothings
            }
        }
        // 常駐音效設置：雨季：下雨聲
        //               立夏-藤：河流聲
        private void AlwaysSoundSet()
        {
            axWMP_always_sound.settings.autoStart = false;
            axWMP_always_sound.settings.setMode("loop", false);
            axWMP_always_sound.Ctlcontrols.stop();

            if (HonnmaruNow == "Default")
            {
                SoundDataPath = DataPath + HonnmaruNow + "\\sound_2.mp3";
            }
            else
            {
                SoundDataPath = DataPath + "RealWorldTime\\" + HonnmaruNow + "\\sound_2.mp3";
            }

            try
            {
                axWMP_always_sound.URL = SoundDataPath;
                axWMP_always_sound.Ctlcontrols.play();
                // 取得常駐音訊的總長度
                TagLib.File TagLib_sound = TagLib.File.Create(SoundDataPath, TagLib.ReadStyle.Average);
                AlwaysSoundIntervalMin = (int)TagLib_sound.Properties.Duration.TotalSeconds + 1;
            }
            catch
            {
                // do nothings
            }
        }
        // 隨機取得時間間隔點，單位分鐘
        private int GetIntervalTime(int min_minute, int max_minute)
        {
            // 取real亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            // 時間單位為毫秒，故1000才是1秒，60*1000才是1分鐘
            return rnd.Next(min_minute*60*1000, max_minute*60*1000 + 1);
        }
        // 隨機取得時間間隔點，單位秒
        private int GetIntervalTimeSecond(int min_second, int max_second)
        {
            // 取real亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            // 時間單位為毫秒，故1000才是1秒
            return rnd.Next(min_second * 1000, max_second * 1000 + 1);
        }
        // 放置語音部份，觸發了時間點
        private void VoiceTimer_Tick(object sender, EventArgs e)
        {
            axWMP_voice.settings.autoStart = false;
            axWMP_voice.settings.setMode("loop", false);
            axWMP_voice.Ctlcontrols.stop();

            try
            {
                String VoicePath = DataPath + HonnmaruNow + "\\time.mp3";
                axWMP_voice.URL = VoicePath;
                axWMP_voice.Ctlcontrols.play();
            }
            catch
            {
                // do nothings
            }

            // 下次的觸發點
            VoiceTimer.Interval = GetIntervalTime(VoiceIntervalMin, VoiceIntervalMax);
        }
        // 點擊語音部分
        private void HonnmaruPictureBox_DoubleClick(object sender, EventArgs e)
        {
            String VoicePath;

            axWMP_voice.settings.autoStart = false;
            axWMP_voice.settings.setMode("loop", false);
            axWMP_voice.Ctlcontrols.stop();

            // 取real亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            // 亂數範圍從1~3
            int num = rnd.Next(1, 4);

            if (num == 1)
            {
                VoicePath = DataPath + HonnmaruNow + "\\touch_1.mp3";
            }
            else if (num == 2)
            {
                VoicePath = DataPath + HonnmaruNow + "\\touch_2.mp3";
            }
            else
            {
                VoicePath = DataPath + HonnmaruNow + "\\touch_3.mp3";
            }

            try
            {
                axWMP_voice.URL = VoicePath;
                axWMP_voice.Ctlcontrols.play();
            }
            catch
            {
                // do nothings
            }
        }
        // 點擊即可顯示設定的介面
        private void UiShowLabel_Click(object sender, EventArgs e)
        {
            string state = UiShowLabel.Text;

            if (state == "︾")
            {
                UiShowLabel.Text = "︽";
                this.Size = new Size(this.Size.Width, 686);
            }
            else 
            {
                UiShowLabel.Text = "︾";
                this.Size = new Size(this.Size.Width, 630);
            }
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
        // 教學說明子視窗
        private void TutorialButton_Click(object sender, EventArgs e)
        {
            SimulationPathTutorial subTutorialForm = new SimulationPathTutorial();
            subTutorialForm.ShowDialog(this);
        }
    }
}
