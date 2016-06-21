using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal.Models
{
    /// <summary>
    /// ����� ������������� ������ �������� � ���� ������ � � ��������
    /// </summary>
    public sealed class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [DisplayName("���")]
        public string Code { get; set; }

        /// <summary>
        /// �������� ���������
        /// </summary>
        [DisplayName("��������")]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("����")]
        public decimal Price { get; set; }

        /// <summary>
        /// ������ ������� � ������� ���� �������� ������������.
        /// </summary>
        [DisplayName("������������ � ��������")]
        public ICollection<MaterialInToy> MaterialsInToy { get; set; }
    }
}