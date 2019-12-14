using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace november_projekt
{
    class Shopkeeper
    {
        Stronk strongPotion = new Stronk();//Här skapas insantser av de olika potionen
        Speed speedPotion = new Speed();
        Healing healingPotion = new Healing();
        Blue bluePotion = new Blue();
      

        public List<string> inventoryKnife = new List<string>();// Här kommer antal knivar, skedar, gafflar, sporks och cursed items som spelaren har vara
        public List<string> inventorySpoon = new List<string>();
        public List<string> inventoryFork = new List<string>();
        public List<string> inventorySpork = new List<string>();
        public List<string> cursedItem = new List<string>();
        public int money = 500;// Detta är antal pengar som spelaren har
        
        public List<string> inventoryPotion = new List<string>();
   


        public void CheckPotion( List<string> inventoryPotion)
        {

            Console.WriteLine("You have this much in your stock");

            for (int i = 0; i < inventoryPotion.Count; i++)
            {


                Console.WriteLine(inventoryPotion[i]);


            }


        


        }// Denna metod visar vad spelaren har för potions gjorda
        public void CheckInventory(List<string> inventoryKnife,List<string> inventorySpoon, List<string> inventoryFork, List<string> inventorySpork)
        { //Denna kollar vad man har i sin inventory

           
            Console.WriteLine("You have this much in your stock");
            Console.WriteLine(inventorySpoon.Count + " spoons");
            Console.WriteLine(inventoryKnife.Count + " knifes");
            Console.WriteLine(inventoryFork.Count + " forks");
            Console.WriteLine(inventorySpork.Count + " sporks");
            for (int i = 0; i < cursedItem.Count; i++)
            {

                Console.WriteLine(cursedItem[i]);

            }
            Console.WriteLine(money);



        }//Denna metod talar om vad för ingredienser som spelarn köpt men som hen inte har använt
         //dubbel kolla med stonk potion och så vidare
        public List<string> MakePotions(string[] recipe, List<string> inventorySpoon, List<string> inventoryFork, List<string> inventorySpork, List<string> inventoryKnife, List<string> inventoryStronk)//Denna metod kollar om spelaren har rätt ingredienser för att göra en potion
            //Om inte måste den gå och köpa rätt ingrdienser. Om spelaren har alla måste hen sätta in ingredienserna i rätt ordning för att få fram en potion, om hen inte lyckas måste hen göra om det
        {

            Console.WriteLine("What potion would you like to make");
            Console.WriteLine("Write either stronk, healing, speed or blue!");

            string input = Console.ReadLine();

            if (input == "stronk")
            {


                if (inventoryKnife.Count < 2 || inventorySpork.Count < 1)//Kollar om man har tillräckligt med ingredienser för att göra sin potion
                {
                    if (inventorySpork.Count < 1)
                    {

                        Console.WriteLine("You have to few sporks to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventorySpork.Count < 1 && inventoryKnife.Count < 2)
                    {

                        Console.WriteLine("You have to few knifes and sporks to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventoryKnife.Count < 2)
                    {
                        Console.WriteLine("You have to few knifes to make this potion");
                        return inventoryPotion;

                    }

                }
                


                Console.WriteLine("Put the correct ingridenses in the correct order to make the right potion!");
                Console.WriteLine("Write either spoon, spork, fork or knife");
                Console.WriteLine("You can check out recipes in the  check out potion option on the menu");

                

                if (inventoryKnife.Count >= 2 && inventoryKnife.Count >= 1) {
                    for (int i = 0; i < strongPotion.recipe.Length; i++)
                    {

                        input = Console.ReadLine();
                        if (input == strongPotion.recipe[i])//Är ens input samma som i receptet så kommer man gå vidare tills man skrivit alla rätt
                        {

                            Console.WriteLine("That is correct! Continue");


                        }
                        else if (input != strongPotion.recipe[i])//Är ens input INTE samma som i receptet så kommer man INTE gå vidare och man måste göra om tills man gör rätt
                        {

                            Console.WriteLine("The potion fails but you manage to retrive the ingrideenses, did you write the right ingridiens? Or did you have the order wrong?");//Lägg till failure finns en chans för explosinon
                            return inventoryPotion;

                        }


                    }

                    inventoryPotion.Add("stronk potion");//En ny potion kommer läggas in i spelarens inventory
                    inventoryKnife.RemoveAt(0);//Antalet ingredienser som man använt kommer att försvinna
                    inventoryKnife.RemoveAt(0);
                    inventorySpork.RemoveAt(0);
                    return inventoryPotion;


                }
            }
            else if (input == "speed")
            {

                if (inventoryKnife.Count < 1 || inventorySpoon.Count < 2)
                {
                    if (inventoryKnife.Count < 1)
                    {

                        Console.WriteLine("You have to few knife to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventoryKnife.Count < 1 && inventorySpoon.Count < 2)
                    {

                        Console.WriteLine("You have to few spoons and knifes to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventorySpoon.Count < 2)
                    {
                        Console.WriteLine("You have to few spoons to make this potion");
                        return inventoryPotion;

                    }

                }
                   
                Console.WriteLine("Put the correct ingridenses in the correct order to make the right potion!");
                Console.WriteLine("Write either spoon, spork, fork or knife");
                Console.WriteLine("You can check out recipes in the  check out potion option on the menu");


                for (int i = 0; i < speedPotion.recipe.Length; i++)
                {
                    input = Console.ReadLine();

                    if (input == speedPotion.recipe[i])
                    {

                        Console.WriteLine("Correct");


                    }
                    else if (input != speedPotion.recipe[i])
                    {

                        Console.WriteLine("The potion fails but you manage to retrive the ingrideenses, did you write the right ingridiens ? Or did you have the order wrong ?");//Lägg till failure finns en chans för explosinon
                        return inventoryPotion;

                    }


                }

                inventoryPotion.Add("speed potion");
                inventorySpoon.RemoveAt(0);
                inventorySpoon.RemoveAt(0);
                inventoryKnife.RemoveAt(0);
                return inventoryPotion;

            }
            else if (input == "healing")
            {

                if (inventoryFork.Count < 1 || inventorySpoon.Count < 2)
                {
                    if (inventoryFork.Count < 1)
                    {

                        Console.WriteLine("You have to few forks to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventoryFork.Count < 1 && inventorySpoon.Count < 2)
                    {

                        Console.WriteLine("You have to few knifes and spoons to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventorySpoon.Count < 2)
                    {
                        Console.WriteLine("You have to few spoons to make this potion");
                        return inventoryPotion;

                    }

                }

                Console.WriteLine("Put the correct ingridenses in the correct order to make the right potion!");
                Console.WriteLine("Write either spoon, spork, fork or knife");
                Console.WriteLine("You can check out recipes in the  check out potion option on the menu");


                for (int i = 0; i < healingPotion.recipe.Length; i++)
                {
                    input = Console.ReadLine();

                    if (input == healingPotion.recipe[i])
                    {

                        Console.WriteLine("Correct");


                    }
                    else if (input != healingPotion.recipe[i])
                    {

                        Console.WriteLine("The potion fails but you manage to retrive the ingrideenses, did you write the right ingridiens ? Or did you have the order wrong ?");//Lägg till failure finns en chans för explosinon
                        return inventoryPotion;

                    }


                }

                inventoryPotion.Add("healing potion");
                inventorySpoon.RemoveAt(0);
                inventorySpoon.RemoveAt(0);
                inventoryFork.RemoveAt(0);
                return inventoryPotion;


            }
            else if (input == "blue") 
            {

                if (inventoryKnife.Count < 1 || inventorySpork.Count < 1 || inventoryFork.Count < 1 )
                {
                    if (inventoryKnife.Count < 1)
                    {

                        Console.WriteLine("You have to few knifes to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventorySpork.Count < 1 )
                    {

                        Console.WriteLine("You have to few sporks to make this potion");
                        return inventoryPotion;
                    }
                    else if (inventoryFork.Count < 1)
                    {
                        Console.WriteLine(" You have to few forks to make this potion");
                        return inventoryPotion;

                    }

                }

                Console.WriteLine("Put the correct ingridenses in the correct order to make the right potion!");
                Console.WriteLine("Write either spoon, spork, fork or knife");
                Console.WriteLine("You can check out recipes in the  check out potion option on the menu");


                for (int i = 0; i < bluePotion.recipe.Length; i++)
                {
                    input = Console.ReadLine();

                    if (input == bluePotion.recipe[i])
                    {

                        Console.WriteLine("Correct");


                    }
                    else if (input != bluePotion.recipe[i])
                    {

                        Console.WriteLine("The potion fails but you manage to retrive the ingrideenses, did you write the right ingridiens ? Or did you have the order wrong ?");//Lägg till failure finns en chans för explosinon
                        return inventoryPotion;

                    }


                }

                inventoryPotion.Add("Blue potion");
                inventoryKnife.RemoveAt(0);
                inventoryFork.RemoveAt(0);
                inventorySpork.RemoveAt(0);

                return inventoryPotion;

            }

            return inventoryPotion;
            
        }
       
    }
}
