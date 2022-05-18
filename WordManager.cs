namespace word
{
    class WordManager
    {
        // attributes
        private string active_word = ""; // private string, the active word the game is to be played with.
        private string incorrect_guesses = "";
        private int active_word_length;
        char[] correct_array = new char[1]; // array starts at arbitrary length, will be resized to match active word
        char[] active_word_array = new char[1];
        private char guess;
        public WordManager(){} // constructor

        WordList word = new WordList(); // instantiates word list object
        active_word = wordList.getWord();
        active_word_length = active_word.Length;

        public void Compare(char guess) // compares letter guesses to already guessed letters, and adds the correct letter to each spot that the letter exists,
        // or concantinates the letter to the incorrect guesses string
        {
            this.guess = guess;
            for(int i = 0; i < active_word_length;i++)
            {
                if(active_word_array[i] == this.guess)
                {
                    correct_array[i] = this.guess;
                } else if(active_word_array[i] != this.guess)
                {
                    incorrect_guesses += this.guess + ",";
                }
            }
        }

        public string print_wrong_guesses() // getter returns the list of incorrect guesses
        {
            return incorrect_guesses;
        }

        public string getWord() // retrieves word from wordList
        {
            return active_word;
        }
        public void init_active_word_array() // active word array holds the word that guesses will be compared to
        {
            Array.Resize(ref active_word_array, active_word_length);
            for(int i = 0; i < active_word_length;i++)
            {
                active_word_array[i] = active_word[i];
            }
        }
        public void init_correct_array() // initializes the correct guess array to match the length of the active word
        {
            Array.Resize(ref correct_array, active_word_length);
            for(int i = 0; i < active_word_length; i++)
            {
                correct_array[i] = '_';
            }
        }

    }
}