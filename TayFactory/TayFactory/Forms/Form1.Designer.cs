namespace ToyFactory.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenMaterialsForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnToyProduction = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenMaterialsForm
            // 
            this.btnOpenMaterialsForm.Location = new System.Drawing.Point(12, 12);
            this.btnOpenMaterialsForm.Name = "btnOpenMaterialsForm";
            this.btnOpenMaterialsForm.Size = new System.Drawing.Size(151, 23);
            this.btnOpenMaterialsForm.TabIndex = 0;
            this.btnOpenMaterialsForm.Text = " Материалы";
            this.btnOpenMaterialsForm.UseVisualStyleBackColor = true;
            this.btnOpenMaterialsForm.Click += new System.EventHandler(this.btnOpenMaterialsForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Конструктор игрушек";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnToyProduction
            // 
            this.btnToyProduction.Location = new System.Drawing.Point(180, 13);
            this.btnToyProduction.Name = "btnToyProduction";
            this.btnToyProduction.Size = new System.Drawing.Size(199, 23);
            this.btnToyProduction.TabIndex = 1;
            this.btnToyProduction.Text = "Производство игрушек";
            this.btnToyProduction.UseVisualStyleBackColor = true;
            this.btnToyProduction.Click += new System.EventHandler(this.btnToyProduction_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(180, 40);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(199, 23);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Заказы игрушек";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 80);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnToyProduction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenMaterialsForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMaterialsForm;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnToyProduction;
        private System.Windows.Forms.Button btnOrders;
    }
}

