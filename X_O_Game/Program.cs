using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;

    static void Main()
    {
        int choice;
        bool isInputValid;

        do
        {
            Console.Clear(); 
            Console.WriteLine("Player {0}'s turn", (currentPlayer == 1) ? "X" : "O");
            DrawBoard();

            do
            {
                Console.Write("Enter a number (1-9) to place your mark: ");
                isInputValid = int.TryParse(Console.ReadLine(), out choice);

                if (!isInputValid || choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    isInputValid = false;
                }
            } while (!isInputValid);

            char mark = (currentPlayer == 1) ? 'X' : 'O';
            board[choice - 1] = mark;

            if (CheckForWinner())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("Player {0} wins!", (currentPlayer == 1) ? "X" : "O");
                break;
            }
            else if (IsBoardFull())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = (currentPlayer == 1) ? 2 : 1;

        } while (true);
    }

    static void DrawBoard()
    {
        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("-----------");
        Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
        Console.WriteLine("-----------");
        Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    }

    static bool CheckForWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                return true;

            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                return true;
        }
        if ((board[0] == board[4] && board[4] == board[8]) || (board[2] == board[4] && board[4] == board[6]))
            return true;

        return false;
    }

    static bool IsBoardFull()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }
}
