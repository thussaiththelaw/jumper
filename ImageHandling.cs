namespace terminal
{
        using System;
        using Newtonsoft.Json.Linq;//dotnet add package Newtonsoft.json is used to add newtonsoft to out program.

        class ASKEYImage
        {
            public int counter = 0;
                private string count = "image_1"; 
                    public void JsonASKEY()
                    {
                        
                            if (counter == 0)
                            {
                                count = "image_1";
                            }
                            else if (counter == 1)   
                            {
                                count = "image_2";
                            }
                            else if (counter == 2)
                            {count = "image_3";}
                            else if (counter == 3)
                            {count = "image_4";}
                            else if (counter == 4)
                            {count = "image_5";}
                            else if (counter == 5)
                            {count = "image_6";}
                            else if (counter == 6)
                            {count = "image_7";}
                            else if (counter == 7)
                            {count = "image_8";}
                            else if (counter == 8)
                            {count = "image_9";}
                        
                        using (StreamReader r = new StreamReader("jumper_images.json") ) //opens the file and set the file equal to r, for read.
                        {

                            string json = r.ReadToEnd(); //Read the WordList.json file and stoes it as the string json.

                            JObject doc = JObject.Parse(json); //parses through the json string to make the doc JObject. This allows us to go into the file and select what we need. 

                            int ListLength = doc[this.count].Count(); // takes the  ListLength of the list of the current difficulty.

                            JArray Image = doc.SelectToken(this.count).Value<JArray>();//Selecting the token of the json to be called then turns it into a JArray. We then use our random location to pull out a Image.
                            // the var prefix sets the input to what ever type we need.

                        for (int i = 0 ;i<Image.Count();i++)
                        {
                            Console.WriteLine(Image[i]);
                        }
                        }
                    }
        
    }
}