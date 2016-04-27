using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyFactory.Dal;
using ToyFactory.Dal.Repositories.Implementation;

namespace ToyFactory.Business
{
    public class ToysController
    {
        private readonly ToyFactoryContext _context;

        private readonly MaterialRepository _materialRepository;

        private readonly 

        public ToysController()
        {
            _context = new ToyFactoryContext();
        }

        public ToysController(ToyFactoryContext context)
        {
            _context = context;
        }


    }
}
