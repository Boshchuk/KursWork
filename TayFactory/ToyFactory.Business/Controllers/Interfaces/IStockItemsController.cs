using System.Collections.Generic;
using ToyFactory.Dal.Models;

namespace ToyFactory.Business.Controllers.Interfaces
{
    public interface IStockItemsController
    {
        IList<StockItem> GetAll();

        /// <summary>
        /// Должно располагать игрушку на складе без лишних проверок
        /// </summary>
        void SimpleInsertInStock(Toy toy, int count);
    }
}