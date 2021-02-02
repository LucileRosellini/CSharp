using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

 
    public class Message
    {
      private DateTime property
        {
            get;
            set;
        }


      public string GetMessageByTime () {

            property = DateTime.Now;

            switch (GetPlageHoraire(property))
            {
                case 0:
                    return "Bon Week-end " + Environment.UserName;
                    //Bon week-end <nom_de_l’utilisateur> » pour la tranche horaire vendredi 18h - lundi 9h
                    break;
                case 1:
                    return "Bonjour " + Environment.UserName;
                    //Bonjour <nom_de_l’utilisateur> » pour la tranche horaire 9h - 13h
                    break;
                case 2:
                    return "Bon Aprés-midi " + Environment.UserName;
                    //Bon après-midi <nom_de_l’utilisateur> » pour la tranche 13h - 18h 
                    break;
                case 3:
                    return "Bonsoir " + Environment.UserName;
                    //Bonsoir < nom_de_l’utilisateur > » pour la tranche horaire 18h - 9h
                    break;
                default:
                    return "Pas pris en charge! ";
                    break;
            }

       int GetPlageHoraire(DateTime valeur)
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
            else if ((valeur.Hour > 18) & (valeur.Hour < 9))
            {
                return (3);
            }
            return (4);
        }
}
}
}