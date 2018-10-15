using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartGame
{
    public partial class Form1 : Form
    {
        private Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void addPlayer_btn_Click(object sender, EventArgs e)
        {
            if (playerName_tb.Text != String.Empty || playerName_tb.Text == "")
            {
                game.AddPlayer(playerName_tb.Text);
            }

            playerListView.Items.Clear();

            foreach (Player player in game.GetPlayers())
            {
                playerListView.Items.Add(player.ToString());
            }

            playerName_tb.Text = String.Empty;
        }

        private void startGame_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New game started!");
            playerListView.Enabled = false;
            startGame_btn.Visible = false;
            foreach (Player player in game.GetPlayers())
            {
                playerPointsView.Items.Add(player.ToString());
            }
        }

        private void nextTurn_btn_click(object sender, EventArgs e)
        {
            playerPointsView.Items.Clear();

            foreach (Player player in game.GetPlayers())
            {
                player.AddTurn();
                playerPointsView.Items.Add(player.ToString() + " " + player.GetScore());
            }


        }
    }
}
