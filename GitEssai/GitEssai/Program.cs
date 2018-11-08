using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Light;
namespace GitEssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne t = new Personne();
            Personne t1 = new Personne("josephine");
            Console.WriteLine(t+"    nnn" +t1);


            Console.ReadKey();

        }
    }
}
