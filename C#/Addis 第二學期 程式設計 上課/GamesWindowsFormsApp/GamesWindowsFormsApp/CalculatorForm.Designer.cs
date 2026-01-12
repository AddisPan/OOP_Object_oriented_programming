namespace GamesWindowsFormsApp
{
    partial class CalculatorForm
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
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayLabel.Location = new System.Drawing.Point(58, 53);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(646, 31);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(150, 373);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(79, 45);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(39, 302);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(79, 45);
            this.OneButton.TabIndex = 2;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(150, 302);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(79, 45);
            this.TwoButton.TabIndex = 3;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(271, 302);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(79, 45);
            this.ThreeButton.TabIndex = 4;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(39, 225);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(79, 45);
            this.FourButton.TabIndex = 5;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(150, 225);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(79, 45);
            this.FiveButton.TabIndex = 6;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(271, 225);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(79, 45);
            this.SixButton.TabIndex = 7;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(39, 140);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(79, 45);
            this.SevenButton.TabIndex = 8;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(150, 140);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(79, 45);
            this.EightButton.TabIndex = 9;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(271, 140);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(79, 45);
            this.NineButton.TabIndex = 10;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(477, 126);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(79, 45);
            this.PlusButton.TabIndex = 11;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(477, 206);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(79, 45);
            this.MinusButton.TabIndex = 12;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(477, 289);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(79, 45);
            this.MultiplyButton.TabIndex = 13;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(477, 373);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(79, 45);
            this.DivideButton.TabIndex = 14;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(625, 176);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(79, 45);
            this.EqualButton.TabIndex = 15;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.button15_Click);
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(625, 314);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(79, 45);
            this.PointButton.TabIndex = 16;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.DisplayLabel);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button PointButton;
    }
}