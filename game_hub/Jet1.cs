using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace game_hub
{
    public partial class Jet1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        
        

        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        int oldscore;
        Random rnd = new Random();


        public Jet1()
        {
            InitializeComponent();
            
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = score.ToString();


            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;


            if(enemyOne.Top > 710 || enemyTwo.Top > 710 || enemyThree.Top > 710)
            {
                gameOver();
            }



            // player movement logic starts

            if(goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if(goRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }
            // player movement logic ends

            if(shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if(bullet.Top < 0)
            {
                shooting = false;
            }

            if(bullet.Bounds.IntersectsWith(enemyOne.Bounds)) //
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -450;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -450;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if(score == 5)
            {
                enemySpeed = 8;
            }
            if(score == 10)
            {
                enemySpeed = 10;
            }
            if (score == 15)
            {
                enemySpeed = 12;
            }
            if (score == 20)
            {
                enemySpeed = 13;
            }
            if (score == 25)
            {
                enemySpeed = 15;
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void Jet1_Load(object sender, EventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width /2);

            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new MainMenu().Show();
            }
        }

        private void resetGame()
        {
            cn = new SqlConnection(Session.Connect_String);
            cn.Open();
            string query2 = "SELECT game1 FROM data_hub WHERE username = @username";
            cmd = new SqlCommand(query2, cn);
            cmd.Parameters.AddWithValue("@username", Session.LoggedUsername);

            object result = cmd.ExecuteScalar(); // z cmd query2 dostane udaje do result


            if (result != DBNull.Value && result != null)
            {
                oldscore = Convert.ToInt32(result);
            }
            else
            {
                oldscore = 0; // defaultné ak este nema ziadnu hodnotu
            }

            score_result.Text += Environment.NewLine + "Staré skore" + oldscore + Environment.NewLine + "Nové skore" + score;


            // porovnanie
            if (score > oldscore)
            {
                string query = "UPDATE data_hub SET game1 = @score WHERE username = @username";
                SqlCommand updateCmd = new SqlCommand(query, cn);
                updateCmd.Parameters.AddWithValue("@score", score);
                updateCmd.Parameters.AddWithValue("@username", Session.LoggedUsername);
                updateCmd.ExecuteNonQuery();
            }

            cn.Close();

            gameTimer.Start();
            enemySpeed = 6;

            
            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) *-1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;


            txtScore.Text = score.ToString();


            
            
            
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "Game Over!!" + Environment.NewLine + "Press Enter to try again.";
            score_result.Text = "";


        }
    }
}
