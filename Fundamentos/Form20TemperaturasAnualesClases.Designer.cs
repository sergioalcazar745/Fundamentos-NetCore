namespace Fundamentos
{
    partial class Form20TemperaturasAnualesClases
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
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMediaMensual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinimoMensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaximaMensual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinimaAnual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaximaAnual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAños = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarMeses.Location = new System.Drawing.Point(365, 62);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(174, 38);
            this.btnGenerarMeses.TabIndex = 22;
            this.btnGenerarMeses.Text = "Generar";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 21;
            this.lstMeses.Location = new System.Drawing.Point(49, 125);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(225, 256);
            this.lstMeses.TabIndex = 21;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Meses";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.txtMediaMensual);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMinimoMensual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaximaMensual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(319, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 263);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del mes";
            // 
            // txtMediaMensual
            // 
            this.txtMediaMensual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMediaMensual.Location = new System.Drawing.Point(79, 193);
            this.txtMediaMensual.Name = "txtMediaMensual";
            this.txtMediaMensual.Size = new System.Drawing.Size(100, 29);
            this.txtMediaMensual.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(101, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Media";
            // 
            // txtMinimoMensual
            // 
            this.txtMinimoMensual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinimoMensual.Location = new System.Drawing.Point(77, 132);
            this.txtMinimoMensual.Name = "txtMinimoMensual";
            this.txtMinimoMensual.Size = new System.Drawing.Size(100, 29);
            this.txtMinimoMensual.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Temperatura mínima";
            // 
            // txtMaximaMensual
            // 
            this.txtMaximaMensual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaximaMensual.Location = new System.Drawing.Point(77, 76);
            this.txtMaximaMensual.Name = "txtMaximaMensual";
            this.txtMaximaMensual.Size = new System.Drawing.Size(100, 29);
            this.txtMaximaMensual.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Temperatura maxima";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtMediaAnual);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMinimaAnual);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaximaAnual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(614, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 263);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos anuales";
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMediaAnual.Location = new System.Drawing.Point(79, 193);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(100, 29);
            this.txtMediaAnual.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Media";
            // 
            // txtMinimaAnual
            // 
            this.txtMinimaAnual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinimaAnual.Location = new System.Drawing.Point(77, 132);
            this.txtMinimaAnual.Name = "txtMinimaAnual";
            this.txtMinimaAnual.Size = new System.Drawing.Size(100, 29);
            this.txtMinimaAnual.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Temperatura mínima";
            // 
            // txtMaximaAnual
            // 
            this.txtMaximaAnual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaximaAnual.Location = new System.Drawing.Point(77, 76);
            this.txtMaximaAnual.Name = "txtMaximaAnual";
            this.txtMaximaAnual.Size = new System.Drawing.Size(100, 29);
            this.txtMaximaAnual.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(46, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Temperatura maxima";
            // 
            // cbAños
            // 
            this.cbAños.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAños.FormattingEnabled = true;
            this.cbAños.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbAños.Location = new System.Drawing.Point(49, 61);
            this.cbAños.Name = "cbAños";
            this.cbAños.Size = new System.Drawing.Size(225, 29);
            this.cbAños.TabIndex = 37;
            this.cbAños.SelectedIndexChanged += new System.EventHandler(this.cbAños_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(51, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Años";
            // 
            // Form20TemperaturasAnualesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 421);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAños);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Name = "Form20TemperaturasAnualesClases";
            this.Text = "Form20TemperaturasAnualesClases";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerarMeses;
        private ListBox lstMeses;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMediaMensual;
        private Label label4;
        private TextBox txtMinimoMensual;
        private Label label3;
        private TextBox txtMaximaMensual;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtMediaAnual;
        private Label label5;
        private TextBox txtMinimaAnual;
        private Label label6;
        private TextBox txtMaximaAnual;
        private Label label7;
        private ComboBox cbAños;
        private Label label8;
    }
}