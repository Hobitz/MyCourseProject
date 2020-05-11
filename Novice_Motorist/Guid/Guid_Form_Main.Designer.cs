namespace Novice_Motorist
{
    partial class Guid_Form_Main
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
            this.Exite_Application = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).BeginInit();
            this.SuspendLayout();
            // 
            // Exite_Application
            // 
            this.Exite_Application.Image = global::Novice_Motorist.Properties.Resources.Button_Back;
            this.Exite_Application.InitialImage = null;
            this.Exite_Application.Location = new System.Drawing.Point(763, 12);
            this.Exite_Application.Name = "Exite_Application";
            this.Exite_Application.Size = new System.Drawing.Size(25, 25);
            this.Exite_Application.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exite_Application.TabIndex = 4;
            this.Exite_Application.TabStop = false;
            this.Exite_Application.Click += new System.EventHandler(this.Exite_Application_Click);
            // 
            // Guid_Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exite_Application);
            this.Name = "Guid_Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Guid_Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.Exite_Application)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exite_Application;
    }
}