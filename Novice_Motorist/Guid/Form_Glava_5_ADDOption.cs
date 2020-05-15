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
    public partial class Form_Glava_5_ADDOption : Form
    {
        public Form_Glava_5_ADDOption()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size { Width = 747, Height = 367 };
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(124, 120);
            pictureBox1.Size = new Size { Width = 479, Height = 236 };
        }
    }
}
