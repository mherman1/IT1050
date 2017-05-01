namespace Lab5
{
    class Board
    {
        private string[,] board;
        public Board()
        {
            board = new string[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i < 2 || i > 5)
                    {
                        board[i, j] = "X";
                    }
                    else
                    {
                        board[i, j] = " ";
                    }
                }
            }
        }

        public void Draw()
        {
            System.Console.Write(" ".PadRight(5));
            for (int i = 0; i < 8; i++)
            {
                System.Console.Write(i + " ".PadLeft(3));
            }
            System.Console.Write("\n".PadRight(4) + "+---+---+---+---+---+---+---+---+");
            for (int i = 0; i < 8; i++)
            {
                System.Console.WriteLine();
                System.Console.Write(i + "  |");
                for (int j = 0; j < 8; j++)
                {
                    System.Console.Write(" " + board[i, j] + " |");
                }
                System.Console.Write("\n".PadRight(4) + "+---+---+---+---+---+---+---+---+");
            }
            System.Console.WriteLine();
        }

        public void Move()
        {
            System.Console.Write("\nEnter Target X coordinate between 0 and 7: ");
            int x = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter Target Y coordinate between 0 and 7: ");
            int y = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter Destination X coordinate between 0 and 7: ");
            int dx = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter Destination Y coordinate between 0 and 7: ");
            int dy = int.Parse(System.Console.ReadLine());
            if ((x >= 0 && y >= 0) && (dx >= 0 && dy >= 0))
            {
                if ((x <= 7 && y <= 7) && (dx <= 7 && dy <= 7))
                {
                    board[dy, dx] = board[y, x];
                    board[y, x] = " ";
                }
                else
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Coodinates out of range! Game Over!");
                    System.Console.WriteLine("Press any key to close console...");
                    System.Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else
            {
                System.Console.Clear();
                System.Console.WriteLine("Coodinates out of range! Game Over!");
                System.Console.WriteLine("Press any key to close console...");
                System.Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}
