using System;

namespace Is_it_true
{

    class Program
    {
        static string word;
        static void Main(string[] args)
        {
            Console.WriteLine("Say sth");
            word = Console.ReadLine();
            char bir = word[0];

            for (int i = 0; i < word[i]; i++)
            {
                if (word[i] == 0||word[i]==1 || word[i] == 2 || word[i] == 3 || word[i] == 4 || word[i] == 5 || word[i] == 6 || word[i] == 7 || word[i] == 8 || word[i] == 9)
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
                //if (word.Contains('1') || word.Contains('2') || word.Contains('3') || word.Contains('4') || word.Contains('5') || word.Contains('6') || word.Contains('7') || word.Contains('8') || word.Contains('9') || word.Contains('0'))
                //{
                //    Console.WriteLine("True");
                //}
                //else
                //    Console.WriteLine("False");
            }
            
            

            Main(null);
        }
        
    }
}
