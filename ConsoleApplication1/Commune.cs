namespace ConsoleApplication1
{
    public class Commune
    {
        private string name;
        private int departement;
        private string country;
        private string maire;
        private int inhabitantNumber;

        public Commune(string name, int departement, string country, string maire, int inhabitantNumber)
        {
            this.name = name.Substring(0,1).ToUpper() + name.Substring(1);;
            this.country = country.Substring(0,1).ToUpper() + country.Substring(1);;
            this.maire = maire.ToLower();
            this.inhabitantNumber = inhabitantNumber > 0 ? inhabitantNumber : -1;
            this.departement = departement > 0 ? departement : -1;
        }

        public override string ToString()
        {
            return string.Format("Le nom de la commune est: {0}, il a {1} habitants, son maire est {2}, dans le departement {3} " +
                                 "qui est dans le pays {4}", name, inhabitantNumber, maire, departement, country);
        }

        public bool Equals(Commune commune)
        {
            return inhabitantNumber == commune.inhabitantNumber;
        }

        public static bool EqualStatic(Commune c1, Commune c2)
        {
            return c1.Equals(c2);
        }
        
        public int InhabitantNumber
        {
            get { return inhabitantNumber;}
            set { inhabitantNumber = value > 0 ? value : -1; }
        }

        public string Maire
        {
            set { maire = value.ToString(); }
        }

        public string Name
        {
            get { return name; }
        }
    }
}