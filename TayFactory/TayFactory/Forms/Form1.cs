using System.Windows.Forms;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Forms.Materials;
using ToyFactory.Forms.Toys;

namespace ToyFactory.Forms
{
    public partial class Form1 : Form
    {
        private MaterialsForm materialsForm;

        private ToysListForm toysListForm;

        private readonly ToyFactoryContext _context;
        private MaterialRepository _materialRepository;

        public Form1()
        {
            InitializeComponent();

            _context = new ToyFactoryContext();

            _materialRepository = new MaterialRepository(_context);
        }

        private void btnOpenMaterialsForm_Click(object sender, System.EventArgs e)
        {
           OpenMaterialsForm();
        }

        private void ToyConstructor_CLick(object sender, System.EventArgs e)
        {
            OpenToyConstructorForm();
        }

        private void OpenMaterialsForm()
        {
            this.Hide();
            materialsForm = new MaterialsForm(_materialRepository);
            materialsForm.ShowDialog();
            this.Show();
        }

        private void OpenToyConstructorForm()
        {
            this.Hide();
            toysListForm = new ToysListForm(_context);
            toysListForm.ShowDialog();
            this.Show();
        }

        private void AnotherClick()
        {
            
        }
    }
}
