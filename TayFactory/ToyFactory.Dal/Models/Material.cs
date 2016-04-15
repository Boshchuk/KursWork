using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}