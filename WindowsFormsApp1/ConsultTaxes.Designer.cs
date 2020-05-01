namespace WindowsFormsApp1
{
    partial class ConsultTaxes
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
            this.lblpPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipodeVehiculo = new System.Windows.Forms.Label();
            this.txtAvaluo = new System.Windows.Forms.TextBox();
            this.lblAvaluo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpPlaca
            // 
            this.lblpPlaca.AutoSize = true;
            this.lblpPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpPlaca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpPlaca.Location = new System.Drawing.Point(253, 50);
            this.lblpPlaca.Name = "lblpPlaca";
            this.lblpPlaca.Size = new System.Drawing.Size(43, 16);
            this.lblpPlaca.TabIndex = 0;
            this.lblpPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(421, 49);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(152, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(421, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(152, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelo.Location = new System.Drawing.Point(253, 86);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 16);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(253, 120);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 16);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Toyota",
            "Mazda",
            "Chevrolet",
            "Renault",
            "Audi"});
            this.cmbMarca.Location = new System.Drawing.Point(421, 119);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(152, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Camioneta",
            "Campero",
            "Camión",
            "Automovíl",
            "Microbús"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(421, 156);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(152, 21);
            this.cmbTipoVehiculo.TabIndex = 7;
            // 
            // lblTipodeVehiculo
            // 
            this.lblTipodeVehiculo.AutoSize = true;
            this.lblTipodeVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipodeVehiculo.Location = new System.Drawing.Point(253, 157);
            this.lblTipodeVehiculo.Name = "lblTipodeVehiculo";
            this.lblTipodeVehiculo.Size = new System.Drawing.Size(108, 16);
            this.lblTipodeVehiculo.TabIndex = 6;
            this.lblTipodeVehiculo.Text = "Tipo de vehículo";
            // 
            // txtAvaluo
            // 
            this.txtAvaluo.Location = new System.Drawing.Point(421, 194);
            this.txtAvaluo.Name = "txtAvaluo";
            this.txtAvaluo.Size = new System.Drawing.Size(152, 20);
            this.txtAvaluo.TabIndex = 9;
            // 
            // lblAvaluo
            // 
            this.lblAvaluo.AutoSize = true;
            this.lblAvaluo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaluo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAvaluo.Location = new System.Drawing.Point(253, 195);
            this.lblAvaluo.Name = "lblAvaluo";
            this.lblAvaluo.Size = new System.Drawing.Size(112, 16);
            this.lblAvaluo.TabIndex = 8;
            this.lblAvaluo.Text = "Avalúo comercial";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(421, 271);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(253, 272);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre propietario";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(421, 307);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(152, 20);
            this.txtCedula.TabIndex = 13;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCedula.Location = new System.Drawing.Point(253, 308);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(119, 16);
            this.lblCedula.TabIndex = 12;
            this.lblCedula.Text = "Cedula propietario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(59)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(61, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(30)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(349, 375);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Cacular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(637, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultTaxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtAvaluo);
            this.Controls.Add(this.lblAvaluo);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipodeVehiculo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblpPlaca);
            this.Name = "ConsultTaxes";
            this.Text = "Calculadora de impuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label lblTipodeVehiculo;
        private System.Windows.Forms.TextBox txtAvaluo;
        private System.Windows.Forms.Label lblAvaluo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}