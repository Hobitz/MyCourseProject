using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novice_Motorist.View_cars
{
    public partial class Brand_Cars : Form
    {
        public Brand_Cars()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exite_Application_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Main
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

        private void Button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Exit.Image = Properties.Resources.Button_Exite_Move;
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            Button_Exit.Image = Properties.Resources.Button_Exite;
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

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            var lavel = sender as Label;
            lavel.Font = new Font("Montserrat", 20, FontStyle.Bold);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var lavel = sender as Label;
            lavel.Font = new Font("Montserrat", 18, FontStyle.Bold);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Volkswagen_Cars
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

        private void Brand_Cars_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
