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
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Beige;
            this.btnPulsar.BackColor = Color.LightGreen;

            //CONVERSION AUTOMATICA
            short pequeño2 = 99;
            int numero2 = pequeño2;

            //CONVERSION AUTOMATICA
            int numero = 99;
            short pequeño = 888;

            //NECESITAMOS ALMACENAR EN
            //EL NUMERO MENOR EL DATO DEL MAYOR
            int resultado = (short) numero;

            //CONVERTIR STRING A PRIMITIVO
            string textoNumero = "1444";
            int numeroEntero = int.Parse(textoNumero);
            double doble = double.Parse(textoNumero);

            //CONVERTIR CUALQUIER OBJETO A STRING
            int valor = 8888;
            string texto = valor.ToString();


        }
    }
}