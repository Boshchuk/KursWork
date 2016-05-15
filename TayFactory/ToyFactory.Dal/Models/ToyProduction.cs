using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class ToyProduction
    {
        [Key]
        public int ToyProductionId { get; set; }

        public Toy ConstructedToy { get; set; }

        public virtual List<Material> UsedMaterials { get; set; }
    }
}