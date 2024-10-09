namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaEliminarContacto
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
            this.AceptarEliminar = new System.Windows.Forms.Button();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.ElimTxt = new System.Windows.Forms.Label();
            this.BtnRegresarElimContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AceptarEliminar
            // 
            this.AceptarEliminar.Location = new System.Drawing.Point(446, 284);
            this.AceptarEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarEliminar.Name = "AceptarEliminar";
            this.AceptarEliminar.Size = new System.Drawing.Size(212, 89);
            this.AceptarEliminar.TabIndex = 0;
            this.AceptarEliminar.Text = "Aceptar";
            this.AceptarEliminar.UseVisualStyleBackColor = true;
            this.AceptarEliminar.Click += new System.EventHandler(this.AceptarEliminar_Click);
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(211, 218);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(365, 22);
            this.txtNombreContacto.TabIndex = 1;
            this.txtNombreContacto.TextChanged += new System.EventHandler(this.txtNombreContacto_TextChanged);
            // 
            // ElimTxt
            // 
            this.ElimTxt.AutoSize = true;
            this.ElimTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.ElimTxt.Location = new System.Drawing.Point(205, 134);
            this.ElimTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElimTxt.Name = "ElimTxt";
            this.ElimTxt.Size = new System.Drawing.Size(388, 32);
            this.ElimTxt.TabIndex = 2;
            this.ElimTxt.Text = "Nombre del colaborador a Eliminar:";
            // 
            // BtnRegresarElimContacto
            // 
            this.BtnRegresarElimContacto.Location = new System.Drawing.Point(130, 284);
            this.BtnRegresarElimContacto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresarElimContacto.Name = "BtnRegresarElimContacto";
            this.BtnRegresarElimContacto.Size = new System.Drawing.Size(212, 89);
            this.BtnRegresarElimContacto.TabIndex = 3;
            this.BtnRegresarElimContacto.Text = "Regresar";
            this.BtnRegresarElimContacto.UseVisualStyleBackColor = true;
            this.BtnRegresarElimContacto.Click += new System.EventHandler(this.BtnRegresarElimContacto_Click);
            // 
            // VentanaEliminarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 465);
            this.Controls.Add(this.BtnRegresarElimContacto);
            this.Controls.Add(this.ElimTxt);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.AceptarEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaEliminarContacto";
            this.Text = "VentanaEliminarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptarEliminar;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label ElimTxt;
        private System.Windows.Forms.Button BtnRegresarElimContacto;
    }
}