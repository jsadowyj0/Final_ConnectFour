﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    public partial class GameWonForm : Form
    {
        private GameForm parent;
        private bool shouldExit = true;
        public GameWonForm(GameForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.Text = "Draw!";
            lbl_header.Text = "Draw!";
        }

        public GameWonForm(GameForm parent, int playerNumber)
        {
            InitializeComponent();
            this.parent = parent;
            switch (playerNumber)
            {
                case 0:
                    lbl_header.Text = "Computer Wins!";
                    break;
                case 1:
                    lbl_header.Text = "Red Wins!";
                    break;
                case 2:
                    lbl_header.Text = "Yellow Wins!";
                    break;
                default:
                    break;
            }
        }

        private void GameWonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldExit) Application.Exit();
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            shouldExit = false;
            parent.Show();
            this.Close();
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(this.parent.parent);
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
            shouldExit = false;
            this.Close();
        }
    }
}
