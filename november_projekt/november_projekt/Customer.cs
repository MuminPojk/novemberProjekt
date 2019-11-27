using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Customer
    {
        public int cost1 = 3;
        Shopkeeper g1 = new Shopkeeper();
        //Three metoder som ska vara de olika customers

        public void Customer1()
        {

           
            Console.WriteLine("This customer wants:");
            Console.WriteLine("2 Healing potions");
            Console.WriteLine("1 Speed potion");

            


        }
        public void Customer2()
        {

            Console.WriteLine("This customer wants:");
            Console.WriteLine("1 Stronk potions");
            Console.WriteLine("1 Speed potion");
            Console.WriteLine("1 Healing potion");


        }
        public void Customer3()
        {

            Console.WriteLine("This customer wants:");
            Console.WriteLine("5 Blue potions");
            Console.WriteLine("2 of them should be cursed");



        }
        public int Customer1Buy(List<string> inventoryPotion, int cost1, int money)
        {

            Console.WriteLine(g1.inventoryPotion.Count);//potioninventroty innehåller fortfarande 1 men g1.potion inventory innehåller 0

            int antalHealPotion = 0;
            int antalSpeedPotion = 0;
            for (int i = 0; i < g1.inventoryPotion.Count; i++)
            {

                if (g1.inventoryPotion[i] == "healing potion")
                {

                     
                     antalHealPotion++;


                }
                else if (g1.inventoryPotion[i] == "speed potion")
                {

                    antalSpeedPotion++;

                }


            }


            if (antalSpeedPotion < 1 || antalHealPotion < 2)
            {

                if (antalHealPotion <2)
                {

                    Console.WriteLine("to few healing potions");

                }
                else if(antalSpeedPotion <1){


                    Console.WriteLine("Too few speedpotions");

                }


            }

            if (antalSpeedPotion >= 1 && antalHealPotion >= 2)
            {

                Console.WriteLine("Okay thank you i will take my leave");

                for (int i  = 0; i  < g1.inventoryPotion.Count; i ++)
                {

                    if (g1.inventoryPotion[i] == "healing potion")
                    {


                        g1.inventoryPotion.Remove("healing potion");

                    }
                    else if (g1.inventoryPotion[i] == "speed potion")
                    {

                        g1.inventoryPotion.Remove("speed potion");


                    }



                }

                g1.money = g1.money + cost1;
                return money;

            }

            return money;
        }

    }
}
