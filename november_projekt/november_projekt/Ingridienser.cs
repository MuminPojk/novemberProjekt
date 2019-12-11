using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Ingridiens
    {
        
        public string name;// I subklasserna kommer detta vara deras namn
        public int cost; //Hur mycket ingrediensen kostar
        public string description;// Är en string som beskriver ingrediensen och hintar till vilken potion den ska användas till

        Shopkeeper g1 = new Shopkeeper();//Skapar en instans av shopkeeper för att komma åt dennes variabler

        Random generator = new Random();

        public virtual List<string> Cursed(List<string> cursedItems, List<string> inventory, string item)// Skapar en random int, om inten är under 30 blir ett av itemsen som man köper cursed, och det läggs i cursed item inventory
        {
            int randomNumber = generator.Next(1, 100);

            if (randomNumber <= 30)
            {

                Console.WriteLine("Something about this item seem.... off");
                cursedItems.Add("cursed " + item);
                inventory.RemoveAt(0);

                return cursedItems;

            }


            return cursedItems ;

        }
        public virtual void Descriptor()//Kommer skriva ut fakta om ingredienserna
        {



        }

        //Här kan du ge namn, vikt och pris åt olika ingredienser
        //4 olika ingredienser:
      
        
    }
}
