namespace GamesWindowsFormsApp
{
    partial class PianoForm
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
            this.DoButton = new System.Windows.Forms.Button();
            this.ReButton = new System.Windows.Forms.Button();
            this.MiButton = new System.Windows.Forms.Button();
            this.FaButton = new System.Windows.Forms.Button();
            this.SoButton = new System.Windows.Forms.Button();
            this.LaButton = new System.Windows.Forms.Button();
            this.SiButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoButton
            // 
            this.DoButton.Location = new System.Drawing.Point(35, 73);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(69, 224);
            this.DoButton.TabIndex = 0;
            this.DoButton.Text = "Do";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // ReButton
            // 
            this.ReButton.Location = new System.Drawing.Point(148, 73);
            this.ReButton.Name = "ReButton";
            this.ReButton.Size = new System.Drawing.Size(69, 224);
            this.ReButton.TabIndex = 1;
            this.ReButton.Text = "Re";
            this.ReButton.UseVisualStyleBackColor = true;
            this.ReButton.Click += new System.EventHandler(this.ReButton_Click);
            // 
            // MiButton
            // 
            this.MiButton.Location = new System.Drawing.Point(259, 73);
            this.MiButton.Name = "MiButton";
            this.MiButton.Size = new System.Drawing.Size(69, 224);
            this.MiButton.TabIndex = 2;
            this.MiButton.Text = "Mi";
            this.MiButton.UseVisualStyleBackColor = true;
            this.MiButton.Click += new System.EventHandler(this.MiButton_Click);
            // 
            // FaButton
            // 
            this.FaButton.Location = new System.Drawing.Point(375, 73);
            this.FaButton.Name = "FaButton";
            this.FaButton.Size = new System.Drawing.Size(69, 224);
            this.FaButton.TabIndex = 3;
            this.FaButton.Text = "Fa";
            this.FaButton.UseVisualStyleBackColor = true;
            this.FaButton.Click += new System.EventHandler(this.FaButton_Click);
            // 
            // SoButton
            // 
            this.SoButton.Location = new System.Drawing.Point(482, 73);
            this.SoButton.Name = "SoButton";
            this.SoButton.Size = new System.Drawing.Size(69, 224);
            this.SoButton.TabIndex = 4;
            this.SoButton.Text = "So";
            this.SoButton.UseVisualStyleBackColor = true;
            this.SoButton.Click += new System.EventHandler(this.SoButton_Click);
            // 
            // LaButton
            // 
            this.LaButton.Location = new System.Drawing.Point(602, 73);
            this.LaButton.Name = "LaButton";
            this.LaButton.Size = new System.Drawing.Size(69, 224);
            this.LaButton.TabIndex = 5;
            this.LaButton.Text = "La";
            this.LaButton.UseVisualStyleBackColor = true;
            this.LaButton.Click += new System.EventHandler(this.LaButton_Click);
            // 
            // SiButton
            // 
            this.SiButton.Location = new System.Drawing.Point(711, 73);
            this.SiButton.Name = "SiButton";
            this.SiButton.Size = new System.Drawing.Size(69, 224);
            this.SiButton.TabIndex = 6;
            this.SiButton.Text = "Si";
            this.SiButton.UseVisualStyleBackColor = true;
            this.SiButton.Click += new System.EventHandler(this.SiButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(829, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 224);
            this.button1.TabIndex = 7;
            this.button1.Text = "Do";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PianoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SiButton);
            this.Controls.Add(this.LaButton);
            this.Controls.Add(this.SoButton);
            this.Controls.Add(this.FaButton);
            this.Controls.Add(this.MiButton);
            this.Controls.Add(this.ReButton);
            this.Controls.Add(this.DoButton);
            this.KeyPreview = true;
            this.Name = "PianoForm";
            this.Text = "PianoForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PianoForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Button ReButton;
        private System.Windows.Forms.Button MiButton;
        private System.Windows.Forms.Button FaButton;
        private System.Windows.Forms.Button SoButton;
        private System.Windows.Forms.Button LaButton;
        private System.Windows.Forms.Button SiButton;
        private System.Windows.Forms.Button button1;
    }
}