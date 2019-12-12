using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Customer
    {
        public int cost1 = 50;
        public int cost2 = 100;
        Shopkeeper g1 = new Shopkeeper();
        //Three metoder som ska vara de olika customers

        public void Customer1()
        {

           
            Console.WriteLine("This customer wants:");
            Console.WriteLine("2 Healing potions");
            Console.WriteLine("1 Speed potion");

            


        }//Skriver ut kundens order
        public void Customer2()
        {

            Console.WriteLine("This customer wants:");
            Console.WriteLine("1 Stronk potions");
            Console.WriteLine("1 Speed potion");
            Console.WriteLine("1 Healing potion");


        }//Skriver ut kundens order
        public void Customer3()
        {

            Console.WriteLine("This customer wants:");
            Console.WriteLine("2 Blue potions");
            Console.WriteLine("2 of them should be cursed");



        }//Skriver ut kundens order
        public int Customer1Buy(List<string> inventoryPotion, int cost1, int money)// Kollar först i shopkeepers inventory om den har det kunden frågar efter, har den det så får man pengar och pengarna retuneras
        {//Om man inte har rätt potions skickas man tillbaka till main screen


            int antalHealPotion = 0;
            int antalSpeedPotion = 0;
            for (int i = 0; i < inventoryPotion.Count; i++)
            {

                if (inventoryPotion[i] == "healing potion")
                {


                    antalHealPotion++;// Om spelaren har 2 healing potion på sig så kommer denna int vara lika med 2


                }
                else if (inventoryPotion[i] == "speed potion")
                {

                    antalSpeedPotion++;// Om spelaren har 2 speed potion på sig så kommer denna int vara lika med 2

                }


            }


            if (antalSpeedPotion < 1 || antalHealPotion < 2)// Kollar om spelaren har rätt antal potions
            {

                if (antalHealPotion < 2)
                {

                    Console.WriteLine("to few healing potions");

                }
                else if (antalSpeedPotion < 1)
                {


                    Console.WriteLine("Too few speedpotions");

                }


            }

            if (antalSpeedPotion >= 1 && antalHealPotion >= 2) // Har spelaren rätt antal potions så kommer 2 healing potions och 1 speed potion försvinna från spelarens inventory
            {

                Console.WriteLine("Okay thank you i will take my leave");

                for (int i = 0; i < 3; i++)
                {

                    if (inventoryPotion[0] == "healing potion")
                    {


                        inventoryPotion.Remove("healing potion");

                    }
                    else if (inventoryPotion[0] == "speed potion")
                    {

                        inventoryPotion.Remove("speed potion");


                    }



                }


                money = money + cost1;//Ens pengar kommer öka tillsammans med kundens betalning 
                return money;

            }

            return money;







        }
            
        
        public int Customer2Buy(List<string> inventoryPotion, int cost2, int money)
        {

            int antalHealPotion = 0;
            int antalSpeedPotion = 0;
            int antalStronkPotion = 0;
            for (int i = 0; i < inventoryPotion.Count; i++)
            {

                if (inventoryPotion[i] == "healing potion")
                {


                    antalHealPotion++;


                }
                else if (inventoryPotion[i] == "speed potion")
                {

                    antalSpeedPotion++;

                }
                else if (inventoryPotion[i] == "stronk potion")
                {

                    antalStronkPotion++;


                }


            }


            if (antalSpeedPotion < 1 || antalHealPotion < 1 || antalStronkPotion < 1)
            {

                if (antalHealPotion < 1)
                {

                    Console.WriteLine("to few healing potions");

                }
                else if (antalSpeedPotion < 1)
                {


                    Console.WriteLine("Too few speed potions");

                }
                else //KOLLA OM DETTA FUNGERAR
                {

                    Console.WriteLine("Too few stronk potions");

                }


            }

            if (antalSpeedPotion >= 1 && antalHealPotion >= 1 && antalStronkPotion >= 1)
            {

                Console.WriteLine("Okay thank you i will take my leave");

                for (int i = 0; i < 3; i++)
                {

                    if (inventoryPotion[0] == "healing potion")
                    {


                        inventoryPotion.Remove("healing potion");

                    }
                    else if (inventoryPotion[0] == "speed potion")
                    {

                        inventoryPotion.Remove("speed potion");


                    }
                    else if (inventoryPotion[0] == "stronk potion")
                    {

                        inventoryPotion.Remove("stronk potion");

                    }



                }

                money = money + cost2;
                return money;

            }

            return money;

        }//Fungerar på samma sätt som Customer1Buy

    }
}
