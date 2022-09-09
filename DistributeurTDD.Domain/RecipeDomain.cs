using DistributeurTDD.Domain.DTO;

namespace DistributeurTDD.Domain
{
    public class RecipeDomain
    {
        private readonly IngredientDomain _ingredientDomain;
        private readonly BeverageDomain _beverageDomain;
        private List<RecipeDTO> _recipes { get; set; }
        public RecipeDomain()
        {
            _ingredientDomain = new IngredientDomain();
            _beverageDomain = new BeverageDomain();
            _recipes = new List<RecipeDTO>()
            {
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Expresso"), Ingredient = _ingredientDomain.Get("Café"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Expresso"), Ingredient = _ingredientDomain.Get("Eau"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Allongé"), Ingredient = _ingredientDomain.Get("Café"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Allongé"), Ingredient = _ingredientDomain.Get("Eau"), Quantity = 2}
            };
        }
        private const double margin = 1.3;
        public double GetPrice(string v)
        {
            IEnumerable<RecipeDTO> recipes = _recipes.Where(x => x.Beverage.Name.Equals(v));
            if(!recipes.Any())
            {
                throw new NotImplementedException($"The function related to {v} is not implemented yet.");
            }
            return recipes.Sum(x=>x.Quantity*x.Ingredient.UnitPrice)*margin;
        }
    }
}