using System.Collections.Generic;
using System.Windows.Forms;
using ToyFactory.Dal.Models;

namespace ToyFactory
{
    public static class FormsHelper
    {
        public static FormMode GetFormMode(object sender)
        {
            var tag = ((Button)sender).Tag;

            var formMode = FormMode.Add;

            if ((string) tag == "Edit")
            {
                formMode = FormMode.Edit;
            }

            return formMode;
        }

        public static void InitMaterialsListBox(ListBox listBox, IEnumerable<Material> materials)
        {
            foreach (var material in materials)
            {
                listBox.Items.Add(material.Title);
            }
        }

        public static bool IsFieldNotNullAndNotEmpty(TextBox element, ErrorProvider errorProvider)
        {
            var state = true;

            if (string.IsNullOrEmpty(element.Text))
            {
                errorProvider.SetError(element, "Поле не может быть пустым");
                state = false;
            }

            return state;
        }
    }
}