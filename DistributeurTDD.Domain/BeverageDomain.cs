namespace DistributeurTDD.Domain
{
    public class BeverageDomain
    {
        private const double coffeeUnitPrice = 1.00;
        private const double waterUnitPrice = 0.2;
        private const double margin = 1.3;
        public double GetPrice(string v)
        {
            double price = 0;
            switch(v)
            {
                case "Expresso":
                    price = (coffeeUnitPrice + waterUnitPrice)*margin;
                    break;
                default:break;
            }
            return price;
        }
    }
}