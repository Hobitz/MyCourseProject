using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novice_Motorist
{
    public partial class Guid_Form_Main : Form
    {
        public Guid_Form_Main()
        {
            InitializeComponent();
        }

        private void Exite_Application_Click(object sender, EventArgs e)
        {
            Form fm = Application.OpenForms[0];
            fm.StartPosition = FormStartPosition.Manual;
            fm.Left = this.Left; 
            fm.Top = this.Top; 
            fm.Show();
            this.Close();
        }
    }
}
