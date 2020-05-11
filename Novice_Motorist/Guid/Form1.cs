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
    public partial class Form_Glava_1_Introduction : Form
    {
        public Form_Glava_1_Introduction()
        {
            InitializeComponent();
        }

        private void Form_Glava_1_Introduction_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Exite_Application_Click_1(object sender, EventArgs e)
        {
            Form fm = new Guid_Form_Main
            {
                Left = this.Left,
                Top = this.Top
            };
            fm.StartPosition = FormStartPosition.Manual;
            fm.Left = this.Left;
            fm.Top = this.Top;
            fm.Show();
            this.Close();
        }

        private void Exite_Application_MouseLeave(object sender, EventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back;
        }

        private void Exite_Application_MouseMove(object sender, MouseEventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back_Move;
        }

        private void Button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Hide_MouseLeave(object sender, EventArgs e)
        {
            Button_Hide.Image = Properties.Resources.Button_Hide;
        }

        private void Button_Hide_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Hide.Image = Properties.Resources.Button_Hide_Move;
        }
    }
}
