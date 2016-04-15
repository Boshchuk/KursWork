using System.Windows.Forms;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
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
            using (var ctx = new ToyFactoryContext())
            {
                MaterialRepository materialRepository = new MaterialRepository(ctx);

                materialRepository.InsertMaterial(new Material() {Code = "c", Price = 10,Title = "test"});
                materialRepository.Save();
            }


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
