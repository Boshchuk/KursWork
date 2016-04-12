using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyFactory.Forms
{
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();

            InitTable();
        }

        private void InitTable()
        {
            //var material = new Material();

            dataGridView1.Columns.Add("Code", "Code");
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Price", "Price");

            
        }
    }
}
