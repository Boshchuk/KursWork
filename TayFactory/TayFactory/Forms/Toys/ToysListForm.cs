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

namespace ToyFactory.Forms.Toys
{
    public partial class ToysListForm : Form
    {
        private ToysController _toysController;

        private void InitFakeToys()
        {


            listBox1.Items.Clear();

            listBox1.Items.Add("test");

            try
            {
                var toys = _toysController.GetAllToys();

                foreach (var toy in toys)
                {
                    listBox1.Items.Add(toy);
                }
            }
            catch (CantConnectToDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        public ToysListForm(ToyFactoryContext toyFactoryContext)
        {
            _toysController = new ToysController(toyFactoryContext);
            InitializeComponent();

            InitFakeToys();
        }
    }
}
