namespace terminal
{
    class TerminalService
    {
        public TerminalService(){}


        //get an input from the user to set the difficulty level for the game
        public int difficulty()
        {
            do{
                Console.WriteLine("Please select a difficulty level (type only the number): ");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hard");
                string input = Console.ReadLine();
                int difficulty = Convert.ToInt32(input);
                if (difficulty < 1 || difficulty > 3)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
                else
                {
                    return difficulty;
                }
            } while (true);
        }
        

        //gets the guess from the user and return it to the director class
        public char guess()
        {
            Console.WriteLine("Guess a letter: ");
            char guess = char.Parse(Console.ReadLine());
            guess = char.ToLower(guess);
            return guess;
        }

        //tells the user that their guess was incorrect
        public void print_wrong_guesses(string incorrect_guesses)
        {
            Console.WriteLine($"{incorrect_guesses}");
        }

        //tells the user that their guess was correct and prints the current state of the word
        public void display_correct_guesses(char[] correct_array_string)
        {
            Console.Write("Correct guess! so far you have:");
            Console.WriteLine(correct_array_string);
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

        public void print(string words)
        {
            Console.WriteLine(words);
        }
    }   
}
