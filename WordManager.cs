namespace word
{
    class WordManager
    {
        // attributes
        private string word_to_guess = ""; // private string, the active word the game is to be played with.
        private string incorrect_guesses = "Wrong guesses: ";
        private string all_guesses = "";
        private string correct_array_string = "";
        private int active_word_length;
        char[] correct_array = new char[10]; // array starts at arbitrary length, will be resized to match active word
        char[] active_word_array = new char[10];
        private char guess;
        

        WordList active_word = new WordList(); // instantiates word list object
        //word_to_guess = active_word.getWord();
        //active_word_length = word_to_guess.Length();

        public WordManager(){
            word_to_guess = active_word.getWord();
            active_word_length = word_to_guess.Length;
        } // constructor
        public void Compare(char guess) // compares letter guesses to already guessed letters, and adds the correct letter to each spot that the letter exists,
        // or concantinates the letter to the incorrect guesses string
        {
            this.guess = guess;
            if((!all_guesses.Contains(this.guess)) ) //&& (!correct_array_string.Contains(this.guess))
            {
                
                for(int i = 0; i < active_word_length*2;i++)
                {
                    if(active_word_array[i] == this.guess)
                    {
                        correct_array[i] = this.guess;
                        correct_array_string+=this.guess;
                    } 
                }
                if(!word_to_guess.Contains(this.guess))
                {
                    incorrect_guesses += this.guess + " ";
                }          
            } 
            else if(all_guesses.Contains(this.guess))
            {
                Console.WriteLine("You already guessed that. Guess again.");
            }  
            
            all_guesses += this.guess;
        }

        public string print_wrong_guesses() // getter returns the list of incorrect guesses
        {
            return incorrect_guesses;
        }

        public void display_correct_guesses()
        {
            Console.WriteLine(correct_array);
        }

        public void init_active_word_array() // active word array holds the word that guesses will be compared to
        {
            Array.Resize(ref active_word_array, active_word_length*2);
            for(int i = 0; i < active_word_length*2;i+=2)
            {
                active_word_array[i] = word_to_guess[i/2];
            }
        }
        public void init_correct_array() // initializes the correct guess array to match the length of the active word
        {
            Array.Resize(ref correct_array, active_word_length*2);
            for(int i = 0; i < active_word_length*2; i+=2)
            {
                correct_array[i] = '_';
            }
            for(int i = 1; i < active_word_length*2; i+=2)
            {
                correct_array[i] = ' ';
            }
        }

    }
}