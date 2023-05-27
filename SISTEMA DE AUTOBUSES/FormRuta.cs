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
    public partial class FormRuta : Form
    {
        public FormRuta()
        {
            InitializeComponent();
        }

        private void FormRuta_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = LlenarRUTA();
        }
        public DataTable LlenarRUTA()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM RUTA";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string guardar = "INSERT INTO RUTA (NOMBRE) VALUES (@NOMBRE)";

            try
            {
                SqlCommand guardar1 = new SqlCommand(guardar, conexion.Conectar());
                guardar1.Parameters.AddWithValue("@NOMBRE", txtRuta.Text);
                

                guardar1.ExecuteNonQuery();
                MessageBox.Show("Ruta guardada");
                dataGridView1.DataSource = LlenarRUTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar", ex.Message);

                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string MODIFICAR = "UPDATE RUTA SET NOMBRE= @NOMBRE WHERE ID=ID";

            try
            {
                SqlCommand MODIFICAR1 = new SqlCommand(MODIFICAR, conexion.Conectar());
                MODIFICAR1.Parameters.AddWithValue("@NOMBRE", txtRuta.Text);


                MODIFICAR1.ExecuteNonQuery();
                MessageBox.Show("Ruta modificada");
                dataGridView1.DataSource = LlenarRUTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar", ex.Message);

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtRuta.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string elimminar = "DELETE FROM CHOFERE WHERE ID=@ID";
            try
            {
                SqlCommand eliminar1 = new SqlCommand(elimminar, conexion.Conectar());
                eliminar1.Parameters.AddWithValue("@ID", txtIDR.Text);
                eliminar1.ExecuteNonQuery();
                MessageBox.Show("ruta eliminado");
                dataGridView1.DataSource = LlenarRUTA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo eliminar la ruta", ex.Message);
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string buscar = "SELECT *  FROM RUTA WHERE ID=" + txtIDR.Text;
            SqlCommand BUSCAR1 = new SqlCommand(buscar, conexion.Conectar());
            BUSCAR1.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = BUSCAR1.ExecuteReader();
                if (reader.Read())
                {
                    txtIDR.Text = reader[0].ToString();
                    txtRuta.Text = reader[1].ToString();
                   

                }
                else
                {
                    MessageBox.Show("no se encontro ninguNA RUTA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());
                throw;
            }
        }
    }
}
