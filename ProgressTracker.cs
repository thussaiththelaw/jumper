namespace tracker{
    class ProgressTracker{

        //attributes
        private bool won = false;
        private bool lost = false;
        public int FailCount = 0;




        public ProgressTracker(){} //Constructor



        public bool CheckIfWon(){
            // char my_thing = word.WordManager.
            // if ('_' !in my_thing){
            //won == True;
            //UpdateDisplay(something about calling the image handling probably)

            // } 
            return true;
        }

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