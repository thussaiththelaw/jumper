namespace tracker{
    class ProgressTracker{

        //attributes
        public int FailCount = 0;




        public ProgressTracker(){} //Constructor



        public bool CheckIfWon(char[] current_word){

            for (int i; i < lengthof(current_word); i++){

                if (current_word[i] == '_'){
                    return false;
                }
            }
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