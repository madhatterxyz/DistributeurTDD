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
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Allongé"), Ingredient = _ingredientDomain.Get("Eau"), Quantity = 2},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Capuccino"), Ingredient = _ingredientDomain.Get("Café"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Capuccino"), Ingredient = _ingredientDomain.Get("Chocolat"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Capuccino"), Ingredient = _ingredientDomain.Get("Crème"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Capuccino"), Ingredient = _ingredientDomain.Get("Eau"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Chocolat"), Ingredient = _ingredientDomain.Get("Lait"), Quantity = 2},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Chocolat"), Ingredient = _ingredientDomain.Get("Chocolat"), Quantity = 3},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Chocolat"), Ingredient = _ingredientDomain.Get("Sucre"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Chocolat"), Ingredient = _ingredientDomain.Get("Eau"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Thé"), Ingredient = _ingredientDomain.Get("Thé"), Quantity = 1},
                new RecipeDTO(){ Beverage = _beverageDomain.Get("Thé"), Ingredient = _ingredientDomain.Get("Eau"), Quantity = 2}
            };
        }
        private const double margin = 1.3;
        /// <summary>
        /// Calculate the price of the recipe, including the ingredients + margin
        /// </summary>
        /// <param name="beverageName"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double GetPrice(string beverageName)
        {
            IEnumerable<RecipeDTO> recipes = _recipes.Where(x => x.Beverage.Name.Equals(beverageName));
            if(!recipes.Any())
            {
                throw new NotImplementedException($"The function related to {beverageName} is not implemented yet.");
            }
            return recipes.Sum(x=>x.Quantity*x.Ingredient.UnitPrice)*margin;
        }
    }
}