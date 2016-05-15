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
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Toys
{
    public partial class ToysListForm : Form
    {
        private readonly ToyFactoryContext _toyFactoryContext;
        private ToysController _toysController;

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
    }
}
