namespace ShootBirdWindowsFormsApp
{
    partial class SbForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SbForm));
            this.BirdPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.MissTotalShotlabel = new System.Windows.Forms.Label();
            this.TotalScorelabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameOverlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BirdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BirdPictureBox
            // 
            this.BirdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BirdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BirdPictureBox.Image")));
            this.BirdPictureBox.Location = new System.Drawing.Point(310, 261);
            this.BirdPictureBox.Name = "BirdPictureBox";
            this.BirdPictureBox.Size = new System.Drawing.Size(189, 143);
            this.BirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BirdPictureBox.TabIndex = 0;
            this.BirdPictureBox.TabStop = false;
            this.BirdPictureBox.Click += new System.EventHandler(this.BirdPictureBox_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Lime;
            this.ScoreLabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.ScoreLabel.Location = new System.Drawing.Point(58, 44);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(168, 42);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score = 0";
            // 
            // MissTotalShotlabel
            // 
            this.MissTotalShotlabel.AutoSize = true;
            this.MissTotalShotlabel.BackColor = System.Drawing.Color.Lime;
            this.MissTotalShotlabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MissTotalShotlabel.ForeColor = System.Drawing.Color.Red;
            this.MissTotalShotlabel.Location = new System.Drawing.Point(58, 87);
            this.MissTotalShotlabel.Name = "MissTotalShotlabel";
            this.MissTotalShotlabel.Size = new System.Drawing.Size(235, 42);
            this.MissTotalShotlabel.TabIndex = 2;
            this.MissTotalShotlabel.Text = "Miss Shot = 0";
            // 
            // TotalScorelabel
            // 
            this.TotalScorelabel.AutoSize = true;
            this.TotalScorelabel.BackColor = System.Drawing.Color.Lime;
            this.TotalScorelabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalScorelabel.ForeColor = System.Drawing.Color.Red;
            this.TotalScorelabel.Location = new System.Drawing.Point(58, 130);
            this.TotalScorelabel.Name = "TotalScorelabel";
            this.TotalScorelabel.Size = new System.Drawing.Size(242, 42);
            this.TotalScorelabel.TabIndex = 3;
            this.TotalScorelabel.Text = "Total Shot = 0";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExitButton.Location = new System.Drawing.Point(889, 130);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 62);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RestartButton.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RestartButton.Location = new System.Drawing.Point(889, 44);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(127, 62);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameOverlabel
            // 
            this.GameOverlabel.AutoSize = true;
            this.GameOverlabel.BackColor = System.Drawing.Color.Lime;
            this.GameOverlabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameOverlabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverlabel.Location = new System.Drawing.Point(463, 63);
            this.GameOverlabel.Name = "GameOverlabel";
            this.GameOverlabel.Size = new System.Drawing.Size(0, 42);
            this.GameOverlabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 641);
            this.Controls.Add(this.GameOverlabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TotalScorelabel);
            this.Controls.Add(this.MissTotalShotlabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.BirdPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "ShootBird";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.BirdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BirdPictureBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label MissTotalShotlabel;
        private System.Windows.Forms.Label TotalScorelabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GameOverlabel;
    }
}

