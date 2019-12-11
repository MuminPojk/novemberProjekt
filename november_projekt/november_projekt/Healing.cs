using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Healing : Potion
    {

        public Healing()//Se basklass för tydligare beskrivning
        {

            name = "Heali peaily potion";
            recipe = new string[]{ "spoon", "spoon", "fork"}; // spoon spoon knife
            cursedRecipe = new string[] { "cursed spoon", "cursed spoon", "cursed fork" };

        }

    }
}
