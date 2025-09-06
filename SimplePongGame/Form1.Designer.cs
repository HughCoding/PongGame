namespace SimplePongGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            player = new System.Windows.Forms.PictureBox();
            ball = new System.Windows.Forms.PictureBox();
            cpu = new System.Windows.Forms.PictureBox();
            playerScore = new System.Windows.Forms.Label();
            cpuLabel = new System.Windows.Forms.Label();
            fakeBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fakeBall)).BeginInit();
            SuspendLayout();
          
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += timer1_Tick;
      
            player.BackColor = System.Drawing.Color.White;
            player.Location = new System.Drawing.Point(2, 192);
            player.Name = "player";
            player.Size = new System.Drawing.Size(27, 127);
            player.TabIndex = 0;
            player.TabStop = false;
       
            ball.BackColor = System.Drawing.Color.White;
            ball.Location = new System.Drawing.Point(434, 239);
            ball.Name = "ball";
            ball.Size = new System.Drawing.Size(27, 26);
            ball.TabIndex = 1;
            ball.TabStop = false;
    
            cpu.BackColor = System.Drawing.Color.White;
            cpu.Location = new System.Drawing.Point(898, 230);
            cpu.Name = "cpu";
            cpu.Size = new System.Drawing.Size(27, 127);
            cpu.TabIndex = 2;
            cpu.TabStop = false;
         
            playerScore.AutoSize = true;
            playerScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            playerScore.ForeColor = System.Drawing.Color.White;
            playerScore.Location = new System.Drawing.Point(105, 9);
            playerScore.Name = "playerScore";
            playerScore.Size = new System.Drawing.Size(21, 15);
            playerScore.TabIndex = 3;
            playerScore.Text = "00";
          
            cpuLabel.AutoSize = true;
            cpuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            cpuLabel.ForeColor = System.Drawing.Color.White;
            cpuLabel.Location = new System.Drawing.Point(735, 9);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new System.Drawing.Size(21, 15);
            cpuLabel.TabIndex = 4;
            cpuLabel.Text = "00";
          
            fakeBall.BackColor = System.Drawing.Color.Gray;
            fakeBall.Location = new System.Drawing.Point(434, 239);
            fakeBall.Name = "fakeBall";
            fakeBall.Size = new System.Drawing.Size(27, 26);
            fakeBall.TabIndex = 5;
            fakeBall.TabStop = false;
            fakeBall.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.fakeBall);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fakeBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.PictureBox fakeBall;
    }
}
