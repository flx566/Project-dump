using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;
    static bool gameOver = false;

    static void Main()
    {
        while (!gameOver)
        {
            DrawBoard();
            HandleTurn();
            CheckWin();
            CheckDraw();
            ChangePlayer();
        }
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("-----------");
        Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
        Console.WriteLine("-----------");
        Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    }

    static void HandleTurn()
    {
        bool validMove = false;
        while (!validMove)
        {
            Console.WriteLine("Игрок {0}, выберите клетку (1-9):", currentPlayer);
            string input = Console.ReadLine();
            int move;
            if (int.TryParse(input, out move) && move >= 1 && move <= 9)
            {
                if (board[move - 1] != 'X' && board[move - 1] != 'O')
                {
                    board[move - 1] = (currentPlayer == 1) ? 'X' : 'O';
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Эта клетка уже занята!");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите число от 1 до 9.");
            }
        }
    }

    static void CheckWin()
    {
        char symbol = (currentPlayer == 1) ? 'X' : 'O';
        
        if ((board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
            (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
            (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
            (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
            (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
            (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
            (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
            (board[2] == symbol && board[4] == symbol && board[6] == symbol))
        {
            DrawBoard();
            Console.WriteLine("Игрок {0} победил!", currentPlayer);
            gameOver = true;
        }
    }

    static void CheckDraw()
    {
        bool isFull = true;
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                isFull = false;
                break;
            }
        }

        if (isFull && !gameOver)
        {
            DrawBoard();
            Console.WriteLine("Ничья!");
            gameOver = true;
        }
    }

    static void ChangePlayer()
    {
        if (!gameOver)
        {
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }
    }
}