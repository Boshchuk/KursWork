using System;
using System.Globalization;
using System.Windows.Forms;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Materials
{
    public partial class AddEditMaterialForm : Form
    {
        private readonly Material _material;
        const string AddBtnText = "Добавить";
        const string EditBtnText = "Edit";

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

                        txtCode.Text = material.Code;
                        txtTitle.Text = material.Title;
                        txtPrice.Text = material.Price.ToString(CultureInfo.InvariantCulture);

                        break;
                    }
            }
        }

        // See article about how return result:
        // http://stackoverflow.com/questions/600107/c-how-do-you-send-ok-or-cancel-return-messages-of-dialogs-when-not-using-butto/600412

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            var isValid = IsValid();
            // display error if not valid
            if (isValid)
            {
                _material.Code = txtCode.Text;
                _material.Title = txtTitle.Text;
                _material.Price = decimal.Parse(txtPrice.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private bool IsValid()
        {
            bool state = true;

            // todo: add more validation here with messages
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                errorProvider1.SetError(txtCode, "Код не должен быть пустым");
                state = false;
            }

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Название не должен быть пустым");
                state = false;
            }

           
            decimal price = 0;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                errorProvider1.SetError(txtPrice, "Неправильный форматы цены");
                state = false;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.SetError(txtPrice, "Цена не может быть пустым значением");
                state = false;
            }

            return state;
        }

        private void AddEditMaterialForm_Load(object sender, EventArgs e)
        {

        }

     
    }
}
