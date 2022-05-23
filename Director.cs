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

        private void GetInputs(){


        }

        private void DoUpdates(){

        }

        private void DoOutputs(){

        }


    }
}