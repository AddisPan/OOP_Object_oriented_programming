namespace TurtleWindowsFormsApp
{
    partial class TurtleForm
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
            this.TurtleButton = new System.Windows.Forms.Button();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.LittleFingerRadioButton = new System.Windows.Forms.RadioButton();
            this.ThumbRadioButton = new System.Windows.Forms.RadioButton();
            this.IndexFingerRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddleFingerRadioButton = new System.Windows.Forms.RadioButton();
            this.RingFingerRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(366, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "敵人";
            // 
            // TurtleButton
            // 
            this.TurtleButton.Location = new System.Drawing.Point(456, 227);
            this.TurtleButton.Name = "TurtleButton";
            this.TurtleButton.Size = new System.Drawing.Size(174, 49);
            this.TurtleButton.TabIndex = 12;
            this.TurtleButton.Text = "烏龜烏龜翹";
            this.TurtleButton.UseVisualStyleBackColor = true;
            this.TurtleButton.Click += new System.EventHandler(this.TurtleButton_Click);
            // 
            // ShowLabel
            // 
            this.ShowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShowLabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowLabel.Location = new System.Drawing.Point(483, 345);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(112, 36);
            this.ShowLabel.TabIndex = 11;
            // 
            // LittleFingerRadioButton
            // 
            this.LittleFingerRadioButton.AutoSize = true;
            this.LittleFingerRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LittleFingerRadioButton.Location = new System.Drawing.Point(920, 101);
            this.LittleFingerRadioButton.Name = "LittleFingerRadioButton";
            this.LittleFingerRadioButton.Size = new System.Drawing.Size(170, 29);
            this.LittleFingerRadioButton.TabIndex = 17;
            this.LittleFingerRadioButton.TabStop = true;
            this.LittleFingerRadioButton.Text = "5(LittleFinger)";
            this.LittleFingerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThumbRadioButton
            // 
            this.ThumbRadioButton.AutoSize = true;
            this.ThumbRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ThumbRadioButton.Location = new System.Drawing.Point(61, 101);
            this.ThumbRadioButton.Name = "ThumbRadioButton";
            this.ThumbRadioButton.Size = new System.Drawing.Size(129, 29);
            this.ThumbRadioButton.TabIndex = 18;
            this.ThumbRadioButton.TabStop = true;
            this.ThumbRadioButton.Text = "1(Thumb)";
            this.ThumbRadioButton.UseVisualStyleBackColor = true;
            // 
            // IndexFingerRadioButton
            // 
            this.IndexFingerRadioButton.AutoSize = true;
            this.IndexFingerRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IndexFingerRadioButton.Location = new System.Drawing.Point(239, 101);
            this.IndexFingerRadioButton.Name = "IndexFingerRadioButton";
            this.IndexFingerRadioButton.Size = new System.Drawing.Size(175, 29);
            this.IndexFingerRadioButton.TabIndex = 19;
            this.IndexFingerRadioButton.TabStop = true;
            this.IndexFingerRadioButton.Text = "2(IndexFinger)";
            this.IndexFingerRadioButton.UseVisualStyleBackColor = true;
            // 
            // MiddleFingerRadioButton
            // 
            this.MiddleFingerRadioButton.AutoSize = true;
            this.MiddleFingerRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MiddleFingerRadioButton.Location = new System.Drawing.Point(456, 101);
            this.MiddleFingerRadioButton.Name = "MiddleFingerRadioButton";
            this.MiddleFingerRadioButton.Size = new System.Drawing.Size(190, 29);
            this.MiddleFingerRadioButton.TabIndex = 20;
            this.MiddleFingerRadioButton.TabStop = true;
            this.MiddleFingerRadioButton.Text = "3(MiddleFinger)";
            this.MiddleFingerRadioButton.UseVisualStyleBackColor = true;
            // 
            // RingFingerRadioButton
            // 
            this.RingFingerRadioButton.AutoSize = true;
            this.RingFingerRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RingFingerRadioButton.Location = new System.Drawing.Point(696, 101);
            this.RingFingerRadioButton.Name = "RingFingerRadioButton";
            this.RingFingerRadioButton.Size = new System.Drawing.Size(166, 29);
            this.RingFingerRadioButton.TabIndex = 21;
            this.RingFingerRadioButton.TabStop = true;
            this.RingFingerRadioButton.Text = "4(RingFinger)";
            this.RingFingerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TurtleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 557);
            this.Controls.Add(this.RingFingerRadioButton);
            this.Controls.Add(this.MiddleFingerRadioButton);
            this.Controls.Add(this.IndexFingerRadioButton);
            this.Controls.Add(this.ThumbRadioButton);
            this.Controls.Add(this.LittleFingerRadioButton);
            this.Controls.Add(this.TurtleButton);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.label1);
            this.Name = "TurtleForm";
            this.Text = "烏龜烏龜翹";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TurtleButton;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.RadioButton LittleFingerRadioButton;
        private System.Windows.Forms.RadioButton ThumbRadioButton;
        private System.Windows.Forms.RadioButton IndexFingerRadioButton;
        private System.Windows.Forms.RadioButton MiddleFingerRadioButton;
        private System.Windows.Forms.RadioButton RingFingerRadioButton;
    }
}

