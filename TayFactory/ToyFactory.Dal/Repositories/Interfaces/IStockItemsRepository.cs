using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Dal.Repositories.Interfaces
{
    public interface IStockItemsRepository
    {
        IList<StockItem> GetAllItems();

    }
}