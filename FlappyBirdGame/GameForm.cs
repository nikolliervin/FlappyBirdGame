using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class FlappyBird : Form
    {
        int Score = 0;
        int GravityValue = 10;
        int PipeSpeed = 10;

        
        
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += GravityValue;
            Pipe1.Left -= PipeSpeed;
            Pipe2.Left -= PipeSpeed;
            if (Pipe2.Left < -50)
            {
                Pipe2.Left = 800;
                Score++;
                ScoreLabel.Text = "Score: "+Score;
            }
            if (Pipe1.Left < -80)
            {
                Pipe1.Left = 950;
                Score++;
                ScoreLabel.Text = "Score: " + Score;
            }
            if ((Bird.Bounds.IntersectsWith(Pipe1.Bounds)) ||
                (Bird.Bounds.IntersectsWith(Pipe2.Bounds)) ||
                (Bird.Bounds.IntersectsWith(GroundPanel.Bounds))
                )

            {
                EndGame();
            }

            if (Bird.Top < -75)
            {
                EndGame();
            }
            

            switch (Score)
            {
                case 5:
                    PipeSpeed++;
                    break;
                case 10:
                    PipeSpeed++;
                    break;
                case 15:
                    PipeSpeed++;
                    break;
                case 20:
                    PipeSpeed++;
                    break;
                case 25:
                    PipeSpeed++;
                    break;
                case 30:
                    PipeSpeed++;
                    break;
                case 100:
                    PipeSpeed = PipeSpeed * 2;
                    break;
                default:
                    
                    break;
            }

        }

        private void KeyIsPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GravityValue= -10;
            }
        }

        private void KeyIsReleased(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GravityValue = 10;
            }
        }
        private void EndGame()
        {
            GameTimer.Stop();
            GameOverPanel.Show();
            FinalScoreLabel.Text = ScoreLabel.Text;
        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {

        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            var GameForm = new FlappyBird();
            this.Close();
            GameForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
