namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaNuevaCita
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
            this.comboBoxContactos = new System.Windows.Forms.ComboBox();
            this.AceptarNuevaCita = new System.Windows.Forms.Button();
            this.dateTimePickerFechaHora = new System.Windows.Forms.DateTimePicker();
            this.BtnRegresarNuevaCita = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtNuevoAsunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxContactos
            // 
            this.comboBoxContactos.FormattingEnabled = true;
            this.comboBoxContactos.Location = new System.Drawing.Point(268, 110);
            this.comboBoxContactos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxContactos.Name = "comboBoxContactos";
            this.comboBoxContactos.Size = new System.Drawing.Size(504, 24);
            this.comboBoxContactos.TabIndex = 1;
            this.comboBoxContactos.SelectedIndexChanged += new System.EventHandler(this.comboBoxContactos_SelectedIndexChanged);
            // 
            // AceptarNuevaCita
            // 
            this.AceptarNuevaCita.Location = new System.Drawing.Point(510, 388);
            this.AceptarNuevaCita.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarNuevaCita.Name = "AceptarNuevaCita";
            this.AceptarNuevaCita.Size = new System.Drawing.Size(240, 123);
            this.AceptarNuevaCita.TabIndex = 2;
            this.AceptarNuevaCita.Text = "Aceptar";
            this.AceptarNuevaCita.UseVisualStyleBackColor = true;
            this.AceptarNuevaCita.Click += new System.EventHandler(this.AceptarNuevaCita_Click);
            // 
            // dateTimePickerFechaHora
            // 
            this.dateTimePickerFechaHora.CustomFormat = "";
            this.dateTimePickerFechaHora.Location = new System.Drawing.Point(268, 179);
            this.dateTimePickerFechaHora.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaHora.Name = "dateTimePickerFechaHora";
            this.dateTimePickerFechaHora.Size = new System.Drawing.Size(504, 22);
            this.dateTimePickerFechaHora.TabIndex = 3;
            this.dateTimePickerFechaHora.Value = new System.DateTime(2023, 5, 11, 22, 31, 54, 0);
            this.dateTimePickerFechaHora.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHora_ValueChanged);
            // 
            // BtnRegresarNuevaCita
            // 
            this.BtnRegresarNuevaCita.Location = new System.Drawing.Point(13, 388);
            this.BtnRegresarNuevaCita.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresarNuevaCita.Name = "BtnRegresarNuevaCita";
            this.BtnRegresarNuevaCita.Size = new System.Drawing.Size(240, 123);
            this.BtnRegresarNuevaCita.TabIndex = 4;
            this.BtnRegresarNuevaCita.Text = "Regresar";
            this.BtnRegresarNuevaCita.UseVisualStyleBackColor = true;
            this.BtnRegresarNuevaCita.Click += new System.EventHandler(this.BtnRegresarNuevaCita_Click);
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.CustomFormat = "";
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(268, 212);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(504, 22);
            this.dateTimePickerFechaFin.TabIndex = 5;
            this.dateTimePickerFechaFin.Value = new System.DateTime(2023, 5, 11, 22, 31, 54, 0);
            this.dateTimePickerFechaFin.ValueChanged += new System.EventHandler(this.dateTimePickerFechaFin_ValueChanged);
            // 
            // txtNuevoAsunto
            // 
            this.txtNuevoAsunto.Location = new System.Drawing.Point(268, 143);
            this.txtNuevoAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoAsunto.Name = "txtNuevoAsunto";
            this.txtNuevoAsunto.Size = new System.Drawing.Size(504, 22);
            this.txtNuevoAsunto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Encargado de la tarea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de fin";
            // 
            // VentanaNuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevoAsunto);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.BtnRegresarNuevaCita);
            this.Controls.Add(this.dateTimePickerFechaHora);
            this.Controls.Add(this.AceptarNuevaCita);
            this.Controls.Add(this.comboBoxContactos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaNuevaCita";
            this.Text = "VentanaNuevaCita";
            this.Load += new System.EventHandler(this.VentanaNuevaCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxContactos;
        private System.Windows.Forms.Button AceptarNuevaCita;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHora;
        private System.Windows.Forms.Button BtnRegresarNuevaCita;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.TextBox txtNuevoAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}