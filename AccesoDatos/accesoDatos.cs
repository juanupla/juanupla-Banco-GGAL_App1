using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Banco_GGAL_App1
{
    internal class accesoDatos
    {
        string cadena;
        SqlConnection cnn;


        public accesoDatos()
        {

            cadena = @"Data Source=localhost;Initial Catalog=BancoFundido$GGAL;Integrated Security=True";
            cnn = new SqlConnection(cadena);
        }

        public DataTable ConsultarBD(string query)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlTransaction t = cnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Transaction = t;
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            t.Commit();
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarCuentas(string query, int nro_cliente)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlTransaction t = cnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Transaction = t;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nroCliente", nro_cliente);

            tabla.Load(cmd.ExecuteReader());
            t.Commit();
            cnn.Close();
            return tabla;
        }

        public int EliminarCuenta(string sql, int cbu)
        {
            int i;
            SqlTransaction t = null;
            cnn.Open();
            t = cnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand(sql, cnn, t);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cbu", cbu);
            i = cmd.ExecuteNonQuery();
            t.Commit();
            cnn.Close();
            return i;

        }
        public Cliente DbBuscarCliente(string sql, Cliente cliente)
        {

            cnn.Open();

            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", cliente.Dni);

            SqlParameter param = new SqlParameter("@nro_cliente", SqlDbType.Int, 100);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);


            SqlParameter param1 = new SqlParameter("@nombre", SqlDbType.NVarChar, 100);
            param1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param1);


            SqlParameter param2 = new SqlParameter("@apellido", SqlDbType.NVarChar, 100);
            param2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param2);


            cmd.ExecuteNonQuery();

            try
            {
                int nro_cliente = Convert.ToInt32(param.Value);
                string apellido = Convert.ToString(param2.Value);
                string nombre = Convert.ToString(param1.Value);
                Cliente c = new Cliente(nombre, apellido, nro_cliente);

                cnn.Close();

                return c;
            }
            catch
            {

                cnn.Close();
                int nro_cliente = -1;
                string apellido = "NULL";
                string nombre = "NULL";
                Cliente cc = new Cliente(nombre, apellido, nro_cliente);
                return cc;
            }

        }

        public int DbInsertarCliente(string cadena, Cliente cliente)
        {
            cnn.Open();
            //SqlTransaction t = cnn.BeginTransaction();               Utiliza el metodo transaction
            SqlTransaction t = cnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand(cadena, cnn);
            cmd.Transaction = t;
            //cmd.Transaction = t;                                     Utiliza el metodo transaction
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", cliente.Dni);
            cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);

            SqlParameter param = new SqlParameter("@posicion", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            int posicion = Convert.ToInt32(param.Value);
            //t.Comit()                                                Utiliza el metodo transaction
            t.Commit();
            cnn.Close();
            return posicion;
        }

        public int DbInsertarCuentasCNuevo(string sql, Cuenta c, int posicion)
        {

            SqlTransaction t = null;
            try
            {

                int i;
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sql, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cbu", c.Cbu);
                cmd.Parameters.AddWithValue("@saldo", c.Saldo);
                cmd.Parameters.AddWithValue("@tipoDeCuenta", c.tipoCuenta.id);
                cmd.Parameters.AddWithValue("@ultimoMov", c.UltimoMov);
                cmd.Parameters.AddWithValue("@nroCliente", posicion);

                i = cmd.ExecuteNonQuery();
                t.Commit();

                return i;
            }
            catch
            {
                t.Rollback();
                return -1;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public int DBBuscarExistente(string sql, int documento)
        {
            cnn.Open();
            SqlTransaction t = cnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Transaction = t;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", documento);
            SqlParameter param = new SqlParameter("@nro_cliente", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            int posicion = Convert.ToInt32(param.Value);
            t.Commit();
            cnn.Close();
            return posicion;
        }
    }
}
