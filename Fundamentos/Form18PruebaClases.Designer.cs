namespace Fundamentos
{
    partial class Form18PruebaClases
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
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnVerPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 21;
            this.lstDatos.Location = new System.Drawing.Point(29, 76);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(481, 382);
            this.lstDatos.TabIndex = 0;
            // 
            // btnVerPersona
            // 
            this.btnVerPersona.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerPersona.Location = new System.Drawing.Point(80, 477);
            this.btnVerPersona.Name = "btnVerPersona";
            this.btnVerPersona.Size = new System.Drawing.Size(147, 50);
            this.btnVerPersona.TabIndex = 1;
            this.btnVerPersona.Text = "Ver persona";
            this.btnVerPersona.UseVisualStyleBackColor = true;
            this.btnVerPersona.Click += new System.EventHandler(this.btnVerPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos";
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearEmpleado.Location = new System.Drawing.Point(315, 477);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(147, 62);
            this.btnCrearEmpleado.TabIndex = 3;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // Form18PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 551);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerPersona);
            this.Controls.Add(this.lstDatos);
            this.Name = "Form18PruebaClases";
            this.Text = "Form18PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstDatos;
        private Button btnVerPersona;
        private Label label1;
        private Button btnCrearEmpleado;
    }
}