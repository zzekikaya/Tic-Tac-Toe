using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        [Flags] enum Player { X = 0, O = 1 }
        [Flags] enum Field { A1 = 1 << 0, A2 = 1 << 1, A3 = 1 << 2, B1 = 1 << 3, B2 = 1 << 4, B3 = 1 << 5, C1 = 1 << 6, C2 = 1 << 7, C3 = 1 << 8 };

        Player cPlayer = Player.X;
        Player players = Player.X | Player.O;

        Dictionary<Player, Field> moves = new Dictionary<Player, Field>();
        Dictionary<string, Field> btnField = new Dictionary<string, Field>()
        {
            {"A1", Field.A1}, {"A2", Field.A2}, {"A3", Field.A3}, {"B1", Field.B1}, {"B2", Field.B2}, {"B3", Field.B3}, {"C1", Field.C1}, {"C2", Field.C2}, {"C3", Field.C3},
        };

        int h1 = 7, h2 = 56, h3 = 448, v1 = 73, v2 = 146, v3 = 292, d1 = 84, d2 = 273;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = String.Format("Current player: {0}", cPlayer);
        }

        private void Form1_Load(object s, EventArgs e)
        {
            moves[Player.X] = moves[Player.O] = 0;
        }

        private void Button_Click(object s, EventArgs e)
        {
            Button b = s as Button;
            moves[cPlayer] |= btnField[b.Name];
            b.Text = cPlayer.ToString();
            b.Enabled = false;
            int i = Convert.ToInt32(moves[cPlayer]);

            if(i == h1 || i == h2 || i == h3 || i == v1 || i == v2 ||i == v3 || i == d1 || i == d2)
                MessageBox.Show(String.Format("{0} won!", cPlayer));

            cPlayer ^= players;
            this.Text = String.Format("Current player: {0}", cPlayer);
        }
    }
}
