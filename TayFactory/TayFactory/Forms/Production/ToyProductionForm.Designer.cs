namespace ToyFactory.Forms.Production
{
    partial class ToyProductionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProducedToys = new System.Windows.Forms.DataGridView();
            this.dataGridViewToysList = new System.Windows.Forms.DataGridView();
            this.btnProduce = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducedToys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToysList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступные к производству игрушки:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Произведенные игрушки";
            // 
            // dataGridViewProducedToys
            // 
            this.dataGridViewProducedToys.AllowUserToAddRows = false;
            this.dataGridViewProducedToys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducedToys.Location = new System.Drawing.Point(16, 302);
            this.dataGridViewProducedToys.Name = "dataGridViewProducedToys";
            this.dataGridViewProducedToys.ReadOnly = true;
            this.dataGridViewProducedToys.Size = new System.Drawing.Size(792, 127);
            this.dataGridViewProducedToys.TabIndex = 2;
            // 
            // dataGridViewToysList
            // 
            this.dataGridViewToysList.AllowUserToAddRows = false;
            this.dataGridViewToysList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToysList.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewToysList.Name = "dataGridViewToysList";
            this.dataGridViewToysList.ReadOnly = true;
            this.dataGridViewToysList.Size = new System.Drawing.Size(796, 127);
            this.dataGridViewToysList.TabIndex = 2;
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(232, 217);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(305, 28);
            this.btnProduce.TabIndex = 3;
            this.btnProduce.Text = "Произвести указанное количиство игрушек";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ToyProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 452);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProduce);
            this.Controls.Add(this.dataGridViewToysList);
            this.Controls.Add(this.dataGridViewProducedToys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToyProductionForm";
            this.Text = "ToyProductionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducedToys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToysList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProducedToys;
        private System.Windows.Forms.DataGridView dataGridViewToysList;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.TextBox textBox1;
    }
}