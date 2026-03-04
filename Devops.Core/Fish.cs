using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Core
{
    public enum FishSpecies { Tuna, ClowFish, Sole }
    public class Fish
    {
        public static List<FishSpecies> CarnivoreSpecies = new List<FishSpecies>() {
            FishSpecies.Tuna,
            FishSpecies.ClowFish
        };

        private FishSpecies _specy;
        public FishSpecies Specy
        {
            get { return _specy; }
            private set { _specy = value; }
        }

        public bool IsCarnivore
        {
            get
            {
                return Fish.CarnivoreSpecies.Contains(_specy);
            }
        }

        public Fish(FishSpecies specy)
        {
            Specy = specy;
        }
    }
}
