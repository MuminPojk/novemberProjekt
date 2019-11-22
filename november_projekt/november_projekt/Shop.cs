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

        Shopkeeper g1 = new Shopkeeper();
        public string input;
        static Random generator = new Random();
        //Metoder:
        //Buy= köper en grej och lägger in i shopkeepers inventory lista
        //Stock = uppdaterar stock med ett antal grejer

        public List<int> ClearStock()
        {

            stock.RemoveAt(0);
            stock.RemoveAt(0);
            stock.RemoveAt(0);
            stock.RemoveAt(0);

            return stock;

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

            int knifeStock = generator.Next(1, 8);
            int spoonStock = generator.Next(1, 7);
            int sporkStock = generator.Next(1, 4);
            int forkStock = generator.Next(1, 7);

            stock.Add(knifeStock);
            stock.Add(spoonStock);
            stock.Add(sporkStock);
            stock.Add(forkStock);

            return stock;
            

        }//Randomisar fram hur mycket av varje ingrediens som ska finnas i affären

        public List<string> BuyKnife(string input, List<string> inventoryKnife, List<int> stock)
        {

            Console.WriteLine("How many would you like?");//Failsafe needed

            input = Console.ReadLine();


            int resultat;
            bool lyckad = int.TryParse(input, out resultat);

            while (resultat > stock[0] || resultat < 0)
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

            if (resultat <= stock[0] && resultat >= 0)
            {

                for (int i = 0; i < resultat; i++)
                {

                    g1.inventoryKnife.Add("spoon");
                    


                }

                return g1.inventoryKnife;

            }


            return g1.inventoryKnife;


        }//Om man köper knivar läggs dessa in på spelarens inventory
        public List<string> BuySpoon(string input, List<string> inventorySpoon, List<int> stock)
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

                if(resultat <= stock[1] && resultat >= 0)
                {

                     for (int i = 0; i < resultat; i++)
                     {

                        g1.inventorySpoon.Add("spoon");
                      


                     }

                 return g1.inventorySpoon;

                }


            return g1.inventorySpoon;


        }//Om man köper skedar läggs dessa in på spelarens inventory
        public List<string> BuySpork(string input, List<string> inventorySpork, List<int> stock)
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

                for (int i = 0; i < resultat; i++)
                {

                    g1.inventorySpork.Add("spoon");



                }

                return g1.inventorySpork;

            }


            return g1.inventorySpork;


        }//Om man köper sporkar läggs dessa in på spelarens inventory
        public List<string> BuyFork(string input, List<string> inventoryFork, List<int> stock)
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

                for (int i = 0; i < resultat; i++)
                {

                    g1.inventoryFork.Add("spoon");



                }

                return g1.inventoryFork;

            }


            return g1.inventoryFork;


        }//Om man köper gafflar läggs dessa in på spelarens inventory
    }
}
