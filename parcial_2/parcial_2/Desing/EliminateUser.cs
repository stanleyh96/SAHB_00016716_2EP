using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using parcial_2.SourceCode;

namespace parcial_2.Desing
{
    public partial class EliminateUser : UserControl
    {
        public EliminateUser()
        {
            InitializeComponent();
        }

        private void EliminateUser_Load(object sender, EventArgs e)
        {
            var user = ConnectionBD.ExecuteQuery("SELECT username FROM APPUSER where activo='true'");
            var userCombo = new List<string>();
            foreach (DataRow dr in user.Rows)
            {
                userCombo.Add(dr[0].ToString());
            }
            
            comboBoxusuarios.DataSource = userCombo;
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            ConnectionBD.ExecuteNonQuery($"UPDATE  APPUSER set activo='false' WHERE username='{comboBoxusuarios.Text.ToString()}'  ");
            MessageBox.Show("Usuario eliminado exitosamente");
        }
    }
}