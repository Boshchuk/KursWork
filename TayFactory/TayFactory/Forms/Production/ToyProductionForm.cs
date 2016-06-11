using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyFactory.Business;
using ToyFactory.Dal;

namespace ToyFactory.Forms.Production
{
    public partial class ToyProductionForm : Form
    {
        private readonly ToyFactoryContext _toyFactoryContext;
        private readonly ToysController _toysController;

        public ToyProductionForm(ToyFactoryContext toyFactoryContext )
        {
            _toyFactoryContext = toyFactoryContext;

            InitializeComponent();
          

            _toysController = new ToysController(toyFactoryContext);

            InitToyListHeaders();
            InitToyAvalibelList();

            InitStockListHeaders();
        }

        private void InitToyListHeaders()
        {
            dataGridViewToysList.Columns.Add("Article", "Article");
            dataGridViewToysList.Columns.Add("Title", "Title");
            dataGridViewToysList.Columns.Add("Price", "Price");
        }

        private void InitStockListHeaders()
        {
            dataGridViewProducedToys.Columns.Add("Title", "Title");
            dataGridViewProducedToys.Columns.Add("Count", "Count");
            dataGridViewProducedToys.Columns.Add("Total Price", "Total Price");
        }

        private void InitToyAvalibelList()
        {
            dataGridViewToysList.Rows.Clear();
            var list = _toysController.GetAllToys();
            foreach (var toy in list)
            {
                dataGridViewToysList.Rows.Add(toy.Article, toy.Title, toy.Price);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
