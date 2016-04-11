using System.Collections.Generic;

namespace ToyFactory.Dal
{
    public class ToyProduction
    {
        public int ToyProductionId { get; set; }

        public Toy ConstructedToy { get; set; }

        public List<Material> UsedMaterials { get; set; }
    }
}