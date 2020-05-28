using System;
using System.Windows.Forms;
using parcial_2.SourceCode;

namespace parcial_2.Desing
{
    public partial class AddUser : UserControl
    {
        

        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxnamecomplete.Text.Equals("") ||
                textBoxnameuser.Text.Equals("") ||
                textBoxpassword.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO APPUSER(fullname,username,password,usertype,activo) VALUES( " +
                                                $"'{textBoxnamecomplete.Text.ToString()}' ," +
                                                $"'{textBoxnameuser.Text.ToString()}'," +
                                                $"'{textBoxpassword.Text.ToString()}', " +
                                                $"'{comboBoxadmi.SelectedItem.ToString()}' , " + 
                                                $"{true})");
                    MessageBox.Show("Usuario guardado exitosamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                             
            }
        }

        
    }
}