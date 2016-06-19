using System;
using System.Linq;
using System.Windows.Forms;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Materials
{
    public partial class MaterialsForm : Form
    {
        private readonly MaterialsController _materialsController;

        public MaterialsForm(MaterialsController materialsController)
        {
            _materialsController = materialsController;
        
            InitializeComponent();

           // InitHeaders();
            SettupEvents();

            InsertDataFromRepository();
        }

        private void InsertDataFromRepository()
        {
            //this.dataGridView1.Rows.Clear();

            var materials = _materialsController.GetMaterials();

            this.dataGridView1.DataSource = materials;

            dataGridView1.Columns["MaterialId"].Visible = false;
            dataGridView1.Columns["MaterialsInToy"].Visible = false;

            var any = materials.Any();
            btnEditMaterial.Enabled = any;
            btnDelete.Enabled = any;
        }

        private void SettupEvents()
        {
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
            dataGridView1.UserDeletedRow  += DataGridView1_Deleted;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.RowLeave += DataGridView1_RowLeave;
        }

        private void DataGridView1_Deleted(object sender, DataGridViewRowEventArgs e)
        {
            InsertDataFromRepository();
        }

        private void DataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
          //  btnEditMaterial.Enabled = false;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          //  btnEditMaterial.Enabled = true;
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

        //private void InitHeaders()
        //{
        //    dataGridView1.Columns.Add("Code", "Code");
        //    dataGridView1.Columns.Add("Title", "Title");
        //    dataGridView1.Columns.Add("Price", "Price");
        //}

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

        private void btn1_Click(object sender, EventArgs e)
        {
            // TODO: move to helper
            var response = MessageBox.Show("Вы уверены?", "Удалить запись?",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2);

            if (response == DialogResult.No)
            {
               
            }
            else
            {
                var material = GetSelectedMaterial();
                if (material !=null)
                {
                    try
                    {
                        _materialsController.DeleteMaterial(material.MaterialId);
                    }
                    catch (Exception ex)
                    {
                        // TODO: add error handling
                        MessageBox.Show(ex.Message);

                    }
                    InsertDataFromRepository();
                }

            }
        }
    }
}
