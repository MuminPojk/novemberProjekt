using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Shopkeeper
    {
        Stronk g1 = new Stronk();
        Speed g2 = new Speed();
        Healing g3 = new Healing();
        Blue g4 = new Blue();

        public List<string> inventoryKnife = new List<string>();
        public List<string> inventorySpoon = new List<string>();
        public List<string> inventoryFork = new List<string>();
        public List<string> inventorySpork = new List<string>();

        
        public List<string> inventoryPotion = new List<string>();
   


        public void CheckPotion( List<string> inventoryPotion)
        {

            Console.WriteLine("You have this much in your stock");

            for (int i = 0; i < inventoryPotion.Count; i++)
            {


                Console.WriteLine(inventoryPotion[i]);


            }


        


        }// Denna metod kollar vad spelaren har för potions gjorda
        public void CheckInventory(List<string> inventoryKnife,List<string> inventorySpoon, List<string> inventoryFork, List<string> inventorySpork)
        { //Denna kollar vad man har i sin inventory

           
            Console.WriteLine("You have this much in your stock");
            Console.WriteLine(inventorySpoon.Count + " spoons");
            Console.WriteLine(inventoryKnife.Count + " knifes");
            Console.WriteLine(inventoryFork.Count + " forks");
            Console.WriteLine(inventorySpork.Count + " sporks");



        }//Denna metod talar om vad för ingredienser som spelarn köpt men som hen inte har använt
        public List<string> MakePotions(string[] recipe, List<string> inventorySpoon, List<string> inventoryFork, List<string> inventorySpork, List<string> inventoryKnife, List<string> inventoryStronk)//Denna metod kollar om spelaren har rätt ingredienser för att göra en potion
            //Om inte måste den gå och köpa rätt ingrdienser. Om spelaren har alla måste hen sätta in ingredienserna i rätt ordning för att få fram en potion, om hen inte lyckas måste hen göra om det
        {

            Console.WriteLine("What potion would you like to make");

            string input = Console.ReadLine();

            if (input == "stronk")
            {


                if (inventoryKnife.Count < 2 || inventorySpork.Count < 1)
                {
                    if (inventorySpork.Count < 1)
                    {

                        Console.WriteLine("To few sporks");
                        return inventoryPotion;
                    }
                    else if (inventorySpork.Count < 1 && inventoryKnife.Count < 2)
                    {

                        Console.WriteLine("To few knifes and sporks");
                        return inventoryPotion;
                    }
                    else if (inventoryKnife.Count < 2)
                    {
                        Console.WriteLine("To few knifes ");
                        return inventoryPotion;

                    }

                }
                


                Console.WriteLine("Put the ingridens in the correct order to make the right potion");



                if (inventoryKnife.Count <= 2 && inventoryKnife.Count <= 1) {
                    for (int i = 0; i < g1.recipe.Length; i++)
                    {
                        input = Console.ReadLine();

                        if (input == g1.recipe[i])
                        {

                            Console.WriteLine("Correct");


                        }
                        else if (input != g1.recipe[i])
                        {

                            Console.WriteLine("Wrong");//Lägg till failure finns en chans för explosinon
                            return inventoryPotion;

                        }


                    }

                    inventoryPotion.Add("stronk potion");
                    return inventoryPotion;


                }
            }
                


            
            else if (input == "speed")
            {

                if (inventoryKnife.Count < 1 || inventorySpoon.Count < 2)
                {
                    if (inventoryKnife.Count < 1)
                    {

                        Console.WriteLine("To few knifes");
                        return inventoryPotion;
                    }
                    else if (inventoryKnife.Count < 1 && inventorySpoon.Count < 2)
                    {

                        Console.WriteLine("To few knifes and spoons");
                        return inventoryPotion;
                    }
                    else if (inventorySpoon.Count < 2)
                    {
                        Console.WriteLine("To few spoons ");
                        return inventoryPotion;

                    }

                }
                    Console.WriteLine("Put the ingridens in the correct order to make the right potion");


                for (int i = 0; i < g2.recipe.Length; i++)
                {
                    input = Console.ReadLine();

                    if (input == g2.recipe[i])
                    {

                        Console.WriteLine("Correct");


                    }
                    else if (input != g2.recipe[i])
                    {

                        Console.WriteLine("Wrong");//Lägg till failure finns en chans för explosinon
                        return inventoryPotion;

                    }


                }

                inventoryPotion.Add("speed potion");
                return inventoryPotion;

            }
            else if (input == "healing")
            {

                if (inventoryFork.Count < 1 || inventorySpoon.Count < 2)
                {
                    if (inventoryFork.Count < 1)
                    {

                        Console.WriteLine("To few forks");
                        return inventoryPotion;
                    }
                    else if (inventoryFork.Count < 1 && inventorySpoon.Count < 2)
                    {

                        Console.WriteLine("To few forks and spoons");
                        return inventoryPotion;
                    }
                    else if (inventorySpoon.Count < 2)
                    {
                        Console.WriteLine("To few spoons ");
                        return inventoryPotion;

                    }

                }

                Console.WriteLine("Put the ingridens in the correct order to make the right potion");


                for (int i = 0; i < g3.recipe.Length; i++)
                {
                    input = Console.ReadLine();

                    if (input == g3.recipe[i])
                    {

                        Console.WriteLine("Correct");


                    }
                    else if (input != g3.recipe[i])
                    {

                        Console.WriteLine("Wrong");//Lägg till failure finns en chans för explosinon
                        return inventoryPotion;

                    }


                }

                inventoryPotion.Add(" Healing potion");
                return inventoryPotion;


            }
            else if (input == "blue") 
            {

                if (inventoryKnife.Count < 1 || inventorySpork.Count < 1 || inventoryFork.Count < 1 )
                {
                    if (inventoryKnife.Count < 1)
                    {

                        Console.WriteLine("To few knifes");
                        return inventoryPotion;
                    }
                    else if (inventorySpork.Count < 1 )
                    {

                        Console.WriteLine("To few sporks");
                        return inventoryPotion;
                    }
                    else if (inventoryFork.Count < 1)
                    {
                        Console.WriteLine("To few spoons ");
                        return inventoryPotion;

                    }

                }

                Console.WriteLine("Put the ingridens in the correct order to make the right potion");


                for (int i = 0; i < g4.recipe.Length; i++)
                {
                    input = Console.ReadLine();

                    if (input == g4.recipe[i])
                    {

                        Console.WriteLine("Correct");


                    }
                    else if (input != g4.recipe[i])
                    {

                        Console.WriteLine("Wrong");//Lägg till failure finns en chans för explosinon
                        return inventoryPotion;

                    }


                }

                inventoryPotion.Add("Blue potion");
                return inventoryPotion;

            }

            return inventoryPotion;
            
        }
       
    }
}
