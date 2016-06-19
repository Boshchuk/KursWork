using System;
using System.Linq;
using System.Windows.Forms;

using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Business.Controllers.Interfaces;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Toys
{
    public partial class ToysListForm : Form
    {
        // TODO: fix editing first element if selected only cell somewhere

        private readonly IToysController _toysController;
        private readonly MaterialsController _materialController;

        public ToysListForm(ToyFactoryContext toyFactoryContext)
        {
            _toysController = new ToysController(toyFactoryContext);
            _materialController = new MaterialsController(toyFactoryContext);
            InitializeComponent();

            InitToys();
        }

        private void InitToys()
        {
            try
            {
                dataGridView1.MultiSelect = false;
                dataGridView1.DataSource = _toysController.GetAllToys();
                dataGridView1.Columns["ToyId"].Visible = false;
                dataGridView1.Columns["MaterialInToy"].Visible = false;
            }
            catch (CantConnectToDbException ex)
            {
                throw new CantConnectToDbException(ex.Message);
            }
        }

        private Toy GetSelectedToy()
        {
            Toy toy;
            var toys = _toysController.GetAllToys();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = dataGridView1.SelectedRows[0].DataBoundItem as Toy;

                toy = selected != null ? _toysController.GetById(selected.ToyId) : toys.FirstOrDefault();
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
            var allMaterials =  _materialController.GetMaterials();

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
