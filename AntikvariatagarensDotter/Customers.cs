using System.Collections.Generic;
using System;

namespace AntikvariatagarensDotter
{
    public class Customers
    {
        public int money = 0;
        private int interest = 0;
        private bool ownsBook;
        private int amountOfBooksOwned = 0;
        private List<string> booksOwned = new List<string>();
        Random generator = new Random();

//Här ska listan med böcker som finns tas in
    public Customers(List<string> book)
    {
        //Värdet är satt på 200 så att kunderna ska kunna ha mer pengar än högsta priset på en bok
        //Så att de eventuellt ska kunna köpa flera böcker.
        money = generator.Next(200);
        //Det finns 5 kategorier av böcker, den som slumpas fram är den kategori kunden inte är 
        //Intreserad av.
        interest = generator.Next(5);
        //Slumpar fram hur många böcker man eventuellt äger, satt på 4 så att man inte kan äga alla böcker
        amountOfBooksOwned = generator.Next(4);
        for (int i = 0; i < amountOfBooksOwned; i++)
        {
            booksOwned.Add(book[generator.Next(5)]);
        }
        }
        //Metoden funkar ej då den säger att i++ inte går att nå, hinner ej fixa det.
    // public bool OwnsBook(string book)
    // {
    //     for (int i = 0; i < amountOfBooksOwned; i++)
    //     {
    //         if (book == booksOwned[i])
    //         {
    //             return true;
    //         }
    //         else
    //         {
    //             return false;
    //         }
    //     }
    // }
    }
}
