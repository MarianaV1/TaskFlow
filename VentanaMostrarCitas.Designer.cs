namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VentanaMostrarCitas
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
            this.ListViewCitas = new System.Windows.Forms.ListView();
            this.BtnRegresarCitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewCitas
            // 
            this.ListViewCitas.HideSelection = false;
            this.ListViewCitas.Location = new System.Drawing.Point(16, 31);
            this.ListViewCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListViewCitas.Name = "ListViewCitas";
            this.ListViewCitas.Size = new System.Drawing.Size(716, 349);
            this.ListViewCitas.TabIndex = 0;
            this.ListViewCitas.UseCompatibleStateImageBehavior = false;
            this.ListViewCitas.View = System.Windows.Forms.View.Details;
            this.ListViewCitas.SelectedIndexChanged += new System.EventHandler(this.ListViewCitas_SelectedIndexChanged);
            // 
            // BtnRegresarCitas
            // 
            this.BtnRegresarCitas.Location = new System.Drawing.Point(16, 415);
            this.BtnRegresarCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegresarCitas.Name = "BtnRegresarCitas";
            this.BtnRegresarCitas.Size = new System.Drawing.Size(172, 64);
            this.BtnRegresarCitas.TabIndex = 1;
            this.BtnRegresarCitas.Text = "Regresar";
            this.BtnRegresarCitas.UseVisualStyleBackColor = true;
            this.BtnRegresarCitas.Click += new System.EventHandler(this.BtnRegresarCitas_Click);
            // 
            // VentanaMostrarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnRegresarCitas);
            this.Controls.Add(this.ListViewCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaMostrarCitas";
            this.Text = "VentanaMostrarCitas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewCitas;
        private System.Windows.Forms.Button BtnRegresarCitas;
    }
}