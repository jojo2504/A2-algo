namespace ConsoleApplication1
{
    public class Position
    {
        private int ligne;
        private int colonne;

        public Position(int ligne, int colonne)
        {
            this.ligne = ligne;
            this.colonne = colonne;
        }
        
        public int Ligne { get => ligne; set => ligne = value; }
        
        public int Colonne { get => colonne; set => colonne = value; }

        public override string ToString()
        {
            return string.Format("La ligne est {0} et la colonne est {1}", Ligne, Colonne);
        }

        public bool EstEgale(Position pos)
        {
            return ligne == pos.ligne && colonne == pos.colonne;
        }
        
        
    }
}