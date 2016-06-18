using System.Collections.Generic;
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
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Список игрушек в которых этот материал используется.
        /// </summary>
        public virtual ICollection<MaterialInToy> MaterialsInToy { get; set; }
    }
}