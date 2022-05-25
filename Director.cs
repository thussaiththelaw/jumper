namespace jumper{

    class Director{

        private bool playing = true;



        public Director(){}

        public void StartGame(){



            while (playing){
                GetInputs();
                DoUpdates();
                DoOutputs();                
            }


        }

        private void Initial(){
            terminal.TerminalService terminal = new terminal.TerminalService();
            int difficulty = terminal.difficulty()
            word.WordManager WordManager = new word.WordManager(difficulty);
            tracker.ProgressTracker PrograssTracker = new tracker.ProgressTracker();
            

            //get difficulty
            //construct WM, PT, TS
                //give difficulty to WM when constructing

                //WM will construct Word list
                //TS will construct pics
            


        }
        private void GetInputs(){
        //guess - TS
        //

        }

        private void DoUpdates(){
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