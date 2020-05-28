using System.ComponentModel;

namespace parcial_2.Desing
{
    partial class MainAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainAdministrador));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttoneliminaruser = new System.Windows.Forms.Button();
            this.buttonagregaruser = new System.Windows.Forms.Button();
            this.addUser1 = new parcial_2.Desing.AddUser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttoneliminarnegocio = new System.Windows.Forms.Button();
            this.buttonaddnegocio = new System.Windows.Forms.Button();
            this.addBusiness1 = new parcial_2.Desing.AddBusiness();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttoneliminateproduct = new System.Windows.Forms.Button();
            this.buttonaddproducto = new System.Windows.Forms.Button();
            this.addProduct1 = new parcial_2.Desing.AddProduct();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonvistapedidos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(792, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttoneliminaruser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonagregaruser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addUser1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.80952F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.19048F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttoneliminaruser
            // 
            this.buttoneliminaruser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttoneliminaruser.Location = new System.Drawing.Point(505, 15);
            this.buttoneliminaruser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoneliminaruser.Name = "buttoneliminaruser";
            this.buttoneliminaruser.Size = new System.Drawing.Size(169, 52);
            this.buttoneliminaruser.TabIndex = 1;
            this.buttoneliminaruser.Text = "Eliminar";
            this.buttoneliminaruser.UseVisualStyleBackColor = true;
            this.buttoneliminaruser.Click += new System.EventHandler(this.buttoneliminaruser_Click);
            // 
            // buttonagregaruser
            // 
            this.buttonagregaruser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonagregaruser.Location = new System.Drawing.Point(110, 16);
            this.buttonagregaruser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonagregaruser.Name = "buttonagregaruser";
            this.buttonagregaruser.Size = new System.Drawing.Size(172, 49);
            this.buttonagregaruser.TabIndex = 0;
            this.buttonagregaruser.Text = "agregar";
            this.buttonagregaruser.UseVisualStyleBackColor = true;
            this.buttonagregaruser.Click += new System.EventHandler(this.buttonagregaruser_Click);
            // 
            // addUser1
            // 
            this.addUser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.addUser1, 2);
            this.addUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser1.Location = new System.Drawing.Point(4, 86);
            this.addUser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(778, 430);
            this.addUser1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(792, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Negocios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttoneliminarnegocio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonaddnegocio, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addBusiness1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96154F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.03846F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 520);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttoneliminarnegocio
            // 
            this.buttoneliminarnegocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttoneliminarnegocio.Location = new System.Drawing.Point(512, 20);
            this.buttoneliminarnegocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoneliminarnegocio.Name = "buttoneliminarnegocio";
            this.buttoneliminarnegocio.Size = new System.Drawing.Size(154, 42);
            this.buttoneliminarnegocio.TabIndex = 1;
            this.buttoneliminarnegocio.Text = "Eliminar";
            this.buttoneliminarnegocio.UseVisualStyleBackColor = true;
            this.buttoneliminarnegocio.Click += new System.EventHandler(this.buttoneliminarnegocio_Click);
            // 
            // buttonaddnegocio
            // 
            this.buttonaddnegocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonaddnegocio.Location = new System.Drawing.Point(114, 18);
            this.buttonaddnegocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonaddnegocio.Name = "buttonaddnegocio";
            this.buttonaddnegocio.Size = new System.Drawing.Size(164, 46);
            this.buttonaddnegocio.TabIndex = 0;
            this.buttonaddnegocio.Text = "Agregar";
            this.buttonaddnegocio.UseVisualStyleBackColor = true;
            this.buttonaddnegocio.Click += new System.EventHandler(this.buttonaddnegocio_Click);
            // 
            // addBusiness1
            // 
            this.addBusiness1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.SetColumnSpan(this.addBusiness1, 2);
            this.addBusiness1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBusiness1.Location = new System.Drawing.Point(4, 88);
            this.addBusiness1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBusiness1.Name = "addBusiness1";
            this.addBusiness1.Size = new System.Drawing.Size(778, 427);
            this.addBusiness1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(792, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Producto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttoneliminateproduct, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonaddproducto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.addProduct1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 520);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttoneliminateproduct
            // 
            this.buttoneliminateproduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttoneliminateproduct.Location = new System.Drawing.Point(512, 14);
            this.buttoneliminateproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoneliminateproduct.Name = "buttoneliminateproduct";
            this.buttoneliminateproduct.Size = new System.Drawing.Size(155, 51);
            this.buttoneliminateproduct.TabIndex = 1;
            this.buttoneliminateproduct.Text = "Eliminar";
            this.buttoneliminateproduct.UseVisualStyleBackColor = true;
            this.buttoneliminateproduct.Click += new System.EventHandler(this.buttoneliminateproduct_Click);
            // 
            // buttonaddproducto
            // 
            this.buttonaddproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonaddproducto.Location = new System.Drawing.Point(119, 16);
            this.buttonaddproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonaddproducto.Name = "buttonaddproducto";
            this.buttonaddproducto.Size = new System.Drawing.Size(154, 46);
            this.buttonaddproducto.TabIndex = 0;
            this.buttonaddproducto.Text = "Agregar";
            this.buttonaddproducto.UseVisualStyleBackColor = true;
            this.buttonaddproducto.Click += new System.EventHandler(this.buttonaddproducto_Click);
            // 
            // addProduct1
            // 
            this.addProduct1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.addProduct1, 2);
            this.addProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProduct1.Location = new System.Drawing.Point(4, 84);
            this.addProduct1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(778, 431);
            this.addProduct1.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonvistapedidos);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(792, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pedidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonvistapedidos
            // 
            this.buttonvistapedidos.Location = new System.Drawing.Point(292, 42);
            this.buttonvistapedidos.Name = "buttonvistapedidos";
            this.buttonvistapedidos.Size = new System.Drawing.Size(185, 53);
            this.buttonvistapedidos.TabIndex = 1;
            this.buttonvistapedidos.Text = "Ver pedidos";
            this.buttonvistapedidos.UseVisualStyleBackColor = true;
            // 
            // MainAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainAdministrador";
            this.Text = "Hugo-Administrador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonagregaruser;
        private System.Windows.Forms.Button buttoneliminarnegocio;
        private System.Windows.Forms.Button buttonaddnegocio;
        private System.Windows.Forms.Button buttoneliminaruser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonaddproducto;
        private System.Windows.Forms.Button buttoneliminateproduct;
        private parcial_2.Desing.AddUser addUser1;
        private parcial_2.Desing.AddBusiness addBusiness1;
        private parcial_2.Desing.AddProduct addProduct1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonvistapedidos;
    }
}