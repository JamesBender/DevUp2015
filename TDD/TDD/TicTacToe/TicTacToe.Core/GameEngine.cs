namespace TicTacToe.Core
{
    public class GameEngine
    {
        public string GetWinner(string[,] board)
        {
//            if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X")
//            {
//                return "X";
//            }
//            return " ";
            return board[0, 0];

        }
    }
}