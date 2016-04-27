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
        private readonly ToyFactoryContext _context;

        public MaterialRepository(ToyFactoryContext context)
        {
            this._context = context;
        }

        public IEnumerable<Material> GetMaterials()
        {
            return _context.Materials.ToList();
        }

        public Material GetMaterialById(int materialId)
        {
            return _context.Materials.Find(materialId);
        }

        public void InsertMaterial(Material material)
        {
            _context.Materials.Add(material);
        }

        public void DeleteMaterial(int materialId)
        {
            var material = _context.Materials.Find(materialId);
            _context.Materials.Remove(material);
        }

        public void UpdateMaterial(Material material)
        {
            _context.Entry(material).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #region IDisposible

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}