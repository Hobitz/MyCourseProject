using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novice_Motorist
{
    public partial class Form_Glava_1_Introduction : Form
    {
        readonly Panel[] Sites = new Panel[2];
        int num = 1;
        public Form_Glava_1_Introduction()
        {
            InitializeComponent();
            Sites[0] = glava1_site_1;
            Sites[1] = glava_site_2;
            Sites[1].Visible = false;
            label3.Text = "1";
            label4.Text = "/ "+Sites.Length.ToString();
        }

        private void Form_Glava_1_Introduction_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
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

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Exit.Image = Properties.Resources.Button_Exite_Move;
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            Button_Exit.Image = Properties.Resources.Button_Exite;
        }

        private void Button_prev_glav_Click(object sender, EventArgs e)
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

        private void Button_next_glav_Click(object sender, EventArgs e)
        {
            Form fm = new Form_Glava_2_Brand
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
