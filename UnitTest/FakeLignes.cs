using System.Collections.Generic;
using System.Text.Json;
using ConsoleApp1;

namespace UnitTest
{
    class FakeLignes : IRequest
    {
        public string URI { get; set; }

        public void SetURI(string uri)
        {
            URI = uri;
        }
        public string Query()
        {
            Mapi_line ligne1 = new Mapi_line
            {
                id = "FAKE:1234",
                color = "bleu",
                gtfsId = "FAKE_1234",
                longName = "RouteDeBriqueJaunes",
                mode = "BUS",
                type = "SNC",
                shortName = "RDBJ",
                textColor = "jaune"
            };

            Mapi_line ligne2 = new Mapi_line
            {
                id = "FAKE:4321",
                color = "vert",
                gtfsId = "FAKE_4321",
                longName = "RouteDeBriqueEmeraude",
                mode = "BUS",
                type = "SNC",
                shortName = "RDBJ",
                textColor = "violet"
            };

            List<Mapi_line> lignes = new List<Mapi_line> { ligne1, ligne2 };

            return JsonSerializer.Serialize<List<Mapi_line>>(lignes);
        }
    }
}
