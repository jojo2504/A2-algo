using System;
using System.Text;

namespace ConsoleApplication1
{
    public class Personnage
    {
        private Labyrinthe labyrinthe;
        private Position currentPosition;
        
        public Personnage(Labyrinthe labyrinthe)
        {
            this.labyrinthe = labyrinthe;
            this.currentPosition = labyrinthe.Depart;
            StringBuilder sb = new StringBuilder(labyrinthe.Matrice[currentPosition.Ligne]);
            sb[currentPosition.Colonne] = 'o';
            labyrinthe.Matrice[currentPosition.Ligne] = sb.ToString();
        }

        public bool EstArrive()
        {
            return currentPosition == labyrinthe.Arrive;
        }

        public string AvailableDirectionLeft()
        {
            string directionLine = "";
            if (labyrinthe.Matrice[currentPosition.Ligne + 1][currentPosition.Colonne] == '-')
            {
                directionLine += "right ";
            }
            if (labyrinthe.Matrice[currentPosition.Ligne - 1][currentPosition.Colonne] == '-')
            {
                directionLine += "left ";
            }
            if (labyrinthe.Matrice[currentPosition.Ligne][currentPosition.Colonne + 1] == '-')
            {
                directionLine += "down ";
            }
            if (labyrinthe.Matrice[currentPosition.Ligne][currentPosition.Colonne - 1] == '-')
            {
                directionLine += "up ";
            }

            return string.IsNullOrEmpty(directionLine) ? directionLine : "";
        }
        

        public bool DeplacementSuivant(string direction)
        {
            Position nextPosition = new Position(currentPosition.Ligne, currentPosition.Colonne);
            switch (direction)
            {
                case "up":
                    nextPosition.Ligne--;
                    break;
                case "down":
                    nextPosition.Ligne++;
                    break;
                case "left":
                    nextPosition.Colonne--;
                    break;
                case "right":
                    nextPosition.Colonne++;
                    break;
                default:
                    Console.WriteLine("Le direction n'est pas une bonne valeur");
                    return false;
            }
            
            if (Math.Abs(nextPosition.Ligne - currentPosition.Ligne) >= 1 &&
                Math.Abs(nextPosition.Colonne - currentPosition.Colonne) >= 1)
            {
                Console.WriteLine("trop loin");
                return false;
            }

            if (!labyrinthe.MarquerPassage(nextPosition))
            {
                Console.WriteLine("on avance pas la");
                return false;
            }
            
            if (nextPosition.EstEgale(labyrinthe.Arrive))
            {
                Console.WriteLine("C'est bon !!");
                return true;
            }

            if (labyrinthe.Matrice[nextPosition.Ligne][nextPosition.Colonne] != '-')
            {
                Console.WriteLine("Nous sommes deja passe par la");
                return false;
            }
            
            // replace void position to occupied position
            StringBuilder sb2 = new StringBuilder(labyrinthe.Matrice[nextPosition.Ligne]);
            sb2[nextPosition.Colonne] = 'o';
            labyrinthe.Matrice[nextPosition.Ligne] = sb2.ToString();
            
            currentPosition = nextPosition;

            return false;
        }
    }
}