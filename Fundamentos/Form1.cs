namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //PROPIEDADES DE TIPO PRIMITICO
            this.txtNombre.Width = 150;
            this.btnPulsar.Text = "Botón pulsado";

            //PROPIEDADES DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);

            //PROPIEDADES DE TIPO ENUMERADAS
            //dsds
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Beige;
            this.btnPulsar.BackColor = Color.LightGreen;
        }
    }
}