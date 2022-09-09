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
            IngredientDTO cafe = _ingredientDomain.Get("Café");
            IngredientDTO eau = _ingredientDomain.Get("Eau");
            switch (v)
            {
                case "Expresso":
                    price = (cafe.UnitPrice + eau.UnitPrice) * margin;
                    break;
                case "Allongé":
                    price = (cafe.UnitPrice + 2 * eau.UnitPrice) * margin;
                    break;
                default: break;
            }
            return price;
        }
    }
}