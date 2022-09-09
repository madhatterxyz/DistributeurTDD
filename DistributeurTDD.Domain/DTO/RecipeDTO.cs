namespace DistributeurTDD.Domain.DTO
{
    public class RecipeDTO
    {
        public IngredientDTO Ingredient { get; set; }
        public int Quantity { get; set; } = 0;
        public BeverageDTO  Beverage { get; set; }
    }
}
