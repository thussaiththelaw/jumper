using System;
using Newtonsoft.Json.Linq;//dotnet add package Newtonsoft.json is used to add newtonsoft to out program.

namespace word
{
    class WordList
    {
        /*notes 
        This Class is used to get a random word out of the WordList.json file. To do this we have a UpdateDifficulty function the will
        take in a user input to set the difficulty. This input will need to be an int value. To prevent errors before this function is called
        The Terminal Service function should take a user input string and convert it to an int, if no int is found runing the function 
        will cause the difficulty to be set to level 1. 
        Once we have the difficulty we can then use it as a token call for the Json doc JObject. This string needs to be  correlated to 
        the tokens in the Json file WordList.json or else it will not work. Once we have our list of values that we want we get
        a random location in the JsonArray. This will pull a random word from the file. Lastly we convert this into a string to return it 
        to the WordManager Class to be converted into a list.

        let me know if this is helpful.
        */

       //public WordList(){} // I am not sure what this does. I did not add this - Tyler

       private string difficulty="DifficultyOne";// the base difficulty is one. This will only change if UpdateDiff==1||UpdateDiff==2 in the UpdateDifficulty Function

        public string getWord(int UpdateDiff=0)
        {

            if (UpdateDiff==2)// UpdateDiff = 1 is difficulty level 2
            {
                this.difficulty = "DifficultyTwo";//These are the names of the tokens in the WordList.Json file
            }
            else if (UpdateDiff==3)//updateDiff = 2 is difficulty level 3
            {
                this.difficulty = "DifficultyThree";
            }
            
            using (StreamReader r = new StreamReader("WordList.json") ) //opens the file and set the file equal to r, for read.
            {
                
                string json = r.ReadToEnd(); //Read the WordList.json file and stoes it as the string json.

                JObject doc = JObject.Parse(json); //parses through the json string to make the doc JObject. This allows us to go into the file and select what we need. 
    
                int ListLength = doc[this.difficulty].Count(); // takes the  ListLength of the list of the current difficulty.
                
                Random random = new Random(); // initializes the random condition
                int RandomLocation = random.Next(ListLength);//takes ListLength of the difficulty string in the json and askes for a random int number in the list index. 
                
                var word = doc.SelectToken(this.difficulty).Value<JArray>()[RandomLocation];//Selecting the token of the json to be called then turns it into a JArray. We then use our random location to pull out a word.
                // the var prefix sets the input to what ever type we need.
                

                return word.ToString().ToLower();// converts the var word into a string and then returns it.  
            }
        }
    }
}