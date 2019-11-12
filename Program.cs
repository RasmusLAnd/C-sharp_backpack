using System;
using System.Collections;

namespace C_sharp_backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            int valg;
            string newItem, backPack="";

            do{
            Console.WriteLine("Welcome to the Packpack!");
            Console.WriteLine("Add an item     - press 1");
            Console.WriteLine("See all items   - press 2");
            Console.WriteLine("Clear all items - press 3");
            Console.WriteLine("End Program     - press 9");

            int.TryParse(Console.ReadLine(), out valg);
            

            switch (valg)
            {
                case 1:
                Console.WriteLine("What do you want to add?");
                newItem = Console.ReadLine();
                backPack =backPack+ " "+ newItem;
                break;

                case 2:
                Console.WriteLine("Your backpack contains:");
                Console.WriteLine(backPack);
                break;

                case 3:

                string confirm;
                Console.WriteLine("Are You SURE??? (Y/N)");
                confirm = Console.ReadLine().ToUpper();
                if (confirm == "Y"){
                    backPack ="";
                }
                break;

                default:
                break;
            }
        }while (valg !=9);
        Console.ReadKey();

        // second part

        int valg2;

            string newItem2;
            int countLength;

            Stack mybackPack = new Stack(); 

            do{
            Console.WriteLine("Welcome to the Packpack!");
            Console.WriteLine("Add an item     - press 1");
            Console.WriteLine("See all items   - press 2");
            Console.WriteLine("Clear all items - press 3");
            Console.WriteLine("End Program     - press 9");

            int.TryParse(Console.ReadLine(), out valg2);
            

            switch (valg2)
            {
                case 1:
                Console.WriteLine("What do you want to add?");
                countLength = mybackPack.Count;
                if (countLength>5){
                    mybackPack.Pop();
                }
                newItem2 = Console.ReadLine();
                mybackPack.Push(newItem2);
                
                
                break;

                case 2:
                Console.WriteLine("Your backpack contains:"); 
                foreach(string element in mybackPack){
                        Console.WriteLine(element);
                }      
                break;

                case 3:

                string confirm;
                Console.WriteLine("Are You SURE??? (Y/N)");
                confirm = Console.ReadLine().ToUpper();
                if (confirm == "Y"){
                   mybackPack.Clear();
                }
                break;

                default:
                break;
            }
        }while (valg2 !=9);
    }
    }
}
