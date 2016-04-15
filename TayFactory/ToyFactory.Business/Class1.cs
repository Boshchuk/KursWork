using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;

namespace ToyFactory.Business
{
    public class MaterialsList : IList<Material>
    {
        private MaterialRepository repository;

        public MaterialsList(MaterialRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerator<Material> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Material item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Material item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Material[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Material item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(Material item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Material item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public Material this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
