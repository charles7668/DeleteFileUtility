using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

//DEL 指令
//names 指定一個或更多檔案或目錄清單。可以使用萬用字元
//      來刪除多個檔案。 如果指定目錄，這個目錄內的所有
//      檔案將被刪除。

//  /P 刪除每個檔案前，先提示確認。
//  /F 強制刪除唯讀檔案。
//  /S 由所有子目錄刪除指定的檔案。
//  /Q 安靜模式，不要問是否確定刪除全域萬用字元
//  /A 根據屬性選取要刪除的檔案
//  attributes R  唯讀檔案 S  系統檔案
//  H  隱藏檔案 A  準備保存的檔案
//                -  首碼表示否定
namespace DeleteFileUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable RuleFile = new Hashtable();
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_RuleList();
        }
        private void Load_RuleList()
        {
            listBox_RuleFile.Items.Clear();
            string[] rulefile;
            rulefile = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.rule.txt");
            foreach (string temp in rulefile)
            {
                var rule = Regex.Match(temp, @"[\\](?<rule_name>[^.\\]+)[.]rule");
                listBox_RuleFile.Items.Add(rule.Groups["rule_name"].Value.ToString());
                try
                {
                    RuleFile.Add(rule.Groups["rule_name"].Value.ToString(), temp);
                }
                catch
                {

                }
            }
        }
        private void button_BrowseDir_Click(object sender, EventArgs e)
        {
            using (var dir = new FolderBrowserDialog())
            {
                DialogResult result = dir.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dir.SelectedPath))
                {
                    textBox_DirPath.Text = dir.SelectedPath;
                }
            }
        }

        private void button_AddRule_Click(object sender, EventArgs e)
        {
            if (!listBox_RuleList.Items.Contains(textBox_Rule.Text))
            {
                listBox_RuleList.Items.Add(textBox_Rule.Text);
                textBox_Rule.Text = "";
            }
            else
            {
                textBox_Rule.Text = "";
            }
        }

        private void button_DeleteRule_Click(object sender, EventArgs e)
        {
            if (listBox_RuleList.SelectedIndex >= 0)
            {
                listBox_RuleList.Items.RemoveAt(listBox_RuleList.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //單指令
            //System.Diagnostics.Process.Start("cmd.exe",@"/k dir");
            textBox_OutputPrint.Text = "";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            //p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            //p.StartInfo.StandardErrorEncoding = Encoding.UTF8;

            
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            //Console.InputEncoding = Encoding.UTF8;
            p.Start();
            string result;
            //StreamWriter sw = new StreamWriter(p.StandardInput.BaseStream, Encoding.Unicode);
            for (int i = 0; i < listBox_RuleList.Items.Count; i++)
            {
                //string path = Encoding.UTF32.GetString();
                //byte[] utf_DirPath = Encoding.UTF8.GetBytes(@"del /A/F/S/Q " + @textBox_DirPath.Text + @"\" + @listBox_RuleList.Items[i].ToString());
                //p.StandardInput.WriteLine(@"del /A/F/S/Q " + @textBox_DirPath.Text + @"\" + @listBox_RuleList.Items[i].ToString());
                p.StandardInput.WriteLine(@"Del /A/F/S/Q " + @textBox_DirPath.Text + @"\" + @listBox_RuleList.Items[i].ToString());
                //p.StandardInput.WriteLine(@"del /A/F/S " + Encoding.UTF8.GetString(utf_DirPath)  + @"\" + @listBox_RuleList.Items[i].ToString());
                //string a = Encoding.UTF8.GetString(utf_DirPath);
                //p.StandardInput.BaseStream.Write(utf_DirPath, 0, utf_DirPath.Length);
                p.StandardInput.WriteLine();
                Application.DoEvents();
                Update();
            }
            p.StandardInput.AutoFlush = true;
            //p.StandardInput.WriteLine(@"echo end");
            p.StandardInput.WriteLine(@"exit");
            //string result = p.StandardOutput.ReadToEnd();
            //while (true) ;
            Application.DoEvents();
            while ((result = p.StandardOutput.ReadLine()) != null)
            {
                textBox_OutputPrint.Text += result + "\r\n";
                Update();
                Application.DoEvents();
            }
            //re = Encoding.Unicode.GetBytes(p.StandardOutput.ReadToEnd());
            /*while (p.StandardOutput.Peek() > -1)
            {
                re = Encoding.UTF8.GetBytes(p.StandardOutput.ReadToEnd());
                result = Encoding.UTF8.GetString(re);
                textBox_OutputPrint.Text += result;
            }*/

            /*while (p.StandardError.Peek() > -1)
            {
                re = Encoding.Unicode.GetBytes(p.StandardOutput.ReadToEnd());
                result = Encoding.Unicode.GetString(re);
                textBox_OutputPrint.Text += result;
            }*/
            p.WaitForExit();
            textBox_OutputPrint.Text += "Done";
            //Console.WriteLine(p.StandardOutput.ReadToEnd());
            p.Close();
        }

        private void listBox_RuleFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_RuleFile.Items.Count > 0 && listBox_RuleFile.SelectedIndex >= 0)
            {
                listBox_RuleList.Items.Clear();
                string key = listBox_RuleFile.Items[listBox_RuleFile.SelectedIndex].ToString();
                using (StreamReader sr = new StreamReader((string)RuleFile[key]))
                {
                    string input;
                    while ((input = sr.ReadLine()) != null)
                    {
                        listBox_RuleList.Items.Add(input);
                    }
                }
            }
        }
        string FileName = "rule";
        public void Save_File(string filename)
        {
            string path = Directory.GetCurrentDirectory() + "\\" + filename + ".rule.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach(var item in listBox_RuleList.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            Load_RuleList();
        }
        private void button_SaveRule_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form_InputBox form_inputbox = new Form_InputBox(FileName);
            form_inputbox.Owner = this;
            form_inputbox.Show();
        }

        private void button_DeleteRuleFile_Click(object sender, EventArgs e)
        {
            if(listBox_RuleFile.Items.Count>0 && listBox_RuleFile.SelectedIndex >= 0)
            {
                string path = Directory.GetCurrentDirectory() + "\\" + listBox_RuleFile.Items[listBox_RuleFile.SelectedIndex].ToString() + ".rule.txt";
                File.Delete(path);
                string filename = listBox_RuleFile.Items[listBox_RuleFile.SelectedIndex].ToString();
                Load_RuleList();
                RuleFile.Remove(filename);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_RuleList.Items.Clear();
        }
    }
}
