namespace ToyFactory.Forms.Toys
{
    partial class ToysListForm
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
            this.bttnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteToy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(426, 12);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(124, 23);
            this.bttnAdd.TabIndex = 1;
            this.bttnAdd.Tag = "Add";
            this.bttnAdd.Text = "Добавление";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(426, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Tag = "Edit";
            this.btnEdit.Text = "Редактирование";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnDeleteToy
            // 
            this.btnDeleteToy.Location = new System.Drawing.Point(425, 70);
            this.btnDeleteToy.Name = "btnDeleteToy";
            this.btnDeleteToy.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteToy.TabIndex = 1;
            this.btnDeleteToy.Text = "Удаление";
            this.btnDeleteToy.UseVisualStyleBackColor = true;
            this.btnDeleteToy.Click += new System.EventHandler(this.btn_DeleteToy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(406, 225);
            this.dataGridView1.TabIndex = 3;
            // 
            // ToysListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 254);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteToy);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Name = "ToysListForm";
            this.Text = "Список игрушек ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteToy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}