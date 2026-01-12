namespace fileIoConsoleApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.writeToFileBtn = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // writeToFileBtn
            // 
            this.writeToFileBtn.Location = new System.Drawing.Point(176, 101);
            this.writeToFileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.writeToFileBtn.Name = "writeToFileBtn";
            this.writeToFileBtn.Size = new System.Drawing.Size(141, 71);
            this.writeToFileBtn.TabIndex = 0;
            this.writeToFileBtn.Text = "將資料儲存為文字檔案";
            this.writeToFileBtn.UseVisualStyleBackColor = true;
            this.writeToFileBtn.Click += new System.EventHandler(this.writeToFileBtn_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(176, 206);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(141, 66);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "讀取文字檔案內的資料";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(176, 329);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(141, 64);
            this.CleanButton.TabIndex = 2;
            this.CleanButton.Text = "清除";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(531, 101);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 109);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.writeToFileBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeToFileBtn;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}