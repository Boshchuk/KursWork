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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowAddNewMaterialForm
            // 
            this.btnShowAddNewMaterialForm.Location = new System.Drawing.Point(488, 25);
            this.btnShowAddNewMaterialForm.Name = "btnShowAddNewMaterialForm";
            this.btnShowAddNewMaterialForm.Size = new System.Drawing.Size(139, 23);
            this.btnShowAddNewMaterialForm.TabIndex = 1;
            this.btnShowAddNewMaterialForm.Tag = "Add";
            this.btnShowAddNewMaterialForm.Text = "Add new Material";
            this.btnShowAddNewMaterialForm.UseVisualStyleBackColor = true;
            this.btnShowAddNewMaterialForm.Click += new System.EventHandler(this.btnShowAddNewMaterialForm_Click);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 267);
            this.Controls.Add(this.btnShowAddNewMaterialForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaterialsForm";
            this.Text = "Materials Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAddNewMaterialForm;
    }
}