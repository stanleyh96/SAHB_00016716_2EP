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
                
                    pictureBox1.Image = Resources.banquetechina;
                    label5.Text = "Pizza 4 con 16 porciones de un solo ingrediente" +
                                  $"Ingrediente a elegir:Tocino,Jamon y peperoni" +
                                  $"Precio: $14.99";
                
            }else if (comboBoxempresa.Text.CompareTo("China wok")==0)
            {
                pictureBox2.Image = Resources.china_woklogo;
               
                
                    pictureBox1.Image = Resources.banquetechina;
                    label5.Text = "Banquete para 4 persona con arrox frito,shaomin" +
                                  " y cuatro bebidas personales" +
                                  "Precio: $20.0";
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
            if (textBoxuser.Text.Equals("") ||
                textBoxdireccion.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    DateTime fecha=new DateTime();
                    string sfecha = fecha.ToString("MM/dd/yyyy");
                    string query2 = $"SELECT idproduct FROM product  WHERE name='{comboBoxmenu.Text.ToString()}' ";
                    var dt2 = ConnectionBD.ExecuteQuery(query2);
                    var dr2 = dt2.Rows[0];
                    var idProduct = dr2[0].ToString();
                    
                    string query3 = $"SELECT iduser FROM appuser  WHERE username='{textBoxuser.Text.ToString()}' ";
                    var dt3 = ConnectionBD.ExecuteQuery(query2);
                    var dr3 = dt3.Rows[0];
                    var idUSER = dr3[0].ToString();
            
                    string query = $"SELECT a.idaddress FROM ADDRESS a, APPUSER U  WHERE U.iduser=a.iduser and a.address='{textBoxdireccion.Text.ToString()}' ";
                    var dt = ConnectionBD.ExecuteQuery(query);
                    var dr = dt.Rows[0];
                    var idAddres = dr[0].ToString();
                    
                                                
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO ADDORDER(createdate,idproduct,idaddress,activo) VALUES( " +
                                                 $"'{sfecha}' , " +
                                                 $"{idProduct} , " +
                                                 $"{idAddres}, " +
                                                 $"{true} " );
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO ADDRESS(iduser,address,activo)VALUES({idUSER},'{textBoxdireccion.Text.ToString()}' , " +
                                                 $"{true} ) ");
                    
                    MessageBox.Show("Pedido guardado exitosamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pedido guardado exitosamente");
                }
                             
            }
            
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
                       $" \n\tand u.username= '{textBoxusuario.Text.ToString()}' and o.activo=true");
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