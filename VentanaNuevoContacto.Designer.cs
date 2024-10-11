namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaNuevoContacto
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
            this.NuevoNombre = new System.Windows.Forms.Label();
            this.NuevoCorreo = new System.Windows.Forms.Label();
            this.NuevoTelefono = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevoCorreo = new System.Windows.Forms.TextBox();
            this.txtNuevoTelefono = new System.Windows.Forms.TextBox();
            this.AceptarContacto = new System.Windows.Forms.Button();
            this.BtnSalirNuevoContacto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NuevoNombre
            // 
            this.NuevoNombre.AutoSize = true;
            this.NuevoNombre.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoNombre.Location = new System.Drawing.Point(28, 59);
            this.NuevoNombre.Name = "NuevoNombre";
            this.NuevoNombre.Size = new System.Drawing.Size(87, 26);
            this.NuevoNombre.TabIndex = 0;
            this.NuevoNombre.Text = "Nombre:";
            // 
            // NuevoCorreo
            // 
            this.NuevoCorreo.AutoSize = true;
            this.NuevoCorreo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoCorreo.Location = new System.Drawing.Point(28, 126);
            this.NuevoCorreo.Name = "NuevoCorreo";
            this.NuevoCorreo.Size = new System.Drawing.Size(72, 26);
            this.NuevoCorreo.TabIndex = 1;
            this.NuevoCorreo.Text = "Correo:";
            // 
            // NuevoTelefono
            // 
            this.NuevoTelefono.AutoSize = true;
            this.NuevoTelefono.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoTelefono.Location = new System.Drawing.Point(28, 90);
            this.NuevoTelefono.Name = "NuevoTelefono";
            this.NuevoTelefono.Size = new System.Drawing.Size(89, 26);
            this.NuevoTelefono.TabIndex = 2;
            this.NuevoTelefono.Text = "Telefono:";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(123, 65);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(427, 20);
            this.txtNuevoNombre.TabIndex = 3;
            this.txtNuevoNombre.TextChanged += new System.EventHandler(this.txtNuevoNombre_TextChanged);
            // 
            // txtNuevoCorreo
            // 
            this.txtNuevoCorreo.Location = new System.Drawing.Point(123, 132);
            this.txtNuevoCorreo.Name = "txtNuevoCorreo";
            this.txtNuevoCorreo.Size = new System.Drawing.Size(427, 20);
            this.txtNuevoCorreo.TabIndex = 4;
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Location = new System.Drawing.Point(123, 96);
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(427, 20);
            this.txtNuevoTelefono.TabIndex = 5;
            // 
            // AceptarContacto
            // 
            this.AceptarContacto.Location = new System.Drawing.Point(123, 218);
            this.AceptarContacto.Name = "AceptarContacto";
            this.AceptarContacto.Size = new System.Drawing.Size(167, 61);
            this.AceptarContacto.TabIndex = 6;
            this.AceptarContacto.Text = "Aceptar";
            this.AceptarContacto.UseVisualStyleBackColor = true;
            this.AceptarContacto.Click += new System.EventHandler(this.AceptarContacto_Click);
            // 
            // BtnSalirNuevoContacto
            // 
            this.BtnSalirNuevoContacto.AutoSize = true;
            this.BtnSalirNuevoContacto.Location = new System.Drawing.Point(357, 218);
            this.BtnSalirNuevoContacto.Name = "BtnSalirNuevoContacto";
            this.BtnSalirNuevoContacto.Size = new System.Drawing.Size(167, 61);
            this.BtnSalirNuevoContacto.TabIndex = 7;
            this.BtnSalirNuevoContacto.Text = "Regresar";
            this.BtnSalirNuevoContacto.UseVisualStyleBackColor = true;
            this.BtnSalirNuevoContacto.Click += new System.EventHandler(this.BtnSalirNuevoContacto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(123, 171);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(427, 21);
            this.cmbRol.TabIndex = 9;
            // 
            // VentanaNuevoContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 327);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalirNuevoContacto);
            this.Controls.Add(this.AceptarContacto);
            this.Controls.Add(this.txtNuevoTelefono);
            this.Controls.Add(this.txtNuevoCorreo);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.NuevoTelefono);
            this.Controls.Add(this.NuevoCorreo);
            this.Controls.Add(this.NuevoNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaNuevoContacto";
            this.Text = "VentanaNuevoContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label NuevoNombre;
        public System.Windows.Forms.Label NuevoCorreo;
        public System.Windows.Forms.Label NuevoTelefono;
        public System.Windows.Forms.TextBox txtNuevoNombre;
        public System.Windows.Forms.TextBox txtNuevoCorreo;
        public System.Windows.Forms.TextBox txtNuevoTelefono;
        public System.Windows.Forms.Button AceptarContacto;
        public System.Windows.Forms.Button BtnSalirNuevoContacto;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbRol;
    }
}