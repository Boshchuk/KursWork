using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    /// <summary>
    /// Класс педставляющий объект материла в базе данных и в прогармм
    /// </summary>
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        public string Code { get; set; }
        /// <summary>
        /// Название материала
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
    }
}