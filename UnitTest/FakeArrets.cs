using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UnitTest
{
    class FakeArrets : IRequest
    {
        public string URI { get; set; }

        public void SetURI(string uri)
        {
            URI = uri;
        }

        public string Query()
        {
            Mapi arret1 = new Mapi
            {
                id = "FAKE:1234",
                lat = 1.2345,
                lon = 5.4321,
                name = "Chateau",
                zone = "Oz",
                lines = new List<string> { "RouteDeBriqueJaunes" }
            };

            Mapi arret2 = new Mapi
            {
                id = "FAKE:4321",
                lat = 2.2345,
                lon = 6.4321,
                name = "Ferme",
                zone = "Oz",
                lines = new List<string> { "RouteDeBriqueEmeraude" }
            };

            List<Mapi> arrets = new List<Mapi> { arret1, arret2 };

            return JsonSerializer.Serialize<List<Mapi>>(arrets);
        }
    }
}
