using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;
        bool gameOver = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            ReStartGame();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerGame = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.scorePlayer = new System.Windows.Forms.Label();
            this.hightScoreGame = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(931, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 507);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(931, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // playerGame
            // 
            this.playerGame.BackColor = System.Drawing.Color.Transparent;
            this.playerGame.Image = global::game.Properties.Resources.run_up0;
            this.playerGame.Location = new System.Drawing.Point(151, 35);
            this.playerGame.Name = "playerGame";
            this.playerGame.Size = new System.Drawing.Size(68, 89);
            this.playerGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerGame.TabIndex = 2;
            this.playerGame.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::game.Properties.Resources.box;
            this.pictureBox4.Location = new System.Drawing.Point(445, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::game.Properties.Resources.box;
            this.pictureBox5.Location = new System.Drawing.Point(638, 421);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "obstacle";
            // 
            // scorePlayer
            // 
            this.scorePlayer.AutoSize = true;
            this.scorePlayer.BackColor = System.Drawing.Color.Transparent;
            this.scorePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.scorePlayer.ForeColor = System.Drawing.Color.Transparent;
            this.scorePlayer.Location = new System.Drawing.Point(10, 10);
            this.scorePlayer.Name = "scorePlayer";
            this.scorePlayer.Size = new System.Drawing.Size(135, 32);
            this.scorePlayer.TabIndex = 5;
            this.scorePlayer.Text = "Score : 0";
            // 
            // hightScoreGame
            // 
            this.hightScoreGame.AutoSize = true;
            this.hightScoreGame.BackColor = System.Drawing.Color.Transparent;
            this.hightScoreGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hightScoreGame.ForeColor = System.Drawing.Color.Transparent;
            this.hightScoreGame.Location = new System.Drawing.Point(10, 517);
            this.hightScoreGame.Name = "hightScoreGame";
            this.hightScoreGame.Size = new System.Drawing.Size(215, 32);
            this.hightScoreGame.TabIndex = 6;
            this.hightScoreGame.Text = "Hight Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvents);
            // 
            // Form1
            // 
            this.BackgroundImage = global::game.Properties.Resources.background_still;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 558);
            this.Controls.Add(this.hightScoreGame);
            this.Controls.Add(this.scorePlayer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.playerGame);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Tag = "obstacle";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        private void GameTimerEvents(object sender, EventArgs e)
        {


            scorePlayer.Text = "Score: " + score;
            hightScoreGame.Text = "Hight Score: " + highScore;
            playerGame.Top += gravity;

            if(playerGame.Top > 421)
            {
                gravity = 0;
                playerGame.Top = 421;
                playerGame.Image = Properties.Resources.run_down0;
            }else if(playerGame.Top < 35)
            {
                gravity = 0;
                playerGame.Top = 35;
                playerGame.Image = Properties.Resources.run_up0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if(x.Left < 0)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }
                    if (x.Bounds.IntersectsWith(playerGame.Bounds))
                    {
                        gameTimer.Stop();

                        MessageBox.Show("Press Enter to play again", "Game Over",MessageBoxButtons.OK);
                        gameOver = true;

                        if (score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }
            if (score > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }
        }

        void ReStartGame()
        {
            scorePlayer.Parent = pictureBox1;
            hightScoreGame.Parent = pictureBox2;
            hightScoreGame.Top = 10;
            playerGame.Location = new Point(183, 213);
            playerGame.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }

            gameTimer.Start();
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if(playerGame.Top == 421)
                {
                    playerGame.Top -= 10;
                    gravity -= gravityValue;
                }else if(playerGame.Top == 35)
                {
                    playerGame.Top += 10;
                    gravity = gravityValue;
                }
            }
            if(e.KeyCode == Keys.Enter && gameOver )
            {
                ReStartGame();
            }
        }

   
    }
}
