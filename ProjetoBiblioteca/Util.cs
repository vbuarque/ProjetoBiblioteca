using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public static class Util
    {
        public static void LimparCampos(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)(c)).SelectedIndex = -1;
                }
                else if (c is ListBox)
                {
                    ((ListBox)(c)).Items.Clear();
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)(c)).Image = null;
                }
                
                if (c.HasChildren)
                {
                    LimparCampos(c);
                }
            }
        }

    }
}
