using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Region
    {
        private List<Commune> communeList;
        private string prefet;
        private string chef_lieu;

        public Region(string prefet, string chef_lieu, List<Commune> communeList)
        {
            this.prefet = prefet;
            this.chef_lieu = chef_lieu;
            this.communeList = communeList;
        }

        public override string ToString()
        {
            string communeListStr = "";
            foreach (Commune commune in communeList)
            {
                communeListStr += commune.Name + ", ";
            }
            return string.Format("Le prefet de cette region est {0} et son chef-lieu est {1}. La region a {2} communes qui sont {3}", prefet, chef_lieu, communeList.Count, communeListStr);
        }

        public int PopulationNumberInRegion()
        {
            int populationNumber = 0;
            foreach (var commune in communeList)
            {
                populationNumber += commune.InhabitantNumber;
            }
            return populationNumber;
        }

        public bool CommuneExists(Commune commune)
        {
            // return communeList.Contains(commune); //pourquoi pas faire comme ca comme une personne normal mais devoir juste regarder le nom wtf
            foreach (var commune1 in communeList)
            {
                if (commune.Name == commune1.Name)
                {
                    return true;
                }
            }
            return false;
        }
        
        public List<Commune> CommunesList{ get { return communeList; } }

        public void SortCommune()
        {
            int compareState;
            Commune tempCommune;
            for (int i = 0; i < communeList.Count; i++)
            {
                for (int j = i + 1; j < communeList.Count; j++)
                {
                    compareState = string.Compare(communeList[i].Name, communeList[j].Name);
                    if (compareState == 1)
                    {
                        tempCommune = communeList[i];
                        communeList[i] = communeList[j];
                        communeList[j] = tempCommune;
                    }
                }
            }
        }
    }
}