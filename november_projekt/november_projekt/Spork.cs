using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Spork : Ingridiens
    {

        public Spork()
        {
            name = "Screaming Spork";
            cost = 85;
            description = "What in the hiddety heck is this used for?";

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
