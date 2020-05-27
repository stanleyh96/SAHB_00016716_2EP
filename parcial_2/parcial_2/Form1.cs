using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parcial_2.Desing;
using parcial_2.SourceCode;
using MainMenu = parcial_2.Desing.MainMenu;


namespace parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }
        private void LlenarControles(){
            
            comboBoxuser.DataSource = null;
            comboBoxuser.ValueMember = "password";
            comboBoxuser.DisplayMember = "username";
            comboBoxuser.DataSource = UserDao.getLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxuser.SelectedValue.Equals(textBoxcontra.Text))
            {
                Usuario u = (Usuario) comboBoxuser.SelectedItem;
               

                if (u.userType==false)
                {

                    MessageBox.Show("¡Bienvenido!",
                        "CellphoneStore", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainMenu ventana = new MainMenu(u);
                    ventana.Show(this);
                    this.Hide();
                }
                else if (u.userType==true)
                {
                    MessageBox.Show("¡Bienvenido!",
                        "CellphoneStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainAdministrador ventana = new MainAdministrador();
                    ventana.Show();
                    this.Hide();
                }
                
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "CellphoneStore",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void buttoncambiarcontra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
        }

        private void buttoncambiarcontra_Click(object sender, EventArgs e)
        {
            ChangePassword Ventana = new ChangePassword();
            Ventana.ShowDialog();
            LlenarControles(); 
        }
    }
}