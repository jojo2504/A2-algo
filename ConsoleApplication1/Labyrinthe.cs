using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Labyrinthe
    {
        private Position depart;
        private Position arrive;
        private int nbColonne;
        private int nbLigne;
        private string[] matrice;
        private Dictionary<char,int> BlockState = new Dictionary<char,int>
        {
            {'-', 0},
            {'*', 1},
            {'d', 2},
            {'a', 3},
            {'o', 4}
        };

        public Labyrinthe(string[] matrice, int nbLigne, int nbColonne)
        {
            this.nbColonne = nbColonne;
            this.nbLigne = nbLigne;

            for (int i = 0; i < matrice.Length; i++)
            {
                for (int j = 0; j < matrice[0].Length; j++)
                {
                    if (matrice[i][j] == 'd')
                    {
                        this.depart = new Position(i, j);
                    }

                    if (matrice[i][j] == 'a')
                    {
                        this.arrive = new Position(i, j);
                    }
                }
            }
            this.matrice = matrice;
        }

        public bool EstUnMur(Position pos)
        {
            return BlockState[matrice[pos.Ligne][pos.Colonne]] == 1;
        }
        public bool EstOccupee(Position pos)
        {
            return BlockState[matrice[pos.Ligne][pos.Colonne]] == 4;
        }

        public bool MarquerPassage(Position pos)
        {
            return !EstOccupee(pos) && !EstUnMur(pos);
        }

        public void DisplayLabyrinth()
        {
            for (int i = 0; i < matrice.Length; i++)
            {
                string line = "";
                for (int j = 0; j < matrice[0].Length; j++)
                {
                    switch (matrice[i][j])
                    {
                        case '-':
                            line += " ";
                            break;
                        case 'o':
                            line += "-";
                            break;
                        default:
                            line += matrice[i][j];
                            break;
                    }
                }
                Console.WriteLine(line);
            }
        }
        
        public Position Arrive { get => arrive; }
        
        public string[] Matrice { get => matrice; set => matrice = value; }
        
        public Position Depart { get => depart; }
    }
}