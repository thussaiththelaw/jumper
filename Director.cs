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
            word.WordManager WordManager = new word.WordManager();
            terminal.ProgressTracker PrograssTracker = new terminal.ProgressTracker();
            

            int difficulty = terminal.difficulty();



        }
        private void GetInputs(){


        }

        private void DoUpdates(){

        }

        private void DoOutputs(){

        }


    }
}