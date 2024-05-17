using FactoryDesignPattern.Credit_Cards;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hardcording the card type
            string cardType = "Monzo";

            ICreditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Monzo")
            {
                cardDetails = new Monzo();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            if (cardDetails != null)
            {
                Console.WriteLine("CardType: " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
                Console.WriteLine("ANnualCharge: " + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.ReadLine();
        }
    }
}
