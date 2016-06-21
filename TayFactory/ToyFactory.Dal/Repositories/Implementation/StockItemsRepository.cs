using System.Collections.Generic;
using System.Linq;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Dal.Repositories.Implementation
{
    public class StockItemsRepository : IStockItemsRepository
    {
        private readonly ToyFactoryContext _context;

        public StockItemsRepository(ToyFactoryContext context)
        {
            _context = context;
        }

        public IList<StockItem> GetAllItems()
        {
            return _context.StockItems.ToList();
        }

        public void Insert(Toy toy, int count)
        {
            var stockItem = new StockItem()
            {
                Count = count, Price = toy.Price*count, BaseToy = toy
            };

            _context.StockItems.Add(stockItem);
            _context.SaveChanges();
        }
    }
}