using DistributeurTDD.Domain.DTO;

namespace DistributeurTDD.Domain
{
    public class BeverageDomain
    {
        private List<BeverageDTO> _BeverageDTOs { get; set; }
        public BeverageDomain()
        {
            _BeverageDTOs = new List<BeverageDTO>()
            {
                new BeverageDTO() { Id = 1, Name = "Expresso" },
                new BeverageDTO() { Id = 2, Name = "Allongé" },
                new BeverageDTO() { Id = 3, Name = "Capuccino" },
                new BeverageDTO() { Id = 4, Name = "Chocolat" },
                new BeverageDTO() { Id = 5, Name = "Thé" }
            };
        }
        public List<BeverageDTO> GetAll()
        {
            return _BeverageDTOs;
        }
        public BeverageDTO Get(string name)
        {
            return _BeverageDTOs.FirstOrDefault(x => x.Name == name);
        }
    }
}
