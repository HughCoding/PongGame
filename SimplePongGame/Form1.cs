using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePongGame
{
    public partial class Form1 : Form
    {
    
        int ballXspeed = 9;
        int ballYspeed = 6;
        int playerSpeed = 8;
        int cpuSpeed = 5;

        int playerScoreValue = 0;
        int cpuScoreValue = 0;

        bool goUp = false;
        bool goDown = false;

        Panel pauseMenu = new Panel();
        Button btnContinue = new Button();
        Button btnRestart = new Button();
        Button btnExit = new Button();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            SetupPauseMenu();
        }

        private void SetupPauseMenu()
        {
            pauseMenu.Size = this.ClientSize;
            pauseMenu.BackColor = Color.FromArgb(150, 0, 0, 0); 
            pauseMenu.Visible = false;

            
            btnContinue.Text = "Resume";
            btnContinue.Size = new Size(120, 40);
            btnContinue.Location = new Point(ClientSize.Width / 2 - 60, 150);
            btnContinue.Click += (s, e) => { pauseMenu.Visible = false; gameTimer.Start(); };

           
            btnRestart.Text = "Reset";
            btnRestart.Size = new Size(120, 40);
            btnRestart.Location = new Point(ClientSize.Width / 2 - 60, 200);
            btnRestart.Click += (s, e) => { ResetGame(); pauseMenu.Visible = false; gameTimer.Start(); };

           
            btnExit.Text = "Exit";
            btnExit.Size = new Size(120, 40);
            btnExit.Location = new Point(ClientSize.Width / 2 - 60, 250);
            btnExit.Click += (s, e) => { Application.Exit(); };

            pauseMenu.Controls.Add(btnContinue);
            pauseMenu.Controls.Add(btnRestart);
            pauseMenu.Controls.Add(btnExit);

            this.Controls.Add(pauseMenu);
            pauseMenu.BringToFront();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;

            if (e.KeyCode == Keys.Escape && !pauseMenu.Visible)
            {
                pauseMenu.Visible = true;
                gameTimer.Stop();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            playerScore.Text = playerScoreValue.ToString();
            cpuLabel.Text = cpuScoreValue.ToString();


            ball.Left += ballXspeed;
            ball.Top += ballYspeed;


            if (cpu.Top + cpu.Height / 2 < ball.Top + ball.Height / 2)
                cpu.Top += cpuSpeed;
            else
                cpu.Top -= cpuSpeed;

            if (cpu.Top < 0) cpu.Top = 0;
            if (cpu.Top + cpu.Height > ClientSize.Height) cpu.Top = ClientSize.Height - cpu.Height;


            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballXspeed = -ballXspeed;

                if (ballXspeed > 0) ballXspeed++;
                else ballXspeed--;

                if (ballYspeed > 0) ballYspeed++;
                else ballYspeed--;
            }

     
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
                ballYspeed = -ballYspeed;

            // Pontuação
            if (ball.Left < 0)
            {
                cpuScoreValue++;
                ResetBall();
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                playerScoreValue++;
                ResetBall();
            }


            if (goUp && player.Top > 0) player.Top -= playerSpeed;
            if (goDown && player.Top + player.Height < ClientSize.Height) player.Top += playerSpeed;


            if (playerScoreValue >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Você venceu!");
            }
            if (cpuScoreValue >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU venceu!");
            }
        }

        private void ResetBall()
        {
            ball.Left = ClientSize.Width / 2 - ball.Width / 2;
            ball.Top = ClientSize.Height / 2 - ball.Height / 2;

            Random rand = new Random();
            ballXspeed = (rand.Next(2) == 0 ? 9 : -9);
            ballYspeed = (rand.Next(2) == 0 ? 6 : -6);
        }

        private void ResetGame()
        {
            playerScoreValue = 0;
            cpuScoreValue = 0;
            player.Top = ClientSize.Height / 2 - player.Height / 2;
            cpu.Top = ClientSize.Height / 2 - cpu.Height / 2;
            ResetBall();
        }
    }
}
