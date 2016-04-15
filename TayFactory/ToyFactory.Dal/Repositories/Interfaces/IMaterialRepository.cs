using System;
using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Dal.Repositories.Interfaces
{
    public interface IMaterialRepository : IDisposable
    {
        IEnumerable<Material> GetMaterials();
        Material GetMaterialById(int materialId);

        void InsertMaterial(Material material);
        void DeleteMaterial(int materialId);
        void UpdateStudent(Material material);
        void Save();
    }
}