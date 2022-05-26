namespace jumper{

    //Contains main game loop and 3 of the subclasses. 
    class Director{

        //Attributes
        private bool playing = true;
        public char guess;
        terminal.TerminalService terminal;
        word.WordManager WordManager;
        tracker.ProgressTracker ProgressTracker;
        bool won = false;
        bool lost = false;


        public Director(){} //Constructor

        //Contains main game loop - its what main calls
        public void StartGame(){

            Initial();

            while (playing){
                GetInputs();
                DoUpdates(this.guess);
                DoOutputs();                
            }
            terminal.print("Thanks for playing!");
        }

        //Constructs subclasses and gets the difficulty from the user through terminalservice
        private void Initial(){
            this.terminal = new terminal.TerminalService();
            int difficulty = terminal.difficulty();
            this.WordManager = new word.WordManager(difficulty);
            //WordManager.
            this.ProgressTracker = new tracker.ProgressTracker();
        }

        //takes input from the player
        private void GetInputs(){
        this.guess = terminal.guess();
        }

        //Compares the guess and updates the appropriate variables
        private void DoUpdates(char guess){
            WordManager.Compare(guess);
            bool right_or_wrong = WordManager.correct_wrong;
            if (!right_or_wrong){
                ProgressTracker.FailCount += 1;
            }
            if (ProgressTracker.CheckIfWon(WordManager.correct_array)){
                this.won = true;
            }
            if (ProgressTracker.CheckIfLost()){
                this.lost = true;
            }
            if (this.won || this.lost){
                this.playing = false;
            }
        }  

        //Prints current state of the game for the user
        private void DoOutputs(){
            terminal.display_correct_guesses(WordManager.correct_array);
            terminal.print_wrong_guesses(WordManager.incorrect_guesses);

            if (this.won){
                terminal.print_win();
            }
            else if (this.lost){
                terminal.print_lose();
            }
        }
    }
}