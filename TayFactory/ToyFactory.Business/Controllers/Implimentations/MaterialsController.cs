using System.Collections.Generic;
using System.Linq;
using ToyFactory.Business.Controllers.Interfaces;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Business.Controllers.Implimentations
{
    public class MaterialsController : IMaterialsController
    {
        private readonly IMaterialRepository _materialRepository;

        private readonly IToyRepository _toyRepository;

        public MaterialsController(ToyFactoryContext context)
        {
            _materialRepository = new MaterialRepository(context);

            _toyRepository = new ToyRepository(context);
        }


        public IEnumerable<Material> GetMaterials()
        {
            return _materialRepository.GetMaterials();
        }

        public Material GetMaterialById(int materialId)
        {
            return _materialRepository.GetMaterialById(materialId);
        }

        public void InsertMaterial(Material material)
        {
            _materialRepository.InsertMaterial(material);
            _materialRepository.Save();
        }

        public void DeleteMaterial(int materialId)
        {
            //
            var allToys = _toyRepository.GetAll();

            var toysThatUsing = allToys.Where(t => t.UsedMaterials.Select(m => m.MaterialId == materialId).Any());

            if (toysThatUsing.Any())
            {
                // hande cant delete
                throw new ObjectUsedException("Материал где-то используется");
            }
            else
            {
                _materialRepository.DeleteMaterial(materialId);
                _materialRepository.Save();
            }
        }

        public void UpdateMaterial(Material material)
        {
            _materialRepository.UpdateMaterial(material);
            _materialRepository.Save();
        }
    }
}