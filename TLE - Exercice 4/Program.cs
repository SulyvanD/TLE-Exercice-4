using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE___Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>();
            shopping.Add("Carottes");
            shopping.Add("Oignons");
            shopping.Add("Pommes de terre");
            shopping.Add("Salade");
            shopping.Add("Tomate");

            foreach (string item in shopping)
            {
                Console.WriteLine(item);
            }
        }
    }
}
