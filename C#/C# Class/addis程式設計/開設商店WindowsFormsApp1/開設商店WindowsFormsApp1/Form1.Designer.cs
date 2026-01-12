namespace 開設商店WindowsFormsApp1
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
            this.ChickenCheckBox = new System.Windows.Forms.CheckBox();
            this.BaconCheckBox = new System.Windows.Forms.CheckBox();
            this.PotatoCheckBox = new System.Windows.Forms.CheckBox();
            this.ShallotCheckBox = new System.Windows.Forms.CheckBox();
            this.BaconTextBox = new System.Windows.Forms.TextBox();
            this.PotatoTextBox = new System.Windows.Forms.TextBox();
            this.ShallotTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChickenTextBox = new System.Windows.Forms.TextBox();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.VIPRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountsPayLabel = new System.Windows.Forms.Label();
            this.ChangesLabel = new System.Windows.Forms.Label();
            this.PayTextBox = new System.Windows.Forms.TextBox();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChickenCheckBox
            // 
            this.ChickenCheckBox.AutoSize = true;
            this.ChickenCheckBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChickenCheckBox.Location = new System.Drawing.Point(22, 68);
            this.ChickenCheckBox.Name = "ChickenCheckBox";
            this.ChickenCheckBox.Size = new System.Drawing.Size(238, 35);
            this.ChickenCheckBox.TabIndex = 0;
            this.ChickenCheckBox.Text = "45元 香煎嫩雞吐司";
            this.ChickenCheckBox.UseVisualStyleBackColor = true;
            this.ChickenCheckBox.CheckedChanged += new System.EventHandler(this.ChickenCheckBox_CheckedChanged);
            // 
            // BaconCheckBox
            // 
            this.BaconCheckBox.AutoSize = true;
            this.BaconCheckBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaconCheckBox.Location = new System.Drawing.Point(22, 109);
            this.BaconCheckBox.Name = "BaconCheckBox";
            this.BaconCheckBox.Size = new System.Drawing.Size(214, 35);
            this.BaconCheckBox.TabIndex = 1;
            this.BaconCheckBox.Text = "55元 培根蛋吐司";
            this.BaconCheckBox.UseVisualStyleBackColor = true;
            this.BaconCheckBox.CheckedChanged += new System.EventHandler(this.BaconCheckBox_CheckedChanged);
            // 
            // PotatoCheckBox
            // 
            this.PotatoCheckBox.AutoSize = true;
            this.PotatoCheckBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PotatoCheckBox.Location = new System.Drawing.Point(22, 150);
            this.PotatoCheckBox.Name = "PotatoCheckBox";
            this.PotatoCheckBox.Size = new System.Drawing.Size(214, 35);
            this.PotatoCheckBox.TabIndex = 2;
            this.PotatoCheckBox.Text = "40元 薯餅蛋漢堡";
            this.PotatoCheckBox.UseVisualStyleBackColor = true;
            this.PotatoCheckBox.CheckedChanged += new System.EventHandler(this.PotatoCheckBox_CheckedChanged);
            // 
            // ShallotCheckBox
            // 
            this.ShallotCheckBox.AutoSize = true;
            this.ShallotCheckBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShallotCheckBox.Location = new System.Drawing.Point(22, 191);
            this.ShallotCheckBox.Name = "ShallotCheckBox";
            this.ShallotCheckBox.Size = new System.Drawing.Size(214, 35);
            this.ShallotCheckBox.TabIndex = 3;
            this.ShallotCheckBox.Text = "35元 三星蔥油餅";
            this.ShallotCheckBox.UseVisualStyleBackColor = true;
            this.ShallotCheckBox.CheckedChanged += new System.EventHandler(this.ShallotCheckBox_CheckedChanged);
            // 
            // BaconTextBox
            // 
            this.BaconTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaconTextBox.Location = new System.Drawing.Point(321, 109);
            this.BaconTextBox.Name = "BaconTextBox";
            this.BaconTextBox.Size = new System.Drawing.Size(100, 27);
            this.BaconTextBox.TabIndex = 5;
            this.BaconTextBox.Text = "0";
            this.BaconTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BaconTextBox.TextChanged += new System.EventHandler(this.BaconTextBox_TextChanged);
            // 
            // PotatoTextBox
            // 
            this.PotatoTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PotatoTextBox.Location = new System.Drawing.Point(321, 150);
            this.PotatoTextBox.Name = "PotatoTextBox";
            this.PotatoTextBox.Size = new System.Drawing.Size(100, 27);
            this.PotatoTextBox.TabIndex = 6;
            this.PotatoTextBox.Text = "0";
            this.PotatoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PotatoTextBox.TextChanged += new System.EventHandler(this.PotatoTextBox_TextChanged);
            // 
            // ShallotTextBox
            // 
            this.ShallotTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShallotTextBox.Location = new System.Drawing.Point(321, 191);
            this.ShallotTextBox.Name = "ShallotTextBox";
            this.ShallotTextBox.Size = new System.Drawing.Size(100, 27);
            this.ShallotTextBox.TabIndex = 7;
            this.ShallotTextBox.Text = "0";
            this.ShallotTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShallotTextBox.TextChanged += new System.EventHandler(this.ShallotTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChickenTextBox);
            this.groupBox1.Controls.Add(this.ShallotTextBox);
            this.groupBox1.Controls.Add(this.PotatoTextBox);
            this.groupBox1.Controls.Add(this.BaconTextBox);
            this.groupBox1.Controls.Add(this.ShallotCheckBox);
            this.groupBox1.Controls.Add(this.PotatoCheckBox);
            this.groupBox1.Controls.Add(this.BaconCheckBox);
            this.groupBox1.Controls.Add(this.ChickenCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 282);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "數量";
            // 
            // ChickenTextBox
            // 
            this.ChickenTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChickenTextBox.Location = new System.Drawing.Point(321, 68);
            this.ChickenTextBox.Name = "ChickenTextBox";
            this.ChickenTextBox.Size = new System.Drawing.Size(100, 27);
            this.ChickenTextBox.TabIndex = 8;
            this.ChickenTextBox.Text = "0";
            this.ChickenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChickenTextBox.TextChanged += new System.EventHandler(this.ChickenTextBox_TextChanged);
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NormalRadioButton.Location = new System.Drawing.Point(19, 32);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(175, 35);
            this.NormalRadioButton.TabIndex = 9;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "一般會員 9折";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
            // 
            // VIPRadioButton
            // 
            this.VIPRadioButton.AutoSize = true;
            this.VIPRadioButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VIPRadioButton.Location = new System.Drawing.Point(19, 106);
            this.VIPRadioButton.Name = "VIPRadioButton";
            this.VIPRadioButton.Size = new System.Drawing.Size(180, 35);
            this.VIPRadioButton.TabIndex = 10;
            this.VIPRadioButton.TabStop = true;
            this.VIPRadioButton.Text = "VIP會員 75折";
            this.VIPRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VIPRadioButton);
            this.panel1.Controls.Add(this.NormalRadioButton);
            this.panel1.Location = new System.Drawing.Point(23, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 161);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(542, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "付款金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(542, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "應付金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 14;
            // 
            // AmountsPayLabel
            // 
            this.AmountsPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AmountsPayLabel.Location = new System.Drawing.Point(661, 198);
            this.AmountsPayLabel.Name = "AmountsPayLabel";
            this.AmountsPayLabel.Size = new System.Drawing.Size(100, 25);
            this.AmountsPayLabel.TabIndex = 15;
            // 
            // ChangesLabel
            // 
            this.ChangesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChangesLabel.Location = new System.Drawing.Point(661, 295);
            this.ChangesLabel.Name = "ChangesLabel";
            this.ChangesLabel.Size = new System.Drawing.Size(100, 25);
            this.ChangesLabel.TabIndex = 16;
            // 
            // PayTextBox
            // 
            this.PayTextBox.Location = new System.Drawing.Point(661, 78);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(100, 25);
            this.PayTextBox.TabIndex = 17;
            this.PayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PayTextBox.TextChanged += new System.EventHandler(this.PayTextBox_TextChanged);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(572, 421);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(142, 50);
            this.CheckOutButton.TabIndex = 18;
            this.CheckOutButton.Text = "結帳";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(542, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "應找金額";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.PayTextBox);
            this.Controls.Add(this.ChangesLabel);
            this.Controls.Add(this.AmountsPayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Brench";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChickenCheckBox;
        private System.Windows.Forms.CheckBox BaconCheckBox;
        private System.Windows.Forms.CheckBox PotatoCheckBox;
        private System.Windows.Forms.CheckBox ShallotCheckBox;
        private System.Windows.Forms.TextBox BaconTextBox;
        private System.Windows.Forms.TextBox PotatoTextBox;
        private System.Windows.Forms.TextBox ShallotTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChickenTextBox;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton VIPRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AmountsPayLabel;
        private System.Windows.Forms.Label ChangesLabel;
        private System.Windows.Forms.TextBox PayTextBox;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Label label7;
    }
}

