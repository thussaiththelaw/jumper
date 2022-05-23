namespace tracker{
    class ProgressTracker{

        //attributes
        private bool won = false;
        private bool lost = false;
        public int FailCount = 0;




        public ProgressTracker(){} //Constructor

        public void RunChecks(){

            CheckIfWon();
            CheckIfLost();
        }

        private void CheckIfWon(){
            // char my_thing = word.WordManager.
            // if ('_' !in my_thing){
            //won == True;
            //UpdateDisplay(something about calling the image handling probably)

            // } 

        }

        private void CheckIfLost(){
            if (FailCount >= 7){
                lost = true;
                //UpdateDisplay(something about calling image handling probably)
            }
                       
        }

        private void UpdateDisplay(){
            //call terminal service to display win/loss/current guess
        }



        


    }
}