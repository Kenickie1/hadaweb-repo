using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
using System.Configuration;
namespace PracticaGrupalHADA
{
    class ClienteCAD
    {

        //Datos
        private ClienteEN cliente;
        private String BDD;
        private ArrayList clientes;
        SqlConnection conex;

        //Constructor clientecad
        public ClienteCAD(String loquesea)
        {
            BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            cliente = new ClienteEN();

          

        }
        //Método que inserta un cliente en la BDD
        public void insertar_cliente(ClienteEN cliente)
        {
            this.cliente = cliente;
            DataSet bdvirtual = new DataSet();  
            string operacion = "select * from cliente";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "cliente");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["cliente"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = cliente.IdUsuario;
            nuevafila[1] = cliente.PuntosTotales;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "cliente");

        }
        //Metodo que borra un cliente de la BDD
        public void borrar_cliente(int id)
        {
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from cliente where idCliente = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }
           //Metodo que hace un update en la BDD
        public void modificar_cliente(ClienteEN cliente)
        {
            conex.Open();
            SqlCommand com = new SqlCommand("update cliente set puntosTotales = " + cliente.PuntosTotales + " where idCliente = " + cliente.IdUsuario, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }
        //metodo que muestra algun dato de un cliente.
        public void mostrar_cliente(int id)
        {

        }

        
    }
}
