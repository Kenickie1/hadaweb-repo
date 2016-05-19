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
    // Clase que gestiona la insercion y borrado de las reservas de los cursos solicitados por los clientes
    public class ReservaCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante
        private String BDD;
        private ReservaEN reserva;
        private SqlConnection conex;

        // Constructor reservaCAD
        public ReservaCAD(string algo)
        {
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            reserva = new ReservaEN();
        }

        // Metodo que inserta reservas en la bbdd
        public void insertar_reserva(ReservaEN reserva)
        {
            this.reserva = reserva;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from reserva";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "reserva");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["reserva"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = reserva.IdReserva;
            nuevafila[1] = reserva.F_reserva;
            nuevafila[2] = reserva.Articulo;
            nuevafila[3] = reserva.Cliente;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "reserva");
        }

        // Metodo que borra reservas en la bbdd
        public void borrar_reserva(int id)
        {
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from reserva where idReserva = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que actualiza reservas en la bbdd
        public void modificar_reserva(ReservaEN r)
        {

            conex.Open();
            SqlCommand com = new SqlCommand("update reserva set f_reserva ='" + r.F_reserva + "', articulo = " + r.Articulo + ", cliente = " + r.Cliente + ", where idReserva = " + r.IdReserva, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que muestra una reserva en concreto a partir de un id, que identifica a las reservas
        public ReservaEN mostrar_reserva(int id)
        {
            ReservaEN r = new ReservaEN();
            return r;
        }

        // Metodo que devuelve todas las reservas que han sido registrados en la bbdd
        public List<ReservaEN> mostrar_todos_reservas()
        {
            List<ReservaEN> reserva = new List<ReservaEN>();
            return reserva;
        }
    }
}
