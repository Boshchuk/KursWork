using System;
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
        private readonly ToyFactoryContext _context;

        private readonly IMaterialRepository _materialRepository;

        private readonly IToyRepository _toyRepository;

        public ToysController()
        {
            _context = new ToyFactoryContext();

            _materialRepository = new MaterialRepository(_context);
            _toyRepository = new ToyRepository(_context);

        }

        public ToysController(ToyFactoryContext context)
        {
            _context = context;

            _materialRepository = new MaterialRepository(_context);
            _toyRepository = new ToyRepository(_context);
        }

        public IEnumerable<Toy> GetAllToys()
        {
            return _toyRepository.GetAll().ToList();
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

    public class ObjectUsedException : Exception
    {
        public ObjectUsedException(string message) : base(message)
        {

        }
    }
}
