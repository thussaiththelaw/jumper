namespace tracker{
    class ProgressTracker{

        //attributes
        private bool won = false;
        private bool lost = false;
        public int FailCount = 0;




        public ProgressTracker(){} //Constructor



        public bool CheckIfWon(char[] word_array){
           for (int i = 0; i < lengthof(word_array); i++ ){
               if (word_array[i] == '_'){
                   return false;
               }
            return true;
           }}
           

        public bool CheckIfLost(){
            if (FailCount >= 7){
                return true;
            }
            else{
                return false;
            }}




        


    }
}