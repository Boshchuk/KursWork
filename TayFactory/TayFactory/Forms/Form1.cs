using System.Windows.Forms;
using ToyFactory.Forms;

namespace ToyFactory
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
            materialsForm = new MaterialsForm();
            materialsForm.ShowDialog();
          
        }

        private void AnotherClick()
        {
            
        }
    }
}
