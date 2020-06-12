using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novice_Motorist.View_cars.Kia
{
    public partial class Form_Kia_Cars : Form
    {
        readonly Panel[] Sites = new Panel[2];
        int num = 1;
        public Form_Kia_Cars()
        {
            InitializeComponent();
            Sites[0] = site_1;
            Sites[1] = site_2;
            Sites[1].Visible = false;
            label3.Text = "1";
            label4.Text = "/ " + Sites.Length.ToString();
        }

        private void Form_Kia_Cars_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exite_Application_Click(object sender, EventArgs e)
        {
            Form fm = new Brand_Cars
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

        private void button_sites_back_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                return;
            }
            for (int i = 0; i < Sites.Length; i++)
            {
                if (Sites[i].Visible == true)
                {
                    Sites[i].Visible = false;
                    Sites[i - 1].Visible = true;
                    num -= 1;
                    label3.Text = num.ToString();
                    break;
                }
            }
        }

        private void button_sites_next_Click(object sender, EventArgs e)
        {
            if (num == Sites.Length)
            {
                return;
            }
            for (int i = 0; i < Sites.Length; i++)
            {
                if (Sites[i].Visible == true)
                {
                    Sites[i].Visible = false;
                    Sites[i + 1].Visible = true;
                    num += 1;
                    label3.Text = num.ToString();
                    break;
                }
            }
        }

        private void Button_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back_Move;
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back;
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

        private void label9_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Kia_Optima
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

        private void label10_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Kia_Picanto
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

        private void label11_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Kia_Seltos
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

        private void label12_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Kia_Stinger
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

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            var lavel = sender as Label;
            lavel.Font = new Font("Montserrat", 20, FontStyle.Bold);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            var lavel = sender as Label;
            lavel.Font = new Font("Montserrat", 18, FontStyle.Bold);
        }
    }
}
