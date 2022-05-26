namespace tracker{
    class ProgressTracker{ //Tracks the win/loss progress of the game


        //keeps track of how many wrong guesses have occured
        public int FailCount = 0;




        public ProgressTracker(){} //Constructor


        //Checks the current word char array for '_' to see if the word has been guessed
        public bool CheckIfWon(char[] current_word){

            for (int i = 0; i < current_word.Length; i++){

                if (current_word[i] == '_'){
                    return false;
                }
            }
            return true;
        }

        //references the failcounter to determine if player has lost
        public bool CheckIfLost(){
            if (FailCount >= 7){
                return true;
            }
            else{
                return false;
            }
                       
        }
    }
}