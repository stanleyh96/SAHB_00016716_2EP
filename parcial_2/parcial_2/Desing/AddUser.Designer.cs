using System.ComponentModel;

namespace parcial_2.Desing
{
    partial class AddUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnamecomplete = new System.Windows.Forms.TextBox();
            this.textBoxnameuser = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.comboBoxadmi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77588F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22412F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxnamecomplete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxnameuser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxpassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxadmi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(118, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 49);
            this.label4.TabIndex = 7;
            this.label4.Text = "Administrador:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(118, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 49);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pasword:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(118, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxnamecomplete
            // 
            this.textBoxnamecomplete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxnamecomplete.Location = new System.Drawing.Point(378, 35);
            this.textBoxnamecomplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnamecomplete.Name = "textBoxnamecomplete";
            this.textBoxnamecomplete.Size = new System.Drawing.Size(264, 27);
            this.textBoxnamecomplete.TabIndex = 0;
            // 
            // textBoxnameuser
            // 
            this.textBoxnameuser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxnameuser.Location = new System.Drawing.Point(378, 133);
            this.textBoxnameuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnameuser.Name = "textBoxnameuser";
            this.textBoxnameuser.Size = new System.Drawing.Size(264, 27);
            this.textBoxnameuser.TabIndex = 1;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxpassword.Location = new System.Drawing.Point(378, 231);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(213, 27);
            this.textBoxpassword.TabIndex = 2;
            // 
            // comboBoxadmi
            // 
            this.comboBoxadmi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxadmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxadmi.FormattingEnabled = true;
            this.comboBoxadmi.Items.AddRange(new object[] {"true", "false"});
            this.comboBoxadmi.Location = new System.Drawing.Point(378, 329);
            this.comboBoxadmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxadmi.Name = "comboBoxadmi";
            this.comboBoxadmi.Size = new System.Drawing.Size(174, 28);
            this.comboBoxadmi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(118, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre completo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(378, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(879, 514);
            //this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxadmi;
        private System.Windows.Forms.TextBox textBoxnamecomplete;
        private System.Windows.Forms.TextBox textBoxnameuser;
        private System.Windows.Forms.TextBox textBoxpassword;
    }
}

namespace System.Windows.Forms
{
    
}