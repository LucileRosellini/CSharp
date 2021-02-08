using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Globalization;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private FakeArrets queryArrets;
        private FakeLignes queryLigne;
        private double x;
        private double y;
        private int dist;

        [TestMethod]
        public void TestGeneratedResultat()
        {
            queryArrets = new FakeArrets();
            queryLigne = new FakeLignes();
            x = 1.1234;
            y = 5.67898;
            dist = 500;

            LignesEtArrets lignesEtArrets = new LignesEtArrets(x, y, dist, queryArrets, queryLigne);

            string resultat = lignesEtArrets.Calcule;

            string resultat_attendu = "A l'arret Chateau il y a les lignes : \n\t - RouteDeBriqueJaunes\n\t - RouteDeBriqueEmeraude\nA l'arret Ferme il y a les lignes : \n\t - RouteDeBriqueJaunes\n\t - RouteDeBriqueEmeraude\n";

            Assert.AreEqual(resultat_attendu, resultat, "Erreur lors de la simulation de la generation de sortie suite à l'appel API");
        }
        [TestMethod]
        public void TestGeneratedArretURI()
        {
            queryArrets = new FakeArrets();
            queryLigne = new FakeLignes();
            x = 1.1234;
            y = 5.67898;
            dist = 500;

            LignesEtArrets lignesEtArrets = new LignesEtArrets(x, y, dist, queryArrets, queryLigne);

            string resultat = lignesEtArrets.Calcule;

            string resultat_attendu = String.Format(CultureInfo.InvariantCulture,"https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=false", x, y, dist);

            Assert.AreEqual(resultat_attendu, queryArrets.URI, "Erreur lors de la simulation de la generation de l'URL pour les Arrets");
        }
        [TestMethod]
        public void TestGeneratedLigneURI()
        {
            queryArrets = new FakeArrets();
            queryLigne = new FakeLignes();
            x = 1.1234;
            y = 5.67898;
            dist = 500;

            LignesEtArrets lignesEtArrets = new LignesEtArrets(x, y, dist, queryArrets, queryLigne);

            string resultat = lignesEtArrets.Calcule;

            string resultat_attendu = "https://data.mobilites-m.fr/api/routers/default/index/routes?codes=RouteDeBriqueEmeraude";

            Assert.AreEqual(resultat_attendu, queryLigne.URI, "Erreur lors de la simulation de la generation de l'URL pour les Lignes");

        }
    }
}

