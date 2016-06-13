using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Business.Controllers.Interfaces
{
    public interface IMaterialsController
    {
        IEnumerable<Material> GetMaterials();

        Material GetMaterialById(int materialId);


        void InsertMaterial(Material material);


        void DeleteMaterial(int materialId);

        void UpdateMaterial(Material material);

    }
}