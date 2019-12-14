using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Potion
    {

        //Här kan man ge namn, vikt och kostnad till åt de olika porions
        //Healing
        //Stronk
        //Sped
        //Man blir blå

        public string name;//namn på potion
        public string[] recipe;// Receptet på potion
        public string[] cursedRecipe;//recpit om man ska göra en cursed potion

       public virtual void DescriptionPotion(string name, string[] recipe)
        {

            Console.WriteLine(name);
            for (int i = 0; i < recipe.Length; i++)
            {

                Console.WriteLine("Name of potion");
                Console.WriteLine(name);
                Console.WriteLine("Recipe of the potion");
                Console.WriteLine(recipe[i]);

            }
           

        }


    }
}
