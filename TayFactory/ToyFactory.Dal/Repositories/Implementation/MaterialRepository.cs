using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Dal.Repositories.Implementation
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly ToyFactoryContext context;

        public MaterialRepository(ToyFactoryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Material> GetMaterials()
        {
            return context.Materials.ToList();
        }

        public Material GetMaterialById(int materialId)
        {
            return context.Materials.Find(materialId);
        }

        public void InsertMaterial(Material material)
        {
            context.Materials.Add(material);
        }

        public void DeleteMaterial(int materialId)
        {
            var material = context.Materials.Find(materialId);
            context.Materials.Remove(material);
        }

        public void UpdateStudent(Material material)
        {
            context.Entry(material).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #region IDisposible

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}