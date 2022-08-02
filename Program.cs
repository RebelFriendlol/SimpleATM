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
            decimal amount = 213.95m;
            decimal deposit;
            decimal withdrwa;
            int wybor;
            int pin = 0;
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
                        withdrwa = Convert.ToDecimal(Console.ReadLine());
                        if (withdrwa > amount)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nPRZEPRASZAM! NIEWYSTARCZAJĄCE SALDO!\n");
                            Console.ResetColor();
                        }
                        else if(withdrwa <= 0.99m)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nMożna wypłacać dopiero od 1zł!\n");
                            Console.ResetColor();
                        }
                        else if (withdrwa <= 0.100m)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nMożna wypłacać dopiero od 1zł!\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("\nProsze zebrać pieniądze. \n");
                            amount = amount - withdrwa;
                            Console.WriteLine($"Aktualnie masz na koncie {amount} zł \n");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ile chcesz wpłacić?: ");
                        deposit = Convert.ToDecimal(Console.ReadLine());
                        if(deposit <= 0.99m)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nMożna wpłacać dopiero od 1zł!\n");
                            Console.ResetColor();
                        }
                        else if (deposit <= 0.100m)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nMożna wpłacać dopiero od 1zł!\n");
                            Console.ResetColor();
                        }
                        else
                        {
                           amount = decimal.Add(amount, deposit);
                           Console.ForegroundColor = ConsoleColor.Green;
                           Console.WriteLine("\nTWOJE PIĘNIĄDZE ZOSTAŁY WPŁACONE POMYŚLNIE!\n");
                           Console.ResetColor();
                           Console.WriteLine($"Aktualnie masz na koncie {amount} zł \n");
                        }                        
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
