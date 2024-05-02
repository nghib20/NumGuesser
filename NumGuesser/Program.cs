namespace MyNamespace
{
    class NumGuesser
    {
        public static void Main(string[] args)
        {
            NumGuesser numGuesser = new NumGuesser();
            numGuesser.GuessNumber();
        }

        public void GuessNumber()
        {
            Console.Write("Enter upper limit: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter lower limit: ");
            int minNumber = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                int guess = (maxNumber + minNumber) / 2;
                Console.WriteLine("Did you guess " + guess + "?");
                string input = Console.ReadLine();
                if (input.Equals("yes")) {
                    Console.WriteLine("Your guess was " + guess);
                    break;
                } else if (input.Equals(">"))
                {
                    minNumber = guess;
                } else if (input.Equals("<"))
                {
                    maxNumber = guess;
                } else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}