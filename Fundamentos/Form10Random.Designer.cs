namespace Fundamentos
{
    partial class Form10Random
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstRandom = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.btnSumaSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números";
            // 
            // lstRandom
            // 
            this.lstRandom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRandom.FormattingEnabled = true;
            this.lstRandom.ItemHeight = 21;
            this.lstRandom.Location = new System.Drawing.Point(21, 57);
            this.lstRandom.Name = "lstRandom";
            this.lstRandom.Size = new System.Drawing.Size(137, 340);
            this.lstRandom.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(217, 57);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(166, 50);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarDatos.Location = new System.Drawing.Point(217, 123);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(166, 50);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "MostrarDatos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(217, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Impares";
            // 
            // txtSuma
            // 
            this.txtSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSuma.Location = new System.Drawing.Point(296, 280);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(87, 29);
            this.txtSuma.TabIndex = 7;
            // 
            // txtPares
            // 
            this.txtPares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPares.Location = new System.Drawing.Point(296, 316);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(87, 29);
            this.txtPares.TabIndex = 8;
            // 
            // txtImpares
            // 
            this.txtImpares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImpares.Location = new System.Drawing.Point(296, 356);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(87, 29);
            this.txtImpares.TabIndex = 9;
            // 
            // btnSumaSeleccionados
            // 
            this.btnSumaSeleccionados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSumaSeleccionados.Location = new System.Drawing.Point(217, 190);
            this.btnSumaSeleccionados.Name = "btnSumaSeleccionados";
            this.btnSumaSeleccionados.Size = new System.Drawing.Size(166, 50);
            this.btnSumaSeleccionados.TabIndex = 10;
            this.btnSumaSeleccionados.Text = "Suma Seleccionados";
            this.btnSumaSeleccionados.UseVisualStyleBackColor = true;
            this.btnSumaSeleccionados.Click += new System.EventHandler(this.btnSumaSeleccionados_Click);
            // 
            // Form10Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 436);
            this.Controls.Add(this.btnSumaSeleccionados);
            this.Controls.Add(this.txtImpares);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstRandom);
            this.Controls.Add(this.label1);
            this.Name = "Form10Random";
            this.Text = "Form10Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstRandom;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Button btnSumaSeleccionados;
    }
}