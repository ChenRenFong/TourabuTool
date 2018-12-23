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
        // 存檔路徑
        public static String savePath = @"Record\record.txt";
        // 讀取顯示紀錄的檔案目標
        System.IO.StreamReader GetShowRecordFile;
        // 暫存讀取顯示紀錄的內容
        string GetShowRecordLine = "";
        // 說明文字串
        string readme = "使用說明：" + "\r\n" +
                        "按下\"GO\"可以將所有輸入進行保存，並對特殊指令進行處理。" + "\r\n" +
                        "記錄保存位置：" + "\r\n" +
                        "預設與TourabuTool.exe同一資料夾下的Record資料夾中的record.txt即是。" + "\r\n" +
                        "特殊指令：" + "\r\n" +
                        "(poker)：會隨機替換成任一撲克牌花色。" + "\r\n" +
                        "(dice6)：會隨機替換成1至6任一數字。" + "\r\n";  

        public AskForm()
        {
            InitializeComponent();
        }
        // 啟動時必執行一次的初始化作業
        private void AskForm_Load(object sender, EventArgs e)
        {
            if (MainForm.mySettings.SavePath == "@\"Record\\record.txt\"")
            {
                // 初運行，將相對路徑改成絕對路徑
                savePath = System.Environment.CurrentDirectory + "\\Record\\record.txt";
            }
            else
            {
                // 非初運行，更改為上次的紀錄位置與檔名
                savePath = MainForm.mySettings.SavePath;
            }
            
            UpdoList.Clear();
            ClearUpdoList.Clear();

            OutputTextBox.Text = readme;
        }
        // 有關於每次開起於上次結束的位置
        // 先於專案Settings中新增一個System.Drawing.Point的設定，範圍是User
        // 於視窗設計中的屬性欄找到(ApplicationSettings)，將剛剛新增的設定設定給(ApplicationSettings)
        // 屬性欄視窗中上方有個小閃電，此為事件欄，打開它於FormClosing上點兩下，於程式碼中創建下方程式碼即可
        private void AskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 設定本子視窗關閉
            MainForm.FormOpenList[2] = false;
            // 第一行mySettings後的變數要換成於專案Settings中設定的名稱
            MainForm.mySettings.AskPosition = new Point(this.Location.X, this.Location.Y);
            MainForm.mySettings.Save();
        }
        // 設定項目：紀錄的儲存路徑
        private void SettingButton_Click(object sender, EventArgs e)
        {
            AskFormSetting setting = new AskFormSetting();
            setting.ShowDialog(this);
        }
        // 抓取使用者輸入，並判斷有無特殊指令存在，有即依相應指令工作
        private void AskButton_Click(object sender, EventArgs e)
        {
            // 儲存最終的輸出結果
            string finalOutputStr = "";

            // 取入使用者輸入
            string inputStr = InputTextBox.Text;

            finalOutputStr = FunctionPoker(inputStr);
            finalOutputStr = FunctionDice6(finalOutputStr);

            // 先取得時間資訊的分隔線
            string timeStr = "********************" + DateTime.Now.ToString() + "********************" + "\r\n";
            // 再寫入
            OutputTextBox.Text = OutputTextBox.Text + timeStr + finalOutputStr + "\r\n";
            // 將結果框框的焦點移至最底
            OutputTextBox.SelectionStart = OutputTextBox.Text.Length;
            OutputTextBox.ScrollToCaret();
            // 同時輸出至紀錄檔
            // 先檢查紀錄檔是否存在，不存在就創一個
            outputRecheck:
            if (!System.IO.File.Exists(savePath))
            {
                try
                {
                    System.IO.File.Create(savePath).Close();
                }
                catch
                {
                    MessageBox.Show("路徑與檔案不存在，請重新選擇記錄存放位置。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (DialogForSelectFile.ShowDialog() == DialogResult.OK)
                    {
                        savePath = DialogForSelectFile.FileName.ToString();
                        MainForm.mySettings.SavePath = savePath;
                        MainForm.mySettings.Save();
                    }
                    goto outputRecheck;
                }
            }
            System.IO.StreamWriter FileWriter = System.IO.File.AppendText(savePath);
            FileWriter.WriteLine(timeStr + finalOutputStr);
            FileWriter.Flush();
            FileWriter.Close();
        }
        // 實作(poker)的功能
        private string FunctionPoker(string inputStr)
        {
            // 用來做處理的字串陣列
            Char[] workStr = new Char[inputStr.Length];
            // 用來記錄(poker)第一個字元的所在位置
            List<int> firstCharList = new List<int>();
            // 用來記錄需要刪除的字元的所在位置
            List<int> deleteCharList = new List<int>();
            // 將輸入字串拷貝到字串陣列，以方便做處理
            for (int i = 0; i < workStr.Length; i++)
            {
                workStr[i] = inputStr[i];
            }
            // 先找出(poker)的所有第一個字元的所在位置，並記下須要刪除的字元位置
            for (int i = 0; i < workStr.Length && (i + 6) < workStr.Length; i++)
            {
                if (workStr[i] == '(' && workStr[i + 1] == 'p' && workStr[i + 2] == 'o' && workStr[i + 3] == 'k' && workStr[i + 4] == 'e' && workStr[i + 5] == 'r' && workStr[i + 6] == ')')
                {
                    firstCharList.Add(i);
                    deleteCharList.Add(i + 1);
                    deleteCharList.Add(i + 2);
                    deleteCharList.Add(i + 3);
                    deleteCharList.Add(i + 4);
                    deleteCharList.Add(i + 5);
                    deleteCharList.Add(i + 6);
                }
            }
            // 開始逐一做替換處理
            for (int i = 0; i < firstCharList.Count; i++)
            {
                workStr[firstCharList[i]] = GetPokerRnd();
            }

            // 用來幫outputStr數數用的
            int num = 0;
            // 用來儲存輸出的字串陣列，因為(poker)會被置換，所以每置換一個，長度就會少6
            Char[] outputStr = new Char[inputStr.Length - (firstCharList.Count * 6)];
            // 開始塞入
            for (int i = 0; i < workStr.Length; i++)
            {
                bool deleteChar = false;
                // 先檢查要塞進去的是不是要被刪除的字元
                for (int j = 0; j < deleteCharList.Count; j++)
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
            // 回傳結果字串
            return string.Concat(outputStr);
        }
        // 跑(poker)亂數替換花色
        private Char GetPokerRnd()
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
        // 實作(dice6)的功能
        private string FunctionDice6(string inputStr)
        {
            // 用來做處理的字串陣列
            Char[] workStr = new Char[inputStr.Length];
            // 用來記錄(poker)第一個字元的所在位置
            List<int> firstCharList = new List<int>();
            // 用來記錄需要刪除的字元的所在位置
            List<int> deleteCharList = new List<int>();
            // 將輸入字串拷貝到字串陣列，以方便做處理
            for (int i = 0; i < workStr.Length; i++)
            {
                workStr[i] = inputStr[i];
            }
            // 先找出(dice6)的所有第一個字元的所在位置，並記下須要刪除的字元位置
            for (int i = 0; i < workStr.Length && (i + 6) < workStr.Length; i++)
            {
                if (workStr[i] == '(' && workStr[i + 1] == 'd' && workStr[i + 2] == 'i' && workStr[i + 3] == 'c' && workStr[i + 4] == 'e' && workStr[i + 5] == '6' && workStr[i + 6] == ')')
                {
                    firstCharList.Add(i);
                    deleteCharList.Add(i + 1);
                    deleteCharList.Add(i + 2);
                    deleteCharList.Add(i + 3);
                    deleteCharList.Add(i + 4);
                    deleteCharList.Add(i + 5);
                    deleteCharList.Add(i + 6);
                }
            }
            // 開始逐一做替換處理
            for (int i = 0; i < firstCharList.Count; i++)
            {
                workStr[firstCharList[i]] = GetDice6Rnd();
            }

            // 用來幫outputStr數數用的
            int num = 0;
            // 用來儲存輸出的字串陣列，因為(dice6)會被置換，所以每置換一個，長度就會少6
            Char[] outputStr = new Char[inputStr.Length - (firstCharList.Count * 6)];
            // 開始塞入
            for (int i = 0; i < workStr.Length; i++)
            {
                bool deleteChar = false;
                // 先檢查要塞進去的是不是要被刪除的字元
                for (int j = 0; j < deleteCharList.Count; j++)
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
            // 回傳結果字串
            return string.Concat(outputStr);
        }
        // 跑(dice6)亂數替換花色
        private Char GetDice6Rnd()
        {
            // 取real亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            // 亂數範圍從1~6
            int num = rnd.Next(1, 7);

            if (num == 1)
            {
                return '1';
            }
            else if (num == 2)
            {
                return '2';
            }
            else if (num == 3)
            {
                return '3';
            }
            else if (num == 4)
            {
                return '4';
            }
            else if (num == 5)
            {
                return '5';
            }
            else if (num == 6)
            {
                return '6';
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
        private void SmallDiceButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("(dice6)");
        }
        // 可以開啟之前的記錄存檔
        private void ShowRecordButton_Click(object sender, EventArgs e)
        {
            // 指定只能開啟txt檔
            DialogForSelectFile.Filter = "TXT files|*.txt";

            if (DialogForSelectFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 先檢測編碼類型
                    string filePath = DialogForSelectFile.FileName.ToString();

                    System.IO.StreamReader getEncoding = new System.IO.StreamReader(filePath);
                    getEncoding.Peek();
                    Encoding encoding = getEncoding.CurrentEncoding;

                    // 檢測完畢，依據結果開檔
                    GetShowRecordFile = new System.IO.StreamReader(filePath, encoding);

                    OutputTextBox.Text = "請耐心稍候，正在讀取中...";

                    // 於背景執行緒中開檔讀取，會執行DoWork
                    this.BackgroundWorkerForShowRecord.RunWorkerAsync();
                }
                catch
                {
                    MessageBox.Show("無法選擇此檔案。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // 清空顯示框框
        private void ClearShowButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
        }
        // 顯示基礎說明
        private void ReadMeShowButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.AppendText("********************" + "********************" + "********************" + "\r\n" + readme);
        }
        // 讀取要顯示的紀錄時，使用執行緒，以避免暫時沒有回應的問題，完成後自動執行RunWorkerCompleted
        private void BackgroundWorkerForShowRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            string line;
            
            while ((line = GetShowRecordFile.ReadLine()) != null)
            {
                GetShowRecordLine = GetShowRecordLine + line + "\r\n";
            }

            GetShowRecordFile.Close();
        }
        // 以執行緒讀取要顯示的紀錄完成後，顯示出來
        private void BackgroundWorkerForShowRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OutputTextBox.Text = GetShowRecordLine;
            // 將游標移至顯示框框最底端，以顯示最新的紀錄
            OutputTextBox.Focus();
            OutputTextBox.Select(OutputTextBox.TextLength, 0);
            OutputTextBox.ScrollToCaret();
            // 顯示完後清空暫存
            GetShowRecordLine = "";
        }
    }
}
