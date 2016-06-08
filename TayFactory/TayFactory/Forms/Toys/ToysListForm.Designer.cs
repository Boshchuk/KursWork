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
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteToy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 1;
            this.button2.Tag = "Edit";
            this.button2.Text = "Редактирование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddEdit_Click);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 82);
            this.listBox1.TabIndex = 2;
            // 
            // ToysListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 134);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDeleteToy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttnAdd);
            this.Name = "ToysListForm";
            this.Text = "Список игрушек ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteToy;
        private System.Windows.Forms.ListBox listBox1;
    }
}