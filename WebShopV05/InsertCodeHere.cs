using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            Console.WriteLine("Write how many books you would like to buy");
            int noOfBooksInOrder = int.Parse(Console.ReadLine());
            Console.WriteLine("Write how many DvDs you would like to buy");
            int noOfDVDsInOrder = int.Parse(Console.ReadLine());
            Console.WriteLine("Write how many Games you would like to buy");
            int noOfGamesInOrder = int.Parse(Console.ReadLine());

            double bookPriceTotal = netPriceBook * noOfBooksInOrder;
            double dvdPriceTotal = netPriceDVD * noOfDVDsInOrder;
            double gamePriceTotal = netPriceGame * noOfGamesInOrder;
            int shippingPrice = 49;
            double creditFee = 1.02;
            double taxFee = 1.10;

            double totalPrice = ((((bookPriceTotal + dvdPriceTotal + gamePriceTotal) * taxFee) + shippingPrice) * creditFee); // This variable should contain the total price for the order

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}