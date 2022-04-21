
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
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBigTimer
            // 
            this.MoveBigTimer.Enabled = true;
            this.MoveBigTimer.Interval = 10;
            this.MoveBigTimer.Tick += new System.EventHandler(this.MoveBigTimer_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPlayer.Image = global::Shooter_Game.Properties.Resources.player_stands;
            this.mainPlayer.Location = new System.Drawing.Point(63, 442);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(115, 170);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // MoveLeftTimer
            // 
            this.MoveLeftTimer.Interval = 10;
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // MoveRightTimer
            // 
            this.MoveRightTimer.Interval = 10;
            this.MoveRightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);
            // 
            // MoveUpTimer
            // 
            this.MoveUpTimer.Interval = 10;
            this.MoveUpTimer.Tick += new System.EventHandler(this.MoveUpTimer_Tick);
            // 
            // MoveDownTimer
            // 
            this.MoveDownTimer.Interval = 10;
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // ShooterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shooter_Game.Properties.Resources._1618500868_2_p_pikselnii_fon_dlya_igri_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.mainPlayer);
            this.DoubleBuffered = true;
            this.Name = "ShooterGame";
            this.Text = "ShooterGame";
            this.Load += new System.EventHandler(this.ShooterGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShooterGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShooterGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoveBigTimer;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveRightTimer;
        private System.Windows.Forms.Timer MoveUpTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
    }
}

