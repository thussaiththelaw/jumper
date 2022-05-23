namespace terminal
{
    class TerminalService
    {

        public int difficulty()
        {
            Console.WriteLine("What difficulty would you like to play? (1,2,3): ");
            int difficulty = int.Parse(Console.ReadLine());
            return difficulty;
        }

        public char guess()
        {
            Console.WriteLine("Guess a letter: ");
            char guess = char.Parse(Console.ReadLine());
            return guess;
        }

        public void print_wrong_guesses(string incorrect_guesses)
        {
            Console.WriteLine(incorrect_guesses);
        }

        public void display_correct_guesses(string correct_array_string)
        {
            Console.WriteLine(correct_array_string);
        }

        
    }
}