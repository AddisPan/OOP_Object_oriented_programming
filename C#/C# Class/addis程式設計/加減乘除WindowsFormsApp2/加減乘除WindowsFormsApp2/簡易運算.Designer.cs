namespace 加減乘除WindowsFormsApp2
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.additionlabel = new System.Windows.Forms.Label();
            this.substrationlabel = new System.Windows.Forms.Label();
            this.multiplicationlabel = new System.Windows.Forms.Label();
            this.divisionlabel = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.AdditionLebel = new System.Windows.Forms.Label();
            this.SubtractionLebel = new System.Windows.Forms.Label();
            this.MultiplicationLebel = new System.Windows.Forms.Label();
            this.DivisionLebel = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "數字1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(364, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "數字2";
            // 
            // additionlabel
            // 
            this.additionlabel.AutoSize = true;
            this.additionlabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.additionlabel.ForeColor = System.Drawing.Color.Red;
            this.additionlabel.Location = new System.Drawing.Point(177, 144);
            this.additionlabel.Name = "additionlabel";
            this.additionlabel.Size = new System.Drawing.Size(137, 38);
            this.additionlabel.TabIndex = 2;
            this.additionlabel.Text = "加法結果";
            // 
            // substrationlabel
            // 
            this.substrationlabel.AutoSize = true;
            this.substrationlabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.substrationlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.substrationlabel.Location = new System.Drawing.Point(177, 210);
            this.substrationlabel.Name = "substrationlabel";
            this.substrationlabel.Size = new System.Drawing.Size(137, 38);
            this.substrationlabel.TabIndex = 3;
            this.substrationlabel.Text = "減法結果";
            // 
            // multiplicationlabel
            // 
            this.multiplicationlabel.AutoSize = true;
            this.multiplicationlabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.multiplicationlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiplicationlabel.Location = new System.Drawing.Point(177, 272);
            this.multiplicationlabel.Name = "multiplicationlabel";
            this.multiplicationlabel.Size = new System.Drawing.Size(137, 38);
            this.multiplicationlabel.TabIndex = 4;
            this.multiplicationlabel.Text = "乘法結果";
            // 
            // divisionlabel
            // 
            this.divisionlabel.AutoSize = true;
            this.divisionlabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divisionlabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.divisionlabel.Location = new System.Drawing.Point(177, 339);
            this.divisionlabel.Name = "divisionlabel";
            this.divisionlabel.Size = new System.Drawing.Size(137, 38);
            this.divisionlabel.TabIndex = 5;
            this.divisionlabel.Text = "除法結果";
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(537, 42);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(88, 25);
            this.Number2.TabIndex = 6;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(209, 40);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(87, 25);
            this.Number1.TabIndex = 7;
            // 
            // AdditionLebel
            // 
            this.AdditionLebel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdditionLebel.Location = new System.Drawing.Point(442, 144);
            this.AdditionLebel.Name = "AdditionLebel";
            this.AdditionLebel.Size = new System.Drawing.Size(141, 33);
            this.AdditionLebel.TabIndex = 8;
            // 
            // SubtractionLebel
            // 
            this.SubtractionLebel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubtractionLebel.Location = new System.Drawing.Point(442, 210);
            this.SubtractionLebel.Name = "SubtractionLebel";
            this.SubtractionLebel.Size = new System.Drawing.Size(141, 38);
            this.SubtractionLebel.TabIndex = 9;
            // 
            // MultiplicationLebel
            // 
            this.MultiplicationLebel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MultiplicationLebel.Location = new System.Drawing.Point(442, 272);
            this.MultiplicationLebel.Name = "MultiplicationLebel";
            this.MultiplicationLebel.Size = new System.Drawing.Size(141, 38);
            this.MultiplicationLebel.TabIndex = 10;
            // 
            // DivisionLebel
            // 
            this.DivisionLebel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DivisionLebel.Location = new System.Drawing.Point(442, 339);
            this.DivisionLebel.Name = "DivisionLebel";
            this.DivisionLebel.Size = new System.Drawing.Size(141, 38);
            this.DivisionLebel.TabIndex = 11;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(670, 354);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(87, 23);
            this.ResultButton.TabIndex = 12;
            this.ResultButton.Text = "計算結果";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.DivisionLebel);
            this.Controls.Add(this.MultiplicationLebel);
            this.Controls.Add(this.SubtractionLebel);
            this.Controls.Add(this.AdditionLebel);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.divisionlabel);
            this.Controls.Add(this.multiplicationlabel);
            this.Controls.Add(this.substrationlabel);
            this.Controls.Add(this.additionlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "簡易的運算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label additionlabel;
        private System.Windows.Forms.Label substrationlabel;
        private System.Windows.Forms.Label multiplicationlabel;
        private System.Windows.Forms.Label divisionlabel;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.Label AdditionLebel;
        private System.Windows.Forms.Label SubtractionLebel;
        private System.Windows.Forms.Label MultiplicationLebel;
        private System.Windows.Forms.Label DivisionLebel;
        private System.Windows.Forms.Button ResultButton;
    }
}

