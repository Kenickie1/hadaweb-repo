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
    class MensajesCAD

    {
        //Datos
        private String BDD;
        private MensajesEN mensaje;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;
        //Constructor mensajesCAD
        public MensajesCAD()
        {
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            mensaje = new MensajesEN();
        }
        //Método que muestra un mensaje.
        public void mostrar_mensaje(int id){

        }
       
        public void borrar_mensaje(int id){
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from mensaje where idMensaje = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        //Metodo que inserta un mensaje en la BDD.
        public void insertar_mensaje(MensajesEN mensaje)
        {
            string leido = (mensaje.Leido == true) ? "si" : "no";
            this.mensaje = mensaje;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from mensaje";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "mensaje");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["mensaje"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = mensaje.IdMensaje;
            nuevafila[1] = mensaje.Mensaje;
            nuevafila[2] = mensaje.Emisor;
            nuevafila[3] = mensaje.Receptor;
            nuevafila[4] = leido;
            nuevafila[5] = mensaje.F_envio;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "mensaje");
        }

        public void modificar_mensaje(MensajesEN m)
        {
            SqlCommand com = new SqlCommand("update mensaje set mensaje = '" + m.Mensaje + "', emisor =" + m.Emisor + ", receptor = " + m.Receptor + ", leido = '" + m.Leido + "', f_envio = '" + m.F_envio + " where idMensaje = " + m.Mensaje, conex);
        }
    }
}
