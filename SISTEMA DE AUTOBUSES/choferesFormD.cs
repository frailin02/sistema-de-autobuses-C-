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
    public partial class choferesFormD : Form
    {
        public choferesFormD()
        {
            InitializeComponent();
        }
        public DataTable LlenarChofere()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM CHOFERE";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void choferesFormD_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Conectar();
            
            dataGridView1.DataSource = LlenarChofere();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al conectar", ex.Message);

                throw;
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string guardar = "INSERT INTO CHOFERE (NOMBRE, APELLIDO, FECHA_DE_NACIMIENTO, CEDULA) VALUES (@NOMBRE, @APELLIDO, @FECHA_DE_NACIMIENTO, @CEDULA)";
            
            try
            {
                SqlCommand guardar1 = new SqlCommand(guardar, conexion.Conectar());
            guardar1.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            guardar1.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
            guardar1.Parameters.AddWithValue("@FECHA_DE_NACIMIENTO", dTime.Value);
            guardar1.Parameters.AddWithValue("@CEDULA", txtCedula.Text);

                guardar1.ExecuteNonQuery();
                MessageBox.Show("Chofer guardado");
                dataGridView1.DataSource = LlenarChofere();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroral guardar",ex.Message);

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dTime.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string modificar = "UPDATE CHOFERE SET NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, FECHA_DE_NACIMIENTO=@FECHA_DE_NACIMIENTO, CEDULA=@CEDULA, WHERE  ID=@ID ";

            try
            {
                SqlCommand modificar1 = new SqlCommand(modificar, conexion.Conectar());
                modificar1.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                modificar1.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                modificar1.Parameters.AddWithValue("@FECHA_DE_NACIMIENTO", dTime.Value);
                modificar1.Parameters.AddWithValue("@CEDULA", txtCedula.Text);

                modificar1.ExecuteNonQuery();
                MessageBox.Show("Chofer guardado");
                dataGridView1.DataSource = LlenarChofere();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al modificar", ex.Message);

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
                eliminar1.Parameters.AddWithValue("@ID", txtId.Text);
                eliminar1.ExecuteNonQuery();
                MessageBox.Show("Chofer eliminado");
                dataGridView1.DataSource = LlenarChofere();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo eliminar el chofer", ex.Message);
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string buscar = "SELECT *  FROM CHOFERE WHERE CEDULA=" + txtCedula.Text;
            SqlCommand BUSCAR1 = new SqlCommand(buscar, conexion.Conectar());
            BUSCAR1.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = BUSCAR1.ExecuteReader();
                if (reader.Read())
                {
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtApellido.Text = reader[2].ToString();
                    dTime.Text = reader[3].ToString();
                    txtCedula.Text = reader[4].ToString();  
                    
                }
                else
                {
                    MessageBox.Show("no se encontro ningun Chofer");
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
