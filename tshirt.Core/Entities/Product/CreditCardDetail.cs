
namespace tshirt.Core.Entities.Product
{
    public class CreditCardDetail : EntityBase
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public string Number { get; set; }

        public int Cvv { get; set; }

        public string Name { get; set; }
    }
}
