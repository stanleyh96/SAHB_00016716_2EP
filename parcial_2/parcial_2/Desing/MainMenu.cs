using System;
using System.Windows.Forms;
using parcial_2.SourceCode;
using parcial_2.Properties;
using System.Collections.Generic;
namespace parcial_2.Desing
{
    public partial class MainMenu : Form
    {
        public MainMenu(Usuario pUsuario)
        {
            InitializeComponent();
            
        }

        private void comboBoxempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxempresa.Text.CompareTo("Pizza hut")==0)
            {
                pictureBox2.Image = Resources.logo_pizzahut;
                if (comboBoxmenu.Text.CompareTo("Pizza 4") == 0)
                {
                    label5.Text = "Pizza 4 con 16 porciones de un solo ingrediente" +
                                  $"Ingrediente a elegir:Tocino,Jamon y peperoni" +
                                  $"Precio: $14.99";
                }
            }else if (comboBoxempresa.Text.CompareTo("China wok")==0)
            {
                pictureBox2.Image = Resources.china_woklogo;
                if (comboBoxmenu.Text.CompareTo("Banquete full")==0)
                {
                    label5.Text = "Banquete para 4 persona con arrox frito,shaomin y cuatro bebidas personales" +
                                  "Precio: $20.0";
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }
        private void LlenarControles(){
            
            comboBoxempresa.DataSource = null;
           // comboBoxempresa.ValueMember = "password";
            comboBoxempresa.DisplayMember = "name";
            comboBoxempresa.DataSource = BusinessDao.getLista();
            comboBoxmenu.DisplayMember = "name";
            comboBoxmenu.DataSource = ProductDao.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query=ConnectionBD.ExecuteQuery($"select * from apporder where ")
            ConnectionBD.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress,activo)
            VALUES({DateTime.Now}, 1, 1,true)");
        }
        
        private void buttonverpedido_Click(object sender, EventArgs e)
        {
            
            if (textBoxusuario.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar datos vacios");
            }else
            {
                try
                {
                    var dt =
                        ConnectionBD.ExecuteQuery("select o.idOrder,p.name,o.createdate,b.name,a.address  from address a,apporder o,business b,product p,APPUSER u "+
                        $"\n\twhere a.idAddress=o.idOrder \n\tand o.idProduct=p.idProduct\n\tand p.idBusiness=b.idBusiness\n\tand a.idUser=u.idUser "+
                       $" \n\tand u.username= '{textBox1.Text.ToString()}' and o.activo=true");
                            dataGridView1.DataSource = dt;
                    MessageBox.Show("Datos obtenidos exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar datos vacios");
            }else
            {
                try
                {
                     ConnectionBD.ExecuteNonQuery($"UPDATE APPORDER set activo={false}" +
                                               $" WHERE idOrder='{textBoxID.Text.ToString()}' ");
                    

                    MessageBox.Show("Orden eliminada exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }
    }
}