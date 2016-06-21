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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrMaterials = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСИгрушкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToyConstructorИгрушекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.произвестиИгрушкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrMaterials.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // menuStrMaterials
            // 
            this.menuStrMaterials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.MaterialsToolStripMenuItem,
            this.работаСИгрушкамиToolStripMenuItem,
            this.складToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.menuStrMaterials.Location = new System.Drawing.Point(0, 0);
            this.menuStrMaterials.Name = "menuStrMaterials";
            this.menuStrMaterials.Size = new System.Drawing.Size(770, 24);
            this.menuStrMaterials.TabIndex = 3;
            this.menuStrMaterials.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MaterialsToolStripMenuItem
            // 
            this.MaterialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaterialListToolStripMenuItem});
            this.MaterialsToolStripMenuItem.Name = "MaterialsToolStripMenuItem";
            this.MaterialsToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.MaterialsToolStripMenuItem.Text = "Работа с материалами";
            this.MaterialsToolStripMenuItem.Click += new System.EventHandler(this.работаСМатериаламиToolStripMenuItem_Click);
            // 
            // MaterialListToolStripMenuItem
            // 
            this.MaterialListToolStripMenuItem.Name = "MaterialListToolStripMenuItem";
            this.MaterialListToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.MaterialListToolStripMenuItem.Text = "Открыть Конструктор Материалов";
            this.MaterialListToolStripMenuItem.Click += new System.EventHandler(this.MaterialsListToolStripMenuItem_Click);
            // 
            // работаСИгрушкамиToolStripMenuItem
            // 
            this.работаСИгрушкамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToyConstructorИгрушекToolStripMenuItem});
            this.работаСИгрушкамиToolStripMenuItem.Name = "работаСИгрушкамиToolStripMenuItem";
            this.работаСИгрушкамиToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.работаСИгрушкамиToolStripMenuItem.Text = "Работа с Игрушками";
            // 
            // OpenToyConstructorИгрушекToolStripMenuItem
            // 
            this.OpenToyConstructorИгрушекToolStripMenuItem.Name = "OpenToyConstructorИгрушекToolStripMenuItem";
            this.OpenToyConstructorИгрушекToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.OpenToyConstructorИгрушекToolStripMenuItem.Text = "Открыть конструктор игрушек";
            this.OpenToyConstructorИгрушекToolStripMenuItem.Click += new System.EventHandler(this.OpenToyConstructorИгрушекToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.произвестиИгрушкиToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // произвестиИгрушкиToolStripMenuItem
            // 
            this.произвестиИгрушкиToolStripMenuItem.Name = "произвестиИгрушкиToolStripMenuItem";
            this.произвестиИгрушкиToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.произвестиИгрушкиToolStripMenuItem.Text = "Произвести игрушки";
            this.произвестиИгрушкиToolStripMenuItem.Click += new System.EventHandler(this.ToyConstructionToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоПользователяToolStripMenuItem,
            this.UsersListToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // добавитьНовогоПользователяToolStripMenuItem
            // 
            this.добавитьНовогоПользователяToolStripMenuItem.Name = "добавитьНовогоПользователяToolStripMenuItem";
            this.добавитьНовогоПользователяToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.добавитьНовогоПользователяToolStripMenuItem.Text = "Добавить нового пользователя";
            this.добавитьНовогоПользователяToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // UsersListToolStripMenuItem
            // 
            this.UsersListToolStripMenuItem.Name = "UsersListToolStripMenuItem";
            this.UsersListToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.UsersListToolStripMenuItem.Text = "Посмотреть список Пользотвателей";
            this.UsersListToolStripMenuItem.Click += new System.EventHandler(this.UsersList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 371);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrMaterials);
            this.MainMenuStrip = this.menuStrMaterials;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фабрика игрушек";
            this.menuStrMaterials.ResumeLayout(false);
            this.menuStrMaterials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrMaterials;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСИгрушкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToyConstructorИгрушекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem произвестиИгрушкиToolStripMenuItem;
    }
}

