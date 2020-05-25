namespace Novice_Motorist.Test
{
    partial class Test_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Form));
            this.Button_Hide = new System.Windows.Forms.PictureBox();
            this.site_1 = new System.Windows.Forms.Panel();
            this.Button_Start_Test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.Exite_Application = new System.Windows.Forms.PictureBox();
            this.site_2 = new System.Windows.Forms.Panel();
            this.Button_Speed_High = new System.Windows.Forms.Button();
            this.Button_Speed_Average = new System.Windows.Forms.Button();
            this.Button_Speed_Low = new System.Windows.Forms.Button();
            this.Glava_2_Brand = new System.Windows.Forms.Label();
            this.site_finish = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ImageCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameBrandCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speedCars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Button_Hide)).BeginInit();
            this.site_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).BeginInit();
            this.site_2.SuspendLayout();
            this.site_finish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Hide
            // 
            this.Button_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Hide.Image = global::Novice_Motorist.Properties.Resources.Button_Hide;
            this.Button_Hide.InitialImage = null;
            this.Button_Hide.Location = new System.Drawing.Point(701, 9);
            this.Button_Hide.Name = "Button_Hide";
            this.Button_Hide.Size = new System.Drawing.Size(35, 25);
            this.Button_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_Hide.TabIndex = 7;
            this.Button_Hide.TabStop = false;
            this.Button_Hide.Click += new System.EventHandler(this.Button_Hide_Click);
            this.Button_Hide.MouseLeave += new System.EventHandler(this.Button_Hide_MouseLeave);
            this.Button_Hide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Hide_MouseMove);
            // 
            // site_1
            // 
            this.site_1.BackColor = System.Drawing.Color.White;
            this.site_1.Controls.Add(this.Button_Start_Test);
            this.site_1.Controls.Add(this.label1);
            this.site_1.Location = new System.Drawing.Point(28, 45);
            this.site_1.Name = "site_1";
            this.site_1.Size = new System.Drawing.Size(740, 364);
            this.site_1.TabIndex = 9;
            // 
            // Button_Start_Test
            // 
            this.Button_Start_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Button_Start_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Start_Test.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Start_Test.FlatAppearance.BorderSize = 0;
            this.Button_Start_Test.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Start_Test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Start_Test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Start_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start_Test.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.Button_Start_Test.ForeColor = System.Drawing.Color.White;
            this.Button_Start_Test.Location = new System.Drawing.Point(288, 254);
            this.Button_Start_Test.Name = "Button_Start_Test";
            this.Button_Start_Test.Size = new System.Drawing.Size(140, 74);
            this.Button_Start_Test.TabIndex = 11;
            this.Button_Start_Test.Text = "Начать";
            this.Button_Start_Test.UseVisualStyleBackColor = false;
            this.Button_Start_Test.Click += new System.EventHandler(this.Button_Start_Test_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(98)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "В данном разделе, вы сможете пройти тест, при прохождение которого приложение под" +
    "берёт вам авто по выбранным вами ответов\r\nДля того чтоб начать проходить тест на" +
    "жмите  кнопку начать.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.White;
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.Image = global::Novice_Motorist.Properties.Resources.Button_Exite;
            this.Button_Exit.InitialImage = null;
            this.Button_Exit.Location = new System.Drawing.Point(769, 9);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(25, 25);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_Exit.TabIndex = 14;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            this.Button_Exit.MouseLeave += new System.EventHandler(this.Button_Exit_MouseLeave);
            this.Button_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Exit_MouseMove);
            // 
            // Exite_Application
            // 
            this.Exite_Application.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exite_Application.Image = global::Novice_Motorist.Properties.Resources.Button_Back;
            this.Exite_Application.InitialImage = null;
            this.Exite_Application.Location = new System.Drawing.Point(740, 9);
            this.Exite_Application.Name = "Exite_Application";
            this.Exite_Application.Size = new System.Drawing.Size(25, 25);
            this.Exite_Application.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exite_Application.TabIndex = 15;
            this.Exite_Application.TabStop = false;
            this.Exite_Application.Click += new System.EventHandler(this.Exite_Application_Click);
            this.Exite_Application.MouseLeave += new System.EventHandler(this.Exite_Application_MouseLeave);
            this.Exite_Application.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exite_Application_MouseMove);
            // 
            // site_2
            // 
            this.site_2.BackColor = System.Drawing.Color.White;
            this.site_2.Controls.Add(this.Button_Speed_High);
            this.site_2.Controls.Add(this.Button_Speed_Average);
            this.site_2.Controls.Add(this.Button_Speed_Low);
            this.site_2.Controls.Add(this.Glava_2_Brand);
            this.site_2.Location = new System.Drawing.Point(28, 46);
            this.site_2.Name = "site_2";
            this.site_2.Size = new System.Drawing.Size(740, 364);
            this.site_2.TabIndex = 12;
            // 
            // Button_Speed_High
            // 
            this.Button_Speed_High.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Button_Speed_High.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Speed_High.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_High.FlatAppearance.BorderSize = 0;
            this.Button_Speed_High.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_High.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_High.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_High.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Speed_High.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.Button_Speed_High.ForeColor = System.Drawing.Color.White;
            this.Button_Speed_High.Location = new System.Drawing.Point(512, 193);
            this.Button_Speed_High.Name = "Button_Speed_High";
            this.Button_Speed_High.Size = new System.Drawing.Size(152, 74);
            this.Button_Speed_High.TabIndex = 21;
            this.Button_Speed_High.Text = "Высокую";
            this.Button_Speed_High.UseVisualStyleBackColor = false;
            this.Button_Speed_High.Click += new System.EventHandler(this.Button_Speed_High_Click);
            // 
            // Button_Speed_Average
            // 
            this.Button_Speed_Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Button_Speed_Average.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Speed_Average.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Average.FlatAppearance.BorderSize = 0;
            this.Button_Speed_Average.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Average.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Average.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Average.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Speed_Average.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.Button_Speed_Average.ForeColor = System.Drawing.Color.White;
            this.Button_Speed_Average.Location = new System.Drawing.Point(262, 193);
            this.Button_Speed_Average.Name = "Button_Speed_Average";
            this.Button_Speed_Average.Size = new System.Drawing.Size(152, 74);
            this.Button_Speed_Average.TabIndex = 20;
            this.Button_Speed_Average.Text = "Среднюю";
            this.Button_Speed_Average.UseVisualStyleBackColor = false;
            this.Button_Speed_Average.Click += new System.EventHandler(this.Button_Speed_Average_Click);
            // 
            // Button_Speed_Low
            // 
            this.Button_Speed_Low.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Button_Speed_Low.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Speed_Low.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Low.FlatAppearance.BorderSize = 0;
            this.Button_Speed_Low.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Low.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Low.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Speed_Low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Speed_Low.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.Button_Speed_Low.ForeColor = System.Drawing.Color.White;
            this.Button_Speed_Low.Location = new System.Drawing.Point(32, 193);
            this.Button_Speed_Low.Name = "Button_Speed_Low";
            this.Button_Speed_Low.Size = new System.Drawing.Size(140, 74);
            this.Button_Speed_Low.TabIndex = 19;
            this.Button_Speed_Low.Text = "Низкую";
            this.Button_Speed_Low.UseVisualStyleBackColor = false;
            this.Button_Speed_Low.Click += new System.EventHandler(this.Button_Speed_Low_Click);
            // 
            // Glava_2_Brand
            // 
            this.Glava_2_Brand.AutoSize = true;
            this.Glava_2_Brand.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Glava_2_Brand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Glava_2_Brand.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Glava_2_Brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Glava_2_Brand.Location = new System.Drawing.Point(26, 101);
            this.Glava_2_Brand.Name = "Glava_2_Brand";
            this.Glava_2_Brand.Size = new System.Drawing.Size(697, 33);
            this.Glava_2_Brand.TabIndex = 18;
            this.Glava_2_Brand.Text = "Какую скорость ваш транспорт должен развивать?";
            // 
            // site_finish
            // 
            this.site_finish.BackColor = System.Drawing.Color.White;
            this.site_finish.Controls.Add(this.listView1);
            this.site_finish.Location = new System.Drawing.Point(27, 46);
            this.site_finish.Name = "site_finish";
            this.site_finish.Size = new System.Drawing.Size(740, 364);
            this.site_finish.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImageCar,
            this.nameBrandCar,
            this.speedCars});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 365);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ImageCar
            // 
            this.ImageCar.Text = "Image";
            this.ImageCar.Width = 146;
            // 
            // nameBrandCar
            // 
            this.nameBrandCar.Text = "Brand";
            this.nameBrandCar.Width = 182;
            // 
            // speedCars
            // 
            this.speedCars.Text = "Speed";
            this.speedCars.Width = 203;
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.BackgroundImage = global::Novice_Motorist.Properties.Resources.bg_image;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.Exite_Application);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.site_finish);
            this.Controls.Add(this.site_2);
            this.Controls.Add(this.site_1);
            this.Controls.Add(this.Button_Hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Test_Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Hide)).EndInit();
            this.site_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).EndInit();
            this.site_2.ResumeLayout(false);
            this.site_2.PerformLayout();
            this.site_finish.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Button_Hide;
        private System.Windows.Forms.Panel site_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.PictureBox Exite_Application;
        private System.Windows.Forms.Button Button_Start_Test;
        private System.Windows.Forms.Panel site_2;
        private System.Windows.Forms.Button Button_Speed_High;
        private System.Windows.Forms.Button Button_Speed_Average;
        private System.Windows.Forms.Button Button_Speed_Low;
        private System.Windows.Forms.Label Glava_2_Brand;
        private System.Windows.Forms.Panel site_finish;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ImageCar;
        private System.Windows.Forms.ColumnHeader nameBrandCar;
        private System.Windows.Forms.ColumnHeader speedCars;
    }
}