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
        int VoiceIntervalMin = 1;
        int VoiceIntervalMax = 60;
        // 音效間隔，單位分鐘
        int SoundIntervalMin = 1;
        int SoundIntervalMax = 60;

        public SimulationPath()
        {
            InitializeComponent();
        }
        // 初始便載入的設定與值
        private void SimulationPath_Load(object sender, EventArgs e)
        {
            // 設定使用者介面
            this.Size = new Size(this.Size.Width, 630);
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
            HonnmaruComboBox.Items.Add("立春-梅");
            HonnmaruComboBox.Items.Add("立夏-藤");
            HonnmaruComboBox.Items.Add("立秋-向日葵");
            HonnmaruComboBox.Items.Add("立冬-菊");

            HonnmaruComboBox.Text = MainForm.mySettings.PathHonnmaruSetting;

            // 抓取本丸環境資料
            RealTimeCheckBox.Checked = MainForm.mySettings.PathRealTimeSetting;
            HonnmaruSet();

            // 設定使用者介面，刀男
            ToukennComboBox.Items.Add("--");
            ToukennComboBox.Items.Add("3_三日月宗近");
            ToukennComboBox.Items.Add("5_小狐丸");
            ToukennComboBox.Items.Add("7_石切丸");
            //ToukennComboBox.Items.Add("8_石切丸-極"); //缺語音與立繪
            ToukennComboBox.Items.Add("9_岩融");
            ToukennComboBox.Items.Add("11_今劍");
            ToukennComboBox.Items.Add("12_今劍-極");
            ToukennComboBox.Items.Add("13_大典太光世");
            ToukennComboBox.Items.Add("15_ソハヤノツルキ");
            ToukennComboBox.Items.Add("17_數珠丸恒次");
            ToukennComboBox.Items.Add("19_にっかり青江");
            ToukennComboBox.Items.Add("20_にっかり青江-極");
            ToukennComboBox.Items.Add("23_鳴狐");
            ToukennComboBox.Items.Add("24_鳴狐-極");
            ToukennComboBox.Items.Add("25_一期一振");
            ToukennComboBox.Items.Add("27_鯰尾藤四郎");
            ToukennComboBox.Items.Add("28_鯰尾藤四郎-極");
            ToukennComboBox.Items.Add("29_骨喰藤四郎");
            ToukennComboBox.Items.Add("30_骨喰藤四郎-極");
            ToukennComboBox.Items.Add("31_平野藤四郎");
            ToukennComboBox.Items.Add("32_平野藤四郎-極");
            ToukennComboBox.Items.Add("33_厚藤四郎");
            ToukennComboBox.Items.Add("34_厚藤四郎-極");
            ToukennComboBox.Items.Add("35_後藤藤四郎");
            ToukennComboBox.Items.Add("36_後藤藤四郎-極");
            ToukennComboBox.Items.Add("37_信濃藤四郎");
            ToukennComboBox.Items.Add("38_信濃藤四郎-極");
            ToukennComboBox.Items.Add("39_前田藤四郎");
            ToukennComboBox.Items.Add("40_前田藤四郎-極");
            ToukennComboBox.Items.Add("41_秋田藤四郎");
            ToukennComboBox.Items.Add("42_秋田藤四郎-極");
            ToukennComboBox.Items.Add("43_博多藤四郎");
            ToukennComboBox.Items.Add("44_博多藤四郎-極");
            ToukennComboBox.Items.Add("45_亂藤四郎");
            ToukennComboBox.Items.Add("46_亂藤四郎-極");
            ToukennComboBox.Items.Add("47_五虎退");
            ToukennComboBox.Items.Add("48_五虎退-極");
            ToukennComboBox.Items.Add("49_藥研藤四郎");
            ToukennComboBox.Items.Add("50_藥研藤四郎-極");
            ToukennComboBox.Items.Add("51_包丁藤四郎");
            ToukennComboBox.Items.Add("52_包丁藤四郎-極");
            ToukennComboBox.Items.Add("53_大包平");
            ToukennComboBox.Items.Add("55_鶯丸");
            ToukennComboBox.Items.Add("57_明石国行");
            ToukennComboBox.Items.Add("59_螢丸");
            ToukennComboBox.Items.Add("60_螢丸-極");
            ToukennComboBox.Items.Add("61_愛染国俊");
            ToukennComboBox.Items.Add("62_愛染国俊-極");
            ToukennComboBox.Items.Add("63_千子村正");
            //ToukennComboBox.Items.Add("64_千子村正-極"); //缺立繪
            ToukennComboBox.Items.Add("65_蜻蛉切");
            ToukennComboBox.Items.Add("67_物吉貞宗");
            ToukennComboBox.Items.Add("68_物吉貞宗-極");
            ToukennComboBox.Items.Add("69_太鼓鐘貞宗");
            ToukennComboBox.Items.Add("70_太鼓鐘貞宗-極");
            ToukennComboBox.Items.Add("71_龜甲貞宗");
            //ToukennComboBox.Items.Add("72_龜甲貞宗-極"); //缺立繪
            ToukennComboBox.Items.Add("73_燭台切光忠");
            ToukennComboBox.Items.Add("75_大般若長光");
            ToukennComboBox.Items.Add("77_小竜景光");
            ToukennComboBox.Items.Add("79_江雪左文字");
            ToukennComboBox.Items.Add("81_宗三左文字");
            ToukennComboBox.Items.Add("82_宗三左文字-極");
            ToukennComboBox.Items.Add("83_小夜左文字");
            ToukennComboBox.Items.Add("84_小夜左文字-極");
            ToukennComboBox.Items.Add("85_加州清光");
            ToukennComboBox.Items.Add("86_加州清光-極");
            ToukennComboBox.Items.Add("87_大和守安定");
            ToukennComboBox.Items.Add("88_大和守安定-極");
            ToukennComboBox.Items.Add("89_歌仙兼定");
            //ToukennComboBox.Items.Add("90_歌仙兼定-極"); //位置資訊已設置完畢，才發現缺語音（目前手頭上語音是網路上錄的，音質不好），故最終沒有加入
            ToukennComboBox.Items.Add("91_和泉守兼定");
            ToukennComboBox.Items.Add("92_和泉守兼定-極");
            ToukennComboBox.Items.Add("93_陸奧守吉行");
            ToukennComboBox.Items.Add("94_陸奧守吉行-極");
            ToukennComboBox.Items.Add("95_山姥切国広");
            //ToukennComboBox.Items.Add("96_山姥切国広-極"); //缺語音
            ToukennComboBox.Items.Add("97_山伏国広");
            ToukennComboBox.Items.Add("99_堀川国広");
            ToukennComboBox.Items.Add("100_堀川国広-極");
            ToukennComboBox.Items.Add("101_蜂須賀虎徹");
            ToukennComboBox.Items.Add("102_蜂須賀虎徹-極");
            ToukennComboBox.Items.Add("103_浦島虎徹");
            ToukennComboBox.Items.Add("104_浦島虎徹-極");
            ToukennComboBox.Items.Add("105_長曾祢虎徹");
            ToukennComboBox.Items.Add("106_長曾祢虎徹-極");
            ToukennComboBox.Items.Add("107_髭切");
            ToukennComboBox.Items.Add("112_膝丸");
            ToukennComboBox.Items.Add("116_大俱利伽羅");
            ToukennComboBox.Items.Add("117_大俱利伽羅-極");
            ToukennComboBox.Items.Add("118_へし切長谷部");
            ToukennComboBox.Items.Add("119_へし切長谷部-極");
            ToukennComboBox.Items.Add("120_不動行光");
            ToukennComboBox.Items.Add("121_不動行光-極");
            ToukennComboBox.Items.Add("122_獅子王");
            ToukennComboBox.Items.Add("124_小烏丸");
            ToukennComboBox.Items.Add("128_同田貫正国");
            ToukennComboBox.Items.Add("129_同田貫正国-極");
            ToukennComboBox.Items.Add("130_鶴丸国永");
            ToukennComboBox.Items.Add("132_太郎太刀");
            ToukennComboBox.Items.Add("133_太郎太刀-極");
            ToukennComboBox.Items.Add("134_次郎太刀");
            ToukennComboBox.Items.Add("135_次郎太刀-極");
            ToukennComboBox.Items.Add("136_日本號");
            ToukennComboBox.Items.Add("138_御手杵");
            ToukennComboBox.Items.Add("140_巴形薙刀");
            ToukennComboBox.Items.Add("142_毛利藤四郎");
            ToukennComboBox.Items.Add("144_篭手切江");
            ToukennComboBox.Items.Add("146_謙信景光");
            ToukennComboBox.Items.Add("148_小豆長光");
            ToukennComboBox.Items.Add("150_日向正宗");
            ToukennComboBox.Items.Add("152_靜形薙刀");
            ToukennComboBox.Items.Add("154_南泉一文字");
            ToukennComboBox.Items.Add("156_千代金丸");
            ToukennComboBox.Items.Add("158_山姥切長義");
            ToukennComboBox.Items.Add("160_豐前江");
            ToukennComboBox.Items.Add("162_祢々切丸");
            ToukennComboBox.Items.Add("164_白山吉光");
            ToukennComboBox.Items.Add("166_南海太郎朝尊");
            ToukennComboBox.Items.Add("168_肥前忠広");

            ToukennComboBox.Text = MainForm.mySettings.PathToukennSetting;

            // 抓取刀男資料
            ToukennPictureBox.Parent = HonnmaruPictureBox;          
            ToukennPictureBox.BackColor = Color.Transparent;
            ToukennSet();

            // 計時器，用於放置語音，隨機間隔每1~60分鐘一次
            VoiceTimer.Interval = GetIntervalTime(VoiceIntervalMin, VoiceIntervalMax);
            VoiceTimer.Start();

            // 計時器，每分鐘檢查一次現實時間，如果有設置本丸時間隨現實時間，則會依此改動本丸環境
            RealTimeTimer.Interval = 1 * 60 * 1000;
            RealTimeTimer.Start();

            // 計時器，處理背景音效，隨機間隔每1~60分鐘一次
            SoundTimer.Interval = GetIntervalTime(SoundIntervalMin, SoundIntervalMax);
            SoundTimer.Start();
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
            }
            else
            {
                axWMP_sound.settings.volume = 0;
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
            }
            else
            {
                axWMP_sound.settings.volume = 0;
            }
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
                    if (ToukennComboBox.Text == "89_歌仙兼定" || ToukennComboBox.Text == "162_祢々切丸")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.11);
                    }
                    else if (ToukennComboBox.Text == "100_堀川国広-極" || ToukennComboBox.Text == "30_骨喰藤四郎-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.09);
                    }
                    else if (ToukennComboBox.Text == "85_加州清光")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.08);
                    }
                    else if (ToukennComboBox.Text == "55_鶯丸")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.076);
                    }
                    else if (ToukennComboBox.Text == "36_後藤藤四郎-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.072);
                    }
                    else if (ToukennComboBox.Text == "33_厚藤四郎" || ToukennComboBox.Text == "146_謙信景光")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.065);
                    }
                    else if (ToukennComboBox.Text == "88_大和守安定-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.06);
                    }
                    else if (ToukennComboBox.Text == "62_愛染国俊-極" || ToukennComboBox.Text == "75_大般若長光")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.055);
                    }
                    else if (ToukennComboBox.Text == "12_今劍-極" || ToukennComboBox.Text == "87_大和守安定")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.045);
                    }
                    else if (ToukennComboBox.Text == "95_山姥切国広")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.04);
                    }
                    else if (ToukennComboBox.Text == "120_不動行光" || ToukennComboBox.Text == "122_獅子王" || ToukennComboBox.Text == "154_南泉一文字")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.035);
                    }
                    else if (ToukennComboBox.Text == "46_亂藤四郎-極" || ToukennComboBox.Text == "71_龜甲貞宗" || ToukennComboBox.Text == "79_江雪左文字" ||
                             ToukennComboBox.Text == "81_宗三左文字" || ToukennComboBox.Text == "112_膝丸" || ToukennComboBox.Text == "166_南海太郎朝尊")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.03);
                    }
                    else if (ToukennComboBox.Text == "83_小夜左文字" || ToukennComboBox.Text == "84_小夜左文字-極" || ToukennComboBox.Text == "94_陸奧守吉行-極" ||
                             ToukennComboBox.Text == "124_小烏丸" || ToukennComboBox.Text == "128_同田貫正国")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.025);
                    }
                    else if (ToukennComboBox.Text == "130_鶴丸国永")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.024);
                    }
                    else if (ToukennComboBox.Text == "102_蜂須賀虎徹-極" || ToukennComboBox.Text == "116_大俱利伽羅" || ToukennComboBox.Text == "150_日向正宗")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.022);
                    }
                    else if (ToukennComboBox.Text == "29_骨喰藤四郎" || ToukennComboBox.Text == "69_太鼓鐘貞宗" || ToukennComboBox.Text == "97_山伏国広" ||
                             ToukennComboBox.Text == "136_日本號" || ToukennComboBox.Text == "160_豐前江")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.02);
                    }
                    else if (ToukennComboBox.Text == "7_石切丸" || ToukennComboBox.Text == "93_陸奧守吉行")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.018);
                    }
                    else if (ToukennComboBox.Text == "13_大典太光世" || ToukennComboBox.Text == "23_鳴狐" || ToukennComboBox.Text == "53_大包平" ||
                             ToukennComboBox.Text == "129_同田貫正国-極" || ToukennComboBox.Text == "168_肥前忠広")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.014);
                    }
                    else if (ToukennComboBox.Text == "25_一期一振" || ToukennComboBox.Text == "40_前田藤四郎-極" || ToukennComboBox.Text == "43_博多藤四郎" ||
                             ToukennComboBox.Text == "51_包丁藤四郎" || ToukennComboBox.Text == "61_愛染国俊" || ToukennComboBox.Text == "99_堀川国広" ||
                             ToukennComboBox.Text == "132_太郎太刀" || ToukennComboBox.Text == "142_毛利藤四郎")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.01);
                    }
                    else if (ToukennComboBox.Text == "35_後藤藤四郎" || ToukennComboBox.Text == "41_秋田藤四郎" || ToukennComboBox.Text == "59_螢丸" ||
                             ToukennComboBox.Text == "105_長曾祢虎徹")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.005);
                    }
                    else if (ToukennComboBox.Text == "133_太郎太刀-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * 0.001);
                    }
                    else if (ToukennComboBox.Text == "107_髭切" || ToukennComboBox.Text == "24_鳴狐-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.002);
                    }
                    else if (ToukennComboBox.Text == "9_岩融" || ToukennComboBox.Text == "17_數珠丸恒次" || ToukennComboBox.Text == "52_包丁藤四郎-極" ||
                             ToukennComboBox.Text == "57_明石国行" || ToukennComboBox.Text == "68_物吉貞宗-極" || ToukennComboBox.Text == "103_浦島虎徹" ||
                             ToukennComboBox.Text == "134_次郎太刀" || ToukennComboBox.Text == "140_巴形薙刀" || ToukennComboBox.Text == "42_秋田藤四郎-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.01);
                    }
                    else if (ToukennComboBox.Text == "117_大俱利伽羅-極" || ToukennComboBox.Text == "164_白山吉光")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.014);
                    }
                    else if (ToukennComboBox.Text == "39_前田藤四郎" || ToukennComboBox.Text == "49_藥研藤四郎" || ToukennComboBox.Text == "135_次郎太刀-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.02);
                    }
                    else if (ToukennComboBox.Text == "106_長曾祢虎徹-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.023);
                    }
                    else if (ToukennComboBox.Text == "15_ソハヤノツルキ")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.027);
                    }
                    else if (ToukennComboBox.Text == "5_小狐丸" || ToukennComboBox.Text == "67_物吉貞宗" || ToukennComboBox.Text == "77_小竜景光" || 
                             ToukennComboBox.Text == "156_千代金丸")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.03);
                    }
                    else if (ToukennComboBox.Text == "90_歌仙兼定-極" || ToukennComboBox.Text == "60_螢丸-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.035);
                    }
                    else if (ToukennComboBox.Text == "11_今劍" || ToukennComboBox.Text == "20_にっかり青江-極" || ToukennComboBox.Text == "28_鯰尾藤四郎-極" ||
                             ToukennComboBox.Text == "91_和泉守兼定")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.04);
                    }
                    else if (ToukennComboBox.Text == "148_小豆長光")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.045);
                    }
                    else if (ToukennComboBox.Text == "119_へし切長谷部-極" || ToukennComboBox.Text == "121_不動行光-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.05);
                    }
                    else if (ToukennComboBox.Text == "48_五虎退-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.06);
                    }
                    else if (ToukennComboBox.Text == "38_信濃藤四郎-極" || ToukennComboBox.Text == "118_へし切長谷部")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.07);
                    }
                    else if (ToukennComboBox.Text == "19_にっかり青江" || ToukennComboBox.Text == "73_燭台切光忠")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.075);
                    }
                    else if (ToukennComboBox.Text == "50_藥研藤四郎-極")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.085);
                    }
                    else if (ToukennComboBox.Text == "138_御手杵")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.11);
                    }
                    else if (ToukennComboBox.Text == "65_蜻蛉切")
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width) + HonnmaruPictureBox.Width * -0.115);
                    }
                    else
                    {
                        newX = (int)(0.5 * (HonnmaruPictureBox.Width - ToukennPictureBox.Width));
                    }

                    // 刀男的身高係數，後面乘上的小數點，值越小刀男越高，反之越矮
                    // 按係數低至高排列
                    int newY = 0;
                    if (ToukennComboBox.Text == "136_日本號")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * -0.33);
                    }
                    else if (ToukennComboBox.Text == "162_祢々切丸")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * -0.145);
                    }
                    else if (ToukennComboBox.Text == "9_岩融")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * -0.105);
                    }
                    else if (ToukennComboBox.Text == "65_蜻蛉切" || ToukennComboBox.Text == "152_靜形薙刀")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * -0.08);
                    }
                    else if (ToukennComboBox.Text == "140_巴形薙刀")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * -0.055);
                    }
                    else if (ToukennComboBox.Text == "133_太郎太刀-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.005);
                    }
                    else if (ToukennComboBox.Text == "132_太郎太刀")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.01);
                    }
                    else if (ToukennComboBox.Text == "134_次郎太刀")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.015);
                    }
                    else if (ToukennComboBox.Text == "7_石切丸")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.03);
                    }
                    else if (ToukennComboBox.Text == "138_御手杵")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.045);
                    }
                    else if (ToukennComboBox.Text == "5_小狐丸" || ToukennComboBox.Text == "63_千子村正")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.055);
                    }
                    else if (ToukennComboBox.Text == "13_大典太光世" || ToukennComboBox.Text == "52_包丁藤四郎-極" || ToukennComboBox.Text == "53_大包平" ||
                             ToukennComboBox.Text == "92_和泉守兼定-極" || ToukennComboBox.Text == "105_長曾祢虎徹")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.08);
                    }
                    else if (ToukennComboBox.Text == "3_三日月宗近" || ToukennComboBox.Text == "12_今劍-極" || ToukennComboBox.Text == "15_ソハヤノツルキ" ||
                             ToukennComboBox.Text == "89_歌仙兼定" || ToukennComboBox.Text == "93_陸奧守吉行" || ToukennComboBox.Text == "57_明石国行" ||
                             ToukennComboBox.Text == "77_小竜景光" || ToukennComboBox.Text == "90_歌仙兼定-極" || ToukennComboBox.Text == "94_陸奧守吉行-極" || 
                             ToukennComboBox.Text == "148_小豆長光")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.085);
                    }
                    else if (ToukennComboBox.Text == "73_燭台切光忠" || ToukennComboBox.Text == "102_蜂須賀虎徹-極" || ToukennComboBox.Text == "106_長曾祢虎徹-極" ||
                             ToukennComboBox.Text == "112_膝丸")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.095);
                    }
                    else if (ToukennComboBox.Text == "75_大般若長光" || ToukennComboBox.Text == "81_宗三左文字" || ToukennComboBox.Text == "91_和泉守兼定" ||
                             ToukennComboBox.Text == "116_大俱利伽羅" || ToukennComboBox.Text == "128_同田貫正国" || ToukennComboBox.Text == "129_同田貫正国-極" || 
                             ToukennComboBox.Text == "166_南海太郎朝尊")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.1);
                    }
                    else if (ToukennComboBox.Text == "118_へし切長谷部" || ToukennComboBox.Text == "119_へし切長谷部-極" || ToukennComboBox.Text == "130_鶴丸国永" ||
                             ToukennComboBox.Text == "154_南泉一文字" || ToukennComboBox.Text == "117_大俱利伽羅-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.105);
                    }
                    else if (ToukennComboBox.Text == "17_數珠丸恒次" || ToukennComboBox.Text == "95_山姥切国広" || ToukennComboBox.Text == "101_蜂須賀虎徹" ||
                             ToukennComboBox.Text == "79_江雪左文字" || ToukennComboBox.Text == "160_豐前江")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.11);
                    }
                    else if (ToukennComboBox.Text == "25_一期一振" || ToukennComboBox.Text == "55_鶯丸" || ToukennComboBox.Text == "97_山伏国広" ||
                             ToukennComboBox.Text == "107_髭切" || ToukennComboBox.Text == "156_千代金丸")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.115);
                    }
                    else if (ToukennComboBox.Text == "168_肥前忠広")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.117);
                    }
                    else if (ToukennComboBox.Text == "71_龜甲貞宗" || ToukennComboBox.Text == "24_鳴狐-極" || ToukennComboBox.Text == "158_山姥切長義")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.12);
                    }
                    else if (ToukennComboBox.Text == "19_にっかり青江" || ToukennComboBox.Text == "20_にっかり青江-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.125);
                    }
                    else if ( ToukennComboBox.Text == "122_獅子王")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.135);
                    }
                    else if (ToukennComboBox.Text == "82_宗三左文字-極" || ToukennComboBox.Text == "122_獅子王")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.14);
                    }
                    else if (ToukennComboBox.Text == "104_浦島虎徹-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.145);
                    }
                    else if (ToukennComboBox.Text == "23_鳴狐" || ToukennComboBox.Text == "47_五虎退")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.15);
                    }
                    else if (ToukennComboBox.Text == "28_鯰尾藤四郎-極" || ToukennComboBox.Text == "34_厚藤四郎-極" || ToukennComboBox.Text == "68_物吉貞宗-極" ||
                             ToukennComboBox.Text == "87_大和守安定" || ToukennComboBox.Text == "103_浦島虎徹")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.16);
                    }
                    else if (ToukennComboBox.Text == "40_前田藤四郎-極" || ToukennComboBox.Text == "85_加州清光")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.17);
                    }
                    else if (ToukennComboBox.Text == "86_加州清光-極" || ToukennComboBox.Text == "88_大和守安定-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.175);
                    }
                    else if (ToukennComboBox.Text == "124_小烏丸")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.18);
                    }
                    else if (ToukennComboBox.Text == "120_不動行光" || ToukennComboBox.Text == "121_不動行光-極" || ToukennComboBox.Text == "144_篭手切江")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.197);
                    }
                    else if (ToukennComboBox.Text == "27_鯰尾藤四郎" || ToukennComboBox.Text == "36_後藤藤四郎-極" || ToukennComboBox.Text == "70_太鼓鐘貞宗-極" || 
                             ToukennComboBox.Text == "164_白山吉光")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.2);
                    }
                    else if (ToukennComboBox.Text == "29_骨喰藤四郎" || ToukennComboBox.Text == "35_後藤藤四郎" || ToukennComboBox.Text == "38_信濃藤四郎-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.205);
                    }
                    else if (ToukennComboBox.Text == "33_厚藤四郎" || ToukennComboBox.Text == "67_物吉貞宗" || ToukennComboBox.Text == "69_太鼓鐘貞宗" ||
                             ToukennComboBox.Text == "84_小夜左文字-極" || ToukennComboBox.Text == "99_堀川国広" || ToukennComboBox.Text == "100_堀川国広-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.21);
                    }
                    else if (ToukennComboBox.Text == "30_骨喰藤四郎-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.215);
                    }
                    else if (ToukennComboBox.Text == "48_五虎退-極" || ToukennComboBox.Text == "83_小夜左文字" || ToukennComboBox.Text == "42_秋田藤四郎-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.22);
                    }
                    else if (ToukennComboBox.Text == "37_信濃藤四郎" || ToukennComboBox.Text == "45_亂藤四郎" || ToukennComboBox.Text == "46_亂藤四郎-極" ||
                             ToukennComboBox.Text == "49_藥研藤四郎" || ToukennComboBox.Text == "50_藥研藤四郎-極" || ToukennComboBox.Text == "61_愛染国俊" ||
                             ToukennComboBox.Text == "150_日向正宗")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.24);
                    }
                    else if (ToukennComboBox.Text == "142_毛利藤四郎")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.245);
                    }
                    else if (ToukennComboBox.Text == "31_平野藤四郎" || ToukennComboBox.Text == "43_博多藤四郎" || ToukennComboBox.Text == "62_愛染国俊-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.25);
                    }
                    else if (ToukennComboBox.Text == "39_前田藤四郎" || ToukennComboBox.Text == "41_秋田藤四郎" || ToukennComboBox.Text == "44_博多藤四郎-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.26);
                    }
                    else if (ToukennComboBox.Text == "32_平野藤四郎-極" || ToukennComboBox.Text == "146_謙信景光")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.27);
                    }
                    else if (ToukennComboBox.Text == "11_今劍")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.28);
                    }
                    else if (ToukennComboBox.Text == "51_包丁藤四郎")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.29);
                    }
                    else if (ToukennComboBox.Text == "59_螢丸" || ToukennComboBox.Text == "60_螢丸-極")
                    {
                        newY = (int)(HonnmaruPictureBox.Height * 0.3);
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
            MainForm.mySettings.PathHonnmaruSetting = HonnmaruComboBox.Text;

            HonnmaruSet();
        }
        // 檢查現實時間，並對應更改本丸環境
        private void HonnmaruSet()
        {
            // 如果環境不是目標環境才需要改，預設是目標環境，所以設置不需改變環境，以下會確認是否要改
            bool needTochange = false;
            // 預先假定目標環境是沒有loop音效的，由以下確認使否要改動
            bool LoopSoundData = false;
 
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
                                HonnmaruDataPath = "Home\\雨季.gif";
                                HonnmaruNow = "雨季";
                                LoopSoundData = true;
                            }
                            else
                            {
                                HonnmaruDataPath = "Home\\雨季-晴.gif";
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
                            
                            HonnmaruDataPath = "Home\\夏夜.gif";
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
                            
                            HonnmaruDataPath = "Home\\夏季.gif";
                            HonnmaruNow = "夏季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "夏夜")
                        {
                            needTochange = true;
                            
                            HonnmaruDataPath = "Home\\夏夜.gif";
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
                                
                                HonnmaruDataPath = "Home\\立秋-向日葵.gif";
                                HonnmaruNow = "立秋-向日葵";
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "夏季")
                            {
                                needTochange = true;
                                
                                HonnmaruDataPath = "Home\\夏季.gif";
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
                            
                            HonnmaruDataPath = "Home\\夏夜.gif";
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
                            
                            HonnmaruDataPath = "Home\\秋季.gif";
                            HonnmaruNow = "秋季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "十五夜")
                        {
                            needTochange = true;
                            
                            HonnmaruDataPath = "Home\\十五夜.gif";
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
                            
                            HonnmaruDataPath = "Home\\秋季.gif";
                            HonnmaruNow = "秋季";
                        }
                    }
                    else
                    {
                        // 先判斷使否已經是目標佈景，否才須要換
                        if (HonnmaruNow != "秋夜")
                        {
                            needTochange = true;
                            
                            HonnmaruDataPath = "Home\\秋夜.gif";
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
                                
                                HonnmaruDataPath = "Home\\立冬-菊.gif";
                                HonnmaruNow = "立冬-菊";
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "秋季")
                            {
                                needTochange = true;
                                
                                HonnmaruDataPath = "Home\\秋季.gif";
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
                            
                            HonnmaruDataPath = "Home\\秋夜.gif";
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
                            
                            HonnmaruDataPath = "Home\\冬季.gif";
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
                            
                            HonnmaruDataPath = "Home\\冬季.gif";
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
                                    
                                    HonnmaruDataPath = "Home\\撒豆驅鬼節.gif";
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
                                        
                                        HonnmaruDataPath = "Home\\撒豆驅鬼節.gif";
                                        HonnmaruNow = "撒豆驅鬼節";
                                    }
                                }
                                else
                                {
                                    // 先判斷使否已經是目標佈景，否才須要換
                                    if (HonnmaruNow != "立春-梅")
                                    {
                                        needTochange = true;
                                        
                                        HonnmaruDataPath = "Home\\立春-梅.gif";
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
                                
                                HonnmaruDataPath = "Home\\冬季.gif";
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
                            
                            HonnmaruDataPath = "Home\\春季.gif";
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
                            
                            HonnmaruDataPath = "Home\\春季.gif";
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

                                HonnmaruDataPath = "Home\\立夏-藤.gif";
                                HonnmaruNow = "立夏-藤";
                                LoopSoundData = true;
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "春季")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "Home\\春季.gif";
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

                                HonnmaruDataPath = "Home\\立夏-藤.gif";
                                HonnmaruNow = "立夏-藤";
                                LoopSoundData = true;
                            }
                        }
                        else
                        {
                            // 先判斷使否已經是目標佈景，否才須要換
                            if (HonnmaruNow != "夏夜")
                            {
                                needTochange = true;

                                HonnmaruDataPath = "Home\\夏夜.gif";
                                HonnmaruNow = "夏夜";
                            }
                        }
                    }
                }
            }
            else
            {
                if (HonnmaruNow != HonnmaruComboBox.Text)
                {
                    needTochange = true;

                    HonnmaruDataPath = "Home\\" + HonnmaruComboBox.Text + ".gif";
                    HonnmaruNow = HonnmaruComboBox.Text;

                    if (HonnmaruNow == "雨季" || HonnmaruNow == "立夏-藤")
                    {
                        LoopSoundData = true;
                    }
                }
            }

            // 是否為有常駐音效的本丸環境，僅有在環境改變時設定一次即可
            if (LoopSoundData && needTochange)
            {
                axWMP_sound.settings.autoStart = false;
                axWMP_sound.settings.setMode("loop", true);

                // 設定相應的loop音效
                if (HonnmaruNow == "雨季") 
                {                   
                    SoundDataPath = DataPath + "Home\\Sound\\rain.mp3";
                }
                else if (HonnmaruNow == "立夏-藤")
                {
                    SoundDataPath = DataPath + "Home\\Sound\\river.mp3";
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

                try
                {
                    axWMP_sound.URL = SoundDataPath;
                    axWMP_sound.Ctlcontrols.play();
                }
                catch
                {
                    MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (needTochange)
            {
                axWMP_sound.settings.autoStart = false;
                axWMP_sound.settings.setMode("loop", false);
                axWMP_sound.Ctlcontrols.stop();
                
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
        //           十五夜、秋夜：蟲鳴
        //           雨季：雨(loop)
        //           雨季-晴：蛙鳴
        //           春季、立春-梅：鳥鳴
        //           夏夜：蟲鳴
        //           夏季：風鈴
        //           立夏-藤：河水聲(loop)
        //           撒豆驅鬼節：鴉鳴
        // 其中loop在在本丸環境設置時即完成，不會在此設定
        private void SoundSet()
        {
            axWMP_sound.settings.autoStart = false;
            axWMP_sound.settings.setMode("loop", false);
            axWMP_sound.Ctlcontrols.stop();

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
            else if (HonnmaruNow == "春季" || HonnmaruNow == "立春-梅")
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
            else
            {
                return;
            }

            try
            {
                axWMP_sound.URL = SoundDataPath;
                axWMP_sound.Ctlcontrols.play();
            }
            catch
            {
                MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // 隨機取得時間間隔點
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
            axWMP_voice.settings.autoStart = false;
            axWMP_voice.settings.setMode("loop", false);
            axWMP_voice.Ctlcontrols.stop();

            try
            {
                String VoicePath = DataPath + ToukennComboBox.Text + "\\time.wav";
                axWMP_voice.URL = VoicePath;
                axWMP_voice.Ctlcontrols.play();
            }
            catch
            {
                MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // 下次的觸發點
            VoiceTimer.Interval = GetIntervalTime(VoiceIntervalMin, VoiceIntervalMax);
        }
        // 點擊語音部分
        private void ToukennPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            String VoicePath;
            
            // 先檢查確實點在刀男身上
            if (HitTest(ToukennPictureBox, e.X, e.Y)) 
            {
                axWMP_voice.settings.autoStart = false;
                axWMP_voice.settings.setMode("loop", false);
                axWMP_voice.Ctlcontrols.stop();

                // 取real亂數
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                // 亂數範圍從1~3
                int num = rnd.Next(1, 4);

                if (num == 1)
                {
                    VoicePath = DataPath + ToukennComboBox.Text + "\\touch_1.wav";
                }
                else if (num == 2)
                {
                    VoicePath = DataPath + ToukennComboBox.Text + "\\touch_2.wav";
                }
                else
                {
                    VoicePath = DataPath + ToukennComboBox.Text + "\\touch_3.wav";
                }

                try
                {
                    axWMP_voice.URL = VoicePath;
                    axWMP_voice.Ctlcontrols.play();
                }
                catch
                {
                    MessageBox.Show("遺失了某些音訊。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
