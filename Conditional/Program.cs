using System; 
// Importing Other Libraries that we may want to be using
// Eg:- Console uses the System Library
// Could have been done like this "System.Console.WriteLine"

namespace HelloWorld
// To Group and Organize code if we have multiple classes
// To keep them together
{
    class Program
    {
        static void Main(string[] args) // 1st Method as the entry method to tell from here it starts
        {
            int a = 5;
            int b = 6;
            if(a+b > 10)
            Console.WriteLine("The answer is greater than the previous one");

            while(a < b){
                Console.WriteLine($"a is lesser than b by {b - a}");
                a++;
            }
            // Challenge Sum Problem divisible by 3
            int sum = 0;
            int start = 1;
            while(start <= 20 ){
                if(start % 3 == 0){
                    sum+=start;
                }
                start ++;
            }
            Console.WriteLine($"The sum of numbers is {sum}");
        }
    }
}