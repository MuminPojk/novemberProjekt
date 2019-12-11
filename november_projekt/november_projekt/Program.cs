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
            Knife g5 = new Knife();
            Spoon g6 = new Spoon();
            Spork g7 = new Spork();
            Fork g8 = new Fork();
            


            while (dontStopmeNowBecauseIamHavingSuchAGoodTime) {
                Console.WriteLine("1. Check ingridients");
                Console.WriteLine("2. Buy ingridients");
                Console.WriteLine("3. Make a potion");
                Console.WriteLine("4. Give the customer their order");
                Console.WriteLine("5. Check potions");
                Console.WriteLine("6. Stop playing the game");
                Console.WriteLine("7. Check Customer`s order");


                string input = Console.ReadLine();

                if (input == "1")
                {

                    g1.CheckInventory(g1.inventoryKnife, g1.inventorySpoon, g1.inventoryFork, g1.inventorySpork);//Kollar vilka ingredienser man har köpt

                }
                else if (input == "2")
                {
                    //The shop gets stocked
                    // One can check wares or buy wares
                    g2.Stock();//Ett antal av varje ingrediens kommer slumpas fram

                    Console.WriteLine("Welcome to gilgamesh gloriusly godlike goods");

                    g2.CheckStock();//Skriver ut de olika ingrdienserna och hur många det finns av dem


                    Console.WriteLine("Do you want to buy something?"); // Glöm inte att kolla ifall spelaren har pengar och i fall affären har grjen
                    input = Console.ReadLine();



                    if (input == "yes") {


                        Console.WriteLine("What ingrident would you like to buy?");

                        input = Console.ReadLine();

                        if (input == "spoon")
                        {

                            (g1.inventorySpoon, g1.money) = g2.BuySpoon(input, g1.inventorySpoon, g2.stock, g1.money, g6.cost);//Kommer lägga in antal skedar man har köpt och ta så mycket pengar som ingredienserna kostar
                            g1.cursedItem = g5.Cursed(g1.cursedItem, g1.inventorySpoon, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista

                        }
                        else if (input == "knife")
                        {

                            (g1.inventoryKnife, g1.money) = g2.BuyKnife(input, g1.inventoryKnife, g2.stock, g5.cost, g1.money);//Kommer lägga in antal knivar man har köpt och ta så mycket pengar som ingredienserna kostar
                            g1.cursedItem = g5.Cursed(g1.cursedItem, g1.inventoryKnife, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista


                        }
                        else if (input == "fork")
                        {

                            (g1.inventoryFork, g1.money) = g2.BuyFork(input, g1.inventoryFork, g2.stock, g8.cost, g1.money);//Kommer lägga in antal gafflar man har köpt och ta så mycket pengar som ingredienserna kostar
                            g1.cursedItem = g5.Cursed(g1.cursedItem, g1.inventoryFork, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista
                        }
                        else if (input == "spork")
                        {

                            (g1.inventorySpork, g1.money) = g2.BuySpork(input, g1.inventorySpork, g2.stock, g7.cost, g1.money);//Kommer lägga in antal sporks man har köpt och ta så mycket pengar som ingredienserna kostar
                            g1.cursedItem = g5.Cursed(g1.cursedItem, g1.inventorySpork, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista

                        }


                        g2.ClearStock();//Tar sedan bort stock så att nya värden kan slumpas fram nästa gång man ska köpa något.
                        Console.WriteLine("Thank you bye");
                    }
                    else if (input == "no")
                    {

                        Console.WriteLine("Sure, bye");

                    }



                }
                else if (input == "3")
                {

                    g1.inventoryPotion = g1.MakePotions(g3.recipe, g1.inventorySpoon, g1.inventoryFork, g1.inventorySpork, g1.inventoryKnife, g1.inventoryPotion);// Kommer kolla om man har allt för att göra sin potion och skickar tillbaka de man lyckas göra, de läggs i en lista som heter potion inventory

                }
                else if (input == "4")
                {
                                
                            g1.money = g4.Customer1Buy(g1.inventoryPotion, g4.cost1, g1.money);//Kollar om man har alla potions, har man dem så kommer man få betalt

                }
                else if (input == "5")
                {

                    g1.CheckPotion(g1.inventoryPotion);// Skriver ut vilka potions man har gjorda

                }
                else if (input == "6")//Stänger av spelet
                {

                    dontStopmeNowBecauseIamHavingSuchAGoodTime = false;
                    Console.WriteLine("you sure?");
                    Console.ReadLine();
                    Console.WriteLine("you sure sure?");
                    Console.ReadLine();
                    Console.WriteLine("you sure sure sure sure sure sure sure?");
                    Console.ReadLine();
                    Console.WriteLine("Okay then, bye");

                }
                else if(input == "7")
                {

                    g4.Customer1();//Kallar kundens order
                    g4.Customer2();


                }

                Console.ReadLine();
            }

        }


    }
}
