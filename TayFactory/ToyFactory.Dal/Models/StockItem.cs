using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    public class StockItem
    {
        [Key]
        public int StockItemId { get; set; }

        [DisplayName("�������")]
        public Toy BaseToy { get; set; }

        /// <summary>
        /// Quentity in group
        /// </summary>
        [DisplayName("���������� �� ����� ����������")]
        public int Count { get; set; }

        /// <summary>
        /// Group Price
        /// </summary>
       
        public decimal Price { get; set; }
    }
}