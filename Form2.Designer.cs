namespace Requerimientos
{
    partial class Cuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.listcuentas = new System.Windows.Forms.ListView();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.co = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listcuentas
            // 
            this.listcuentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.co});
            this.listcuentas.Location = new System.Drawing.Point(12, 22);
            this.listcuentas.Name = "listcuentas";
            this.listcuentas.Size = new System.Drawing.Size(141, 196);
            this.listcuentas.TabIndex = 0;
            this.listcuentas.UseCompatibleStateImageBehavior = false;
            this.listcuentas.SelectedIndexChanged += new System.EventHandler(this.listcuentas_SelectedIndexChanged);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(233, 34);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(109, 13);
            this.lblCuenta.TabIndex = 1;
            this.lblCuenta.Text = "Cuenta Seleccionada";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(236, 101);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(207, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(33, 224);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(98, 32);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "Eliminar Cuenta";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // co
            // 
            this.co.Text = "Seleccione una cuenta";
            this.co.Width = 200;
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 258);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.listcuentas);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listcuentas;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.ColumnHeader co;
    }
}