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
        public void GetSelectedCars(int[] type)
        {
            listView1.Items.Clear();
            ImageList imgList = new ImageList
            {
                ImageSize = new Size(50, 50)
            };
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Atlass_Cross.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Golf_Alltrack.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Atlass_Cross.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Golf_Alltrack.jpg")));
            imgList.Images.Add(Image.FromFile(Path.GetFullPath("../../Image/1x/Atlass_Cross.jpg")));
            listView1.LargeImageList = imgList;

                for (int i = 0; i < type.Length; i++)
                {
                ListViewItem viewItem = new ListViewItem(new string[] { "", modelCar[getter[i]], speedCar[getter[i]] })
                {
                    ImageIndex = i
                };
                listView1.Items.Add(viewItem);
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
        readonly string[] modelCar = { "БМВ", "WoltsWagen", "Rehno", "Mersedes", "Audi" };
        readonly string[] speedCar = { "Быстрая", "Средняя", "Медленная", "Средняя", "Быстрая" };        
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
            GetSelectedCars(getter);
            site_2.Visible = false;
            site_finish.Visible = true;
        }

        private void Button_Speed_Average_Click(object sender, EventArgs e)
        {
            string type = "Средняя";
            this.getter = GetTypesModel(type);
            GetSelectedCars(getter);
            site_2.Visible = false;
            site_finish.Visible = true;
        }

        private void Button_Speed_High_Click(object sender, EventArgs e)
        {
            string type = "Быстрая";
            this.getter = GetTypesModel(type);
            GetSelectedCars(getter);
            site_2.Visible = false;
            site_finish.Visible = true;
        }
    }
}
