using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Fork : Ingridiens
    {

        public Fork()
        {
            name = "Featherd fork";
            cost = 35;
            
            description = "Forks are often used as projecttiles, and for that they need to be light and quick";

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
