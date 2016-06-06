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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowAddNewMaterialForm
            // 
            this.btnShowAddNewMaterialForm.Location = new System.Drawing.Point(651, 31);
            this.btnShowAddNewMaterialForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAddNewMaterialForm.Name = "btnShowAddNewMaterialForm";
            this.btnShowAddNewMaterialForm.Size = new System.Drawing.Size(223, 28);
            this.btnShowAddNewMaterialForm.TabIndex = 1;
            this.btnShowAddNewMaterialForm.Tag = "Add";
            this.btnShowAddNewMaterialForm.Text = "Добавление материала";
            this.btnShowAddNewMaterialForm.UseVisualStyleBackColor = true;
            this.btnShowAddNewMaterialForm.Click += new System.EventHandler(this.btnShowAddNewMaterialForm_Click);
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.Enabled = false;
            this.btnEditMaterial.Location = new System.Drawing.Point(651, 66);
            this.btnEditMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(223, 28);
            this.btnEditMaterial.TabIndex = 1;
            this.btnEditMaterial.Tag = "Edit";
            this.btnEditMaterial.Text = "редактирование материала";
            this.btnEditMaterial.UseVisualStyleBackColor = true;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnShowAddNewMaterialForm_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 329);
            this.Controls.Add(this.btnEditMaterial);
            this.Controls.Add(this.btnShowAddNewMaterialForm);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MaterialsForm";
            this.Text = "Материалы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAddNewMaterialForm;
        private System.Windows.Forms.Button btnEditMaterial;
    }
}