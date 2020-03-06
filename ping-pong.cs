using System;

namespace PingPong
{
    class PingPong
    {
      // public int input;
        static void Main()
        {
            Console.WriteLine("Please input a number");
            int input = int.Parse(Console.ReadLine());
            int currentNumber = 0;

            while(currentNumber <= input){
              if(currentNumber % 3 == 0 && currentNumber % 5 == 0){
                Console.WriteLine("ping-pong");
              }
              else if (currentNumber % 5 == 0 ){
                Console.WriteLine("pong");
              }
              else if (currentNumber % 3 == 0 ){
                Console.WriteLine("ping");
              }
              else{
                Console.WriteLine(currentNumber);
              }

              currentNumber++;

            }
        }
    }
}
