using System.Net.Http.Headers;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ICreditCard cardDetails = CreditCardFactory.GetCreditCard("HDFC");
            //if (cardDetails != null)
            //{
            //    Console.WriteLine("CardType : " + cardDetails.GetCardType());
            //    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            //    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}

            IGeometryFactory geometryFactory = GeometryFactory.GetGeometry("Hexagon");
            if (geometryFactory != null)
            {
                Console.WriteLine("Shape : " + geometryFactory.Draw());
            }
            Console.WriteLine("\t\n");

            Console.WriteLine("Enter a database Type");
            string type=Console.ReadLine();

            IDataBaseFactory dataBaseFactory = DataBaseFactory.GetBaseFactory(type);
            //dataBaseFactory.GetType();
            if (dataBaseFactory != null)
            {
                Console.WriteLine("Database : " + dataBaseFactory.DatabaseType());
            }

        }
    }
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
    public class IDFC : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "IDFC";
        }

        public int GetCreditLimit()
        {
            return 10000;
        }
    }
    public class HDFC : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "HDFC";
        }

        public int GetCreditLimit()
        {
            return 150000;
        }
    }
    public class CreditCardFactory
    {

        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard _creditCard;
            if(cardType == "MoneyBack")
            {
                _creditCard= new MoneyBack();
            }
            else if(cardType == "IDFC")
            {
                _creditCard= new IDFC();
            }
            else if (cardType =="HDFC")
            {
                _creditCard = new HDFC();
            }
            else
            {
                throw new CannotUnloadAppDomainException();
            }
           return _creditCard;
        }


    }
}
