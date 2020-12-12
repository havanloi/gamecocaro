using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_cờ_caro
{
    public partial class Form1 : Form
    {
        #region properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlchessboard, txbPlayerName, pctbMark);

            ChessBoard.DrawChessBoard();
        }       
    }
}
