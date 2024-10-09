namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaBorrarCita
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
            this.BtnRegresarBorrarCita = new System.Windows.Forms.Button();
            this.BtnBorrarCita = new System.Windows.Forms.Button();
            this.comboBoxCitas = new System.Windows.Forms.ComboBox();
            this.ElimTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegresarBorrarCita
            // 
            this.BtnRegresarBorrarCita.Location = new System.Drawing.Point(414, 286);
            this.BtnRegresarBorrarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegresarBorrarCita.Name = "BtnRegresarBorrarCita";
            this.BtnRegresarBorrarCita.Size = new System.Drawing.Size(183, 96);
            this.BtnRegresarBorrarCita.TabIndex = 0;
            this.BtnRegresarBorrarCita.Text = "Regresar";
            this.BtnRegresarBorrarCita.UseVisualStyleBackColor = true;
            this.BtnRegresarBorrarCita.Click += new System.EventHandler(this.BtnRegresarBorrarCita_Click);
            // 
            // BtnBorrarCita
            // 
            this.BtnBorrarCita.Location = new System.Drawing.Point(46, 286);
            this.BtnBorrarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBorrarCita.Name = "BtnBorrarCita";
            this.BtnBorrarCita.Size = new System.Drawing.Size(183, 96);
            this.BtnBorrarCita.TabIndex = 1;
            this.BtnBorrarCita.Text = "Borrar";
            this.BtnBorrarCita.UseVisualStyleBackColor = true;
            this.BtnBorrarCita.Click += new System.EventHandler(this.BtnBorrarCita_Click);
            // 
            // comboBoxCitas
            // 
            this.comboBoxCitas.FormattingEnabled = true;
            this.comboBoxCitas.Location = new System.Drawing.Point(49, 184);
            this.comboBoxCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCitas.Name = "comboBoxCitas";
            this.comboBoxCitas.Size = new System.Drawing.Size(548, 24);
            this.comboBoxCitas.TabIndex = 2;
            this.comboBoxCitas.SelectedIndexChanged += new System.EventHandler(this.comboBoxCitas_SelectedIndexChanged);
            // 
            // ElimTxt
            // 
            this.ElimTxt.AutoSize = true;
            this.ElimTxt.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.ElimTxt.Location = new System.Drawing.Point(43, 117);
            this.ElimTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElimTxt.Name = "ElimTxt";
            this.ElimTxt.Size = new System.Drawing.Size(186, 32);
            this.ElimTxt.TabIndex = 3;
            this.ElimTxt.Text = "Tarea a eliminar:";
            // 
            // VentanaBorrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ElimTxt);
            this.Controls.Add(this.comboBoxCitas);
            this.Controls.Add(this.BtnBorrarCita);
            this.Controls.Add(this.BtnRegresarBorrarCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaBorrarCita";
            this.Text = "VentanaBorrarCita";
            this.Load += new System.EventHandler(this.VentanaBorrarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresarBorrarCita;
        private System.Windows.Forms.Button BtnBorrarCita;
        private System.Windows.Forms.ComboBox comboBoxCitas;
        private System.Windows.Forms.Label ElimTxt;
    }
}