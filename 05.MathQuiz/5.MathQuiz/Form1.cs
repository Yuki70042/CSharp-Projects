using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace _5.MathQuiz
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            string soundFilePathsuccess = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "success.wav");
            correctSound = new SoundPlayer(soundFilePathsuccess);

            string SoundFilePathdeath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "death.wav");
            youLost = new SoundPlayer(SoundFilePathdeath);

            string SoundFilePathwin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "win.wav");
            youWin = new SoundPlayer(SoundFilePathwin);
        }



        //Create a random object called randomizer
        // to generate random number.
        Random randomizer = new Random();

        // This variables keep some sounds for differents effect !
        private SoundPlayer correctSound; // the user give a correct answer
        private SoundPlayer youLost;      // The user lost 
        private SoundPlayer youWin;       // The user win


        //          -----------                      initialize the variables
        // These integer variables store the numbers
        // for the addition problem.
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the
        // remaining time.
        int timeLeft;
        //                        ------------------     

        public void StartTheQuiz()
        /* 
            Start the quiz by filling in all of the problems
            and starting the timer.      
        */
        {

            //                ----------------          Addition Part
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();


            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;


            //                ----------------         Subtraction Part
            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();

            difference.Value = 0;


            //                ----------------         Multiplication Part
            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();

            product.Value = 0;


            //                ----------------         Division Part
            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporyQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporyQuotient;

            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();

            quotient.Value = 0;

            // Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }


        private bool CheckTheAnswer()
        /* Check the answers to see if the user got everything right
         * Return true if the answer's correcte, false otherwise
        */
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;

            else
                return false;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            timeLabel.BackColor = Color.White;
            StartTheQuiz();
            startButton.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                youWin.Play();
                timeLabel.BackColor = Color.Green;
                MessageBox.Show("You got all the answers right! \u263A",
                                "Congratulations!");
                startButton.Enabled = true;

            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

                if (timeLeft < 6)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.

                timer1.Stop();
                youLost.Play();
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                
                // allows the player to replay
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpon control.
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void difference_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpon control.
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void product_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpon control.
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void quotient_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpon control.
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {

            if (addend1 + addend2 == sum.Value)
            {
                correctSound.Play();
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                correctSound.Play();
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                correctSound.Play();
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                correctSound.Play();
            }
        }

        private void sum_KeyDown(object sender, KeyEventArgs e)
        {
            // Management of form keys for sum
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // remove the beep
                SendKeys.Send("{TAB}"); // Simulates the tab key
            }
        }

        private void difference_KeyDown(object sender, KeyEventArgs e)
        {
            // Management of form keys for difference
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // remove the beep
                SendKeys.Send("{TAB}"); // Simulates the tab key
            }
        }

        private void product_KeyDown(object sender, KeyEventArgs e)
        {
            // Management of form keys for product
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // remove the beep
                SendKeys.Send("{TAB}"); // Simulates the tab key
            }
        }

        private void quotient_KeyDown(object sender, KeyEventArgs e)
        {
            // Management of form keys for quotient
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // remove the beep
                SendKeys.Send("{TAB}"); // Simulates the tab key
            }
        }
    }
}
