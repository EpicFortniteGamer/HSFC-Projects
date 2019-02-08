using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoughtsAndCrosses.Properties;

namespace NoughtsAndCrosses
{
    public partial class gameUI : Form
    {
        private oxogame theGame;

        private String currentPlayerName;
        private String player1, player2;
        private oxogame.Piece currentPiece;

        public gameUI(string p1Name, string p2Name)
        {
            player1 = p1Name;
            player2 = p2Name;
            InitializeComponent();

        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            theGame = new oxogame(player1, player2); // pass names oxogame
            currentPlayerName = theGame.nextPlayer();
            currentPiece = theGame.nextPiece();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPiece == oxogame.Piece.Nought)
            {
                // display your nought image at 0,0 
                button1.Image = Resources.nought;
            }
            else
            {
                // display your cross image at 0,0 
                button1.Image = Resources.cross;
            }
            theGame.makeMove(0, 0, currentPiece);  // make the move in the model too!
            currentPlayerName = theGame.nextPlayer();
            currentPiece = theGame.nextPiece();
            // now test for a win too;
        }
    }
}
