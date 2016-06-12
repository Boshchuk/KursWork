using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Business.Controllers.Interfaces
{
    public interface IToysController
    {
        void InsertToy(Toy toy);

        IEnumerable<Toy> GetAllToys();

        void DeleteToy(Toy toy);
    }
}
