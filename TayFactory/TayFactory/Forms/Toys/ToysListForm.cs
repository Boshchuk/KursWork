using System;
using System.Linq;
using System.Windows.Forms;
using ToyFactory.Business;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Business.Controllers.Interfaces;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Toys
{
    public partial class ToysListForm : Form
    {
        private readonly ToyFactoryContext _toyFactoryContext;
        private readonly IToysController _toysController;

        private void InitToys()
        {
            listBox1.Items.Clear();

            try
            {
                // TODO: add common mechanism here 
                var toys = _toysController.GetAllToys();

                foreach (var toy in toys)
                {
                    listBox1.Items.Add(toy);
                }
            }
            catch (CantConnectToDbException ex)
            {
                throw new CantConnectToDbException(ex.Message);
            }
        }

        public ToysListForm(ToyFactoryContext toyFactoryContext)
        {
            _toyFactoryContext = toyFactoryContext;
            _toysController = new ToysController(toyFactoryContext);
            InitializeComponent();

            InitToys();
        }

        private Toy GetSelectedToy()
        {
            Toy toy;
            var toys = _toysController.GetAllToys();
            if (listBox1.SelectedItems.Count > 0)
            {
                var selected = listBox1.SelectedItems[0];

                if (selected != null)
                {
                    var index = listBox1.SelectedIndices[0];
                    toy = toys.ToList()[index];
                }
                else
                {
                    toy = toys.FirstOrDefault();
                }
            }
            else
            {
                toy = toys.FirstOrDefault();
            }
            return toy;
        }

        /// <summary>
        /// Обрабатывает событие по нажатию на Add Edit кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            // проверяя tag свойство кнопки опеределяем в каком режиме открыть кнопку

            this.Hide();

            var formMode = FormsHelper.GetFormMode(sender);

            var toy = new Toy();

            if (formMode == FormMode.Edit)
            {
                toy = GetSelectedToy();
            }

            // TODO: change to use controller intead
            var allMaterials = _toyFactoryContext.Materials.ToList();

            var addEditToyFormModal = new AddEditToyForm(toy, formMode, allMaterials);

            var result = addEditToyFormModal.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (formMode == FormMode.Add)
                {
                    _toysController.InsertToy(toy);
                }

                InitToys();
            }


            this.Show();
        }

        private void btn_DeleteToy_Click(object sender, EventArgs e)
        {
            var toy = GetSelectedToy();

            if (toy.ToyId != 0)
            {
                _toysController.DeleteToy(toy);
                InitToys();
            }
            
        }
    }
}
