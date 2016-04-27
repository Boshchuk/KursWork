using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Dal.Repositories.Interfaces
{
    public interface IToyRepository
    {
        IEnumerable<Toy> GetAll();
        Toy GetById(int toyId);

        void Insert(Toy toy);
        void Delete(int toyId);
        void Update(Toy toy);
        void Save();
    }
}