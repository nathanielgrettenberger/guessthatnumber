using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessthatnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            guessThatNumber();
        }
        
        static void guessThatNumber()
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101);
            int count = 0; 
            bool playing = true;
           
           
            
            while (true)
            {
                Console.WriteLine(" Pick a number!!");
            
                string input = Console.ReadLine();
                int input1 = Convert.ToInt32(input);
                if (input1 > randomNumber)
                {
                    Console.WriteLine(" your too low!");

                }
                if (input1 > randomNumber)
                {
                    Console.WriteLine(" your too high!");

                }
                if (input1 == randomNumber)
                {
                    Console.WriteLine(" you are right on and it too you" + count + "times!!");
                }
            }
	
		 
	
            
	         
	
	
           
                
            
            
	
		 
	
            
            
              
            
            }


            
        
        }
    }

