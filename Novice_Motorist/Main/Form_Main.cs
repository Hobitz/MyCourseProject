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
            Form fm = new Guid_Form_Main
            {
                Left = this.Left,
                Top = this.Top
            };
            fm.Show(); 
            this.Hide(); 

        }

        private void Exite_Application_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Exite_Application_MouseMove(object sender, MouseEventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Exite_Move;
        }

        private void Exite_Application_MouseLeave(object sender, EventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Exite;
        }

        private void Button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Hide_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Hide.Image = Properties.Resources.Button_Hide_Move;
        }

        private void Button_Hide_MouseLeave(object sender, EventArgs e)
        {
            Button_Hide.Image = Properties.Resources.Button_Hide;
        }
    }
}