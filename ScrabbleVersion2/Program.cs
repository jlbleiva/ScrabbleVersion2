using System;

namespace ScrabbleVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrabbleScore scrabble = new ScrabbleScore();
            int valor = scrabble.Score("cabbage");

            Console.WriteLine(valor);
            Console.ReadLine();
        }
    }
}
