using System.ComponentModel;

namespace parcial_2.Desing
{
    partial class EliminateUser
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
            this.comboBoxusuarios = new System.Windows.Forms.ComboBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.67822F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32178F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxusuarios, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttoneliminar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxusuarios
            // 
            this.comboBoxusuarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxusuarios.FormattingEnabled = true;
            this.comboBoxusuarios.Location = new System.Drawing.Point(364, 114);
            this.comboBoxusuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxusuarios.Name = "comboBoxusuarios";
            this.comboBoxusuarios.Size = new System.Drawing.Size(193, 28);
            this.comboBoxusuarios.TabIndex = 0;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttoneliminar.Location = new System.Drawing.Point(364, 258);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(158, 68);
            this.buttoneliminar.TabIndex = 1;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(210, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EliminateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EliminateUser";
            this.Size = new System.Drawing.Size(808, 512);
            this.Load += new System.EventHandler(this.EliminateUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.ComboBox comboBoxusuarios;
        private System.Windows.Forms.Label label1;
    }
}