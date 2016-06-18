using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            InitMaterials(avalibleMaterials.ToList(), toy.MaterialInToy !=null ? toy.MaterialInToy.ToList(): null);
            switch (formMode)
            {
                case FormMode.Add:
                    {
                        // инициализируем писок доступных материалов
                        break;
                    }
                case FormMode.Edit:
                    {
                        txtArticle.Text = toy.Article;
                        txtTitle.Text = toy.Title;

                        break;
                    }
            }
            DisplayPrice();
        }

        private void InitMaterials(List<Material> materials, List<MaterialInToy> used)
        {

            for (int index = 0; index < materials.Count(); index++)
            {
                var avalibleMaterial = materials[index];

                MaterialInToy posibleUsed = null;
                if (used != null)
                {
                    posibleUsed = used.FirstOrDefault(m => m.UsedMaterial.MaterialId == avalibleMaterial.MaterialId);
                }


                var checkState = false;
                var count = 0;
                if (posibleUsed != null)
                {
                    checkState = true;
                    count = posibleUsed.Quentity;
                }


                var checkBox = new CheckBox
                {
                    Text = avalibleMaterial.Title,
                    Location = new Point(0, index*30),
                    Tag = avalibleMaterial,
                    Name = string.Format("chk_{0}", avalibleMaterial.MaterialId),
                    Checked = checkState
                };

                checkBox.CheckedChanged += MaterialCheckedToUse;

                var numeric = new NumericUpDown
                {
                    Text = count.ToString(),
                    Location = new Point(180, index*30),
                    Width = 60
                };
                numeric.ValueChanged += Numeric_ValueChanged;
                numeric.Tag = avalibleMaterial;
                numeric.Name = string.Format("num_{0}", avalibleMaterial.MaterialId);

                panelMaterials.Controls.Add(checkBox);
                panelMaterials.Controls.Add(numeric);


            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            var s = sender as NumericUpDown;
            var id = (s.Tag as Material).MaterialId;

            var checkBoxControl = panelMaterials.Controls.Find(string.Format("chk_{0}", id), true).FirstOrDefault() as CheckBox;

            if (checkBoxControl != null)
            {
                checkBoxControl.Checked = s.Value > 0;
            }
            DisplayPrice();
        }

        private void MaterialCheckedToUse(object sender, EventArgs e)
        {
            var s = sender as CheckBox;
            var id = (s.Tag as Material).MaterialId;
            var numControl = panelMaterials.Controls.Find(string.Format("num_{0}", id),true).FirstOrDefault();

            if (numControl != null)
            {
                numControl.Text = s.Checked ? 1.ToString() : 0.ToString();
            }
            DisplayPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _toy.Article = txtArticle.Text;
                _toy.Title = txtTitle.Text;

                var elements =GetUsedMaterials();


                _toy.MaterialInToy = elements;
                _toy.Price = CalculatePrice();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Возвращает использованые материалы, собирая информацию из контроллов.
        /// </summary>
        /// <returns></returns>
        private List<MaterialInToy> GetUsedMaterials()
        {
            var result = new List<MaterialInToy>();
            for (var index = 0; index < panelMaterials.Controls.Count; )
            {
                var checkBox = panelMaterials.Controls[index] as CheckBox;
                var numericUpDown = panelMaterials.Controls[index+1] as NumericUpDown;

                if (checkBox != null && numericUpDown != null)
                {
                    if (checkBox.Checked)
                    {
                        result.Add(
                        new MaterialInToy((int)numericUpDown.Value, checkBox.Tag as Material));
                    }
                    
                }
                index = index + 2;
            }
            return result;
        }

        private bool IsValid()
        {
            var state = true;

            state = FormsHelper.IsFieldNotNullAndNotEmpty(txtArticle, errorProvider1);
            state = FormsHelper.IsFieldNotNullAndNotEmpty(txtTitle, errorProvider1);

            return state;
        }

        private decimal CalculatePrice()
        {
            var price = GetUsedMaterials().Sum(usedMaterial => usedMaterial.UsedMaterial.Price * usedMaterial.Quentity);

            price = price + (price*35/100);

            return price;
        }

        private void DisplayPrice()
        {
            var price = CalculatePrice();
            txtPrice.Text = price.ToString(CultureInfo.InvariantCulture);
        }
    }
}
