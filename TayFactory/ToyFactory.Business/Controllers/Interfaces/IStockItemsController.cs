using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Business.Controllers.Interfaces
{
    public interface IStockItemsController
    {
        IList<StockItem> GetAll();
    }
}