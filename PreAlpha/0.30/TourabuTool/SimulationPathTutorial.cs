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
    public partial class SimulationPathTutorial : Form
    {
        public SimulationPathTutorial()
        {
            InitializeComponent();
        }
        // 初始便載入的設定與值
        private void SimulationPathTutorial_Load(object sender, EventArgs e)
        {
            InformationTextBox.Text = "資料所在位置：" + "\r\n" +
                                      "與TourabuTool.exe同一資料夾下的SimulationPath資料夾。" + "\r\n\r\n" +

                                      "資料夾說明：" + "\r\n" +
                                      "Default資料夾為常駐時節景趣的資料。" + "\r\n" +
                                      "RealWorldTime資料夾為現實時節景趣的資料。" + "\r\n\r\n" +
                                      
                                      "客製化說明：" + "\r\n" +
                                      "請用同檔名檔案覆蓋裡面的檔案即可完成客製化。" + "\r\n\r\n" +

                                      "格式說明：" + "\r\n" +
                                      "圖檔請使用png格式，最佳尺寸為1030x580。" + "\r\n" +
                                      "音訊檔請使用mp3格式，其中刀男語音為time、touch_1~3，前者為放置語音，後者為互動語音，sound_1~2為環境語音，1為隨機時間點觸發，2為常駐循環音效。" + "\r\n\r\n" +

                                      "格外留意：" + "\r\n" +
                                      "圖檔不可以缺，但音訊檔刪掉是不影響運作的，只是會沒聲音沒語音而已。";
        }
    }
}
