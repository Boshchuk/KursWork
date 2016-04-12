using System.Windows.Forms;
using ToyFactory.Forms.Materials;

namespace ToyFactory.Forms
{
    public partial class Form1 : Form
    {
        private MaterialsForm materialsForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenMaterialsForm_Click(object sender, System.EventArgs e)
        {
            OpenMaterialsForm();
        }

        private void OpenMaterialsForm()
        {
            this.Hide();
            materialsForm = new MaterialsForm();
            materialsForm.ShowDialog();
            this.Show();
        }

        private void AnotherClick()
        {
            
        }
    }
}
