using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Blue : Potion
    {

        public Blue()//Se basklass för tydligare beskrivning
        {

            name = "Bluey stewy potion";
            recipe = new string[] { "spork", "fork", "knife" };
            cursedRecipe = new string[] { "cursed spork", "cursed fork", "cursed knife" };

        }

        public override void DescriptionPotion(string name, string[] recipe)
        {
            base.DescriptionPotion(name, recipe);
        }

    }
}
