using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    /// <summary>
    /// Класс педставляющий объект материла в базе данных и в прогармм
    /// </summary>
    public sealed class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [DisplayName("Код")]
        public string Code { get; set; }

        /// <summary>
        /// Название материала
        /// </summary>
        [DisplayName("Название")]
        public string Title { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        /// <summary>
        /// Список игрушек в которых этот материал используется.
        /// </summary>
        [DisplayName("Используется в игрушках")]
        public ICollection<MaterialInToy> MaterialsInToy { get; set; }
    }
}