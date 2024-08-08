using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Pong
{
    public partial class Form1 : Form
    {

        // ---------    Initializing variables

        bool goup; // boolean to detect player up position
        bool godown; // boolean to detect player down position

        int speed = 5;  // integer called speed holding value of 5
        int ballx = 5;  // horizontal X speed value for the ball object
        int bally = 5;  // vertical Y speed value for the ball objects

        int score = 0; // score of the player
        int cpuScore = 0; // score for the cpu

        Random cpuLose = new Random(); // a random object 
        int probabilityToLose; // probability that the cpu miss the ball


        public Form1()
        {
            InitializeComponent();
        }



        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if player presses the up key
                // change the go up boolean to true
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                // if player presses the down key
                // change the go down boolean to true
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if player leaves the up key
                // change the go up boolean to false
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                // if player leaves the down key
                // change the go down boolean to false
                godown = false;
            }
        }



        private void gameTimer_Tick(object sender, EventArgs e)
        {
            playerLabel.Text = "" + score; // show player score on label 1
            cpuLabel.Text = "" + cpuScore; // show CPU score on label 2

            ball.Top -= bally; // assign the ball TOP to ball Y integer
            ball.Left -= ballx; // assign the ball LEFT to ball X integer

            cpu.Top -= speed; // assignment the CPU top speed integer


            // if the score is less than 5 
            if (score < 5)
            {
                // then do the following
                // if CPU has reached the top or gone to the bottom of the screen
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                    //then
                    //change the speed direction so it moves back up or down
                    speed = -speed;
                }
            }

            else // if the score is greater than 5, increase the difficulty
            {               

                if (score == 5 && probabilityToLose >= 60 ) // From 5, the probability the cpu lose is 40%
                {
                    cpu.Top = ball.Top + 33;
                }
                else if (score == 6 && probabilityToLose >= 69)// From 6, the probability the cpu lose is 31%
                {
                    cpu.Top = ball.Top + 35;
                }
                else if (score == 7 && probabilityToLose >= 78)// From 7, the probability the cpu lose is 22%
                {
                    cpu.Top = ball.Top + 35;
                }
                else if (score == 8 && probabilityToLose >= 88)// From 8, the probability the cpu lose is 12%
                {
                    cpu.Top = ball.Top + 35;
                }
                else if (score == 9 && probabilityToLose >= 97) // From 9, the probability the cpu lose is 3%
                {
                    cpu.Top = ball.Top + 35;
                }
                else
                {
                    cpu.Top = ball.Top + 20;
                }
            }

            //check the score
            // if the ball has gone pass the player through the left
            if (ball.Left < 0)
            {
                //then
                ball.Left = 434; // reset the ball to the middle of the screen
                ballx = -ballx; // change the balls direction
                ballx -= 2; // increase the speed
                cpuScore++; // add 1 to the CPU score
                probabilityToLose = cpuLose.Next(1, 101);
            }

            // if the ball has gone pass the cpu through the right
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                // then
                ball.Left = 434;  // set the ball to centre of the screen
                ballx = -ballx; // change the direction of the ball
                ballx += 2; // increase the speed of the ball
                score++; // add one to the players score
                probabilityToLose = cpuLose.Next(1, 101);
            }

            //   ----------       controlling the ball
            // if the ball either reachers the top of the screen or the bottom
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                // then
                //reverse the speed of the ball so it stays within the screen
                bally = -bally;
            }

            // ----------   if the ball hits the player or the CPU
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                // then bounce the ball in the other direction
                ballx = -ballx;
                if (goup && bally < 0) // if player press up, change the direction of the ball
                {
                    bally = -bally;
                }
                else if (godown && bally > 0) // if player press down, change the direction of the ball
                {
                    bally = -bally;
                }
                probabilityToLose = cpuLose.Next(1, 100); // a random number is generated each time the ball hits a player
            }



            // -------------- moove player part
            // if go up boolean is true and player is within the top boundary
            if (goup == true && player.Top > 0)
            {
                // then
                // move player towards to the top
                player.Top -= 8;
            }

            // if go down boolean is true and player is within the bottom boundary
            if (godown == true && player.Top < 455)
            {
                // then
                // move player towards the bottom of screen
                player.Top += 10;
            }

            // ------------- end moove player part




            // ------------------------------------- Final Score part and end of the game
   
            // if the player score more than 10
            // then we will stop the timer and show a message box
            if (score >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You win this game", "Congratulation");
            }

            // if the CPU scores more than 10
            // then we will stop the timer and show a message box
            if (cpuScore >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins, you lose");
            }
            // ------------------------------------- 

        }
    }
}
