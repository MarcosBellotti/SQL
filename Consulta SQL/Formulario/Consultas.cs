using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Formulario
{
    public class Consultas
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=*Nombre de la instancia da la BD*; Initial Catalog= *Nombre de la BD*; Integrated Security= True");
        
        public DataTable Consulta(string StrSql) //Para que pasemos por string a que tabla queremos consultarle algo
        {
            DataTable Tabla = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(StrSql, conexion); //hace que la tabla se adapte segun la tabla que buscamos en tal conexion
            Da.Fill(Tabla); //llena la tabla con lo que hay
            return Tabla;

        }

    }
}
