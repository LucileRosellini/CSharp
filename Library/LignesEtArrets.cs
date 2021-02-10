using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Globalization;

namespace ConsoleApp1
{
    public class LignesEtArrets
    {
        public string Calcule { get => GetLignesEtArrets(); } // Accesseur façon Jerôme. Methode qui appelle une classe. / sorte d'accesseur automatique. Rend la methode utilisable comme une variable. 

        public double X { get; set; } //  Attribut interne à LigneEtarrets lui-même. 

        public double Y { get; set; } //  Attribut interne à LigneEtarrets lui-même. 

        public int DIST { get; set; } //  Attribut interne à LigneEtarrets lui-même. 

        public IRequest Query { get; set; }
        public IRequest Query_line { get; set; }


        public LignesEtArrets(double x, double y, int dist) // Constructeur
        {
            // On stock les arguments passés au createur dans les attribues de l'objet pour les utiliser plus tard
            X = x;
            Y = y;
            DIST = dist;
            Query = new Request();
            Query_line = new Request();
        }

        public LignesEtArrets(double x, double y, int dist, IRequest query, IRequest query_line)
        {
            X = x;
            Y = y;
            DIST = dist;
            Query = query;
            Query_line = query_line;
        }

        public string GetLignesEtArrets()
        {
            string resultat = String.Empty;

            //Query.SetURI(String.Format("https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=false", X.ToString().Replace(",", "."), Y.ToString().Replace(",", "."), DIST));

            Query.SetURI(String.Format(CultureInfo.InvariantCulture,"https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=false", X,Y, DIST));


            string myJsonResponse = Query.Query();

            List<Mapi> arrets = JsonSerializer.Deserialize<List<Mapi>>(myJsonResponse);

            foreach (Mapi arret in arrets)
            {
                resultat += "A l'arret " + arret.name + " il y a les lignes : \n";
                foreach (string ligne_id in arret.lines)
                {
                    Query_line.SetURI(String.Format("https://data.mobilites-m.fr/api/routers/default/index/routes?codes={0}", ligne_id));
                    string myJsonResponse_line = Query_line.Query();
                    List<Mapi_line> lignes = JsonSerializer.Deserialize<List<Mapi_line>>(myJsonResponse_line);
                    lignes.ForEach(delegate (Mapi_line currentLine)
                    {
                        resultat += "\t - " + currentLine.longName + "\n";
                    });

                }
            }
            return (resultat);
        }

    }
}
