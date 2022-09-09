using DistributeurTDD.Domain.DTO;

namespace DistributeurTDD.Domain
{
    public class IngredientDomain
    {
        private List<IngredientDTO> _ingredientDTOs { get; set; }
        public IngredientDomain()
        {
            _ingredientDTOs = new List<IngredientDTO>()
            {
                new IngredientDTO() { Id = 1, Name = "Café", UnitPrice = 1.00 },
                new IngredientDTO() { Id = 2, Name = "Eau", UnitPrice = 0.2 },
                new IngredientDTO() { Id = 3, Name = "Chocolat", UnitPrice = 1 },
                new IngredientDTO() { Id = 4, Name = "Crème", UnitPrice = 0.5 },
                new IngredientDTO() { Id = 5, Name = "Thé", UnitPrice = 2 },
                new IngredientDTO() { Id = 6, Name = "Sucre", UnitPrice = 0.1 },
                new IngredientDTO() { Id = 7, Name = "Lait", UnitPrice = 0.4 }
            };
        }
        public List<IngredientDTO> GetAll()
        {
            return _ingredientDTOs;
        }
        public IngredientDTO Get(string name)
        {
            return _ingredientDTOs.FirstOrDefault(x => x.Name == name);
        }
    }
}
