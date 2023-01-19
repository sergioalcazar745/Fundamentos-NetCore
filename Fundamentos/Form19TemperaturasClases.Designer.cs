namespace Fundamentos
{
    partial class Form19TemperaturasClases
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
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMediaAnual.Location = new System.Drawing.Point(346, 308);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(100, 29);
            this.txtMediaAnual.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(346, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Media anual";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinimo.Location = new System.Drawing.Point(344, 247);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 29);
            this.txtMinimo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(313, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura mínima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaxima.Location = new System.Drawing.Point(344, 191);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(100, 29);
            this.txtMaxima.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(313, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura maxima";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarDatos.Location = new System.Drawing.Point(313, 110);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(174, 40);
            this.btnMostrarDatos.TabIndex = 13;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarMeses.Location = new System.Drawing.Point(313, 66);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(174, 38);
            this.btnGenerarMeses.TabIndex = 12;
            this.btnGenerarMeses.Text = "Generar meses";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(42, 66);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(225, 256);
            this.lstMeses.TabIndex = 11;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meses";
            // 
            // Form19TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 370);
            this.Controls.Add(this.txtMediaAnual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Name = "Form19TemperaturasClases";
            this.Text = "Form19TemperaturasClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMediaAnual;
        private Label label4;
        private TextBox txtMinimo;
        private Label label3;
        private TextBox txtMaxima;
        private Label label2;
        private Button btnMostrarDatos;
        private Button btnGenerarMeses;
        private ListBox lstMeses;
        private Label label1;
    }
}