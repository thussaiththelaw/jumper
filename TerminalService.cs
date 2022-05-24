namespace terminal
{
    class TerminalService
    {
        public TerminalService(){}


        //get an input from the user to set the difficulty level for the game
        public int difficulty()
        {
            Console.WriteLine("What difficulty would you like to play? (1,2,3): ");
            int difficulty = int.Parse(Console.ReadLine());
            return difficulty;
        }

        //gets the guess from the user and return it to the director class
        public char guess()
        {
            Console.WriteLine("Guess a letter: ");
            char guess = char.Parse(Console.ReadLine());
            return guess;
        }

        //tells the user that their guess was incorrect
        public void print_wrong_guesses(string incorrect_guesses)
        {
            Console.WriteLine($"{incorrect_guesses} is not in the word.");
        }

        //tells the user that their guess was correct and prints the current state of the word
        public void display_correct_guesses(string correct_array_string)
        {
            Console.WriteLine($"Correct guess! so far you have: {correct_array_string}");
        }

        //tells the user that they have won the game
        public void print_win()
        {
            Console.WriteLine("You win!");
        }

        //tells the user that they have lost the game
        public void print_lose()
        {
            Console.WriteLine("You lose! Don't do a big dumb next time");
        }

    }
}
