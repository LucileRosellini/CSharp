using System;

public interface IDate
{
	public IDate()
	{
        
    }
}



/*Une interface est un modèle de classe. 
Elle contient des méthodes et des propriétés, avec la particularité qu'elle ne fournit pas l'implémentation des méthodes. 
Cela veut dire qu'on décrit juste les méthodes sans décrire ce qu'elles font.
Une interface ne sert à rien toute seule : chaque interface est vouée à être implémentée par une classe (ou une structure) qui devra implémenter ses méthodes et posséder ses propriétés. 
Le but d'une interface est de définir les méthodes et propriétés proposées par toute classe (ou structure) qui l'implémente, sans que le développeur ait besoin de savoir comment celles-ci sont codées. Pour faire simple, une interface est comme un contrat : 
elle définit des attentes sans prévoir les solutions techniques qui seront utilisées.*/
