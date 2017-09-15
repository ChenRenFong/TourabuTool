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
    public partial class AskForm : Form
    {
        // List的最大值
        int max = 100;
        // 檢查是否是使用者輸入狀態
        bool isUserInput = true;
        // 儲存上一次的輸入內容
        String upStr = "";
        // 每當TestChange發生時，儲存文字的容器
        List<String> UpdoList = new List<String>();
        // 每當還原時，儲存文字的容器
        List<String> ClearUpdoList = new List<String>();

        public AskForm()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void AskForm_Load(object sender, EventArgs e)
        {
            UpdoList.Clear();
            ClearUpdoList.Clear();

            OutputTextBox.Text = "使用說明：" + "\r\n" +
                                 "按下\"GO\"可以將所有輸入進行保存，並對特殊指令進行處理。" + "\r\n" +
                                 "保存位置：" + "\r\n" +
                                 "與TourabuTool.exe同一資料夾下的Record資料夾中的record.txt即是。" + "\r\n" +
                                 "特殊指令：" + "\r\n" +
                                 "(poker)：會隨機替換成任一撲克牌花色。";
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void AskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 留意，第一行new的變數要換成namespace的名稱，第二行mySettings的變數也要換成於專案Settings中設定的名稱
            Properties.Settings mySettings = new TourabuTool.Properties.Settings();
            mySettings.AskPosition = new Point(this.Location.X, this.Location.Y);
            mySettings.Save();
        }
        // 抓取使用者輸入，並判斷有無(poker)存在，有即亂數替換(poker)
        private void AskButton_Click(object sender, EventArgs e)
        {
            String inputStr = InputTextBox.Text;
            // 用來做處理的字串陣列
            Char[] workStr = new Char[inputStr.Length];
            // 用來記錄(pdddd)第一個字元的所在位置
            List<int> firstCharList = new List<int>();
            // 用來記錄需要刪除的字元的所在位置
            List<int> deleteCharList = new List<int>();
            // 將輸入字串拷貝到字串陣列，以方便做處理
            for (int i = 0; i < workStr.Length; i++)
            {
                workStr[i] = inputStr[i];
            }
            // 先找出(pdddd)的所有第一個字元的所在位置，並記下須要刪除的字元位置
            for (int i = 0; i < workStr.Length && (i + 6) < workStr.Length; i++)
            {
                if (workStr[i] == '(' && workStr[i + 1] == 'p' && workStr[i + 2] == 'o' && workStr[i + 3] == 'k' && workStr[i + 4] == 'e' && workStr[i + 5] == 'r' && workStr[i + 6] == ')')
                {
                    firstCharList.Add(i);
                    deleteCharList.Add(i+1);
                    deleteCharList.Add(i+2);
                    deleteCharList.Add(i+3);
                    deleteCharList.Add(i+4);
                    deleteCharList.Add(i+5);
                    deleteCharList.Add(i+6);
                }
            }
            // 開始逐一做替換處理
            for (int i = 0; i < firstCharList.Count; i++)
            {
                workStr[firstCharList[i]] = GetRnd();
            }

            // 用來幫outputStr數數用的
            int num = 0;
            // 用來儲存輸出的字串陣列，因為(poker)會被置換，所以每置換一個，長度就會少6
            Char[] outputStr = new Char[inputStr.Length-(firstCharList.Count*6)];
            // 開始塞入
            for (int i = 0; i < workStr.Length; i++) 
            {
                bool deleteChar = false;
                // 先檢查要塞進去的是不是要被刪除的字元
                for (int j = 0; j < deleteCharList.Count; j++ )
                {
                    if (i == deleteCharList[j]) 
                    {
                        deleteChar = true;
                    }
                }
                // 不是要被刪除的字元
                if (!deleteChar)
                {
                    outputStr[num] = workStr[i];
                    num++;
                }
            }
            // 先清空
            OutputTextBox.Text = "";
            // 轉成輸出字串
            for ( int i = 0 ; i < outputStr.Length ; i++ )
            {
                OutputTextBox.Text = OutputTextBox.Text + outputStr[i] ;
            }
            // 同時輸出至紀錄檔
            System.IO.StreamWriter FileWriter = System.IO.File.AppendText(@"Record\record.txt");
            FileWriter.WriteLine("********************" + DateTime.Now.ToString() + "********************" + "\r\n" + OutputTextBox.Text);
            FileWriter.Flush();
            FileWriter.Close();
        }
        // 跑(poker)亂數替換花色
        private Char GetRnd()
        {
            // 取real亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            // 亂數範圍從1~4
            int num = rnd.Next(1, 5);

            if (num == 1)
            {
                return '♠';
            }
            else if (num == 2)
            {
                return '♣';
            }
            else if (num == 3)
            {
                return '♥';
            }
            else if (num == 4)
            {
                return '♦';
            }
            else
            {
                return ' ';
            }
        }
        // 點擊即會復原輸入
        private void UpdoButton_Click(object sender, EventArgs e)
        {
            // 有可以還原的內容存在
            if (UpdoList.Count != 0) 
            {
                // 設定為非使用者輸入狀態
                isUserInput = false;
                // 取得當前文字內容
                String inputStr = InputTextBox.Text;
                // 在ClearUpdoList尾端新增一筆
                ClearUpdoList.Add(inputStr);
                // 設定InputTextBox中的文字
                InputTextBox.Text = UpdoList[UpdoList.Count - 1];
                // 移除UpdoList最尾端資料
                UpdoList.RemoveAt(UpdoList.Count - 1);
                // 將當前文字設為變動前文字
                upStr = InputTextBox.Text;
                // 設定為使用者輸入狀態
                isUserInput = true;
            }
        }
        // 點擊即會取消復原輸入
        private void ClearUpdoButton_Click(object sender, EventArgs e)
        {
            // 有可以取消還原的內容存在
            if (ClearUpdoList.Count != 0)
            {
                // 設定為非使用者輸入狀態
                isUserInput = false;
                // 取得當前文字內容
                String inputStr = InputTextBox.Text;
                // 在UpdoList尾端新增一筆
                UpdoList.Add(inputStr);
                CheckUpdoListMax();
                // 設定InputTextBox中的文字
                InputTextBox.Text = ClearUpdoList[ClearUpdoList.Count - 1];
                // 移除ClearUpdoList最尾端資料
                ClearUpdoList.RemoveAt(ClearUpdoList.Count - 1);
                // 將當前文字設為變動前文字
                upStr = InputTextBox.Text;
                // 設定為使用者輸入狀態
                isUserInput = true;
            }
        }
        // 這指令是在變動之後執行，每次變動後，儲存變動前的文字內容
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput) 
            {
                ClearUpdoList.Clear();
                // 變動後文字內容
                String inputStr = InputTextBox.Text;
                // 在UpdoList尾端新增一筆變動前文字內容
                UpdoList.Add(upStr);
                CheckUpdoListMax();
                // 當前的變動後文字內容在下一次變動之後，會變成動前的文字內容
                upStr = inputStr;
            }
        }
        // 檢查UpdoList的元素最大值
        private void CheckUpdoListMax()
        {
            // 當到達最大值時，移除最舊的資料
            if (UpdoList.Count==max)
            {
                UpdoList.RemoveAt(0);
            }
        }
        // 點擊即複製相應指令
        private void SpadesButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("♠");
        }
        private void PlumButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("♣");
        }
        private void HeartButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("♥");
        }
        private void BrickButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("♦");
        }
        private void PokerDiceButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("(poker)");
        }
    }
}
