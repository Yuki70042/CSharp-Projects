using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            MessageBox.Show("Hi Player, I'm Xero the new AI." , "Xero");
            MessageBox.Show("Can you beat me? \nYou start with the circle...", "Good Luck");
        }

        private string currentPlayer = "O";
        string symbol = "n";
        bool AIMode = true;

        private Button[] buttons;
        Random random = new Random(); // A random object for the IA turn

 
        private void InitializeButtons()
        {
            // Assure-toi que tous les boutons sont correctement nommés dans le designer
            buttons = new Button[]
            {
                button1, button2, button3,
                button4, button5, button6,
                button7, button8, button9
            };
        }

        // ------------ Events Part and main game


        // Main event
        private void button_Click(object sender, EventArgs e)
            // click event, change the text (font webding) to display a cross
        {
            Button clickedButton = sender as Button;

            // Check if the conversion is ok
            if (clickedButton != null) 
            {
                // Checks if the case isn't already taken by a symbol
                if (string.IsNullOrEmpty(clickedButton.Text))
                {
                    // If the case is free, add the current symbol
                    clickedButton.Text = symbol;

                    // Check if someone  has won the game
                    CheckForWinner();

                    // Switch to the next player
                    SwitchPlayer();
                  
                    // If AI mode, allows the cpu to play
                    AITurn();
                    
                }
                else // If the case already has a symbol inside
                {
                    MessageBox.Show("The case is already taken... ");
                }
            }
        }



        private void ChangeMode_Click(object sender, EventArgs e)
            // Change in the two player mode if currently in IA mode and reverse
        {
            
            if (ChangeMode.Text == "Play with Player 2")
            {
                ChangeMode.Text = "Play with AI";
                AIMode = false;
                ClearBoard();
                MessageBox.Show("You are now in 2 Player mod");
            }
            else
            {
                ChangeMode.Text = "Play with Player 2";
                ClearBoard();
                MessageBox.Show("You are playing now against the AI");
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        // When the restart button is click, clear the gameboard
        {
            ClearBoard();
        }


        // ---------------- End of event Part


        private void SwitchPlayer()
        {
            // Alternate between X and O

            if (AIMode) // If AI Mode is active
            {
                if (currentPlayer == "Xero")
                {
                    currentPlayer = "Player1";
                    symbol = "n"; // 0 symbol
                }
                else
                {
                    currentPlayer = "Xero";
                    symbol = "r"; // X symbol
                }
            }
            else // Two Player Mod
            {
                if (currentPlayer == "Player2")
                {
                    currentPlayer = "Player1";
                    symbol = "n"; // 0 symbol
                }
                else
                {
                    currentPlayer = "Player2";
                    symbol = "r"; // X symbol
                }
            }
        }


        private void AITurn()
        {
            if (AIMode)
            {

            }
        }


        private void CheckForWinner()
        { 
            // A table of all win combinations
            int[,] winningCombinations = new int[,]
            {
                { 0, 1, 2},
                { 3, 4, 5}, // Lines
                { 6, 7, 8},

                { 0, 3, 6},
                { 1, 4, 7}, // Columns
                { 2, 5, 8},

                { 0, 4, 8}, // diagonals
                { 2, 4, 6},
            };
            
            // Check all the combinations
            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                int index1 = winningCombinations[i, 0];
                int index2 = winningCombinations[i, 1];
                int index3 = winningCombinations[i, 2];


                if (index1 >= buttons.Length || index2 >= buttons.Length || index3 >= buttons.Length)
                {
                    MessageBox.Show($"Index out of bounds: {index1}, {index2}, {index3}");
                    continue;
                }

                if (CheckLine(buttons[index1], buttons[index2], buttons[index3]))
                {
                    MessageBox.Show($"{currentPlayer} you Win!");
                    return;
                }
            }
            if (BoardIsFull())
            {
                MessageBox.Show("It's a Draw!");
            }

        }
        private bool CheckLine(Button a, Button b, Button c)
        {
            return a.Text == b.Text && b.Text == c.Text && !string.IsNullOrEmpty(a.Text);
        }

        private bool BoardIsFull()
        {
            foreach (Button button in buttons)
            {
                if (string.IsNullOrEmpty(button.Text))
                    return false; // Some buttons are empty
            }
            return true; // the board is full
        }

        private void ClearBoard()
        //A method to clear the game board
        {           
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                // Check if Control is a button
                if (control is Button button)
                {
                    // Erase all the content                     
                    button.Text = string.Empty;
                    
                }
            }
        }
    }
}
