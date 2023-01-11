namespace Fundamentos
{
    partial class Form04DateTime
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
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.cbCambiarFormatoFecha = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.tdbAños = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncrementar = new System.Windows.Forms.TextBox();
            this.btnIncremento = new System.Windows.Forms.Button();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(39, 76);
            this.txtFechaActual.Multiline = true;
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(627, 40);
            this.txtFechaActual.TabIndex = 1;
            // 
            // cbCambiarFormatoFecha
            // 
            this.cbCambiarFormatoFecha.AutoSize = true;
            this.cbCambiarFormatoFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCambiarFormatoFecha.Location = new System.Drawing.Point(39, 140);
            this.cbCambiarFormatoFecha.Name = "cbCambiarFormatoFecha";
            this.cbCambiarFormatoFecha.Size = new System.Drawing.Size(195, 25);
            this.cbCambiarFormatoFecha.TabIndex = 2;
            this.cbCambiarFormatoFecha.Text = "Cambiar Formato Fecha";
            this.cbCambiarFormatoFecha.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncremento);
            this.groupBox1.Controls.Add(this.txtIncrementar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tdbAños);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(41, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar fecha";
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(25, 35);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(58, 25);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(25, 76);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(72, 25);
            this.rdbMeses.TabIndex = 1;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // tdbAños
            // 
            this.tdbAños.AutoSize = true;
            this.tdbAños.Location = new System.Drawing.Point(25, 117);
            this.tdbAños.Name = "tdbAños";
            this.tdbAños.Size = new System.Drawing.Size(63, 25);
            this.tdbAños.TabIndex = 2;
            this.tdbAños.TabStop = true;
            this.tdbAños.Text = "Años";
            this.tdbAños.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(179, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // txtIncrementar
            // 
            this.txtIncrementar.Location = new System.Drawing.Point(274, 42);
            this.txtIncrementar.Name = "txtIncrementar";
            this.txtIncrementar.Size = new System.Drawing.Size(318, 29);
            this.txtIncrementar.TabIndex = 4;
            // 
            // btnIncremento
            // 
            this.btnIncremento.Location = new System.Drawing.Point(274, 90);
            this.btnIncremento.Name = "btnIncremento";
            this.btnIncremento.Size = new System.Drawing.Size(318, 34);
            this.btnIncremento.TabIndex = 5;
            this.btnIncremento.Text = "Incrementar";
            this.btnIncremento.UseVisualStyleBackColor = true;
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(41, 414);
            this.txtNuevaFecha.Multiline = true;
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(627, 40);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva fecha";
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 505);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCambiarFormatoFecha);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.label1);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox cbCambiarFormatoFecha;
        private GroupBox groupBox1;
        private Button btnIncremento;
        private TextBox txtIncrementar;
        private Label label2;
        private RadioButton tdbAños;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private TextBox txtNuevaFecha;
        private Label label3;
    }
}