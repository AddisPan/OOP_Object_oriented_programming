namespace WindowsFormsApp1
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
            this.ReadButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.diaplayLst = new System.Windows.Forms.ListBox();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(52, 13);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(141, 66);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "讀取文字檔案內的資料";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(52, 374);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(4);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(141, 64);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "清除";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // diaplayLst
            // 
            this.diaplayLst.FormattingEnabled = true;
            this.diaplayLst.ItemHeight = 15;
            this.diaplayLst.Location = new System.Drawing.Point(449, 81);
            this.diaplayLst.Margin = new System.Windows.Forms.Padding(4);
            this.diaplayLst.Name = "diaplayLst";
            this.diaplayLst.Size = new System.Drawing.Size(192, 259);
            this.diaplayLst.TabIndex = 4;
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "讀取檔案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "建立一個新的成績";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 71);
            this.button3.TabIndex = 7;
            this.button3.Text = "另存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diaplayLst);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.ReadButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeToFileBtn;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox diaplayLst;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

