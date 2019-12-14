using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Spoon : Ingridiens
    {
        public Spoon()
        {
            name = "Sacred Spoon";
            cost = 30;
            
            description = "Spoons are not good to use as protjecttiles or weapons in general, i guess it is good for other stuff";

        }
        public override List<string> Cursed(List<string> cursedItems, List<string> inventory, string item)//Är exakt samma som grundmetoden i Ingredienser enda skillnaden är att den tar in olika inventorys och items
        {
            return base.Cursed(cursedItems, inventory, item);
        }
        public override void Descriptor(string name, int cost, string description)
        {
            base.Descriptor(name, cost, description);
        }


    }
}
