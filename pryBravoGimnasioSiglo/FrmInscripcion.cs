namespace pryBravoGimnasioSiglo
{
    public partial class FrmInscripcion : Form
    {
        const int MUSCULACION = 15000;
        const int FUNCIONAL = 18000;
        const int NATACION = 22000;

        const string MANANA = "Mañana";
        const string TARDE = "Tarde";
        const string NOCHE = "Noche";

        const int EDAD_MINIMA = 14;

        const int CASILLERO = 3000;

        const int MENOR_EDAD = 25;
        const int DESCUENTO_MAYOR_EDAD = 30;
        const int DESCUENTO_ESTUDIANTE = 25;

        const int DESCUENTO_EFECTIVO = 10;

        const int UNA_CUOTA = 0;
        const int TRES_CUOTAS = 10;
        const int SEIS_CUOTAS = 20;



        public FrmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            // Textos vacíos
            txtNombre.Text = "";
            txtEdad.Text = "";

            // Meses en 1
            txtMes.Text = "1";

            // Casillas desmarcadas
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;

            // Planes seleccionados
            cmbPlan.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;

            // Efectivo marcado
            rbtEfectivo.Checked = true;

            // Cuotas sin selección y deshabilitadas
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            // Botón calcular deshabilitado
            btnCalcular.Enabled = false;

            // Foco en nombre
            txtNombre.Focus();
        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Nombre;
            int Edad;
            int mesesPlan;
            decimal precioMensual;
            decimal subtotal;
            decimal descuento;
            decimal ajustePago;
            decimal total;
            decimal valorCuota;
            
        }
    }
}
