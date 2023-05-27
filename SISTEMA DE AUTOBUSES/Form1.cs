using System.Data.SqlClient;

namespace SISTEMA_DE_AUTOBUSES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            Form choferes = new choferesFormD();
            choferes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ruta = new FormRuta();
            ruta.ShowDialog();  
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            Form Autobuses = new AutobusesForm();
            Autobuses.ShowDialog(); 
        }

        private void btnViaje(object sender, EventArgs e)
        {
            Form viaje = new FormViaje();
            viaje.ShowDialog();
        }
    }
    
   
}