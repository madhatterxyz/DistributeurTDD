using DistributeurTDD.Domain.DTO;

namespace DistributeurTDD.Domain
{
    public class BeverageDomain
    {
        private readonly IngredientDomain _ingredientDomain;
        public BeverageDomain()
        {
            _ingredientDomain = new IngredientDomain();
        }
        private const double margin = 1.3;
        public double GetPrice(string v)
        {
            double price = 0;
            switch(v)
            {
                case "Expresso":
                    IngredientDTO cafe = _ingredientDomain.Get("Café");
                    IngredientDTO eau = _ingredientDomain.Get("Eau");
                    price = (cafe.UnitPrice + eau.UnitPrice)*margin;
                    break;
                default:break;
            }
            return price;
        }
    }
}