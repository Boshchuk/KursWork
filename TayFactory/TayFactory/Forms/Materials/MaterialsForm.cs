using System;
using System.Linq;
using System.Windows.Forms;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Materials
{
    public partial class MaterialsForm : Form
    {
        //private readonly MaterialRepository materialRepository;

        private readonly MaterialsController _materialsController;

        public MaterialsForm(MaterialsController materialsController)
        {
            _materialsController = materialsController;
        
            InitializeComponent();

            InitHeaders();
            SettupEvents();

            SettupDataSource();
            InsertDataFromRepository();
        }

        private void SettupDataSource()
        {
            // dataGridView1.DataSource = new dataSou
            //this.dataGridView1.Rows.Add("five", "six", "seven", "eight");
            //this.dataGridView1.Rows.Insert(0, "one", "two", "three", "four");
        }

        private void InsertDataFromRepository()
        {
            this.dataGridView1.Rows.Clear();

            var materials = _materialsController.GetMaterials();

            foreach (var material in materials)
            {
                this.dataGridView1.Rows.Add(material.Code, material.Title, material.Price);
            }
        }

        private void SettupEvents()
        {
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.RowLeave += DataGridView1_RowLeave;
        }

        private void DataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //btnEditMaterial.Enabled = false;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnEditMaterial.Enabled = true;
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!e.Row.IsNewRow)
            {
                // TODO: move to helper
                var response = MessageBox.Show("Are you sure?", "Delete row?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2);

                if (response == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    var material = GetSelectedMaterial();

                    try {
                        _materialsController.DeleteMaterial(material.MaterialId);
                    }
                    catch(Exception ex)
                    {
                        // TODO: add error handling
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void InitHeaders()
        {
            dataGridView1.Columns.Add("Code", "Code");
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Price", "Price");
        }

        private Material GetSelectedMaterial()
        {
            Material material;
            var materials = _materialsController.GetMaterials();
            // init material as existed one
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = dataGridView1.SelectedRows[0];

                if (selected != null)
                {
                    var index = selected.Index;
                    material = materials.ToList()[index];
                }
                else
                {
                    material = materials.FirstOrDefault();
                }
            }
            else
            {
                material = materials.FirstOrDefault();
            }

            return material;
        }

        private void btnShowAddNewMaterialForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            var formMode = FormsHelper.GetFormMode(sender);

            var material = new Material();

            if (formMode == FormMode.Edit)
            {
                material = GetSelectedMaterial();
            }

            var addEditModal = new AddEditMaterialForm(material, formMode);

            var result = addEditModal.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (formMode == FormMode.Add)
                {
                    _materialsController.InsertMaterial(material);
                }
                else
                {
                    _materialsController.UpdateMaterial(material);
                }
                
                
                InsertDataFromRepository();
            }

            this.Show();
        }
    }
}
