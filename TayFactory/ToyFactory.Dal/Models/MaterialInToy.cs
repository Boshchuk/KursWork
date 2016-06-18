using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace ToyFactory.Dal.Models
{
    public class MaterialInToy
    {
        [Key]
        public int MaterialInToyId { get; set; }

      
        
        /// <summary>
        ///  оличество опеределенного материала в игрушке
        /// </summary>
        public int Quentity { get; set; }

        public virtual Material UsedMaterial { get; set; }

        public MaterialInToy(int count, Material usedMaterial)
        {
            UsedMaterial = usedMaterial;
            Quentity = count;
        }
        
    }
}