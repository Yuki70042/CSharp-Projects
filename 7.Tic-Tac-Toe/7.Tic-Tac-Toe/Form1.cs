using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        // ----------  Initialisation variables
        Random random = new Random(); // A random object for the IA turn
        private Button[] buttons;
        private string currentPlayer = "Player";
        string symbol = "n";
        string opponentSymbol = "r";
        bool winner = false;
        bool AIMode = true;


        private void InitializeButtons()
        {
            // Initializing the different buttons in a table 
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
                    clickedButton.Text = symbol;
                    CheckForWinner();
                    if (!winner) // Ensure the game is not over
                    {
                        SwitchPlayer();

                        if (AIMode && !winner) // If AI mode is active and the game isn't over
                        {
                            AITurnMinimax(); // AI takes its turn
                        }
                    }

                    else
                    {
                        MessageBox.Show("Win");
                    }
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
                currentPlayer = "Player1";
                symbol = "n";
                MessageBox.Show("You are now in 2 Player mod");

            }
            else
            {
                ChangeMode.Text = "Play with Player 2";
                currentPlayer = "Player1";
                symbol = "n";
                ClearBoard();
                AIMode = true;
                MessageBox.Show("You are playing now against the AI. \nYou start with \"O\"");
            }

            InformationsText.Text = "Player1 turn";
            winner = false;
            ActivateBoardButtons();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        // When the restart button is click, clear the gameboard
        {
            winner = false;
            ClearBoard();
            ActivateBoardButtons();
        }

        // ---------------- End of event Part


        private void SwitchPlayer()
        {
            // Alternate between X and O

            if (AIMode) // If AI Mode is active
            {
                if (currentPlayer == "Xero")
                {
                    currentPlayer = "Player";
                    symbol = "n"; // 0 symbol
                    InformationsText.Text = "Player Turn";
                    AIMode = false;
                }
                else
                {
                    currentPlayer = "Xero";
                    symbol = "r"; // X symbol
                    InformationsText.Text = "Xero Turn";
                }
            }

            else // Two Player Mod
            {
                if (currentPlayer == "Player2")
                {
                    currentPlayer = "Player1";
                    symbol = "n"; // 0 symbol
                    InformationsText.Text = "Player1 Turn";
                }
                else
                {
                    currentPlayer = "Player2";
                    symbol = "r"; // X symbol
                    InformationsText.Text = "Player2 Turn";
                }
            }
        }


        private async void AITurnRandom()
        {
            if (AIMode)
            {
                await Task.Delay(400);
                bool SymboleIsOk = false; // Is the AI action ok?
                int index = 0; // number of the case of AI Action

                while (!SymboleIsOk && !winner) // while the AI action is not valid
                {
                    index = random.Next(0, 9); // generate a random number for the AI action

                    if (string.IsNullOrEmpty(buttons[index].Text) || BoardIsFull())
                        // if the case free, add the symbole. 
                        // if it's a draw, pass the AI turn
                    {
                        buttons[index].Text = symbol; // The AI add the symbole in a random case
                        SymboleIsOk = true; // AI turn finish
                        CheckForWinner();
                    }
                }
                SwitchPlayer();
            }
        }

        private void AITurnMinimax()
        {
            if (AIMode)
            {
                int bestValue = int.MinValue;
                int bestMove = -1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    if (string.IsNullOrEmpty(buttons[i].Text))
                    {
                        buttons[i].Text = symbol;
                        int moveVal = Minimax(0, false);
                        buttons[i].Text = string.Empty;

                        if (moveVal > bestValue)
                        {
                            bestMove = i;
                            bestValue = moveVal;
                        }
                    }
                }

                // Make the best move
                if (bestMove != -1)
                {
                    buttons[bestMove].Text = symbol;
                    CheckForWinner();
                    SwitchPlayer(); // Move to the next player
                }
            }
        }


        private int Minimax(int depth, bool isMaximizing) // Minimax Algorithm
        {

            int score = CheckForWinner(); 
            // Check the Board status 

            if (score != -1)  // -1 indicates the game is still ongoing
            {
                return score;
            }

            if (isMaximizing) 
                // If AI want to have the score Max
            {
                int best = int.MinValue;

                for (int i = 0; i < buttons.Length; i++)
                    // Foreach buttons, simulate all possible moves
                {
                    if (string.IsNullOrEmpty(buttons[i].Text)) // Check if buttons is free
                    {
                        buttons[i].Text = symbol; // simulate the move

                        /* recursively calls the new board create
                         * increase the depth of the tree and !isMaximizing 
                         * reverse role (search the best move for the player)
                         * Math.Max keep the best move find */
                        best = Math.Max(best, Minimax(depth + 1, !isMaximizing));                        
                        buttons[i].Text = string.Empty; // reset the move 
                    }
                }
                return best; // Return the best (Max) move find
            }

            else // Search 
            {
                int best = int.MaxValue;

                // Iterate through all possible moves
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (string.IsNullOrEmpty(buttons[i].Text))
                    {
                        buttons[i].Text = opponentSymbol;
                        best = Math.Min(best, Minimax(depth + 1, !isMaximizing));
                        buttons[i].Text = string.Empty;
                    }
                }
                return best;
            }
        }

        private int CheckForWinner()
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

                if (CheckLine(buttons[index1], buttons[index2], buttons[index3]))
                {
                    if (buttons[index1].Text == "r") // Example for "X"
                    {
                        DisableBoardButtons();
                        return 10; // Value for "X" win
                    }

                    else if (buttons[index1].Text == "n") // Example for "O"
                    {
                        DisableBoardButtons();
                        return -10; // Value for "O" win
                    }
                }
            }
            if (BoardIsFull())
            {
                DisableBoardButtons();
                // MessageBox.Show("It's a Draw !");
                return 0;
            }

            return -1; // Game is still ongoing
        }

        private void DisableBoardButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false; // Disable each button
            }
        }


        private void ActivateBoardButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true; // Disable each button
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
