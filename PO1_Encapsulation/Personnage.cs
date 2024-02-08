using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage  //   internal class Personnage  **changer internal en public
    {
        //On crée les attributs de la classe Personnage
        private string nom;
        private int pointDeVie;
        private int pointsDePuissance;

        public string Nom { get => nom; set => nom = value; }
        public int PointDeVie
        // Mise en place de l'encapsulation sur l'attribut pointsDeVie
        // Si le pointsDeVie est supérieur à 0, on affecte la valeur 
        // Si le pointsDeVie est inférieur à 0, on affecte la valeur 0
        {
            get => pointDeVie;
            set
            {

                if (value > 0) //Si le pointsDeVie est supérieur à 0, on affecte la valeur
                {
                    pointDeVie = value;
                }
                else // Si le pointsDeVie est inférieur à 0, on affecte la valeur 0
                {
                    pointDeVie = 0;
                }
            }
        }   
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if (pointDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
