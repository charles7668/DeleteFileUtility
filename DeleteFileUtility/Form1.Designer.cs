﻿namespace DeleteFileUtility
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_DirectoryPath = new System.Windows.Forms.Label();
            this.textBox_DirPath = new System.Windows.Forms.TextBox();
            this.button_BrowseDir = new System.Windows.Forms.Button();
            this.listBox_RuleList = new System.Windows.Forms.ListBox();
            this.textBox_Rule = new System.Windows.Forms.TextBox();
            this.button_AddRule = new System.Windows.Forms.Button();
            this.button_DeleteRule = new System.Windows.Forms.Button();
            this.textBox_OutputPrint = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_DeleteRuleFile = new System.Windows.Forms.Button();
            this.button_SaveRule = new System.Windows.Forms.Button();
            this.listBox_RuleFile = new System.Windows.Forms.ListBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_RuleFileList = new System.Windows.Forms.Label();
            this.label_RuleList = new System.Windows.Forms.Label();
            this.label_OutputPrint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_DirectoryPath
            // 
            this.label_DirectoryPath.AutoSize = true;
            this.label_DirectoryPath.Font = new System.Drawing.Font("新細明體", 24F);
            this.label_DirectoryPath.Location = new System.Drawing.Point(36, 47);
            this.label_DirectoryPath.Name = "label_DirectoryPath";
            this.label_DirectoryPath.Size = new System.Drawing.Size(116, 32);
            this.label_DirectoryPath.TabIndex = 0;
            this.label_DirectoryPath.Text = "DirPath:";
            // 
            // textBox_DirPath
            // 
            this.textBox_DirPath.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox_DirPath.Location = new System.Drawing.Point(158, 47);
            this.textBox_DirPath.Name = "textBox_DirPath";
            this.textBox_DirPath.Size = new System.Drawing.Size(404, 33);
            this.textBox_DirPath.TabIndex = 1;
            // 
            // button_BrowseDir
            // 
            this.button_BrowseDir.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_BrowseDir.Location = new System.Drawing.Point(578, 47);
            this.button_BrowseDir.Name = "button_BrowseDir";
            this.button_BrowseDir.Size = new System.Drawing.Size(75, 33);
            this.button_BrowseDir.TabIndex = 2;
            this.button_BrowseDir.Text = "瀏覽";
            this.button_BrowseDir.UseVisualStyleBackColor = true;
            this.button_BrowseDir.Click += new System.EventHandler(this.button_BrowseDir_Click);
            // 
            // listBox_RuleList
            // 
            this.listBox_RuleList.FormattingEnabled = true;
            this.listBox_RuleList.ItemHeight = 12;
            this.listBox_RuleList.Location = new System.Drawing.Point(42, 153);
            this.listBox_RuleList.Name = "listBox_RuleList";
            this.listBox_RuleList.Size = new System.Drawing.Size(198, 208);
            this.listBox_RuleList.TabIndex = 3;
            // 
            // textBox_Rule
            // 
            this.textBox_Rule.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox_Rule.Location = new System.Drawing.Point(247, 129);
            this.textBox_Rule.Name = "textBox_Rule";
            this.textBox_Rule.Size = new System.Drawing.Size(100, 33);
            this.textBox_Rule.TabIndex = 4;
            // 
            // button_AddRule
            // 
            this.button_AddRule.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_AddRule.Location = new System.Drawing.Point(247, 176);
            this.button_AddRule.Name = "button_AddRule";
            this.button_AddRule.Size = new System.Drawing.Size(75, 39);
            this.button_AddRule.TabIndex = 5;
            this.button_AddRule.Text = "加入";
            this.button_AddRule.UseVisualStyleBackColor = true;
            this.button_AddRule.Click += new System.EventHandler(this.button_AddRule_Click);
            // 
            // button_DeleteRule
            // 
            this.button_DeleteRule.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_DeleteRule.Location = new System.Drawing.Point(246, 221);
            this.button_DeleteRule.Name = "button_DeleteRule";
            this.button_DeleteRule.Size = new System.Drawing.Size(75, 39);
            this.button_DeleteRule.TabIndex = 5;
            this.button_DeleteRule.Text = "刪除";
            this.button_DeleteRule.UseVisualStyleBackColor = true;
            this.button_DeleteRule.Click += new System.EventHandler(this.button_DeleteRule_Click);
            // 
            // textBox_OutputPrint
            // 
            this.textBox_OutputPrint.Location = new System.Drawing.Point(489, 176);
            this.textBox_OutputPrint.Multiline = true;
            this.textBox_OutputPrint.Name = "textBox_OutputPrint";
            this.textBox_OutputPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_OutputPrint.Size = new System.Drawing.Size(274, 184);
            this.textBox_OutputPrint.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "開始刪除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_DeleteRuleFile
            // 
            this.button_DeleteRuleFile.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_DeleteRuleFile.Location = new System.Drawing.Point(246, 266);
            this.button_DeleteRuleFile.Name = "button_DeleteRuleFile";
            this.button_DeleteRuleFile.Size = new System.Drawing.Size(75, 39);
            this.button_DeleteRuleFile.TabIndex = 5;
            this.button_DeleteRuleFile.Text = "刪檔";
            this.button_DeleteRuleFile.UseVisualStyleBackColor = true;
            this.button_DeleteRuleFile.Click += new System.EventHandler(this.button_DeleteRuleFile_Click);
            // 
            // button_SaveRule
            // 
            this.button_SaveRule.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_SaveRule.Location = new System.Drawing.Point(246, 311);
            this.button_SaveRule.Name = "button_SaveRule";
            this.button_SaveRule.Size = new System.Drawing.Size(75, 39);
            this.button_SaveRule.TabIndex = 5;
            this.button_SaveRule.Text = "儲存";
            this.button_SaveRule.UseVisualStyleBackColor = true;
            this.button_SaveRule.Click += new System.EventHandler(this.button_SaveRule_Click);
            // 
            // listBox_RuleFile
            // 
            this.listBox_RuleFile.FormattingEnabled = true;
            this.listBox_RuleFile.ItemHeight = 12;
            this.listBox_RuleFile.Location = new System.Drawing.Point(327, 200);
            this.listBox_RuleFile.Name = "listBox_RuleFile";
            this.listBox_RuleFile.Size = new System.Drawing.Size(156, 160);
            this.listBox_RuleFile.TabIndex = 8;
            this.listBox_RuleFile.SelectedIndexChanged += new System.EventHandler(this.listBox_RuleFile_SelectedIndexChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("新細明體", 16F);
            this.button_Clear.Location = new System.Drawing.Point(42, 93);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 30);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_RuleFileList
            // 
            this.label_RuleFileList.AutoSize = true;
            this.label_RuleFileList.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_RuleFileList.Location = new System.Drawing.Point(328, 175);
            this.label_RuleFileList.Name = "label_RuleFileList";
            this.label_RuleFileList.Size = new System.Drawing.Size(98, 22);
            this.label_RuleFileList.TabIndex = 10;
            this.label_RuleFileList.Text = "檔案列表";
            // 
            // label_RuleList
            // 
            this.label_RuleList.AutoSize = true;
            this.label_RuleList.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_RuleList.Location = new System.Drawing.Point(38, 128);
            this.label_RuleList.Name = "label_RuleList";
            this.label_RuleList.Size = new System.Drawing.Size(98, 22);
            this.label_RuleList.TabIndex = 11;
            this.label_RuleList.Text = "檔案名稱";
            // 
            // label_OutputPrint
            // 
            this.label_OutputPrint.AutoSize = true;
            this.label_OutputPrint.Font = new System.Drawing.Font("新細明體", 16F);
            this.label_OutputPrint.Location = new System.Drawing.Point(485, 140);
            this.label_OutputPrint.Name = "label_OutputPrint";
            this.label_OutputPrint.Size = new System.Drawing.Size(98, 22);
            this.label_OutputPrint.TabIndex = 10;
            this.label_OutputPrint.Text = "訊息輸出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 401);
            this.Controls.Add(this.label_RuleList);
            this.Controls.Add(this.label_OutputPrint);
            this.Controls.Add(this.label_RuleFileList);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.listBox_RuleFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_OutputPrint);
            this.Controls.Add(this.button_SaveRule);
            this.Controls.Add(this.button_DeleteRuleFile);
            this.Controls.Add(this.button_DeleteRule);
            this.Controls.Add(this.button_AddRule);
            this.Controls.Add(this.textBox_Rule);
            this.Controls.Add(this.listBox_RuleList);
            this.Controls.Add(this.button_BrowseDir);
            this.Controls.Add(this.textBox_DirPath);
            this.Controls.Add(this.label_DirectoryPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DirectoryPath;
        private System.Windows.Forms.TextBox textBox_DirPath;
        private System.Windows.Forms.Button button_BrowseDir;
        private System.Windows.Forms.ListBox listBox_RuleList;
        private System.Windows.Forms.TextBox textBox_Rule;
        private System.Windows.Forms.Button button_AddRule;
        private System.Windows.Forms.Button button_DeleteRule;
        private System.Windows.Forms.TextBox textBox_OutputPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_DeleteRuleFile;
        private System.Windows.Forms.Button button_SaveRule;
        private System.Windows.Forms.ListBox listBox_RuleFile;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_RuleFileList;
        private System.Windows.Forms.Label label_RuleList;
        private System.Windows.Forms.Label label_OutputPrint;
    }
}

