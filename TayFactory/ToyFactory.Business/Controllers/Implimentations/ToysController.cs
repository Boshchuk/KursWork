using System.Collections.Generic;
using System.Linq;
using ToyFactory.Business.Controllers.Interfaces;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Business.Controllers.Implimentations
{
    public class ToysController : IToysController
    {
        private readonly IMaterialRepository _materialRepository;

        private readonly IToyRepository _toyRepository;

        public ToysController(ToyFactoryContext context)
        {
            _materialRepository = new MaterialRepository(context);
            _toyRepository = new ToyRepository(context);
        }

        public IEnumerable<Toy> GetAllToys()
        {
            return _toyRepository.GetAll().ToList();
        }

        public Toy GetById(int id)
        {
            return _toyRepository.GetById(id);
        }

        public void InsertToy(Toy toy)
        {
            _toyRepository.Insert(toy);
            _toyRepository.Save();
        }

        public void UpdateToy(Toy toy)
        {
            _toyRepository.Update(toy);
            _toyRepository.Save();  // TODO: check is this needed
        }

        public void DeleteToy(Toy toy)
        {
            _toyRepository.Delete(toy.ToyId);
            _toyRepository.Save();
        }

    }
}
