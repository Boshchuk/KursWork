namespace ToyFactory.Forms.Materials
{
    partial class MaterialsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAddNewMaterialForm = new System.Windows.Forms.Button();
            this.btnEditMaterial = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowAddNewMaterialForm
            // 
            this.btnShowAddNewMaterialForm.Location = new System.Drawing.Point(488, 25);
            this.btnShowAddNewMaterialForm.Name = "btnShowAddNewMaterialForm";
            this.btnShowAddNewMaterialForm.Size = new System.Drawing.Size(167, 23);
            this.btnShowAddNewMaterialForm.TabIndex = 1;
            this.btnShowAddNewMaterialForm.Tag = "Add";
            this.btnShowAddNewMaterialForm.Text = "Добавление материала";
            this.btnShowAddNewMaterialForm.UseVisualStyleBackColor = true;
            this.btnShowAddNewMaterialForm.Click += new System.EventHandler(this.btnShowAddNewMaterialForm_Click);
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.Enabled = false;
            this.btnEditMaterial.Location = new System.Drawing.Point(488, 54);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(167, 23);
            this.btnEditMaterial.TabIndex = 1;
            this.btnEditMaterial.Tag = "Edit";
            this.btnEditMaterial.Text = "Редактирование материала";
            this.btnEditMaterial.UseVisualStyleBackColor = true;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnShowAddNewMaterialForm_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(488, 84);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(167, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Удаление материала";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 267);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEditMaterial);
            this.Controls.Add(this.btnShowAddNewMaterialForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaterialsForm";
            this.Text = "Материалы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAddNewMaterialForm;
        private System.Windows.Forms.Button btnEditMaterial;
        private System.Windows.Forms.Button btn1;
    }
}