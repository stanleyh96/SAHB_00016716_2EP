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
                                  $"Ingrediente a elegir:Tocino,Jamon y peperoni";
                }
            }else if (comboBoxempresa.Text.CompareTo("China wok")==0)
            {
                pictureBox2.Image = Resources.china_woklogo;
                if (comboBoxmenu.Text.CompareTo("Banquete full")==0)
                {
                    label5.Text = "Banquete para 4 persona con arrox frito,shaomin y cuatro bebidas personales";
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
    }
}