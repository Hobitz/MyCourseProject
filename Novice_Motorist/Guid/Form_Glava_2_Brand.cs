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
    public partial class Form_Glava_2_Brand : Form
    {
        readonly Panel[] Sites = new Panel[2];
        int num = 1;
        public Form_Glava_2_Brand()
        {
            InitializeComponent();
            Sites[0] = glava_2_site_1;
            Sites[1] = glava_2_site_2;
            Sites[1].Visible = false;
            label3.Text = "1";
            label4.Text = "/ " + Sites.Length.ToString();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            Button_Exit.Image = Properties.Resources.Button_Exite;
        }

        private void Button_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Exit.Image = Properties.Resources.Button_Exite_Move;
        }

        private void Exite_Application_Click(object sender, EventArgs e)
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

        private void Form_Glava_2_Brand_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Button_sites_next_Click(object sender, EventArgs e)
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

        private void Button_sites_back_Click(object sender, EventArgs e)
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

        private void Picture_car_body_MouseMove(object sender, MouseEventArgs e)
        {
            picture_car_body.Location = new Point(0, 0);
            picture_car_body.Size = new Size{ Width = 731, Height = 364 };
        }

        private void Picture_car_body_MouseLeave(object sender, EventArgs e)
        {
            picture_car_body.Location = new Point(162, 129);
            picture_car_body.Size = new Size { Width = 433, Height = 221 };
        }

        private void Button_prev_glav_Click(object sender, EventArgs e)
        {
            Form fg = new Form_Glava_1_Introduction
            {
                Left = this.Left,
                Top = this.Top
            };
            fg.StartPosition = FormStartPosition.Manual;
            fg.Left = this.Left;
            fg.Top = this.Top;
            fg.Show();
            this.Close();
        }

        private void button_next_glav_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Glava_3_Fuel
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
    }
}
