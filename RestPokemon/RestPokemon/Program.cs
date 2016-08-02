using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RestPokemon
{
    class Program
    {
        

        static void Main(string[] args)
        {
            RestSystem rest = RestSystem.Instance;


            Pokemon pokemon = rest.GetSpecificPokemon(1);

            Console.WriteLine();
            Console.ReadLine();
        }

       
    }
}
