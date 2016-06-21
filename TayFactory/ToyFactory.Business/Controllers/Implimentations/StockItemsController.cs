using System.Collections.Generic;
using ToyFactory.Business.Controllers.Interfaces;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Business.Controllers.Implimentations
{
    public class StockItemsController : IStockItemsController
    {
        private readonly IStockItemsRepository _itemsRepository;

        public StockItemsController(ToyFactoryContext context)
        {
            _itemsRepository = new StockItemsRepository(context);
        }

        public IList<StockItem> GetAll()
        {
            return _itemsRepository.GetAllItems();
        }

        public void SimpleInsertInStock(Toy toy, int count)
        {
            _itemsRepository.Insert(toy, count);
        }
    }
}