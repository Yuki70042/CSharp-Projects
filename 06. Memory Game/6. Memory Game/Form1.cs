using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Memory_Game
{
    public partial class Form1 : Form
    {

        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Create a soundplayer object to play a sound if the player win the game
        private SoundPlayer winSound;
        private SoundPlayer makePairSound;
        private SoundPlayer turnCardSound;


        //Each of these letters is an interesting icon
        // In the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",", "k", "k", "o", "o", "r", "r",
                "b", "b", "v", "v", "w", "w", "z", "z", "e", "e", "l", "l",
            };


        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;


        /// Assign each icon from the list of icons to a random square
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        public Form1()
        {

            InitializeComponent();
            AssignIconsToSquares();

            string soundFilePathwin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "win.wav");
            winSound = new SoundPlayer(soundFilePathwin);

            string soundFilePathmakePair = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "makePair.wav");
            makePairSound = new SoundPlayer(soundFilePathmakePair);

            string soundFilePathturnCard = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "turncard.wav");
            turnCardSound = new SoundPlayer(soundFilePathturnCard);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    turnCardSound.Play();
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                secondClicked = clickedLabel;
                turnCardSound.Play();
                secondClicked.ForeColor = Color.Black;

                // Check to see if the player won
                CheckForWinner();

                // If the player clicked two matching icons, keep them 
                // black and reset firstClicked and secondClicked 
                // so the player can click another icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    makePairSound.Play();
                    return;
                }

                // If the player gets this far, the player 
                // clicked two different icons, so start the 
                // timer (which will wait three quarters of 
                // a second, and then hide the icons)
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }


        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            winSound.Play();
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }

        private void label1Click(object sender, EventArgs e)
        {

        }
    }

}
