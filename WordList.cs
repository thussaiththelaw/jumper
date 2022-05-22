namespace word
{
    class WordList
    {
        /*notes 
        I am working to figure out how to use a json file in c# I currently have a file with over 300 words with room to grow.
        If we don't want to usse a setter/getter for this we can just add difficulty to be in the getWord() function.
        */

        public WordList(){} // I am not sure what this does.

        private int difficulty = 1;


        public void JsonReader() //may need this class to be able to read a json file. If not it will be a .txt reader
        {

        }



        public void SetDifficulty(int diff) //setter that gets a difficulty and stores it so that the game can pick a word of an appropriate length.
        {
            difficulty = diff;
        }



        public string getWord()//This can be changed to take in an int value for difficulty.
        {
            var random = new Random();
            var list = new List<string>{ "red","blue","green","yellow"}; // selects random test word.
            
            if (difficulty == 2) // if the user selects a different difficulty then these will be the lists it will draw from.
            {
                list = new List<string>{"one","two"}; 
            }
            else if (difficulty == 3)
            {
                list = new List<string>{"bird","eagle"};
            }

            int index = random.Next(list.Count); // takes the length of the list and then reutrns an int 

            string ReturnWord = list[index];// takes in that int to get an index in the list.

            return ReturnWord; // returns the word to be used in the "jumper" game.
        }
    }
}