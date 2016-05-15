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

namespace ToyFactory.Forms.Toys
{
    public partial class AddEditToyForm : Form
    {
        private readonly Toy _toy;

        public AddEditToyForm(Toy toy, FormMode formMode, IEnumerable<Material> avalibleMaterials)
        {
            _toy = toy;
            InitializeComponent();



            switch (formMode)
            {
                case FormMode.Add:
                    {
                        // если захотеть менять тест кнопки сохранения - менять здесь
                        //button1.Text = AddBtnText;

                        // инициализируем писок доступных материалов

                        InitAvalibleMaterials(avalibleMaterials);

                        break;
                    }
                case FormMode.Edit:
                    {
                        // если захотеть менять тест кнопки сохранения - менять тут тоже
                        //button1.Text = EditBtnText;

                        txtArticle.Text = toy.Article;
                        txtTitle.Text = toy.Title;

                        // инициализируем писок доступных материалов и используемых материалов

                        
                        break;
                    }
            }
        }

        private void InitAvalibleMaterials(IEnumerable<Material> materials)
        {
            FormsHelper.InitMaterialsListBox(listBoxAvalible, materials);
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
