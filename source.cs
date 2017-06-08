using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        /* Project Tic-Tac-Toe
         * Version: 0.2
         * Author: André Lichtenthäler
         * Licence: GPL-3.0
         * Website: https://github.com/Bikossor/Tic-tac-toe
         */

        [Flags] enum Player { X = 0, O = 1 }
        Player playerActive = Player.X;
        Player playerMask = Player.X | Player.O;

        [Flags] enum Field
        {
            None = 0,
            A1 = 1 << 0,
            A2 = 1 << 1,
            A3 = 1 << 2,
            B1 = 1 << 3,
            B2 = 1 << 4,
            B3 = 1 << 5,
            C1 = 1 << 6,
            C2 = 1 << 7,
            C3 = 1 << 8
        };

        Dictionary<Player, Field> playerMoves = new Dictionary<Player, Field>();
        Dictionary<string, Field> btnToField = new Dictionary<string, Field>()
        {
            {"A1", Field.A1},
            {"A2", Field.A2},
            {"A3", Field.A3},
            {"B1", Field.B1},
            {"B2", Field.B2},
            {"B3", Field.B3},
            {"C1", Field.C1},
            {"C2", Field.C2},
            {"C3", Field.C3},
        };

        // Horizontal solutions
        Field h1 = Field.A1 | Field.A2 | Field.A3;
        Field h2 = Field.B1 | Field.B2 | Field.B3;
        Field h3 = Field.C1 | Field.C2 | Field.C3;
        // Vertical solutions
        Field v1 = Field.A1 | Field.B1 | Field.C1;
        Field v2 = Field.A2 | Field.B2 | Field.C2;
        Field v3 = Field.A3 | Field.B3 | Field.C3;
        // Diagonal solutions
        Field d1 = Field.A1 | Field.B2 | Field.C3;
        Field d2 = Field.A3 | Field.B2 | Field.C1;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = String.Format("Player {0}'s turn", playerActive);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerMoves[Player.X] = playerMoves[Player.O] = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            playerMoves[playerActive] |= btnToField[b.Name];
            b.Text = playerActive.ToString();
            b.Enabled = false;

            if ((playerMoves[playerActive] & h1) == h1 ||
                (playerMoves[playerActive] & h2) == h2 ||
                (playerMoves[playerActive] & h3) == h3 ||
                (playerMoves[playerActive] & v1) == v1 ||
                (playerMoves[playerActive] & v2) == v2 ||
                (playerMoves[playerActive] & v3) == v3 ||
                (playerMoves[playerActive] & d1) == d1 ||
                (playerMoves[playerActive] & d2) == d2)
                MessageBox.Show(String.Format("Player {0} has won!", playerActive));

            playerActive ^= playerMask;
            this.Text = String.Format("Player {0}'s turn", playerActive);
        }
    }
}
