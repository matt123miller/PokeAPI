using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestPokemon
{
    class RestSystem
    {
        private static RestSystem instance;
        public static RestSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RestSystem();
                }
                return instance;
            }
        }

        string baseUrl = "http://pokeapi.co/api/v2/";

        private RestSystem()
        {

        }

        public async Task<Pokemon> GetSpecificPokemon(int id)
        {
            string url = baseUrl + "pokemon/" + id;

            using (HttpClient client = new HttpClient())
            {
                Task<string> getPokemonTask = client.GetStringAsync(url);

                var urlContents = await getPokemonTask;
                // decode json into useful data.
                Console.WriteLine(urlContents);



                return new Pokemon();
            }

        }



    }
}
