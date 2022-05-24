// namespace word
// {
//     class DougTest
//     {
//         static void Main(string[] args)
//         {
//             WordManager wordIO = new WordManager();
//             wordIO.init_active_word_array();
//             wordIO.init_correct_array();
            
//             for(int i = 0; i < 40; i++)
//             {
//                 Console.WriteLine("Guess a letter:");
//                 char guess = Console.ReadLine()[0];
//                 wordIO.Compare(guess);
//                 wordIO.display_correct_guesses();
//                 Console.WriteLine(wordIO.print_wrong_guesses());
//             }
            
//         }
//     }
// }