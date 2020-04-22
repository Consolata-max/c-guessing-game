using System;

namespace Numbergame
{
    class Program
    {
        static void Main(string[] args)
        {
             {
             
              Random rand = new Random();
                Console.WriteLine(" welcome to the game! There are 3 levels, easy(E), medium(M) and hard(H),");
                var input = Console.ReadLine().ToUpper();

                char input2;
              if (char.TryParse(input, out input2))
              {              
               
                        
                       // easy level
            if (input2 == 'E')            
                  {     
                   var random = new Random();
                   var numrange = random.Next(1, 10);
                   var numOfGuessesLeft = 6;
                   var guess = 0;
                   Console.WriteLine("Guess a number between 1 and 10");
                       while (guess != numrange)
                        {
                            numOfGuessesLeft--;
                             var input3  = Console.ReadLine();
                             guess = int.Parse(input3);
                               if (guess != numrange)
                                 {
                                     Console.WriteLine("That was wrong");
                                     Console.WriteLine($"You have {numOfGuessesLeft} guess left");
                                 }

                                if (numOfGuessesLeft == 0)
                                  {
                                    Console.WriteLine("Game over");
                                       break;
                                  }
                             }

                                    if (guess == numrange)
                                  {
                                    Console.WriteLine("You got it right");
                                  } 
                              
                  }

             }
                  

             //medium level
                 else if (input2 == 'M')
                 {
                   var random = new Random();
                   var numrange = random.Next(1, 20);
                   var numOfGuessesLeft = 4;
                   var guess = 0;
                   Console.WriteLine("Guess a number between 1 and 20");
                       while (guess != numrange)
                        {
                            numOfGuessesLeft--;
                             var input3  = Console.ReadLine();
                             guess = int.Parse(input3);
                               if (guess != numrange)
                                 {
                                     Console.WriteLine("That was wrong");
                                     Console.WriteLine($"You have {numOfGuessesLeft} guess left");
                                 }

                                if (numOfGuessesLeft == 0)
                                  {
                                    Console.WriteLine("Game over");
                                       break;
                                  }
                             }

                                    if (guess == numrange)
                                  {
                                    Console.WriteLine("You got it right");
                                  }  
                        }  
               
             // hard level
              else if (input2 == 'H')
                 {
                  var random = new Random();
                   var numrange = random.Next(1, 50);
                   var numOfGuessesLeft = 3;
                   var guess = 0;
                   Console.WriteLine("Guess a number between 1 and 50");
                       while (guess != numrange)
                        {
                            numOfGuessesLeft--;
                             var input3  = Console.ReadLine();
                             guess = int.Parse(input3);
                               if (guess != numrange)
                                 {
                                     Console.WriteLine("That was wrong");
                                     Console.WriteLine($"You have {numOfGuessesLeft} guess left");
                                 }


                                if (numOfGuessesLeft == 0)
                                  {
                                    Console.WriteLine("Game over");
                                       break;
                                  }
                             }

                                    if (guess == numrange)
                                  {
                                    Console.WriteLine("You got it right");
                                  }     
                }
             }

             
        }

    }

    
    }



