using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Materials
{
    public partial class AddEditMaterialForm : Form
    {
        private readonly Material _material;
        const string AddBtnText = "Add";
        const string EditBtnText = "Edit";

        //public AddEditMaterialForm()
        //{
        //    InitializeComponent();
        //}

        public AddEditMaterialForm(Material material, FormMode formMode)
        {
            InitializeComponent();
            _material = material;
            switch (formMode)
            {
                case FormMode.Add:
                    {
                        button1.Text = AddBtnText;
                        break;
                    }
                case FormMode.Edit:
                    {
                        button1.Text = EditBtnText;
                        break;
                    }
            }
        }

        // See article about how return result:
        // http://stackoverflow.com/questions/600107/c-how-do-you-send-ok-or-cancel-return-messages-of-dialogs-when-not-using-butto/600412

        private void button2_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // todo validate

            var isValid = IsValid();
            // display error if not valid
            if (isValid)
            {
                _material.Code = textBox1.Text;
                _material.Title = textBox2.Text;
                _material.Price = decimal.Parse(textBox3.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }

            
            // add if valid and close



        }

        private bool IsValid()
        {
            // todo: add more validation here with messages
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                return false;
            }

            return true;
        }
    }
}
