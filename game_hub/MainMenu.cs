﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_hub
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e) // back to log in button
        {
            new Form1().Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e) // jet game button
        {
            new Jet1().Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) // baloon game button
        {
            new Baloon1().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) //leaderboard button
        {
            new Leaderboard().Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Game3().Show();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new xox().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new Form1().Show();
            }
        }
    }
}
