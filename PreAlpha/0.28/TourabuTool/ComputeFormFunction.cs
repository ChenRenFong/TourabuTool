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
    public partial class ComputeFormFunction : Form
    {
        public ComputeFormFunction()
        {
            InitializeComponent();
        }
        // 初始便載入的設定與值
        private void ComputeFormFunction_Load(object sender, EventArgs e)
        {
            InformationTextBox.Text = "總經驗：單次地圖經驗 * 進出地圖次數" + "\r\n\r\n" +

                                      "單次地圖經驗：(搶譽經驗+非搶譽經驗) * 額外加成" + "\r\n" +
                                      "如果戰鬥場數=1，則相當於單場戰鬥經驗" + "\r\n" +
                                      "BOSS點分開單獨計算" + "\r\n\r\n" +

                                      "搶譽經驗：單場戰鬥平均經驗 * 隊長加成 * 搶譽加成 * 戰鬥評分加成 * ( 戰鬥場數 * 搶譽機率 )" + "\r\n\r\n" +

                                      "非搶譽經驗：單場戰鬥平均經驗 * 隊長加成 * 戰鬥評分加成 * ( 戰鬥場數 * (1-搶譽機率) )" + "\r\n\r\n" +

                                      "＊＊＊" + "\r\n\r\n" +

                                      "某地圖平均經驗：加總(經驗 * (該經驗的所有場數 / 該地圖中所有戰鬥場數))" + "\r\n\r\n" +

                                      "某地圖平均場數：(走到底的最大場數 + 走到底的最小場數) / 2" + "\r\n\r\n" +

                                      "＊＊＊" + "\r\n\r\n" +

                                      "隊員平均搶譽機率：1 / 隊員數" + "\r\n\r\n" +

                                      "＊＊＊" + "\r\n\r\n" +

                                      "單次地圖需時：單場戰鬥需時 * 該地圖平均場數" + "\r\n\r\n" +

                                      "＊＊＊" + "\r\n\r\n" +

                                      "出陣總需時：單次地圖需時 * 進出地圖次數" + "\r\n\r\n" +
                                      "地圖總次數：需時 / (單場戰鬥需時 * 該地圖平均場數)" + "\r\n\r\n" +
                                      "";
        }
    }
}
