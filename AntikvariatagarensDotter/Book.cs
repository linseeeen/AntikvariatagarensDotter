using System.Xml;
using System.Collections.Generic;
using System;

namespace AntikvariatagarensDotter
{
    public class Book
    {
        public int price = 0;
        private string name = "";
        private int rarity = 0;
        private string category = "";
        private int actualValue = 0;
        private bool cursed;
        private Random generator = new Random();
        public string[] nameArray = {"bok1", "bok2", "bok3", "bok4", "bok5"};
        private string[] categoryArray = {"kat1", "kat2", "kat3", "kat4", "kat5"};
        
        public Book()
        {
            //Jag valde 100 som maxvärde för att inte slumpa fram absurt höga värden
            actualValue = generator.Next(100);
            rarity = generator.Next(100);
            if (generator.Next(2) == 1)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }
            name = nameArray[generator.Next(5)];
            category = categoryArray[generator.Next(5)];
        }
        public void PrintInfo()
        {
            Console.WriteLine("Bokens namn är: " + name);
            Console.WriteLine("Bokens rarity är: " + rarity);
            Console.WriteLine("Bokens kategori är: " + category);
            Console.WriteLine("Boken kostar: " + price + " kr.");
        }
        public int Evaluate()
        {
            price = actualValue * rarity;
            //Jag är osäker på hur jag får prick 50% och prick 150% så det fick bli ca 50% och 200%
            price = generator.Next(price / 2, price * 2);
            return price;
        }
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public bool IsCursed()
        {
            if (cursed == true && generator.Next(10) < 9 || cursed == false && generator.Next(10) < 9)
            {
                Console.WriteLine("rätt");
                return true;
            }
            else
            {
                Console.WriteLine("fel");
                return false;
            }
        }

    }
}
