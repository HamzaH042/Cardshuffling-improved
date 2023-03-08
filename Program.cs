using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of players:");
            int numPlayers = int.Parse(Console.ReadLine());

            Test test = new Test();
            test.Run(numPlayers);

            Console.ReadLine();
        }
    }
}

