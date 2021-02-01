using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
           
        {

            DateTime currentTime = DateTime.Now;

            switch (GetPlageHoraire(currentTime))
            {
                case 0:
                    Console.WriteLine("Bon Week-end: {0}", Environment.UserName);
                    //Bon week-end <nom_de_l’utilisateur> » pour la tranche horaire vendredi 18h - lundi 9h
                    break;
                case 1:
                    Console.WriteLine("Bonjour: {0}", Environment.UserName);
                    //Bonjour <nom_de_l’utilisateur> » pour la tranche horaire 9h - 13h
                    break;
                case 2:
                    Console.WriteLine("Bon Aprés-midi: {0}", Environment.UserName);
                    //Bon après-midi <nom_de_l’utilisateur> » pour la tranche 13h - 18h 
                    break;
                case 3:
                    Console.WriteLine("Bonsoir: {0}", Environment.UserName);
                    //Bonsoir < nom_de_l’utilisateur > » pour la tranche horaire 18h - 9h
                    break;
                default:
                    Console.WriteLine("Pas pris en charge! : {0}", GetPlageHoraire(currentTime));
                    break;
            }
            Console.ReadLine();
        }

        static int GetPlageHoraire(DateTime valeur)
        {
            if ((valeur.DayOfWeek == DayOfWeek.Saturday) || (valeur.DayOfWeek == DayOfWeek.Sunday))
            {
                return (0);
            }
            else if ((valeur.Hour >= 9) && (valeur.Hour <= 13))
            {
                return (1);
            }
            else if ((valeur.Hour > 13) && (valeur.Hour <= 18))
            {
                return (2);
            }
            else if ((valeur.Hour > 18) || (valeur.Hour < 9))
            {
                return (3);
            }
            return (4);
        }
    }          
}

