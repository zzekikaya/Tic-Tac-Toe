using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	 public partial class Main : Form
	 {
		  /* 
		   * Project Tic-Tac-Toe
			* Version: 0.1.2
			* Author: André Lichtenthäler
			* Licence: GPL-3.0
			* Website: https://github.com/Bikossor/Tic-Tac-Toe
			*/

		  /// <summary>
		  /// Defines both players as enum-items.
		  /// </summary>
		  [Flags]
		  private enum Player
		  {
				X = 0,
				O = 1 << 0
		  };

		  /// <summary>
		  /// Defines all fields of the standard 3x3; line for line from left to right.
		  /// </summary>
		  [Flags]
		  private enum Field
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

		  /// <summary>
		  /// Sets the first player to play.
		  /// </summary>
		  private Player playerActive = Player.X;

		  /// <summary>
		  /// Defines a 'playerMask' which simplifies the selection of the active player.
		  /// </summary>
		  private Player playerMask = Player.X | Player.O;

		  /// <summary>
		  /// Defines a dictionary for all moves both players took.
		  /// </summary>
		  private Dictionary<Player, Field> playerMoves = new Dictionary<Player, Field>();

		  /// <summary>
		  /// Defines a dictionary which simplifies the translation from a button-name to a field.
		  /// </summary>
		  private Dictionary<string, Field> btnToField = new Dictionary<string, Field>()
        {
            {"A1", Field.A1},
            {"A2", Field.A2},
            {"A3", Field.A3},
            {"B1", Field.B1},
            {"B2", Field.B2},
            {"B3", Field.B3},
            {"C1", Field.C1},
            {"C2", Field.C2},
            {"C3", Field.C3}
        };

		  /// <summary>
		  /// Defining the horizontal solutions.
		  /// </summary>
		  private Field h1 = Field.A1 | Field.A2 | Field.A3;
		  private Field h2 = Field.B1 | Field.B2 | Field.B3;
		  private Field h3 = Field.C1 | Field.C2 | Field.C3;

		  /// <summary>
		  /// Defining the vertical solutions.
		  /// </summary>
		  private Field v1 = Field.A1 | Field.B1 | Field.C1;
		  private Field v2 = Field.A2 | Field.B2 | Field.C2;
		  private Field v3 = Field.A3 | Field.B3 | Field.C3;

		  /// <summary>
		  /// Defining the diagonal solutions.
		  /// </summary>
		  private Field d1 = Field.A1 | Field.B2 | Field.C3;
		  private Field d2 = Field.A3 | Field.B2 | Field.C1;

		  public Main()
		  {
				InitializeComponent();

				// Prints to the window title which player is currently playing.
				this.Text = String.Format("Player {0}'s turn", playerActive);
		  }

		  private void Form1_Load(object sender, EventArgs e)
		  {
				// Initializes the moves-dictionary with a zero for both players.
				playerMoves[Player.X] = playerMoves[Player.O] = Field.None;
		  }

		  /// <summary>
		  /// A generic click function for all 9 buttons (fields).
		  /// NOTE: Buttons MUST have names from A1 to A3, B1 to B3 and C1 to C3 (line for line from left to right).
		  /// </summary>
		  private void Button_Click(object sender, EventArgs e)
		  {
				Button b = (Button)sender;
				playerMoves[playerActive] |= btnToField[b.Name];
				b.Text = playerActive.ToString();
				b.Enabled = false;

				// This is the whole game logic. It checks every single solution bitwise if its true or not.
				if ((playerMoves[playerActive] & h1) == h1 ||
					 (playerMoves[playerActive] & h2) == h2 ||
					 (playerMoves[playerActive] & h3) == h3 ||
					 (playerMoves[playerActive] & v1) == v1 ||
					 (playerMoves[playerActive] & v2) == v2 ||
					 (playerMoves[playerActive] & v3) == v3 ||
					 (playerMoves[playerActive] & d1) == d1 ||
					 (playerMoves[playerActive] & d2) == d2)
				{
					 // If someone won the game, all other buttons gets disabled.
					 foreach (Control c in this.Controls)
					 {
						  c.Enabled = false;
					 }

					 // Displaying, which player won.
					 MessageBox.Show(String.Format("Player {0} has won!", playerActive));
				}

				// Inverting the active player.
				playerActive ^= playerMask;

				// Prints to the window title which player is currently playing.
				this.Text = String.Format("Player {0}'s turn", playerActive);				
		  }
	 }
}
