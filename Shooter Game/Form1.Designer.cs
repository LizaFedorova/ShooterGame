namespace Shooter_Game
{
    partial class ShooterGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MoveBigTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.mainLabel = new System.Windows.Forms.Label();
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelLevelText = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoveBigTimer
            // 
            this.MoveBigTimer.Enabled = true;
            this.MoveBigTimer.Interval = 10;
            this.MoveBigTimer.Tick += new System.EventHandler(this.MoveBigTimer_Tick);
            // 
            // MoveLeftTimer
            // 
            this.MoveLeftTimer.Enabled = true;
            this.MoveLeftTimer.Interval = 10;
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // MoveRightTimer
            // 
            this.MoveRightTimer.Enabled = true;
            this.MoveRightTimer.Interval = 10;
            this.MoveRightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);
            // 
            // MoveUpTimer
            // 
            this.MoveUpTimer.Enabled = true;
            this.MoveUpTimer.Interval = 10;
            this.MoveUpTimer.Tick += new System.EventHandler(this.MoveUpTimer_Tick);
            // 
            // MoveDownTimer
            // 
            this.MoveDownTimer.Enabled = true;
            this.MoveDownTimer.Interval = 10;
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // MoveBulletsTimer
            // 
            this.MoveBulletsTimer.Enabled = true;
            this.MoveBulletsTimer.Interval = 10;
            this.MoveBulletsTimer.Tick += new System.EventHandler(this.FireBullet);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.Red;
            this.mainLabel.Location = new System.Drawing.Point(278, 48);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(311, 98);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "label1";
            this.mainLabel.Visible = false;
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Interval = 10;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1081, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(1181, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(51, 38);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "00";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.ForeColor = System.Drawing.Color.Black;
            this.labelLevel.Location = new System.Drawing.Point(1181, 48);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(51, 38);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "00";
            // 
            // labelLevelText
            // 
            this.labelLevelText.AutoSize = true;
            this.labelLevelText.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelText.ForeColor = System.Drawing.Color.Black;
            this.labelLevelText.Location = new System.Drawing.Point(1088, 47);
            this.labelLevelText.Name = "labelLevelText";
            this.labelLevelText.Size = new System.Drawing.Size(87, 38);
            this.labelLevelText.TabIndex = 3;
            this.labelLevelText.Text = "Level:";
            // 
            // rules
            // 
            this.rules.AutoSize = true;
            this.rules.BackColor = System.Drawing.Color.Transparent;
            this.rules.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rules.ForeColor = System.Drawing.Color.Black;
            this.rules.Location = new System.Drawing.Point(12, 614);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(177, 50);
            this.rules.TabIndex = 5;
            this.rules.Text = "Press W,A,S,D to move\r\nPress SPACE to shoot";
            // 
            // ShooterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shooter_Game.Properties.Resources._1618500868_2_p_pikselnii_fon_dlya_igri_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelLevelText);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainLabel);
            this.DoubleBuffered = true;
            this.Name = "ShooterGame";
            this.Text = "ShooterGame";
            this.Load += new System.EventHandler(this.ShooterGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShooterGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShooterGame_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBigTimer;
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveRightTimer;
        private System.Windows.Forms.Timer MoveUpTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
        private System.Windows.Forms.Timer MoveBulletsTimer;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelLevelText;
        private System.Windows.Forms.Label rules;
    }
}

