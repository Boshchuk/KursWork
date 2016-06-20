using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ToyFactory.Dal.Models
{
    public sealed class Toy
    {
        [Key]
        [DisplayName("Идентификатор")]
        public int ToyId { get; set; }

        [DisplayName("Артикул")]
        public string Article { get; set; }

        [DisplayName("Название")]
        public string Title { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DisplayName("Используемые материалы")]
        public ICollection<MaterialInToy> MaterialInToy { get; set; }

        public Toy()
        {
            MaterialInToy = new List<MaterialInToy>();
        }


        public override string ToString()
        {
            return string.Format("A.: {0}; T.: {1}; P.:{2}", Article, Title, Price);
        }

        [NotMapped]
        [DisplayName("Используемые материалы")]
        public string UsedMaterials
        {
            get
            {
                var res = string.Empty;

                foreach (var materialInToy in MaterialInToy)
                {
                    res += string.Format("{0} - в количестве: {1}; ", materialInToy.UsedMaterial.Title,
                        materialInToy.Quentity);
                }

                return res;
            }

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Toy))
            {
                return false;
            }
        
            var result = true;

            var compar = (Toy) obj;

            if (this.ToyId != compar.ToyId)
            {
                return false;
            }

            var count = this.MaterialInToy.Count;
            if (count != compar.ToyId)
            {
                return false;
            }
            
            for (int i = 0; i < MaterialInToy.Count; i++)
            {
                if (compar.MaterialInToy != null)
                {
                    var el = compar.MaterialInToy.ToList()[i];

                    if (el != null)
                    {
                        if (MaterialInToy.ToList()[i].Quentity != el.Quentity ||
                            MaterialInToy.ToList()[i].UsedMaterial.MaterialId != el.UsedMaterial.MaterialId)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }

            return result;
        }
    }
}