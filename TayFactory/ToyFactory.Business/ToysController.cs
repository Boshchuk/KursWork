using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Business
{
    public class ToysController
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

    }
}
