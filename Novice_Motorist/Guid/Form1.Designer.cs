namespace Novice_Motorist
{
    partial class Form_Glava_1_Introduction
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
            this.Button_Hide = new System.Windows.Forms.PictureBox();
            this.Exite_Application = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Hide
            // 
            this.Button_Hide.Image = global::Novice_Motorist.Properties.Resources.Button_Hide;
            this.Button_Hide.InitialImage = null;
            this.Button_Hide.Location = new System.Drawing.Point(722, 12);
            this.Button_Hide.Name = "Button_Hide";
            this.Button_Hide.Size = new System.Drawing.Size(35, 25);
            this.Button_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_Hide.TabIndex = 7;
            this.Button_Hide.TabStop = false;
            this.Button_Hide.Click += new System.EventHandler(this.Button_Hide_Click);
            this.Button_Hide.MouseLeave += new System.EventHandler(this.Button_Hide_MouseLeave);
            this.Button_Hide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Hide_MouseMove);
            // 
            // Exite_Application
            // 
            this.Exite_Application.Image = global::Novice_Motorist.Properties.Resources.Button_Back;
            this.Exite_Application.InitialImage = null;
            this.Exite_Application.Location = new System.Drawing.Point(763, 12);
            this.Exite_Application.Name = "Exite_Application";
            this.Exite_Application.Size = new System.Drawing.Size(25, 25);
            this.Exite_Application.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exite_Application.TabIndex = 6;
            this.Exite_Application.TabStop = false;
            this.Exite_Application.Click += new System.EventHandler(this.Exite_Application_Click_1);
            this.Exite_Application.MouseLeave += new System.EventHandler(this.Exite_Application_MouseLeave);
            this.Exite_Application.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exite_Application_MouseMove);
            // 
            // Form_Glava_1_Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Hide);
            this.Controls.Add(this.Exite_Application);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Glava_1_Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Glava_1_Introduction_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Button_Hide;
        private System.Windows.Forms.PictureBox Exite_Application;
    }
}