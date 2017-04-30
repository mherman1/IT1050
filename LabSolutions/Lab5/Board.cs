namespace Lab5
{
    class Board
    {
        private string[][] board;
        public Board()
        {
            board = new string[8][];
            for (int i = 0; i < 8; i++)
            {
                board[i] = new string[8];
                for (int j = 0; j < 8; j++)
                {
                    if (i < 2 || i > 5)
                    {
                        board[i][j] = "X";
                    }
                    else
                    {
                        board[i][j] = " ";
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
                    System.Console.Write(" " + board[i][j] + " |");
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
            board[dy][dx] = board[y][x];
            board[y][x] = " ";
        }
    }
}
