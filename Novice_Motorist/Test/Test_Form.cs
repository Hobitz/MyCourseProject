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
        readonly string[] imageCar = { "../../Image/1x/Test_Cars/1.jpg",
            "../../Image/1x/Test_Cars/2.jpg",
            "../../Image/1x/Test_Cars/3.jpg",
            "../../Image/1x/Test_Cars/4.jpg",
            "../../Image/1x/Test_Cars/5.jpg"
        };
        readonly string[] brandCar = { "BMW",
            "Volkswagen",
            "Renault",
            "Mersedes-Benz",
            "Audi" };
        readonly string[] modelCar = { "BMW M6 GRAN COUPE",
            "GOLF ALLTRACK",
            "RENAULT EZ-ULTIMO",
            "GLB",
            "E-TRON" 
        };
        readonly string[] speedCar = { "Быстрая",
            "Средняя",
            "Медленная",
            "Средняя",
            "Средняя"
        };
        readonly string[] placeCar = { "Мало",
            "Много",
            "Среднее",
            "Среднее",
            "Среднее"
        };
        public void GetSelectedCars()
        {
            listView1.Items.Clear();
            ImageList imgList = new ImageList
            {
                ImageSize = new Size(250, 150)
            };

            for (int j = 0; j < imageCar.Length; j++)
            {
                imgList.Images.Add(Image.FromFile(Path.GetFullPath(imageCar[j])));
            };


            for (int j = 0; j < getter.Length; j++)
            {
                ListViewItem item = new ListViewItem(new string[] { "", brandCar[getter[j]], modelCar[getter[j]] })
                {
                    ImageIndex = getter[j]
                };
                this.listView1.Items.Add(item);
                this.listView1.SmallImageList = imgList;
            }
        }
        public int[] GetTypesSpeed(string type)
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
        public int[] GetTypesPlace(string type)
        {

            List<int> result = new List<int>();
            for (int i = 0; i < speedCar.Length; i++)
            {
                if (placeCar[i] == type)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }


        public Test_Form()
        {
            InitializeComponent();
            site_2.Visible = false;
            site_3.Visible = false;
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
            this.getter = GetTypesSpeed(type);
            GetSelectedCars();
            site_2.Visible = false;
            site_finish.Visible = true;
        }

        private void Button_Speed_Average_Click(object sender, EventArgs e)
        {
            string type = "Средняя";
            this.getter = GetTypesSpeed(type);
            GetSelectedCars();
            site_2.Visible = false;
            site_3.Visible = true;
        }

        private void Button_Speed_High_Click(object sender, EventArgs e)
        {
            string type = "Быстрая";
            this.getter = GetTypesSpeed(type);
            GetSelectedCars();
            site_2.Visible = false;
            site_3.Visible = true;
        }

        private void Input_Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '2' && e.KeyChar <= '9') ||e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button_Place_Car_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(Input_Field_site_3.Text);
            string place;
            if (type == 2)
            {
                place = "Мало";
            }
            else if (type >=3 || type==4)
            {
                place = "Среднее";
            }
            else
            {
                place = "Много";
            }
            site_finish.Visible = true;
            this.getter = GetTypesPlace(place);
            GetSelectedCars();
            site_3.Visible = false;
            site_finish.Visible = true;

        }
    }
}

