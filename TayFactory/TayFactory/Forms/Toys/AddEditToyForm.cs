using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToyFactory.Dal.Models;

namespace ToyFactory.Forms.Toys
{
    public partial class AddEditToyForm : Form
    {
        private readonly Toy _toy;


        private readonly IList<Material> _avalibleMaterials;

        private readonly IList<Material> _usedMaterials = new List<Material>();

        public AddEditToyForm(Toy toy, FormMode formMode, IEnumerable<Material> avalibleMaterials)
        {
            _toy = toy;
            _avalibleMaterials = avalibleMaterials.ToList();
            InitializeComponent();

            switch (formMode)
            {
                case FormMode.Add:
                    {
                        // если захотеть менять тест кнопки сохранения - менять здесь
                        //button1.Text = AddBtnText;

                        // инициализируем писок доступных материалов

                        InitAvalibleMaterials(_avalibleMaterials);

                        break;
                    }
                case FormMode.Edit:
                    {
                        // если захотеть менять тест кнопки сохранения - менять тут тоже
                        //button1.Text = EditBtnText;

                        _avalibleMaterials = _avalibleMaterials.Except(toy.UsedMaterials).ToList();
                        _usedMaterials = toy.UsedMaterials.ToList();


                        txtArticle.Text = toy.Article;
                        txtTitle.Text = toy.Title;

                        InitAvalibleMaterials(_avalibleMaterials);
                        InitUsedMaterial(toy.UsedMaterials);
                        // инициализируем писок доступных материалов и используемых материалов


                        break;
                    }
            }
        }

        private void InitAvalibleMaterials(IEnumerable<Material> materials)
        {
            FormsHelper.InitMaterialsListBox(listBoxAvalible, materials);
        }

        private void InitUsedMaterial(IEnumerable<Material> materials)
        {
            FormsHelper.InitMaterialsListBox(listBoxUsed , materials);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _toy.Article = txtArticle.Text;
            _toy.Title = txtTitle.Text;

            if (_usedMaterials != null )
            {
                _toy.UsedMaterials = _usedMaterials;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MoveMaterial(ListBox source, ListBox target, IList<Material> s, IList<Material> t)
        {
            if (source.SelectedItem != null)
            {
                var index = source.SelectedIndex;
                var selected = s[index];

                target.Items.Add(selected.Title);
                t.Add(selected);

                s.RemoveAt(index);
                source.Items.RemoveAt(index);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveMaterial(listBoxAvalible,
                         listBoxUsed,
                         _avalibleMaterials,
                         _usedMaterials);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveMaterial(listBoxUsed,
                         listBoxAvalible,
                         _usedMaterials,
                         _avalibleMaterials
                         );
        }

        private void listBoxUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
        }
    }
}
