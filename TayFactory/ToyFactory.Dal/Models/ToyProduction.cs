using System.Collections.Generic;

namespace ToyFactory.Dal.Models
{
    public class ToyProduction
    {
        public int ToyProductionId { get; set; }

        public Toy ConstructedToy { get; set; }

        public virtual List<Material> UsedMaterials { get; set; }
    }
}