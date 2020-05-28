using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using parcial_2.SourceCode;

namespace parcial_2.Desing
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var name = ConnectionBD.ExecuteQuery("SELECT name FROM BUSINESS ");
            var nameCombo = new List<string>();
            foreach (DataRow dr in name.Rows)
            {
                nameCombo.Add(dr[0].ToString());
            }
            
            comboBoxempresa.DataSource = nameCombo;
        }

        private void button1agregar_Click(object sender, EventArgs e)
        {
            if (textBoxnombreproduct.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    string query = $"SELECT B.idBusiness FROM BUSINESS B WHERE B.name='{comboBoxempresa.Text.ToString()}' ";
                    
                    var dt2 = ConnectionBD.ExecuteQuery(query);
                    var dr2 = dt2.Rows[0];
                    var idBusiness = dr2[0].ToString();
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness,name) VALUES( " +
                                                 $"'{idBusiness}' ," +
                                                 $"'{textBoxnombreproduct.Text.ToString()}') ");
                    MessageBox.Show("Producto guardado exitosamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                             
            }
        }
    }
}