using System;
using System.ComponentModel;
using System.Windows.Forms;
using ToyFactory.Business.Controllers.Implimentations;
using ToyFactory.Common;
using ToyFactory.Dal;
using ToyFactory.Forms.Materials;
using ToyFactory.Forms.Production;
using ToyFactory.Forms.Toys;

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
            if (backgroundWorker1.IsBusy != true)
            {
                _loadForm = new SimpleLoadingForm();
                _loadForm.Show();
                this.Hide();
                backgroundWorker1.RunWorkerAsync();
            }
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
    }
}
