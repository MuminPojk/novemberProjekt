using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Speed: Potion
    {

        public Speed()//Se basklass för tydligare beskrivning
        {

            name = "Sped potion";
            recipe = new string[] { "spoon", "spoon", "knife" }; // spoon spoon knife
            cursedRecipe = new string[] { "cursed spoon", "cursed spoon", "cursed knife" };

        }
        public override void DescriptionPotion(string name, string[] recipe)
        {
            base.DescriptionPotion(name, recipe);
        }


        //fork fork knife
    }
}
