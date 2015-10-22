namespace Requerimientos
{
    partial class Principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnOnenote = new System.Windows.Forms.Button();
            this.btnAcces = new System.Windows.Forms.Button();
            this.btnoutlook = new System.Windows.Forms.Button();
            this.btnpowerpoint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnactualizar);
            this.tabPage1.Controls.Add(this.txttelefono);
            this.tabPage1.Controls.Add(this.txtcorreo);
            this.tabPage1.Controls.Add(this.txtapellido);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblInicio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Perfil";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(163, 221);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 9;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(218, 158);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(159, 20);
            this.txttelefono.TabIndex = 8;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(29, 158);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(159, 20);
            this.txtcorreo.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(218, 61);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(159, 20);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(29, 61);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(159, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(8, 20);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(63, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bienvenido ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblmensaje);
            this.tabPage2.Controls.Add(this.btnPublisher);
            this.tabPage2.Controls.Add(this.btnOnenote);
            this.tabPage2.Controls.Add(this.btnAcces);
            this.tabPage2.Controls.Add(this.btnoutlook);
            this.tabPage2.Controls.Add(this.btnpowerpoint);
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.btnWord);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Acceso";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(9, 19);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(271, 13);
            this.lblmensaje.TabIndex = 7;
            this.lblmensaje.Text = "Solo se habilitarán los programas a los que tiene acceso";
            // 
            // btnPublisher
            // 
            this.btnPublisher.Enabled = false;
            this.btnPublisher.Image = global::Requerimientos.Properties.Resources.publisher;
            this.btnPublisher.Location = new System.Drawing.Point(60, 147);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(75, 68);
            this.btnPublisher.TabIndex = 6;
            this.btnPublisher.UseVisualStyleBackColor = true;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnOnenote
            // 
            this.btnOnenote.Enabled = false;
            this.btnOnenote.Image = global::Requerimientos.Properties.Resources.Onenote;
            this.btnOnenote.Location = new System.Drawing.Point(151, 147);
            this.btnOnenote.Name = "btnOnenote";
            this.btnOnenote.Size = new System.Drawing.Size(75, 68);
            this.btnOnenote.TabIndex = 5;
            this.btnOnenote.UseVisualStyleBackColor = true;
            this.btnOnenote.Click += new System.EventHandler(this.btnOnenote_Click);
            // 
            // btnAcces
            // 
            this.btnAcces.Enabled = false;
            this.btnAcces.Image = global::Requerimientos.Properties.Resources.Acces;
            this.btnAcces.Location = new System.Drawing.Point(242, 147);
            this.btnAcces.Name = "btnAcces";
            this.btnAcces.Size = new System.Drawing.Size(75, 68);
            this.btnAcces.TabIndex = 4;
            this.btnAcces.UseVisualStyleBackColor = true;
            this.btnAcces.Click += new System.EventHandler(this.btnAcces_Click);
            // 
            // btnoutlook
            // 
            this.btnoutlook.Enabled = false;
            this.btnoutlook.Image = global::Requerimientos.Properties.Resources.outlook;
            this.btnoutlook.Location = new System.Drawing.Point(269, 46);
            this.btnoutlook.Name = "btnoutlook";
            this.btnoutlook.Size = new System.Drawing.Size(75, 68);
            this.btnoutlook.TabIndex = 3;
            this.btnoutlook.UseVisualStyleBackColor = true;
            this.btnoutlook.Click += new System.EventHandler(this.btnoutlook_Click);
            // 
            // btnpowerpoint
            // 
            this.btnpowerpoint.Enabled = false;
            this.btnpowerpoint.Image = global::Requerimientos.Properties.Resources.pp;
            this.btnpowerpoint.Location = new System.Drawing.Point(183, 46);
            this.btnpowerpoint.Name = "btnpowerpoint";
            this.btnpowerpoint.Size = new System.Drawing.Size(75, 68);
            this.btnpowerpoint.TabIndex = 2;
            this.btnpowerpoint.UseVisualStyleBackColor = true;
            this.btnpowerpoint.Click += new System.EventHandler(this.btnpowerpoint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Enabled = false;
            this.btnExcel.Image = global::Requerimientos.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(102, 46);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 68);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Enabled = false;
            this.btnWord.Image = global::Requerimientos.Properties.Resources.word;
            this.btnWord.Location = new System.Drawing.Point(21, 46);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 68);
            this.btnWord.TabIndex = 0;
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 294);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnOnenote;
        private System.Windows.Forms.Button btnAcces;
        private System.Windows.Forms.Button btnoutlook;
        private System.Windows.Forms.Button btnpowerpoint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}