namespace parcial_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxuser = new System.Windows.Forms.ComboBox();
            this.textBoxcontra = new System.Windows.Forms.TextBox();
            this.buttoncambiarcontra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImage = global::parcial_2.Properties.Resources.Hugo_imagen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(187, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxuser
            // 
            this.comboBoxuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxuser.FormattingEnabled = true;
            this.comboBoxuser.Location = new System.Drawing.Point(240, 292);
            this.comboBoxuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxuser.Name = "comboBoxuser";
            this.comboBoxuser.Size = new System.Drawing.Size(211, 28);
            this.comboBoxuser.TabIndex = 1;
            // 
            // textBoxcontra
            // 
            this.textBoxcontra.Location = new System.Drawing.Point(240, 372);
            this.textBoxcontra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcontra.Name = "textBoxcontra";
            this.textBoxcontra.PasswordChar = '*';
            this.textBoxcontra.Size = new System.Drawing.Size(211, 27);
            this.textBoxcontra.TabIndex = 2;
            // 
            // buttoncambiarcontra
            // 
            this.buttoncambiarcontra.BackColor = System.Drawing.Color.Indigo;
            this.buttoncambiarcontra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttoncambiarcontra.ForeColor = System.Drawing.Color.White;
            this.buttoncambiarcontra.Location = new System.Drawing.Point(123, 466);
            this.buttoncambiarcontra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncambiarcontra.Name = "buttoncambiarcontra";
            this.buttoncambiarcontra.Size = new System.Drawing.Size(140, 55);
            this.buttoncambiarcontra.TabIndex = 3;
            this.buttoncambiarcontra.Text = "Cambiar contraseña";
            this.buttoncambiarcontra.UseVisualStyleBackColor = false;
            this.buttoncambiarcontra.Click += new System.EventHandler(this.buttoncambiarcontra_Click);
            this.buttoncambiarcontra.KeyDown +=
                new System.Windows.Forms.KeyEventHandler(this.buttoncambiarcontra_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(325, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Iniciar sesion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(123, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(88, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(634, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttoncambiarcontra);
            this.Controls.Add(this.textBoxcontra);
            this.Controls.Add(this.comboBoxuser);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxuser;
        private System.Windows.Forms.Button buttoncambiarcontra;
        private System.Windows.Forms.TextBox textBoxcontra;
    }
}