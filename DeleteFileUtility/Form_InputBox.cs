using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DeleteFileUtility
{
    public partial class Form_InputBox : Form
    {
        public Form_InputBox()
        {
            InitializeComponent();
        }
        string filename = string.Empty;
        public Form_InputBox(string name)
        {
            InitializeComponent();
            filename = name;
            textBox_FileName.Text = filename;
        }

        private void Form_InputBox_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_FileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能輸入檔名允許的字元
            if ((e.KeyChar >= (Char)48 && e.KeyChar <= (Char)57) ||
                (e.KeyChar >= (Char)64 && e.KeyChar <= (Char)91) ||
                (e.KeyChar >= (Char)97 && e.KeyChar <= (Char)123) ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8  ||
               e.KeyChar == (Char)93 ||e.KeyChar == (Char)95 || e.KeyChar == (Char)125)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Form1 form_main = (Form1)this.Owner;
            if (textBox_FileName.Text == "")
            {
                label_Message.Text = "名稱為空";
                return;
            }
            string path = Directory.GetCurrentDirectory() + "\\" + textBox_FileName.Text+".rule.txt";
            if (File.Exists(path))
            {
                //label_Message.Text = "檔名已存在";
                DialogResult dr = MessageBox.Show("檔名衝突", "檔名已存在，是否覆寫？", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        form_main.Save_File(textBox_FileName.Text);
                        form_main.Enabled = true;
                        this.Close();
                        break;
                    case DialogResult.No:
                        return;
                }
                return;
            }
            form_main.Save_File(textBox_FileName.Text);
            form_main.Enabled = true;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form1 form_main = (Form1)this.Owner;
            form_main.Enabled = true;
            this.Close();
        }
    }
}
