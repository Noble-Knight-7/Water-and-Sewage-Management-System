using System.Windows.Forms;

namespace WaterSewageManagementSystem.Helpers
{
    public static class FormNavigationHelper
    {
        // Opens a new form and optionally hides the current one
        public static void OpenForm(Form newForm, Form currentForm = null, bool hideCurrentForm = true)
        {
            if (hideCurrentForm && currentForm != null)
                currentForm.Hide();
            newForm.Show();
        }
    }
}
