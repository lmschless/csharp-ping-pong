using System;

namespace PingPong
{
    class PingPong
    {
      private static int input; // use STATIC for local/global variables that can be passed between variables.

        private static void Main()
        {
            GetNumber();
            Run();
        }

         private static void GetNumber(){
          Console.WriteLine("Please input a number");

          // doesn't need int input = here because it's declared above.
          input = int.Parse(Console.ReadLine());
        }
       private static void Run() {
         int currentNumber = 1;
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
