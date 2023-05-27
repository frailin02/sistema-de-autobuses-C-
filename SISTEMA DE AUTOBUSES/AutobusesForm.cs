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
    public partial class AutobusesForm : Form
    {
        public AutobusesForm()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdAuto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtModelo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPlaca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtColor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtAño.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable Llenar()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM AUTOBUSES";
            SqlCommand cmd = new SqlCommand(consulta,conexion.Conectar());  

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void AutobusesForm_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            MessageBox.Show("conexion exitosa");
            dataGridView1.DataSource = Llenar();    
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string insertar = "INSERT INTO AUTOBUSES (MARCA, MODELO, PLACA, COLOR, AÑO) VALUES (@MARCA,@MODELO,@PLACA,@COLOR,@AÑO)";
            SqlCommand insertar2 = new SqlCommand(insertar, conexion.Conectar());
            insertar2.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            insertar2.Parameters.AddWithValue("@MODELO", txtModelo.Text);
            insertar2.Parameters.AddWithValue("@PLACA", txtPlaca.Text);
            insertar2.Parameters.AddWithValue("@COLOR", txtColor.Text);
            insertar2.Parameters.AddWithValue("@AÑO", txtAño.Text);
            insertar2.ExecuteNonQuery();
            MessageBox.Show("autobus guardado");
            dataGridView1.DataSource=Llenar();  
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string modificar = "UPDATE AUTOBUSES SET MARCA=@MARCA, MODELO=@MODELO, PLACA=@PLACA, COLOR=@COLOR, AÑO=@AÑO WHERE  ID=@ID ";
            SqlCommand modficar1 = new SqlCommand(modificar, conexion.Conectar());
            modficar1.Parameters.AddWithValue("@ID", txtIdAuto.Text);
            modficar1.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            modficar1.Parameters.AddWithValue("@MODELO", txtModelo.Text);
            modficar1.Parameters.AddWithValue("@PLACA", txtPlaca.Text);
            modficar1.Parameters.AddWithValue("@COLOR", txtColor.Text);
            modficar1.Parameters.AddWithValue("@AÑO", txtAño.Text);
            modficar1.ExecuteNonQuery();
            MessageBox.Show("autobus modificado");
            dataGridView1.DataSource = Llenar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string elimminar = "DELETE FROM AUTOBUSES WHERE ID=@ID";
            SqlCommand eliminar1 = new SqlCommand(elimminar, conexion.Conectar());
            eliminar1.Parameters.AddWithValue("@ID", txtIdAuto.Text);
            eliminar1.ExecuteNonQuery();
            MessageBox.Show("autobus eliminado");
            dataGridView1.DataSource= Llenar(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string buscar = "SELECT *  FROM AUTOBUSES WHERE PLACA="+ txtPlaca.Text;
            SqlCommand BUSCAR1 =new SqlCommand(buscar, conexion.Conectar());
            BUSCAR1.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                reader = BUSCAR1.ExecuteReader();
                if (reader.Read())
                {
                    txtIdAuto.Text = reader[0].ToString();
                    txtMarca.Text = reader[1].ToString();
                    txtModelo.Text = reader[2].ToString();
                    txtPlaca.Text = reader[3].ToString();
                    txtColor.Text = reader[4].ToString();
                    txtAño.Text = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("no se encontro ningun autobus");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());
                throw;
            }
            
            

            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
