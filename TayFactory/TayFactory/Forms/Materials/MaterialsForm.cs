using System;
using System.Windows.Forms;

namespace ToyFactory.Forms.Materials
{
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();

            InitHeaders();
            SettupEvents();

            SettupDataSource();
        }

        private void SettupDataSource()
        {
            // dataGridView1.DataSource = new dataSou
            this.dataGridView1.Rows.Add("five", "six", "seven", "eight");
            this.dataGridView1.Rows.Insert(0, "one", "two", "three", "four");
        }

        private void SettupEvents()
        {
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!e.Row.IsNewRow)
            {
                var response = MessageBox.Show("Are you sure?", "Delete row?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2);

                if (response == DialogResult.No)
                {
                    e.Cancel = true;
                }
                    
            }
        }

        private void InitHeaders()
        {
            dataGridView1.Columns.Add("Code", "Code");
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Price", "Price");
        }

        private void btnShowAddNewMaterialForm_Click(object sender, EventArgs e)
        {

        }
    }
}
