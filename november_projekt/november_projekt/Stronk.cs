using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Stronk : Potion
    {
        // knife knife spork

        public Stronk(){//Se basklass för tydligare beskrivning

            name = "stronki bonki potion";
            recipe = new string[]{ "knife", "knife", "spork"};
            cursedRecipe = new string[] {"cursed knife","cursed knife", "cursed spork" };



        }

        public override void DescriptionPotion(string name, string[] recipe)
        {
            base.DescriptionPotion(name, recipe);
        }

    }
        

}
