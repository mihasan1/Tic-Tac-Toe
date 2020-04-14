using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe;

namespace TicTacToe_v0._1
{
    public partial class Form1 : Form
    {
        private TicTacToeGAME game = new TicTacToeGAME();

        public Form1()
        {
            InitializeComponent();
            game.ShowGrid += ShowGrid;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game.NewGame();
            ShowGrid(game.arr);
            label10.ForeColor = Color.DarkRed;
            label10.Text = "Ходят крестики";
        }

        private void ShowGrid(string[] arr)
        {
            label1.Text = arr[0];
            label2.Text = arr[1];
            label3.Text = arr[2];
            label4.Text = arr[3];
            label5.Text = arr[4];
            label6.Text = arr[5];
            label7.Text = arr[6];
            label8.Text = arr[7];
            label9.Text = arr[8];
        }

        private void LabelClick(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int n = Convert.ToInt16(lb.Tag);
            if (n == 9)
                game.NewGame();
            else
            {
                if (game.DefinePlayer(n) == "err")
                    MessageBox.Show("Эта клетка уже занята!", "Ошибка!");
                else
                {
                    if (game.Winner() != "Ошибка!")
                        MessageBox.Show(game.Winner());
                }
            }
        }

        private void TextColorChanged(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int n = Convert.ToInt16(lb.Tag);
            if (lb.Text == "X")
            {
                lb.ForeColor = Color.DarkRed;
                label10.ForeColor = Color.DodgerBlue;
                label10.Text = "  Ходят нолики";
            }
            else if (lb.Text == "0")
            {
                lb.ForeColor = Color.DodgerBlue;
                label10.ForeColor = Color.DarkRed;
                label10.Text = "Ходят крестики";
            }
        }
    }
}
