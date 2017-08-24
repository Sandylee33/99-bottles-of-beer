using System;

namespace _bottles_of_beer_CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 99;
            while (n > 1) {
                Console.WriteLine(n + " bottles of beer on the wall, " + n + " bottles of beer.");
		Console.WriteLine("Take one down and pass it around, " + (n - 1).ToString() + " bottles of beer on the wall.\n");
                n--;
            }
            if (n == 1){
                Console.WriteLine(n + " bottle of beer on the wall, " + n + " bottle of beer.");
		Console.WriteLine("Take one down and pass it around, " +  "no more bottles of beer on the wall.\n");
                n--;
            }
            if (n == 0){
                n = 99;
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                Console.WriteLine("Go to the store and buy some more, "+ n +" bottles of beer on the wall");
            }
        }
    }
}
