using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Clientes
    {

        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarClientes()
        {
            string QryMostrarClientes = "usp_clientes_mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarClientes, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarClientes = new DataTable();
            adapter.Fill(dtMostrarClientes);
            db_conexion.MtdCerrarConexion();
            return dtMostrarClientes;
        }
        public void MtdAgregarClientes(string Nombre, string Direccion, string Departamento, string Pais, string Categoria, string Estado)
        {
            //db_conexion.MtdAbrirConexion();
            string Usp_crear = "usp_clientes_crear";
            SqlCommand cmd_InsertarClientes = new SqlCommand(Usp_crear,db_conexion.MtdAbrirConexion());
            cmd_InsertarClientes.CommandType = CommandType.StoredProcedure;
            //aqui van laos parametros
            cmd_InsertarClientes.Parameters.AddWithValue("@Nombre", Nombre);
            cmd_InsertarClientes.Parameters.AddWithValue("@Direccion", Direccion);
            cmd_InsertarClientes.Parameters.AddWithValue("@Departamento", Departamento);
            cmd_InsertarClientes.Parameters.AddWithValue("@Pais", Pais);
            cmd_InsertarClientes.Parameters.AddWithValue("@Categoria", Categoria);
            cmd_InsertarClientes.Parameters.AddWithValue("@Estado", Estado);
            //para finalizar los parametros es como el end de sql
            cmd_InsertarClientes.ExecuteNonQuery();
            //para cerrar conexion
            db_conexion.MtdCerrarConexion();

        }
    } 

    

}
