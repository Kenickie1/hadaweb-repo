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
    // Clase que gestiona la insercion y borrado de pedidos de los cursos solicitados por los clientes
    class PedidoCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante
        private String BDD;
        private PedidoEN pedido;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

         // Constructor de pedidoCAD
        public PedidoCAD(string bbdd = ""){
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            pedido = new PedidoEN();
        }

        // Metodo que inserta pedidos en la bbdd 
        public void insertar_pedido(PedidoEN pedido){
            this.pedido = pedido;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from pedido";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "pedido");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["pedido"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = pedido.IdPedido;
            nuevafila[1] = pedido.Descripcion;
            nuevafila[2] = pedido.F_compra;
            nuevafila[3] = pedido.Importe_total;
            nuevafila[4] = pedido.Puntos;
            nuevafila[5] = pedido.EstadoPago;
            nuevafila[6] = pedido.FormaPago;
            nuevafila[7] = pedido.EstadoPedido;
            nuevafila[8] = pedido.Cliente;
            nuevafila[9] = pedido.Curso;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "pedido");

            // Aqui realizamos el insert en la bbdd
        }

        // Metodo que borra pedidos de la bbdd 
        public void borrar_pedido(int id){
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from pedido where idPedido = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que actualiza los datos de un pedido
        public void modificar_pedido(PedidoEN pedido){
            // Aqui realizamos el update en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("update pedido set descripcion ='" + pedido.Descripcion + "', f_compra =" + pedido.F_compra + "', importe_total =" + pedido.Importe_total + "', puntos =" + pedido.Puntos + "', estadoPago =" + pedido.EstadoPago + "', formaPago =" + pedido.FormaPago + "', estadoPedido =" + pedido.EstadoPedido + "', cliente =" + pedido.Cliente + "where idPedido = " + pedido.IdPedido, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que muestra un pedido en concreto a partir de un id, que identifica a los cursos
        public PedidoEN mostrar_pedido(int id){
            PedidoEN p = new PedidoEN ();
            return p;
        }

        // Metodo que devuelve todos los pedidos que han sido registrados en la bbdd (pedidos solicitados)
        public List<PedidoEN> mostrar_todos_pedidos()
        {
            List<PedidoEN> pedidos = new List<PedidoEN>();
            return pedidos;
        }
    }
}
