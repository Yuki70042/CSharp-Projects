﻿using System;
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
            MessageBox.Show("Hi Player, I'm zero the new IA." , "Zero");
            MessageBox.Show(" Can you beat me? You are the circle...", "Good Luck");
        }

        private string currentPlayer = "O";
        string symbol = "n";
        bool AIMode = true;


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                }
                else
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
            }
            else
            {
                ChangeMode.Text = "Play with Player 2";
                ClearBoard();
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
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
                symbol = "n";
            }
            else
            {
                currentPlayer = "X";
                symbol = "r";
            }
        }


        private void CheckForWinner()
        {

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
