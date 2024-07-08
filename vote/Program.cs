using System.Text;
using vote;
Console.OutputEncoding = Encoding.UTF8;

Voting voting = new Voting();
Console.WriteLine("Изберете за кого да гласувате (с 1 за Кандидат 1 и с 2 за Кандидат 2; натиснете 0 за край).");
Console.WriteLine();
while (true)
{
    Console.Write("Вашият избор е: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 0)
    {
        break;
    }

    voting.Vote(choice);
}
Console.WriteLine();
voting.DisplayResults();