namespace ScoreWindowsFormsApp1
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
            this.diaplayLst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // diaplayLst
            // 
            this.diaplayLst.FormattingEnabled = true;
            this.diaplayLst.ItemHeight = 15;
            this.diaplayLst.Location = new System.Drawing.Point(363, 49);
            this.diaplayLst.Margin = new System.Windows.Forms.Padding(4);
            this.diaplayLst.Name = "diaplayLst";
            this.diaplayLst.Size = new System.Drawing.Size(188, 244);
            this.diaplayLst.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diaplayLst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox diaplayLst;
    }
}

