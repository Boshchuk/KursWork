using System;
using System.Windows.Forms;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Dal;

namespace ToyFactory.Forms.Production
{
    public partial class ToyProductionForm : Form
    {
        private readonly ToysController _toysController;

        public ToyProductionForm(ToyFactoryContext toyFactoryContext )
        {
            InitializeComponent();

            _toysController = new ToysController(toyFactoryContext);

            InitToyAvalibelList();

            InitStockListHeaders();
        }
        
        private void InitStockListHeaders()
        {
            dataGridViewProducedToys.Columns.Add("Title", "Title");
            dataGridViewProducedToys.Columns.Add("Quentity", "Quentity");
            dataGridViewProducedToys.Columns.Add("Total Price", "Total Price");
        }

        private void InitToyAvalibelList()
        {
            dataGridViewToysList.Rows.Clear();
            var list = _toysController.GetAllToys();
            dataGridViewToysList.DataSource = list;

        }

       

        private void btnProduce_Click(object sender, EventArgs e)
        {

        }
    }
}
