using System;
using System.Windows.Forms;
using parcial_2.SourceCode;

namespace parcial_2
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            comboBoxiusuario.DataSource = null;
            comboBoxiusuario.ValueMember = "password";
            comboBoxiusuario.DisplayMember = "username";
            comboBoxiusuario.DataSource = UserDao.getLista();
        }

        private void buttoncontra_Click(object sender, EventArgs e)
        {
            bool actualIgual = comboBoxiusuario.SelectedValue.Equals(textBoxactual.Text);
            bool nuevaIgual = textBoxcontranueva.Text.Equals(textBoxrepetidacontra.Text);
            bool nuevaValida = textBoxcontranueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    UserDao.actualizarContra(comboBoxiusuario.Text, textBoxcontranueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}