namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    partial class VenanaMiPerfil
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
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtCorreo3 = new System.Windows.Forms.TextBox();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(189, 117);
            this.txtNombre1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(480, 22);
            this.txtNombre1.TabIndex = 0;
            this.txtNombre1.TextChanged += new System.EventHandler(this.txtNombre1_TextChanged);
            // 
            // txtCorreo3
            // 
            this.txtCorreo3.Location = new System.Drawing.Point(189, 225);
            this.txtCorreo3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo3.Name = "txtCorreo3";
            this.txtCorreo3.Size = new System.Drawing.Size(480, 22);
            this.txtCorreo3.TabIndex = 1;
            this.txtCorreo3.TextChanged += new System.EventHandler(this.txtCorreo3_TextChanged);
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(189, 171);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(480, 22);
            this.txtTelefono2.TabIndex = 2;
            this.txtTelefono2.TextChanged += new System.EventHandler(this.txtTelefono2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo:";
            // 
            // btnActualizarInfo
            // 
            this.btnActualizarInfo.Location = new System.Drawing.Point(436, 340);
            this.btnActualizarInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarInfo.Name = "btnActualizarInfo";
            this.btnActualizarInfo.Size = new System.Drawing.Size(232, 94);
            this.btnActualizarInfo.TabIndex = 6;
            this.btnActualizarInfo.Text = "ACTUALIZAR";
            this.btnActualizarInfo.UseVisualStyleBackColor = true;
            this.btnActualizarInfo.Click += new System.EventHandler(this.btnActualizarInfo_Click);
            // 
            // VenanaMiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 465);
            this.Controls.Add(this.btnActualizarInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.txtCorreo3);
            this.Controls.Add(this.txtNombre1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VenanaMiPerfil";
            this.Text = "VenanaMiPerfil";
            this.Load += new System.EventHandler(this.VenanaMiPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtCorreo3;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizarInfo;
    }
}