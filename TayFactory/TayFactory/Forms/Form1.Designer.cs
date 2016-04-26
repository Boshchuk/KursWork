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
            this.SuspendLayout();
            // 
            // btnOpenMaterialsForm
            // 
            this.btnOpenMaterialsForm.Location = new System.Drawing.Point(121, 12);
            this.btnOpenMaterialsForm.Name = "btnOpenMaterialsForm";
            this.btnOpenMaterialsForm.Size = new System.Drawing.Size(151, 23);
            this.btnOpenMaterialsForm.TabIndex = 0;
            this.btnOpenMaterialsForm.Text = "Display Materials";
            this.btnOpenMaterialsForm.UseVisualStyleBackColor = true;
            this.btnOpenMaterialsForm.Click += new System.EventHandler(this.btnOpenMaterialsForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toy Counstructor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOpenMaterialsForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenMaterialsForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMaterialsForm;
        private System.Windows.Forms.Button button1;
    }
}

