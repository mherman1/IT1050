namespace Lab2
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(35) + ":");
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt.PadRight(35)));
        }
    }
}
