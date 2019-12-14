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
            Console.WriteLine("To select something just type the number of it!");
            
            Shopkeeper shopKeeper = new Shopkeeper();
            Shop shop = new Shop();
            Stronk strongPotion = new Stronk();
            Speed speedPotion = new Speed();
            Healing healingPotion = new Healing();
            Blue bluePotion = new Blue();
            Customer customer = new Customer();
            Knife knife = new Knife();
            Spoon spoon = new Spoon();
            Spork spork = new Spork();
            Fork fork = new Fork();

            while (dontStopmeNowBecauseIamHavingSuchAGoodTime) {
                Console.WriteLine("1. Check ingridients");
                Console.WriteLine("2. Buy ingridients");
                Console.WriteLine("3. Make a potion");
                Console.WriteLine("4. Give the customer their order");
                Console.WriteLine("5. Check potions");
                Console.WriteLine("6. Stop playing the game");
                Console.WriteLine("7. Check Customer`s order");
                Console.WriteLine("8. Check out the ingridneses names and cost");
                Console.WriteLine("9. Check out the potions name and cost");


                string input = Console.ReadLine();

                if (input == "1")
                {

                    shopKeeper.CheckInventory(shopKeeper.inventoryKnife, shopKeeper.inventorySpoon, shopKeeper.inventoryFork, shopKeeper.inventorySpork);//Kollar vilka ingredienser man har köpt

                }
                else if (input == "2")
                {
                    //The shop gets stocked
                    // One can check wares or buy wares
                    shop.Stock();//Ett antal av varje ingrediens kommer slumpas fram

                    Console.WriteLine("Welcome to gilgamesh gloriusly godlike goods");

                    shop.CheckStock();//Skriver ut de olika ingrdienserna och hur många det finns av dem


                    Console.WriteLine("Do you want to buy something?"); // Glöm inte att kolla ifall spelaren har pengar och i fall affären har grjen
                    input = Console.ReadLine();



                    if (input == "yes") {


                        Console.WriteLine("What ingrident would you like to buy?");

                        input = Console.ReadLine();

                        if (input == "spoon")
                        {

                            (shopKeeper.inventorySpoon, shopKeeper.money) = shop.BuySpoon(input, shopKeeper.inventorySpoon, shop.stock, shopKeeper.money, spoon.cost);//Kommer lägga in antal skedar man har köpt och ta så mycket pengar som ingredienserna kostar
                            shopKeeper.cursedItem = spoon.Cursed(shopKeeper.cursedItem, shopKeeper.inventorySpoon, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista

                        }
                        else if (input == "knife")
                        {

                            (shopKeeper.inventoryKnife, shopKeeper.money) = shop.BuyKnife(input, shopKeeper.inventoryKnife, shop.stock, knife.cost, shopKeeper.money);//Kommer lägga in antal knivar man har köpt och ta så mycket pengar som ingredienserna kostar
                            shopKeeper.cursedItem = knife.Cursed(shopKeeper.cursedItem, shopKeeper.inventoryKnife, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista


                        }
                        else if (input == "fork")
                        {

                            (shopKeeper.inventoryFork, shopKeeper.money) = shop.BuyFork(input, shopKeeper.inventoryFork, shop.stock, fork.cost, shopKeeper.money);//Kommer lägga in antal gafflar man har köpt och ta så mycket pengar som ingredienserna kostar
                            shopKeeper.cursedItem = fork.Cursed(shopKeeper.cursedItem, shopKeeper.inventoryFork, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista
                        }
                        else if (input == "spork")
                        {

                            (shopKeeper.inventorySpork, shopKeeper.money) = shop.BuySpork(input, shopKeeper.inventorySpork, shop.stock, spork.cost, shopKeeper.money);//Kommer lägga in antal sporks man har köpt och ta så mycket pengar som ingredienserna kostar
                            shopKeeper.cursedItem = spork.Cursed(shopKeeper.cursedItem, shopKeeper.inventorySpork, input);//Kommer kanske göra om en av ingredianserna till cursed och den läggs in i en cursed item lista

                        }


                        shop.ClearStock();//Tar sedan bort stock så att nya värden kan slumpas fram nästa gång man ska köpa något.
                        Console.WriteLine("Thank you bye");
                    }
                    else if (input == "no")
                    {

                        Console.WriteLine("Sure, bye");

                    }



                }
                else if (input == "3")
                {

                    shopKeeper.inventoryPotion = shopKeeper.MakePotions(strongPotion.recipe, shopKeeper.inventorySpoon, shopKeeper.inventoryFork, shopKeeper.inventorySpork, shopKeeper.inventoryKnife, shopKeeper.inventoryPotion);// Kommer kolla om man har allt för att göra sin potion och skickar tillbaka de man lyckas göra, de läggs i en lista som heter potion inventory

                }
                else if (input == "4")
                {

                    Console.WriteLine("Who do you want to give the order to customer 1 or 2?");

                    input = Console.ReadLine();

                    if (input == "1")
                    {

                        shopKeeper.money = customer.Customer1Buy(shopKeeper.inventoryPotion, customer.cost1, shopKeeper.money);//Kollar om man har alla potions, har man dem så kommer man få betalt
                    }
                    else if(input == "2")
                    {

                        shopKeeper.money = customer.Customer2Buy(shopKeeper.inventoryPotion, customer.cost2, shopKeeper.money);//Fungerar på samma sätt
                    }


                }
                else if (input == "5")
                {

                    shopKeeper.CheckPotion(shopKeeper.inventoryPotion);// Skriver ut vilka potions man har gjorda

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

                    customer.Customer1();//Kallar kundens order
                    customer.Customer2();


                }
                else if (input == "8")
                {

                    strongPotion.DescriptionPotion(strongPotion.name, strongPotion.recipe);
                    speedPotion.DescriptionPotion(speedPotion.name, speedPotion.recipe);
                    healingPotion.DescriptionPotion(healingPotion.name, healingPotion.recipe);
                    bluePotion.DescriptionPotion(bluePotion.name, bluePotion.recipe);

                }
                else if (input == "9")
                {

                    fork.Descriptor(fork.name, fork.cost, fork.description);
                    spoon.Descriptor(spoon.name, spoon.cost, spoon.description);
                    spork.Descriptor(spork.name, spork.cost, spork.description);
                    knife.Descriptor(knife.name, knife.cost, knife.description);
                }

                Console.ReadLine();
            }

        }


    }
}
