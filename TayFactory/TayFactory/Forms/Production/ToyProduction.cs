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
    public partial class ToyProduction : Form
    {
        private readonly ToyFactoryContext _toyFactoryContext;
        private readonly ToysController _toysController;

        public ToyProduction(ToysController toysController)
        {
            
            InitializeComponent();

            _toysController = toysController;

            _toysController = new ToysController(_toyFactoryContext);
        }

        private void InitToyAvalibelList()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
