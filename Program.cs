using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 2137;
            decimal deposit;
            decimal withdrwa;
            int wybor;
            int pin = 0;
            int x = 0;
            bool d = true;
            Console.Write("Prosze wpisac 4 cyfrowy pin: ");
            pin = int.Parse(Console.ReadLine());
            Console.Clear();
            while (d)
            {
                Console.WriteLine("WITAMY W BANKOMACIE PKO\n");
                Console.WriteLine("1. Aktualne środki \n");
                Console.WriteLine("2. Wypłać pieniądze \n");
                Console.WriteLine("3. Wpłać pieniędze \n");
                Console.WriteLine("4. Wyjdz \n");
                Console.WriteLine("***************\n");
                Console.Write("WPISZ SWÓJ WYBOR: ");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Aktualnie masz na koncie {amount} zł \n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Ile chcesz wypłacić?: ");
                        withdrwa = int.Parse(Console.ReadLine());
                        if (withdrwa > amount)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("PRZEPRASZAM! NIEWYSTARCZAJĄCE SALDO! \n");
                            Console.ResetColor();
                        }
                        else 
                        {
                            Console.WriteLine("Prosze zebrać pieniądze. \n");
                            amount = amount - withdrwa;
                            Console.WriteLine($"Aktualnie masz na koncie {amount} zł \n");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ile chcesz wpłacić?: ");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("TWOJE PIĘNIĄDZE ZOSTAŁY WPŁACONE POMYŚLNIE!\n");
                        Console.ResetColor();
                        Console.WriteLine($"Aktualnie masz na koncie {amount} zł \n");
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU…");
                        d = false;
                        break;
                }
            }
        }         
    }
}
