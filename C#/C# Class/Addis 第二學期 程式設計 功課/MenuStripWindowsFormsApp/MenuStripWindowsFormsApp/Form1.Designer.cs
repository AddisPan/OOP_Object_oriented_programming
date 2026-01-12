namespace MenuStripWindowsFormsApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfingLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfingStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderGoodsToolStripMenuItem,
            this.surfingLoginToolStripMenuItem,
            this.surfingStatisticToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderGoodsToolStripMenuItem
            // 
            this.orderGoodsToolStripMenuItem.Name = "orderGoodsToolStripMenuItem";
            this.orderGoodsToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.orderGoodsToolStripMenuItem.Text = "orderGoods";
            this.orderGoodsToolStripMenuItem.Click += new System.EventHandler(this.orderGoodsToolStripMenuItem_Click);
            // 
            // surfingLoginToolStripMenuItem
            // 
            this.surfingLoginToolStripMenuItem.Name = "surfingLoginToolStripMenuItem";
            this.surfingLoginToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.surfingLoginToolStripMenuItem.Text = "surfingLogin";
            this.surfingLoginToolStripMenuItem.Click += new System.EventHandler(this.surfingLoginToolStripMenuItem_Click);
            // 
            // surfingStatisticToolStripMenuItem
            // 
            this.surfingStatisticToolStripMenuItem.Name = "surfingStatisticToolStripMenuItem";
            this.surfingStatisticToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.surfingStatisticToolStripMenuItem.Text = "surfingStatistic";
            this.surfingStatisticToolStripMenuItem.Click += new System.EventHandler(this.surfingStatisticToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfingLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfingStatisticToolStripMenuItem;
    }
}

