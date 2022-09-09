using DistributeurTDD.Domain.DTO;

namespace DistributeurTDD.Domain
{
    public class BeverageDomain
    {
        private IngredientDTO cafe = new IngredientDTO() { Id = 1, Name = "Café", UnitPrice = 1.00 };
        private IngredientDTO eau = new IngredientDTO() { Id = 2, Name = "Eau", UnitPrice = 0.2 };
        private const double margin = 1.3;
        public double GetPrice(string v)
        {
            double price = 0;
            switch(v)
            {
                case "Expresso":
                    price = (cafe.UnitPrice + eau.UnitPrice)*margin;
                    break;
                default:break;
            }
            return price;
        }
    }
}