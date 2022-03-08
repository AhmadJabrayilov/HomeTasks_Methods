using System;

namespace HA
{
    internal class Program
    {
        static  int Repeat(string word, int count)
        {               
                        
            
            for (int i = 0; i<count; i++)
            {
                Console.Write(word);
            }
            Repeat(word, count);
           
        }
        static void Main(string[] args)
        {
            
            Console.Write("Enter the word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());
            Console.Write(Repeat(word,count));
            // Salam. string ve int type-ni eyni metod icinde yazmaq olmur deyesen, alindira bilmedim nese :(
            
        }
    }
}
