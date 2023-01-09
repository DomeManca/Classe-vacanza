using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_vacanza
{
    internal class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Vacanza Manca = new Vacanza("A001", 200, "Caraibi", 5, true, 120);
                Manca.Purchase(2);
                Manca.ApplyDiscount(20);
                Manca.ChooseFlight(true, 100);
                Manca.ChooseNumberOfDays(4);
                Vacanza Messi = new Vacanza("A002", 250, "Caraibi", 5, true, 90);
                Messi.Purchase(3);
                Console.WriteLine(Messi.ComparePackages(Manca));
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}
