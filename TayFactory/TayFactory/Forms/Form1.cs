using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Common;
using ToyFactory.Dal;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Implementation;
using ToyFactory.Forms.Materials;
using ToyFactory.Forms.Production;
using ToyFactory.Forms.Toys;
using ToyFactory.Forms.UsersForms;

namespace ToyFactory.Forms
{
    public partial class Form1 : Form
    {
        #region Forms

        private MaterialsForm _materialsForm;

        private ToysListForm _toysListForm;

        private SimpleLoadingForm _loadForm;

        private ToyProductionForm _toyProductionForm;

        #endregion

        #region For work with db

        private readonly ToyFactoryContext _context;

        private readonly MaterialsController _materialsController;

        #endregion

        public Form1()
        {
            InitializeComponent();

            _context = new ToyFactoryContext();

            _materialsController = new MaterialsController(_context);

            backgroundWorker1.WorkerReportsProgress = true;
        
        }

        private void btnOpenMaterialsForm_Click(object sender, System.EventArgs e)
        {
            OpenMaterialsForm();
        }

        private void OpenMaterialsForm()
        {
            this.Hide();
            _materialsForm = new MaterialsForm(_materialsController);
            _materialsForm.ShowDialog();
            this.Show();
        }

        private void OpenToyConstructorForm()
        {
            try
            {
                _toysListForm = new ToysListForm(_context);

                _toysListForm.ShowDialog();
            }
            catch (CantConnectToDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            ToyConstructorStart();
        }

        private void ToyConstructorStart()
        {
            //if (backgroundWorker1.IsBusy != true)
            //{
            //    _loadForm = new SimpleLoadingForm();
            //    _loadForm.Show();
            //    this.Hide();
            //    backgroundWorker1.RunWorkerAsync();
            //}
            Hide();
            _toysListForm = new ToysListForm(_context);
            _toysListForm.ShowDialog();
            Show();
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                try
                {
                    _toysListForm = new ToysListForm(_context);
                    worker.ReportProgress(100);
                    _toysListForm.ShowDialog();
                }
                catch (CantConnectToDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _loadForm.Close();
            this.Show();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _loadForm.Close();
        }

        private void btnToyProduction_Click(object sender, EventArgs e)
        {
            this.Hide();
            _toyProductionForm = new ToyProductionForm(_context);
            _toyProductionForm.ShowDialog();
            this.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void работаСМатериаламиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MaterialsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMaterialsForm();
        }

        private void AddNewMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();


            var material = new Material();
            var addEditModal = new AddEditMaterialForm(material, FormMode.Edit);

            var result = addEditModal.ShowDialog();

            if (result == DialogResult.OK)
            {
              _materialsController.InsertMaterial(material);
            }

            this.Show();
        }

        private void UsersList_Click(object sender, EventArgs e)
        {
            Hide();
            ShowUserListDialog();
            Show();
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var createUserForm = new СreateUserForm(new UserRepository(_context));
            createUserForm.ShowDialog();

            ShowUserListDialog();

            Show();
        }

        private DialogResult ShowUserListDialog()
        {
            var form = new UsersList(_context);
            var result = form.ShowDialog();
            return result;
        }

        private void OpenToyConstructorИгрушекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToyConstructorStart();
        }

        private void ToyConstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _toyProductionForm = new ToyProductionForm(_context);
            _toyProductionForm.ShowDialog();
            this.Show();
        }
    }
}
