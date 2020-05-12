using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void Button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exite_Application_MouseMove(object sender, MouseEventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back_Move;
        }

        private void Exite_Application_MouseLeave(object sender, EventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back;
        }

        private void Button_Hide_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Hide.Image = Properties.Resources.Button_Hide_Move;
        }

        private void Button_Hide_MouseLeave(object sender, EventArgs e)
        {
            Button_Hide.Image = Properties.Resources.Button_Hide;
        }

        private void Guid_Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Glava_1_Introduction
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

        private void Glava_1_Introduction_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Glava_1_Introduction
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

        private void Glava_1_Introduction_MouseMove(object sender, MouseEventArgs e)
        {
            var lavel = sender as System.Windows.Forms.Label;
            lavel.Font = new Font("Montserrat", 18, FontStyle.Bold);
        }

        private void Glava_1_Introduction_MouseLeave(object sender, EventArgs e)
        {
            var lavel = sender as System.Windows.Forms.Label;
            lavel.Font = new Font("Montserrat", 16, FontStyle.Bold);
        }

        private void Glava_2_Brand_Click(object sender, EventArgs e)
        {

        }
    }
}