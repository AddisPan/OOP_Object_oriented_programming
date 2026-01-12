namespace MenuStripWindowsFormsApp
{
    partial class surfingStatisticForm
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
            this.ReadButton = new System.Windows.Forms.Button();
            this.surfingTimeListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(495, 303);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(152, 41);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "ReadFile";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // surfingTimeListBox
            // 
            this.surfingTimeListBox.FormattingEnabled = true;
            this.surfingTimeListBox.ItemHeight = 15;
            this.surfingTimeListBox.Location = new System.Drawing.Point(183, 45);
            this.surfingTimeListBox.Name = "surfingTimeListBox";
            this.surfingTimeListBox.Size = new System.Drawing.Size(420, 169);
            this.surfingTimeListBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // surfingStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.surfingTimeListBox);
            this.Controls.Add(this.ReadButton);
            this.Name = "surfingStatisticForm";
            this.Text = "surfingStatisticForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.ListBox surfingTimeListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}