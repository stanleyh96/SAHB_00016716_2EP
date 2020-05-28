using System.ComponentModel;

namespace parcial_2.Desing
{
    partial class AddProduct
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxnombreproduct = new System.Windows.Forms.TextBox();
            this.button1agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxempresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.57178F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.42822F));
            this.tableLayoutPanel1.Controls.Add(this.button1agregar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxnombreproduct, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxempresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 612);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxnombreproduct
            // 
            this.textBoxnombreproduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxnombreproduct.Location = new System.Drawing.Point(343, 367);
            this.textBoxnombreproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombreproduct.Name = "textBoxnombreproduct";
            this.textBoxnombreproduct.Size = new System.Drawing.Size(271, 31);
            this.textBoxnombreproduct.TabIndex = 0;
            // 
            // button1agregar
            // 
            this.button1agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1agregar.Location = new System.Drawing.Point(343, 462);
            this.button1agregar.Name = "button1agregar";
            this.button1agregar.Size = new System.Drawing.Size(183, 53);
            this.button1agregar.TabIndex = 1;
            this.button1agregar.Text = "Agregar";
            this.button1agregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(78, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Porducto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxempresa
            // 
            this.comboBoxempresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxempresa.FormattingEnabled = true;
            this.comboBoxempresa.Location = new System.Drawing.Point(343, 209);
            this.comboBoxempresa.Name = "comboBoxempresa";
            this.comboBoxempresa.Size = new System.Drawing.Size(240, 33);
            this.comboBoxempresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(78, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empresa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(801, 612);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnombreproduct;
        private System.Windows.Forms.Button button1agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxempresa;
    }
}