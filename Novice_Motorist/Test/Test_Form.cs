using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novice_Motorist.Test
{
    public partial class Test_Form : Form
    {
        public int[] getter;
        public void GetSelectedCars()
        {
            listView1.Items.Clear();
            ImageList imgList = new ImageList
            {
                ImageSize = new Size(250, 150)
            };
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Test_Cars/1.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Test_Cars/2.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Test_Cars/3.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Test_Cars/4.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Test_Cars/5.jpg")));
            this.listView1.SmallImageList = imgList;

            for (int j = 0; j < getter.Length; j++)
            {
                ListViewItem item = new ListViewItem(new string[] { "", brandCar[getter[j]], modelCar[getter[j]] })
                {
                    ImageIndex = getter[j]
                };
                this.listView1.Items.Add(item);
            }
        }
        public int[] GetTypesModel(string type)
        {

            List<int> result = new List<int>();
            for (int i = 0; i < speedCar.Length; i++)
            {
                if (speedCar[i] == type)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
        readonly string[] brandCar = { "BMW", "Volkswagen", "Renault", "Mersedes-Benz", "Audi" };
        readonly string[] modelCar = { "BMW M6 GRAN COUPE", "GOLF ALLTRACK", "RENAULT EZ-ULTIMO", "GLB", "E-TRON" };
        readonly string[] speedCar = { "Быстрая", "Средняя", "Медленная", "Средняя", "Средняя" };
        public Test_Form()
        {
            InitializeComponent();
            site_2.Visible = false;
            site_finish.Visible = false;

        }

        private void Button_Start_Test_Click(object sender, EventArgs e)
        {
            site_1.Visible = false;
            site_2.Visible = true;
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

        private void Exite_Application_MouseMove(object sender, MouseEventArgs e)
        {

            Exite_Application.Image = Properties.Resources.Button_Back_Move;
        }

        private void Exite_Application_MouseLeave(object sender, EventArgs e)
        {
            Exite_Application.Image = Properties.Resources.Button_Back;
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

        private void Test_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Button_Speed_Low_Click(object sender, EventArgs e)
        {
            string type = "Медленная";
            this.getter = GetTypesModel(type);
            GetSelectedCars();
            site_2.Visible = false;
            site_finish.Visible = true;
        }

        private void Button_Speed_Average_Click(object sender, EventArgs e)
        {
            string type = "Средняя";
            this.getter = GetTypesModel(type);
            GetSelectedCars();
            site_2.Visible = false;
            site_finish.Visible = true;
        }

        private void Button_Speed_High_Click(object sender, EventArgs e)
        {
            string type = "Быстрая";
            this.getter = GetTypesModel(type);
            GetSelectedCars();
            site_2.Visible = false;
            site_finish.Visible = true;
        }
    }
}

