using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote
{
    internal class Voting
    {
        private int choice;
        private int candidate1;
        private int candidate2;
        private int totalVotes;

       
        public Voting()
        {
            candidate1 = 0;
            candidate2 = 0;
            totalVotes = 0;
        }

        public void Vote(int choice)
        {
            if (choice == 1)
            {
                candidate1++;
            }
            else if (choice == 2) 
            {
                candidate2++;
            }
            else
            {
                Console.WriteLine("Невалиден избор.");
                return;
            }

            totalVotes++;
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Гласували общо: {totalVotes}");
            Console.WriteLine($"Кандидат 1: {candidate1}");
            Console.WriteLine($"Кандидат 2: {candidate2}");
            if (candidate1 > candidate2)
            {
                Console.WriteLine("Кандидат 1 печели изборите!");
            }
            else if (candidate1 < candidate2)
            {
                Console.WriteLine("Кандидат 2 печели изборите!");
            }
            else
            {
                Console.WriteLine("Ще има балотаж!");
            }
        }
    }

    
}
