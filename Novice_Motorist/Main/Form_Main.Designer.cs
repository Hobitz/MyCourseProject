namespace Novice_Motorist
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Guide_Button = new System.Windows.Forms.Button();
            this.Life_Hacks_Button = new System.Windows.Forms.Button();
            this.Express_Button = new System.Windows.Forms.Button();
            this.button_Brand_Cars = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_Hide = new System.Windows.Forms.PictureBox();
            this.Exite_Application = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).BeginInit();
            this.SuspendLayout();
            // 
            // Guide_Button
            // 
            this.Guide_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Guide_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guide_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guide_Button.FlatAppearance.BorderSize = 0;
            this.Guide_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guide_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Guide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guide_Button.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Guide_Button.ForeColor = System.Drawing.Color.White;
            this.Guide_Button.Location = new System.Drawing.Point(12, 138);
            this.Guide_Button.Name = "Guide_Button";
            this.Guide_Button.Size = new System.Drawing.Size(201, 78);
            this.Guide_Button.TabIndex = 0;
            this.Guide_Button.Text = "Cправочник";
            this.Guide_Button.UseVisualStyleBackColor = false;
            this.Guide_Button.Click += new System.EventHandler(this.Guide_Button_Click);
            // 
            // Life_Hacks_Button
            // 
            this.Life_Hacks_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Life_Hacks_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Life_Hacks_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Life_Hacks_Button.FlatAppearance.BorderSize = 0;
            this.Life_Hacks_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Life_Hacks_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Life_Hacks_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Life_Hacks_Button.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Life_Hacks_Button.ForeColor = System.Drawing.Color.White;
            this.Life_Hacks_Button.Location = new System.Drawing.Point(223, 54);
            this.Life_Hacks_Button.Name = "Life_Hacks_Button";
            this.Life_Hacks_Button.Size = new System.Drawing.Size(201, 78);
            this.Life_Hacks_Button.TabIndex = 1;
            this.Life_Hacks_Button.Text = "Лайфхаки";
            this.Life_Hacks_Button.UseVisualStyleBackColor = false;
            // 
            // Express_Button
            // 
            this.Express_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.Express_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Express_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Express_Button.FlatAppearance.BorderSize = 0;
            this.Express_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Express_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Express_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Express_Button.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Express_Button.ForeColor = System.Drawing.Color.White;
            this.Express_Button.Location = new System.Drawing.Point(12, 54);
            this.Express_Button.Name = "Express_Button";
            this.Express_Button.Size = new System.Drawing.Size(201, 78);
            this.Express_Button.TabIndex = 2;
            this.Express_Button.Text = "Быстрый выбор";
            this.Express_Button.UseVisualStyleBackColor = false;
            this.Express_Button.Click += new System.EventHandler(this.Express_Button_Click);
            // 
            // button_Brand_Cars
            // 
            this.button_Brand_Cars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.button_Brand_Cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Brand_Cars.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Brand_Cars.FlatAppearance.BorderSize = 0;
            this.button_Brand_Cars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Brand_Cars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Brand_Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Brand_Cars.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Brand_Cars.ForeColor = System.Drawing.Color.White;
            this.button_Brand_Cars.Location = new System.Drawing.Point(223, 138);
            this.button_Brand_Cars.Name = "button_Brand_Cars";
            this.button_Brand_Cars.Size = new System.Drawing.Size(201, 78);
            this.button_Brand_Cars.TabIndex = 5;
            this.button_Brand_Cars.Text = "Виды машин";
            this.button_Brand_Cars.UseVisualStyleBackColor = false;
            this.button_Brand_Cars.Click += new System.EventHandler(this.Button_Brand_Cars_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(136)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(98, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выбери своего коня!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Novice_Motorist.Properties.Resources.Logotype;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseMove);
            // 
            // Button_Hide
            // 
            this.Button_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Hide.Image = global::Novice_Motorist.Properties.Resources.Button_Hide;
            this.Button_Hide.InitialImage = null;
            this.Button_Hide.Location = new System.Drawing.Point(358, 4);
            this.Button_Hide.Name = "Button_Hide";
            this.Button_Hide.Size = new System.Drawing.Size(35, 25);
            this.Button_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_Hide.TabIndex = 4;
            this.Button_Hide.TabStop = false;
            this.Button_Hide.Click += new System.EventHandler(this.Button_Hide_Click);
            this.Button_Hide.MouseLeave += new System.EventHandler(this.Button_Hide_MouseLeave);
            this.Button_Hide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Hide_MouseMove);
            // 
            // Exite_Application
            // 
            this.Exite_Application.BackColor = System.Drawing.Color.White;
            this.Exite_Application.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exite_Application.Image = global::Novice_Motorist.Properties.Resources.Button_Exite;
            this.Exite_Application.InitialImage = null;
            this.Exite_Application.Location = new System.Drawing.Point(399, 4);
            this.Exite_Application.Name = "Exite_Application";
            this.Exite_Application.Size = new System.Drawing.Size(25, 25);
            this.Exite_Application.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exite_Application.TabIndex = 3;
            this.Exite_Application.TabStop = false;
            this.Exite_Application.Click += new System.EventHandler(this.Exite_Application_Click);
            this.Exite_Application.MouseLeave += new System.EventHandler(this.Exite_Application_MouseLeave);
            this.Exite_Application.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exite_Application_MouseMove);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.BackgroundImage = global::Novice_Motorist.Properties.Resources.bg_image;
            this.ClientSize = new System.Drawing.Size(436, 224);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Brand_Cars);
            this.Controls.Add(this.Button_Hide);
            this.Controls.Add(this.Exite_Application);
            this.Controls.Add(this.Express_Button);
            this.Controls.Add(this.Life_Hacks_Button);
            this.Controls.Add(this.Guide_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(186)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guide_Button;
        private System.Windows.Forms.Button Life_Hacks_Button;
        private System.Windows.Forms.Button Express_Button;
        private System.Windows.Forms.PictureBox Exite_Application;
        private System.Windows.Forms.PictureBox Button_Hide;
        private System.Windows.Forms.Button button_Brand_Cars;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

