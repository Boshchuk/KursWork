using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    /// <summary>
    /// ����� ������������� ������ �������� � ���� ������ � � ��������
    /// </summary>
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        public string Code { get; set; }
        /// <summary>
        /// �������� ���������
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// ������ ������� � ������� ���� �������� ������������.
        /// </summary>
        public virtual ICollection<MaterialInToy> MaterialsInToy { get; set; }
    }
}