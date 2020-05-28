using System;
using System.Windows.Forms;


namespace parcial_2.Desing
{
    public partial class MainAdministrador : Form
    {
        private UserControl current = null;
        private UserControl current2 = null;
        private UserControl current3 = null;

        public MainAdministrador()
        {
            InitializeComponent();
            current = addUser1;
            current2 = addBusiness1;
            current3 = addProduct1;
        }

        private void buttonagregaruser_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new AddUser();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
        }

        private void buttoneliminaruser_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current=new EliminateUser();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
            
        }

        private void buttonaddnegocio_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current2);
            current2=new AddBusiness();
            tableLayoutPanel2.Controls.Add(current2,0,1);
            tableLayoutPanel1.SetColumnSpan(current2,3);
        }

        private void buttoneliminarnegocio_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current2);
            current2=new EliminateUser();
            tableLayoutPanel2.Controls.Add(current2,0,1);
            tableLayoutPanel1.SetColumnSpan(current2,3);
        }

        private void buttonaddproducto_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current3);
            current3=new AddProduct();
            tableLayoutPanel3.Controls.Add(current3,0,1);
            tableLayoutPanel3.SetColumnSpan(current3,2);
        }

        private void buttoneliminateproduct_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current3);
            current3=new EliminateUser();
            tableLayoutPanel3.Controls.Add(current3,0,1);
            tableLayoutPanel3.SetColumnSpan(current3,2);
        }
    }
}