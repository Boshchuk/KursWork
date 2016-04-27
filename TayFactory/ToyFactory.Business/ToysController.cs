using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyFactory.Dal;
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


    }
}
