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
                Vacanza Caraibi = new Vacanza("A123", 198, "Caraibi", 5, true, 120);
                Caraibi.Purchase(2);
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}
