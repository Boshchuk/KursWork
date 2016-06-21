using System;
using System.Windows.Forms;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Dal;

namespace ToyFactory.Forms.Production
{
    public partial class ToyProductionForm : Form
    {
        private readonly ToysController _toysController;
        private readonly StockItemsController _stockItemsController;


        public ToyProductionForm(ToyFactoryContext toyFactoryContext )
        {
            InitializeComponent();

            _toysController = new ToysController(toyFactoryContext);
            _stockItemsController = new StockItemsController(toyFactoryContext);

            InitToyAvalibelList();

            InitStockList();
        }

        private void InitStockList()
        {
            dataGridViewProducedToys.DataSource = _stockItemsController.GetAll();
            dataGridViewProducedToys.Columns["StockItemId"].Visible = false;
        }

        private void InitToyAvalibelList()
        {
            dataGridViewToysList.Rows.Clear();
            var list = _toysController.GetAllToys();
            dataGridViewToysList.DataSource = list;
            dataGridViewToysList.Columns["ToyId"].Visible = false;
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            // посчитать игрушки. 
            // если нет - спокойон добавить первую
            // если уже есть. нужно добавить к существующим похожим, 
            // похожая эта в которой используются те же материалы, в том же количестве, при этом цена исходных материалов
            // может отличастья (этот момент лучше уточнить)

            var allStockItmes = _stockItemsController.GetAll();
        }
    }
}
