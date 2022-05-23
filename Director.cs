namespace program{

    class Director{

        private bool playing = true;


        public void GameLoop(){

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