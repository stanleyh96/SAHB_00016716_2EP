using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Preparcial.Vista
{
    public partial class FrmMain : Form
    {
        private Usuario u;

        public FrmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtNewUser.Text.Equals(""))
            {
                ControladorUsuario.CrearUsuario(txtNewUser.Text);
                ActualizarCrearUsuario();
            }
        }

        private void ActualizarCrearUsuario()
        {
            dgvCreateUser.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void ActualizarInventario()
        {
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
        }

        private void ActualizarOrdenes()
        {
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void ActualizarOrdenesUsuario()
        {
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable(u.IdUsuario);
            cmbProductMakeOrder.DataSource = null;
            cmbProductMakeOrder.ValueMember = "idArticulo";
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductos();
        }

        private void bttnAddInventary_Click(object sender, EventArgs e)
        {
            //Correpcion:cambiando de string al varibale double e int a stock y precio
            int stock = 0;
            double precio = 0;
            
            precio = Convert.ToDouble(txtPriceInventary.Text);
            stock = Convert.ToInt32(txtStockInventary.Text);
            
            if (txtProductNameInventary.Text.Equals("") ||
                txtDescriptionInventary.Text.Equals("")  ||
                txtPriceInventary.Text.Equals("") ||
                txtStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.AnadirProducto(txtProductNameInventary.Text
                    , txtDescriptionInventary.Text, precio, stock);

                ActualizarInventario();
            }
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            if(txtDeleteInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                ActualizarInventario();
            }
        }

        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            if (txtUpdateStockIdInventary.Text.Equals("") && txtUpdateStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, txtUpdateStockInventary.Text);
                ActualizarInventario();
            }
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            if (txtMakeOrderQuantity.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                //correpcion:convirtiendo  a enteros los valores 
                ControladorPedido.HacerPedido(Convert.ToInt32(u.IdUsuario), Convert.ToInt32(cmbProductMakeOrder.SelectedValue.ToString()), 
                    Convert.ToInt32(txtMakeOrderQuantity.Text));
                ActualizarOrdenesUsuario();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!tabControl1.SelectedTab.Name.Equals("generalTab"))
            {
                if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Admin)
                    ActualizarCrearUsuario();

                else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Admin)
                    ActualizarInventario();

                else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Admin)
                    ActualizarOrdenesUsuario();

                else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Admin)
                    ActualizarOrdenes();

                else
                {
                    MessageBox.Show("No tiene permisos para ver esta pestana");
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                }
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
