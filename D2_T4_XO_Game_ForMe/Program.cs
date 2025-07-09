using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D2_T4_XO_Game_ForMe
{
    internal class Program
    {
        public static void PrintBoard(char[] board)
        {
            
            Console.WriteLine("Current Board:");
            Console.WriteLine(@"""
                 |     |   
              {0}  |  {1}  |  {2}
                 |     |
            ==================
                 |     |   
              {3}  |  {4}  |  {5}
                 |     |
            ==================
                 |     |   
              {6}  |  {7}  |  {8}
                 |     |

                                """,
             board[0], board[1], board[2],
             board[3], board[4], board[5],
             board[6], board[7], board[8]);
        
        }
        
        public static bool IsBoardFull(char[] board)
        {

            foreach (char cell in board)
            {
                if (cell != 'X' && cell != 'O')
                {
                    return false;
                }
            }
            return true; 
        }
        public static bool IsWinner(char[] board, char symbol)
        {
            bool isWinner = false;
            // 0 1 2
            // 3 4 5
            // 6 7 8

            #region Rows == Horizontal 
            if (board[0] == symbol && board[1] == symbol && board[2] == symbol) 
            {
                isWinner = true;
                return isWinner;
            }
            else if (board[3] == symbol && board[4] == symbol && board[5] == symbol)
            {
                isWinner = true;
                return isWinner;

            }
            else if (board[6] == symbol && board[7] == symbol && board[8] == symbol)
            {
                isWinner = true;
                return isWinner;
            }
            #endregion
            #region Columns == Vertical 
            else if (board[0] == symbol && board[3] == symbol && board[6] == symbol)
            {
                isWinner = true;
                return isWinner;
            }
            else if (board[1] == symbol && board[4] == symbol && board[7] == symbol)
            {
                isWinner = true;
                return isWinner;

            }
            else if (board[2] == symbol && board[5] == symbol && board[8] == symbol)
            {
                isWinner = true;
                return isWinner;
            }
            #endregion
            #region Cross == Diagonal 
            else if (board[0] == symbol && board[4] == symbol && board[8] == symbol)
            {
                isWinner = true;
                return isWinner;
            }
            else if (board[2] == symbol && board[4] == symbol && board[6] == symbol)
            {
                isWinner = true;
                return isWinner;

            }
            #endregion


            return isWinner;

        }
        static void Main(string[] args)
        {
            char[] board = new char[9];

            // Initialize the board with 1-9 
            for (int i = 0; i < board.Length; i++)
            {
                //(char)('0' + number); 8==> '8'
                board[i] = (char)('0' + (i + 1));
            }

            int move;

            while (true)
            {
                PrintBoard(board);
                Console.Write("(1st PlayerX) Please Enter Your Move (1-9): ");
                move = int.Parse(Console.ReadLine());
                // Validate the input
                while (move < 1 || move > 9 || board[move - 1] == 'X' || board[move - 1] == 'O')
                {
                    Console.WriteLine("Invalid Move, Please Try Again.");
                    Console.Write("(1st PlayerX) Please Enter Your Move (1-9): ");
                    move = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                board[move - 1] = 'X';
                if (IsWinner(board, 'X'))
                {
                    PrintBoard(board);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1st PlayerX Win!");
                    Console.ResetColor();
                    break;
                }
                PrintBoard(board);
                ///////////////////////////////////////////////////
                Console.Write("(2nd PlayerO) Please Enter Your Move (1-9): ");
                move = int.Parse(Console.ReadLine());
                // Validate the input
                while (move < 1 || move > 9 || board[move - 1] == 'X' || board[move - 1] == 'O')
                {
                    Console.WriteLine("Invalid Move, Please Try Again.");
                    Console.Write("(2nd PlayerO) Please Enter Your Move (1-9): ");
                    move = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                board[move - 1] = 'O';
                if (IsWinner(board, 'O'))
                {
                    PrintBoard(board);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2nd PlayerO Win!");
                    Console.ResetColor();
                    break;
                }
                ////////////////////////
                // Check if the board is full
                if (IsBoardFull(board))
                {
                    PrintBoard(board);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a Draw!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
