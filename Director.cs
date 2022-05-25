namespace jumper{

    class Director{

        private bool playing = true;
        public char guess;
        terminal.TerminalService terminal;
        word.WordManager WordManager;
        tracker.ProgressTracker ProgressTracker;
        bool won = false;
        bool lost = false;


        public Director(){}


        public void StartGame(){

            Initial();

            while (playing){
                GetInputs();
                DoUpdates(this.guess);
                DoOutputs();                
            }


        }

        private void Initial(){
            this.terminal = new terminal.TerminalService();
            int difficulty = terminal.difficulty();
            this.WordManager = new word.WordManager(difficulty);
            this.ProgressTracker = new tracker.ProgressTracker();
            

            //get difficulty
            //construct WM, PT, TS
                //give difficulty to WM when constructing

                //WM will construct Word list
                //TS will construct pics
            


        }
        private void GetInputs(){
        this.guess = terminal.guess();
        //guess - TS
        //

        }

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

            //compare (is good or not)- WM
            //right or wrong -> update fail counter - PT
            //correct array - WM > PT
            //check win/loss - PT
            //
        }  

        private void DoOutputs(){
            //correct array - WM -> TS
            //incorrect guesses - WM -> TS
            //win/loss - TS (if its happened)
            //wrong/right - TS
        }


    }
}