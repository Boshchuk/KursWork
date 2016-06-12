using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class StockItem
    {
        [Key]
        public int StockItemId { get; set; }

        public Toy BaseToy { get; set; }

        /// <summary>
        /// Count in group
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Group Price
        /// </summary>
        public decimal Price { get; set; }
    }
}