using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Shop
    {
        public List<int> stock = new List<int>();

        Shopkeeper shopkeeper = new Shopkeeper();
        
      
        
        static Random generator = new Random();
        //Metoder:
        //Buy= köper en grej och lägger in i shopkeepers inventory lista
        //Stock = uppdaterar stock med ett antal grejer

        public List<int> ClearStock()
        {

            stock.RemoveAt(0);//Tar bort allt som finns i listan stock
            stock.RemoveAt(0);
            stock.RemoveAt(0);
            stock.RemoveAt(0);

            return stock;//Retunerar den nu tomma listan

        }// Tar bort stock så att affären kan en ny stock via metoden Stock
        public void CheckStock()
        {
            Console.WriteLine("This is what the shop has in store, it will get restocked the next time!");

    
                Console.WriteLine(stock[0] + " knives");
                Console.WriteLine(stock[1] + " spoons");
                Console.WriteLine(stock[2] + " sporks");
                Console.WriteLine(stock[3] + " forks");



        }//Skriver ut vad det är som affären har
        public List<int> Stock()
        {

            int knifeStock = generator.Next(1, 8);//Slumpar fram olika antal ingredienser som sparas i varsin int
            int spoonStock = generator.Next(1, 7);
            int sporkStock = generator.Next(1, 4);
            int forkStock = generator.Next(1, 7);

            stock.Add(knifeStock);//Varje plats har varsit antal ingredienser, på stocks första plats kommer det alltid att vara hur många knifes som affären har just då
            stock.Add(spoonStock);
            stock.Add(sporkStock);
            stock.Add(forkStock);

            return stock;
            

        }//Randomisar fram hur mycket av varje ingrediens som ska finnas i affären

        public (List<string> inventoryKnife, int money) BuyKnife(string input, List<string> inventoryKnife, List<int> stock, int knifeCost, int money)
        {

            Console.WriteLine("How many would you like?");

            input = Console.ReadLine();


            int resultat;
            bool lyckad = int.TryParse(input, out resultat);

            while (resultat > stock[0] || resultat < 0)//Kollar om det personen har skrivit in är lika mycket som stock har och att det är över 0. Spelaren får skriva om det tills den får något acceptabelt
            {

                if (resultat > stock[0])
                {

                    Console.WriteLine("Too much");

                }
                else if (resultat < 0)
                {

                    Console.WriteLine("To little");

                }

                input = Console.ReadLine();
                lyckad = int.TryParse(input, out resultat);

            }

            if (resultat <= stock[0] && resultat > 0)
            {

                if (money >= knifeCost* resultat)// Kollar om personen har tillräckligt mycket pengar för att köpa så många ingredienser som de vill köpa
                {

                   

                    for (int i = 0; i < resultat; i++) // Går igenom listan så många gånger som antalet knivar som spelaren ville köpa
                    {

                        shopkeeper.inventoryKnife.Add("spoon");// Vill man köpa två knivar kommer det då läggas in 2 knivar i spelarens inventory

                        
                        
                        
                    }

                    money = money - (knifeCost* resultat);//Tar bort kostnaden av ingrdienserna från spelarens pengar.
                    return (shopkeeper.inventoryKnife, money);

                }

                Console.WriteLine("I am sorry you do not have enough money to buy that many knives, please come back later");
                return (shopkeeper.inventoryKnife, money);


            }


            return (shopkeeper.inventoryKnife, money);


        }//Om man köper knivar läggs dessa in på spelarens inventory
        public (List<string> inventorySpoon, int money) BuySpoon(string input, List<string> inventorySpoon, List<int> stock, int money, int spoonCost)
        {

                Console.WriteLine("How many would you like?");//Failsafe needed

                input = Console.ReadLine();

                
                int resultat;
                bool lyckad = int.TryParse(input, out resultat);

               while (resultat > stock[1] || resultat < 0) {

                    if (resultat > stock[1])
                    {

                        Console.WriteLine("Too much");

                    }
                    else if (resultat < 0)
                    {

                        Console.WriteLine("To little");

                    }

                    input = Console.ReadLine();
                    lyckad = int.TryParse(input, out resultat);

                }

            if (resultat <= stock[1] && resultat >= 0)
            {

                if (money >= spoonCost * resultat)
                {

                    for (int i = 0; i < resultat; i++)
                    {

                        shopkeeper.inventorySpoon.Add("spoon");



                    }

                    money = money - (spoonCost * resultat);
                    return (shopkeeper.inventorySpoon, money);

                }
            }

                

                 


            return (shopkeeper.inventorySpoon, money);


        }//Om man köper skedar läggs dessa in på spelarens inventory
        public (List<string> inventorySpork, int money) BuySpork(string input, List<string> inventorySpork, List<int> stock, int sporkCost, int money)
        {

            Console.WriteLine("How many would you like?");//Failsafe needed

            input = Console.ReadLine();


            int resultat;
            bool lyckad = int.TryParse(input, out resultat);

            while (resultat > stock[2] || resultat < 0)
            {

                if (resultat > stock[2])
                {

                    Console.WriteLine("Too much");

                }
                else if (resultat < 0)
                {

                    Console.WriteLine("To little");

                }

                input = Console.ReadLine();
                lyckad = int.TryParse(input, out resultat);

            }

            if (resultat <= stock[2] && resultat >= 0)
            {

                if (money >= sporkCost * resultat) { 

                    for (int i = 0; i < resultat; i++)
                    {

                        shopkeeper.inventorySpork.Add("spoon");



                    }

                    money = money - (sporkCost * resultat);
                    return (shopkeeper.inventorySpork, money);
                }

            }


            return (shopkeeper.inventorySpork, money);


        }//Om man köper sporkar läggs dessa in på spelarens inventory
        public (List<string> inventoryFork, int money) BuyFork(string input, List<string> inventoryFork, List<int> stock, int forkCost, int money)
        {

            Console.WriteLine("How many would you like?");//Failsafe needed

            input = Console.ReadLine();


            int resultat;
            bool lyckad = int.TryParse(input, out resultat);

            while (resultat > stock[3] || resultat < 0)
            {

                if (resultat > stock[3])
                {

                    Console.WriteLine("Too much");

                }
                else if (resultat < 0)
                {

                    Console.WriteLine("To little");

                }

                input = Console.ReadLine();
                lyckad = int.TryParse(input, out resultat);

            }

            if (resultat <= stock[3] && resultat >= 0)
            {

                if (money >= forkCost * resultat) { 

                     for (int i = 0; i < resultat; i++)
                     {

                        shopkeeper.inventoryFork.Add("spoon");



                     }



                      money = money - (forkCost * resultat);
                      return (shopkeeper.inventoryFork, money);
                }

            }

            return (shopkeeper.inventoryFork, money);
          


        }//Om man köper gafflar läggs dessa in på spelarens inventory
    }
}
