using System;
using System.ComponentModel;
using System.Windows.Forms;
using ToyFactory.Business;
using ToyFactory.Common;
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

        private SimpleLoadingForm loadForm;

        public Form1()
        {
            InitializeComponent();

            _context = new ToyFactoryContext();

            _materialRepository = new MaterialRepository(_context);

           
            backgroundWorker1.WorkerReportsProgress = true;
            // backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnOpenMaterialsForm_Click(object sender, System.EventArgs e)
        {
           OpenMaterialsForm();
        }

        //private void ToyConstructor_CLick(object sender, System.EventArgs e)
        //{
        //    OpenToyConstructorForm();
        //}

        private void OpenMaterialsForm()
        {
            this.Hide();
            materialsForm = new MaterialsForm(_materialRepository);
            materialsForm.ShowDialog();
            this.Show();
        }

        private void OpenToyConstructorForm()
        {
            try
            {
                toysListForm = new ToysListForm(_context);

                toysListForm.ShowDialog();
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
                loadForm = new SimpleLoadingForm();
                loadForm.Show();
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

            //for (int i = 1; i <= 10; i++)
            //{
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;// break;
                }
                else
                {
                // OpenToyConstructorForm();
                // Perform a time consuming operation and report progress.
                //System.Threading.Thread.Sleep(500);

                try
                {
                    toysListForm = new ToysListForm(_context);
                    worker.ReportProgress(100);
                    toysListForm.ShowDialog();
                }
                catch (CantConnectToDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                }
            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadForm.Close();
            this.Show();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadForm.Close();
        }
    }
}
