using System.ComponentModel;

namespace parcial_2.Desing
{
    partial class AddBusiness
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.01552F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.98448F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxnombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxdescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonagregar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(117, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxnombre.Location = new System.Drawing.Point(390, 180);
            this.textBoxnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(214, 27);
            this.textBoxnombre.TabIndex = 0;
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxdescripcion.Location = new System.Drawing.Point(390, 300);
            this.textBoxdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(214, 27);
            this.textBoxdescripcion.TabIndex = 1;
            // 
            // buttonagregar
            // 
            this.buttonagregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonagregar.Location = new System.Drawing.Point(390, 420);
            this.buttonagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(157, 62);
            this.buttonagregar.TabIndex = 2;
            this.buttonagregar.Text = "Agregar";
            this.buttonagregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(117, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddBusiness";
            this.Size = new System.Drawing.Size(902, 638);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.TextBox textBoxdescripcion;
        private System.Windows.Forms.TextBox textBoxnombre;
    }
}