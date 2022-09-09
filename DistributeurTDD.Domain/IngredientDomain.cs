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
                new IngredientDTO() { Id = 2, Name = "Eau", UnitPrice = 0.2 }
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
