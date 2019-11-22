using System;

namespace TestSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9999, 876, 4567, 2987, 1 };

            Array.Sort(numbers);

            Console.WriteLine($"Maxiumum Number:{numbers[4]} Minimum Number:{numbers[0]}");

            int sum = numbers[4] + numbers[0];

            Console.WriteLine(sum);


            string phrase = "lnhnh";

            char[] phraseSplit = phrase.ToCharArray();

            if (phraseSplit[0] == phraseSplit[1]
                && phraseSplit[1] == phraseSplit[2] && phraseSplit[2] == phraseSplit[3]
                && phraseSplit[3] == phraseSplit[4])
            {
                Console.WriteLine(phraseSplit.Length);
                
            }

           else if(phraseSplit[0]==phraseSplit[1] && phraseSplit[1]== phraseSplit[2]&& phraseSplit[2] == phraseSplit[3])
            {
                Console.WriteLine(phraseSplit.Length - 1);
                
            }

            else if(phraseSplit[0]== phraseSplit[1] && phraseSplit[1] == phraseSplit[2] )
            {
                Console.WriteLine(phraseSplit.Length - 2);
            }

            else if(phraseSplit[0]== phraseSplit[1])
            {
                Console.WriteLine(phraseSplit.Length - 3);
            }

            else if(phraseSplit[0] + phraseSplit[1]== phraseSplit[2] + phraseSplit[3])
            {
                Console.WriteLine($"{phraseSplit[0]} {phraseSplit[1]} {phraseSplit[2]} {phraseSplit[3]}");
            }

            else if(phraseSplit[0]+ phraseSplit[1] == phraseSplit[3] + phraseSplit[4])
            {
                Console.WriteLine($"{phraseSplit[0]}{phraseSplit[1]} {phraseSplit[3]} {phraseSplit[4]}");
            }

            else if (phraseSplit[1]+phraseSplit[2] == phraseSplit[3] + phraseSplit[4])
            {
                Console.WriteLine($"{phraseSplit[1] }{phraseSplit[2] }{phraseSplit[3] }{phraseSplit[4]}");
            }
        else
            {

            Console.WriteLine("No repeating substring");
            }
           
        }
    }
}
