using System.ComponentModel;

namespace parcial_2
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxiusuario = new System.Windows.Forms.ComboBox();
            this.textBoxactual = new System.Windows.Forms.TextBox();
            this.textBoxcontranueva = new System.Windows.Forms.TextBox();
            this.textBoxrepetidacontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttoncontra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::parcial_2.Properties.Resources.Hugo_imagen1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(292, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxiusuario
            // 
            this.comboBoxiusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxiusuario.FormattingEnabled = true;
            this.comboBoxiusuario.Location = new System.Drawing.Point(350, 218);
            this.comboBoxiusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxiusuario.Name = "comboBoxiusuario";
            this.comboBoxiusuario.Size = new System.Drawing.Size(210, 28);
            this.comboBoxiusuario.TabIndex = 1;
            // 
            // textBoxactual
            // 
            this.textBoxactual.Location = new System.Drawing.Point(350, 272);
            this.textBoxactual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxactual.Name = "textBoxactual";
            this.textBoxactual.PasswordChar = '*';
            this.textBoxactual.Size = new System.Drawing.Size(210, 27);
            this.textBoxactual.TabIndex = 2;
            // 
            // textBoxcontranueva
            // 
            this.textBoxcontranueva.Location = new System.Drawing.Point(350, 334);
            this.textBoxcontranueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcontranueva.Name = "textBoxcontranueva";
            this.textBoxcontranueva.PasswordChar = '*';
            this.textBoxcontranueva.Size = new System.Drawing.Size(210, 27);
            this.textBoxcontranueva.TabIndex = 3;
            // 
            // textBoxrepetidacontra
            // 
            this.textBoxrepetidacontra.Location = new System.Drawing.Point(350, 398);
            this.textBoxrepetidacontra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxrepetidacontra.Name = "textBoxrepetidacontra";
            this.textBoxrepetidacontra.PasswordChar = '*';
            this.textBoxrepetidacontra.Size = new System.Drawing.Size(210, 27);
            this.textBoxrepetidacontra.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña actual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña nueva:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repetir contrseña nueva:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttoncontra
            // 
            this.buttoncontra.BackColor = System.Drawing.Color.GhostWhite;
            this.buttoncontra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttoncontra.ForeColor = System.Drawing.Color.Indigo;
            this.buttoncontra.Location = new System.Drawing.Point(288, 460);
            this.buttoncontra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncontra.Name = "buttoncontra";
            this.buttoncontra.Size = new System.Drawing.Size(204, 54);
            this.buttoncontra.TabIndex = 9;
            this.buttoncontra.Text = "Cambiar";
            this.buttoncontra.UseVisualStyleBackColor = false;
            this.buttoncontra.Click += new System.EventHandler(this.buttoncontra_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.buttoncontra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxrepetidacontra);
            this.Controls.Add(this.textBoxcontranueva);
            this.Controls.Add(this.textBoxactual);
            this.Controls.Add(this.comboBoxiusuario);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxrepetidacontra;
        private System.Windows.Forms.TextBox textBoxactual;
        private System.Windows.Forms.TextBox textBoxcontranueva;
        private System.Windows.Forms.ComboBox comboBoxiusuario;
        private System.Windows.Forms.Button buttoncontra;
    }
}