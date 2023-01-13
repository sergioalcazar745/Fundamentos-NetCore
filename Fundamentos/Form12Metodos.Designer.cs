namespace Fundamentos
{
    partial class Form12Metodos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnValor = new System.Windows.Forms.Button();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnObjetoReferencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(103, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(250, 29);
            this.txtNumero.TabIndex = 1;
            // 
            // btnValor
            // 
            this.btnValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnValor.Location = new System.Drawing.Point(117, 107);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(145, 41);
            this.btnValor.TabIndex = 2;
            this.btnValor.Text = "Doble() Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // btnReferencia
            // 
            this.btnReferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReferencia.Location = new System.Drawing.Point(117, 181);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(145, 59);
            this.btnReferencia.TabIndex = 3;
            this.btnReferencia.Text = "Doble() Referencia";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(47, 347);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 21);
            this.lblResultado.TabIndex = 4;
            // 
            // btnObjetoReferencia
            // 
            this.btnObjetoReferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnObjetoReferencia.Location = new System.Drawing.Point(117, 266);
            this.btnObjetoReferencia.Name = "btnObjetoReferencia";
            this.btnObjetoReferencia.Size = new System.Drawing.Size(145, 59);
            this.btnObjetoReferencia.TabIndex = 5;
            this.btnObjetoReferencia.Text = "Objeto Referencia";
            this.btnObjetoReferencia.UseVisualStyleBackColor = true;
            this.btnObjetoReferencia.Click += new System.EventHandler(this.btnObjetoReferencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo números";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(524, 49);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(171, 23);
            this.txtNumeros.TabIndex = 7;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(524, 93);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(171, 23);
            this.txtLetras.TabIndex = 9;
            this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(428, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Solos letras";
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMouse.ForeColor = System.Drawing.Color.Black;
            this.lblMouse.Location = new System.Drawing.Point(411, 151);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(284, 217);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "lblMouse";
            this.lblMouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 390);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObjetoReferencia);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnValor;
        private Button btnReferencia;
        private Label lblResultado;
        private Button btnObjetoReferencia;
        private Label label2;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label label3;
        private Label lblMouse;
    }
}