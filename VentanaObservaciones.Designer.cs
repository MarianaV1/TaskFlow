namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaObservaciones
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
            this.BtnSubirObservacion = new System.Windows.Forms.Button();
            this.LblTarea = new System.Windows.Forms.Label();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.rchTxtObservaciones = new System.Windows.Forms.RichTextBox();
            this.cmbListaTareas = new System.Windows.Forms.ComboBox();
            this.listViewObservaciones = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnSubirObservacion
            // 
            this.BtnSubirObservacion.Location = new System.Drawing.Point(452, 397);
            this.BtnSubirObservacion.Name = "BtnSubirObservacion";
            this.BtnSubirObservacion.Size = new System.Drawing.Size(233, 56);
            this.BtnSubirObservacion.TabIndex = 0;
            this.BtnSubirObservacion.Text = "Subir observacion";
            this.BtnSubirObservacion.UseVisualStyleBackColor = true;
            this.BtnSubirObservacion.Click += new System.EventHandler(this.BtnSubirObservacion_Click);
            // 
            // LblTarea
            // 
            this.LblTarea.AutoSize = true;
            this.LblTarea.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarea.Location = new System.Drawing.Point(28, 78);
            this.LblTarea.Name = "LblTarea";
            this.LblTarea.Size = new System.Drawing.Size(155, 23);
            this.LblTarea.TabIndex = 1;
            this.LblTarea.Text = "TAREA OBJETIVO:";
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(28, 123);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(155, 23);
            this.LblObservaciones.TabIndex = 2;
            this.LblObservaciones.Text = "OBSERVACIONES:";
            // 
            // rchTxtObservaciones
            // 
            this.rchTxtObservaciones.Location = new System.Drawing.Point(208, 123);
            this.rchTxtObservaciones.Name = "rchTxtObservaciones";
            this.rchTxtObservaciones.Size = new System.Drawing.Size(487, 55);
            this.rchTxtObservaciones.TabIndex = 3;
            this.rchTxtObservaciones.Text = "";
            // 
            // cmbListaTareas
            // 
            this.cmbListaTareas.FormattingEnabled = true;
            this.cmbListaTareas.Location = new System.Drawing.Point(208, 80);
            this.cmbListaTareas.Name = "cmbListaTareas";
            this.cmbListaTareas.Size = new System.Drawing.Size(487, 24);
            this.cmbListaTareas.TabIndex = 4;
            // 
            // listViewObservaciones
            // 
            this.listViewObservaciones.HideSelection = false;
            this.listViewObservaciones.Location = new System.Drawing.Point(32, 204);
            this.listViewObservaciones.Name = "listViewObservaciones";
            this.listViewObservaciones.Size = new System.Drawing.Size(663, 167);
            this.listViewObservaciones.TabIndex = 5;
            this.listViewObservaciones.UseCompatibleStateImageBehavior = false;
            this.listViewObservaciones.View = System.Windows.Forms.View.Details;
            // 
            // VentanaObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 465);
            this.Controls.Add(this.listViewObservaciones);
            this.Controls.Add(this.cmbListaTareas);
            this.Controls.Add(this.rchTxtObservaciones);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblTarea);
            this.Controls.Add(this.BtnSubirObservacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaObservaciones";
            this.Text = "VentanaObservaciones";
            this.Load += new System.EventHandler(this.VentanaObservaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubirObservacion;
        private System.Windows.Forms.Label LblTarea;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.RichTextBox rchTxtObservaciones;
        private System.Windows.Forms.ComboBox cmbListaTareas;
        private System.Windows.Forms.ListView listViewObservaciones;
    }
}