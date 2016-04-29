using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class Toy
    {
        [Key]
        public int ToyId { get; set; }

        public string Article { get; set; }

        public string Title { get; set; }


        public decimal Price { get; set; }

        public virtual List<Material> UsedMaterials { get; set; }
        // todo: add relations with materials

        public override string ToString()
        {
            return string.Format("A.: {0}; T.: {1}; P.:{2}",Article,Title,Price);
        }
    }
}