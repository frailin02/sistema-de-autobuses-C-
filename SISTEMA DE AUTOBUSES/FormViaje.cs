using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_AUTOBUSES
{
    public partial class FormViaje : Form
    {
        public FormViaje()
        {
            InitializeComponent();
            dataGridView1.DataSource = LlenarVIAJE();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormViaje_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = LlenarVIAJE();
            dataGridView2.DataSource = llenarRutasDis();
            dataGridView4.DataSource = llenarIDAuto();
            dataGridView3.DataSource = llenarChofere();
        }
        public DataTable LlenarVIAJE()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT V.ID, C.NOMBRE AS NOMBRE,\r\nC.CEDULA AS CEDULA,\r\nA.MARCA AS MARCA,\r\nA.MODELO AS MODELO,\r\nA.PLACA AS PLACA,\r\nR.NOMBRE AS NOMBRE\r\nFROM VIAJE V \r\nINNER JOIN CHOFERE C ON C.ID= V.ID_CHOFER\r\nINNER JOIN AUTOBUSES A ON A.ID= V.ID_AUTOBUS\r\nINNER JOIN RUTA R ON R.ID = V.ID_RUTA ;";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            try
            {
                
                
                string guardar = "INSERT INTO VIAJE(ID_CHOFER, ID_AUTOBUS, ID_RUTA) VALUES (@CHOFER, @AUTOBUSES, @RUTA)";
                SqlCommand cmd= new SqlCommand(guardar,conexion.Conectar());
                cmd.Parameters.AddWithValue("@CHOFER",txtIdChofe.Text);
                cmd.Parameters.AddWithValue("@AUTOBUSES", txtIdAuto.Text);
                cmd.Parameters.AddWithValue("@RUTA", txtRu.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Se Inserto Correctamente!");
                dataGridView1.DataSource = LlenarVIAJE();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRu.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
        public DataTable llenarRutasDis()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT DISTINCT ID, (NOMBRE)AS 'RUTA'\r\nFROM RUTA WHERE ID NOT IN (SELECT ID_RUTA FROM VIAJE);";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAuto.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
        }
        public DataTable llenarIDAuto()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT DISTINCT ID, CONCAT(MARCA,'',MODELO)AS 'AUTOBUS',PLACA,COLOR,AÑO\r\nFROM AUTOBUSES WHERE ID NOT IN(SELECT ID_AUTOBUS FROM VIAJE);";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdChofe.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }
        public DataTable llenarChofere()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT DISTINCT ID, CONCAT(NOMBRE,'',APELLIDO)AS'NOMBRE COMPLETO', FECHA_DE_NACIMIENTO, CEDULA\r\nFROM CHOFERE WHERE ID NOT IN (SELECT ID FROM RUTA);";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string elimminar = "DELETE FROM VIAJE WHERE ID=@ID";
            SqlCommand eliminar1 = new SqlCommand(elimminar, conexion.Conectar());
            eliminar1.Parameters.AddWithValue("@ID", txtEliminar.Text);
            eliminar1.ExecuteNonQuery();
            MessageBox.Show("autobus eliminado");
            dataGridView1.DataSource = LlenarVIAJE();
        }
    }
       
}
