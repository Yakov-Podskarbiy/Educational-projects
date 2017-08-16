using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankomat b1 = new Bankomat();

            b1.Input();

            Console.WriteLine("Введите сумму:");

            b1.read_sum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Выдать с разменом?  1 - Да;   2 - Нет");

            string quest = Console.ReadLine();

            b1.Check(quest);

            if (Int32.Parse(quest) == 1)
            {
                b1.Output_1();
            }



                       
            
            
        }
    }
}
