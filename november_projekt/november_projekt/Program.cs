using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dontStopmeNowBecauseIamHavingSuchAGoodTime = true;
            Console.WriteLine("It is time to make your own potion! What do you want to do?");
            Shopkeeper g1 = new Shopkeeper();
            Shop g2 = new Shop();
            Stronk g3 = new Stronk();
            Customer g4 = new Customer();

            while (dontStopmeNowBecauseIamHavingSuchAGoodTime) {
                Console.WriteLine("1. Check ingridients");
                Console.WriteLine("2. Buy ingridients");
                Console.WriteLine("3. Make a potion");
                Console.WriteLine("4. Customer`s order");
                Console.WriteLine("5. Check potions");
              
                
                string input = Console.ReadLine();

                if (input == "1") 
                {

                    g1.CheckInventory(g1.inventoryKnife, g1.inventorySpoon, g1.inventoryFork, g1.inventorySpork);

                }
                else if (input == "2")
                {
                    //The shop gets stocked
                    // One can check wares or buy wares
                    g2.Stock();

                    Console.WriteLine("Welcome to gilgamesh gloriusly godlike goods");

                    g2.CheckStock();
                    

                    Console.WriteLine("Do you want to buy something?"); // Glöm inte att kolla ifall spelaren har pengar och i fall affären har grjen
                    input = Console.ReadLine();
                    

                    
                    if(input == "yes"){


                        Console.WriteLine("What ingrident would you like to buy?");

                        input = Console.ReadLine();

                        if (input == "spoon")
                        {

                            g1.inventorySpoon = g2.BuySpoon(input, g1.inventorySpoon, g2.stock);

                        }
                        else if (input == "knife")
                        {

                            g1.inventoryKnife = g2.BuyKnife(input, g1.inventoryKnife, g2.stock);
                        }
                        else if (input == "fork")
                        {

                            g1.inventoryFork = g2.BuyFork(input, g1.inventoryFork, g2.stock);
                        }
                        else if (input == "spork")
                        {

                            g1.inventorySpork = g2.BuySpork(input, g1.inventorySpork, g2.stock);

                        }


                        g2.ClearStock();
                        Console.WriteLine("Thank you bye");
                    }
                    else if(input == "no")
                    {

                        Console.WriteLine("Sure, bye");

                    }



                }
                else if (input == "3")
                {

                   g1.inventoryPotion = g1.MakePotions(g3.recipe, g1.inventorySpoon, g1.inventoryFork, g1.inventorySpork, g1.inventoryKnife, g1.inventoryPotion);

                }
                else if(input == "4"){


                    g4.Customer1();

                    Console.WriteLine("Do you want to give the customer their order");

                    input = Console.ReadLine();

                    if (input == "yes")
                    {

                       g1.money = g4.Customer1Buy(g1.inventoryPotion, g4.cost1, g1.money);

                    }
                    else if (input == "no")
                    {
                        Console.WriteLine("Okay then");

                    }


                }
                else if (input == "5")
                {

                    g1.CheckPotion ( g1.inventoryPotion);

                }


                Console.ReadLine();
            }

        }
    }
}
