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
            var name = ConnectionBD.ExecuteQuery("SELECT usuario FROM USUARIO WHERE activo='true'");
            var nameCombo = new List<string>();
            foreach (DataRow dr in name.Rows)
            {
                nameCombo.Add(dr[0].ToString());
            }
            
            comboBoxempresa.DataSource = nameCombo;
        }

        private void button1agregar_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}