using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToeGAME
    {
        public event ShowGridEventHandler ShowGrid;
        public delegate void ShowGridEventHandler(string[] arr);
        private int i;
        public string[] arr;
        string player;

        public TicTacToeGAME()
        {
            i = 0;
            arr = new string[9];
            player = "X";
        }

        public void NewGame()
        {
            i = 0;
            player = "X";
            for (int k = 0; k < 9; k++)
                arr[k] = "";
            ShowGrid?.Invoke(arr);
        }

        public string DefinePlayer(int cell)
        {
            if (arr[cell] == "X" || arr[cell] == "0")
                return "err";
            if (i % 2 == 0) player = "X";
            else player = "0";
            i++;
            arr[cell] = player;
            ShowGrid?.Invoke(arr);
            return "Ok";
        }

        public string Winner()
        {
            if ((arr[0] == "X" & arr[1] == "X" & arr[2] == "X") |
                (arr[3] == "X" & arr[4] == "X" & arr[5] == "X") |
                (arr[6] == "X" & arr[7] == "X" & arr[8] == "X") |
                (arr[0] == "X" & arr[4] == "X" & arr[8] == "X") |
                (arr[2] == "X" & arr[4] == "X" & arr[6] == "X") |
                (arr[0] == "X" & arr[3] == "X" & arr[6] == "X") |
                (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") |
                (arr[2] == "X" & arr[5] == "X" & arr[8] == "X"))
                return "Победа крестиков!";
            else if ((arr[0] == "0" & arr[1] == "0" & arr[2] == "0") |
                (arr[3] == "0" & arr[4] == "0" & arr[5] == "0") |
                (arr[6] == "0" & arr[7] == "0" & arr[8] == "0") |
                (arr[0] == "0" & arr[4] == "0" & arr[8] == "0") |
                (arr[2] == "0" & arr[4] == "0" & arr[6] == "0") |
                (arr[0] == "0" & arr[3] == "0" & arr[6] == "0") |
                (arr[1] == "0" & arr[4] == "0" & arr[7] == "0") |
                (arr[2] == "0" & arr[5] == "0" & arr[8] == "0"))
                return "Победа ноликов!";

            else if ((arr[0] != "") & (arr[1] != "") &
                (arr[2] != "") & (arr[3] != "") &
                (arr[4] != "") & (arr[6] != "") &
                (arr[7] != "") & (arr[8] != ""))
                return "Ничья!";
            return "Ошибка!";
        }
    }
}
