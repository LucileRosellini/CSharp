using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

 
    public class Message
    {
        private Name name;
        private Date date;
    
      //injection de dependance depuis l'exterieur. 

        public Message()
        {
            // Creer un message en utilisation "normale".

            this.name = new Name();
            this.date = new Date();
        }

        public Message(Name name , Date date) {

            //creer un message customisé - 
            //Pour les test. Construction d'injection de dependance création de l'objet name à l'interieur de la classe. 

            this.name = name;
            this.date = date;
        }




      public string GetMessageByTime () {

            switch (GetPlageHoraire())
            {
                case 0:
                    return "Bon Week-end " + name.GetName();
                    //Bon week-end <nom_de_l’utilisateur> » pour la tranche horaire vendredi 18h - lundi 9h
                    break;
                case 1:
                    return "Bonjour " + name.GetName();
                    //Bonjour <nom_de_l’utilisateur> » pour la tranche horaire 9h - 13h
                    break;
                case 2:
                    return "Bon Aprés-midi " + name.GetName();
                    //Bon après-midi <nom_de_l’utilisateur> » pour la tranche 13h - 18h 
                    break;
                case 3:
                    return "Bonsoir " + name.GetName();
                    //Bonsoir < nom_de_l’utilisateur > » pour la tranche horaire 18h - 9h
                    break;
                default:
                    return "Pas pris en charge! ";
                    break;
            }      

         int GetPlageHoraire()
        {
                DateTime valeur = date.GetTime();
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
}