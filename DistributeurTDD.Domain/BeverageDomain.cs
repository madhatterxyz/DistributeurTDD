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
                new BeverageDTO() { Id = 2, Name = "Allongé" }
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
