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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Guide_Button_Click(object sender, EventArgs e)
        {
            Form fm = new Guid_Form_Main();
            fm.Left = this.Left; 
            fm.Top = this.Top; 
            fm.Show(); 
            this.Hide(); 

        }

        private void Exite_Application_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}