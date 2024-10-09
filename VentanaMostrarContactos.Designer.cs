namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaMostrarContactos
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.ListViewContactos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(13, 429);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(160, 58);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // ListViewContactos
            // 
            this.ListViewContactos.HideSelection = false;
            this.ListViewContactos.Location = new System.Drawing.Point(13, 13);
            this.ListViewContactos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListViewContactos.Name = "ListViewContactos";
            this.ListViewContactos.Size = new System.Drawing.Size(731, 408);
            this.ListViewContactos.TabIndex = 2;
            this.ListViewContactos.UseCompatibleStateImageBehavior = false;
            this.ListViewContactos.View = System.Windows.Forms.View.Details;
            this.ListViewContactos.SelectedIndexChanged += new System.EventHandler(this.ListViewContactos_SelectedIndexChanged);
            // 
            // VentanaMostrarContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ListViewContactos);
            this.Controls.Add(this.BtnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaMostrarContactos";
            this.Text = "VentanaMostrarContactos";
            this.Load += new System.EventHandler(this.VentanaMostrarContactos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.ListView ListViewContactos;
    }
}