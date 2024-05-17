using FactoryDesignPattern.Credit_Cards;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Monzo");

            if (cardDetails != null)
            {
                Console.WriteLine("Card Type : " + cardDetails.GetCardType());
                Console.WriteLine("Credit Limit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("Annual Charge : " + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.ReadLine();
        }
    }
}
