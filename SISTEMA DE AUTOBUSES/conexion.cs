using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SISTEMA_DE_AUTOBUSES
{
    internal class conexion
    {
        public static SqlConnection Conectar()
        {
         SqlConnection conexion =new SqlConnection("Data Source=FRAILIN-OB\\SQLEXPRESS;Initial Catalog=sistema;Integrated Security=True");
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUDO CONECTAR");
                throw;
            }
        }
        
        


    }
}
