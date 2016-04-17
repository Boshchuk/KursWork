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
        private ToyFactoryContext Context;
        private MaterialRepository _materialRepository;

        public Form1()
        {
            InitializeComponent();

            Context = new ToyFactoryContext();

            _materialRepository = new MaterialRepository(Context);
        }

        private void btnOpenMaterialsForm_Click(object sender, System.EventArgs e)
        {
           OpenMaterialsForm();
        }

        private void OpenMaterialsForm()
        {
            this.Hide();
            materialsForm = new MaterialsForm(_materialRepository);
            materialsForm.ShowDialog();
            this.Show();
        }

        private void AnotherClick()
        {
            
        }
    }
}
