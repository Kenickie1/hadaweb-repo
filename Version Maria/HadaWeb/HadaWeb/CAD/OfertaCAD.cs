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
    public class OfertaCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante
        private String BDD;
        private OfertaEN oferta;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

         // Constructor de ofertaCAD
        public OfertaCAD(string bbdd = ""){
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            oferta = new OfertaEN();
        }

        // Metodo que inserta ofertas en la bbdd 
        public void insertar_oferta(OfertaEN oferta){
            // Aqui realizamos el insert en la bbdd
            this.oferta = oferta;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from oferta";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "oferta");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["oferta"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = oferta.IdOferta;
            nuevafila[1] = oferta.Nombre;
            nuevafila[2] = oferta.Avatar;
            nuevafila[3] = oferta.Curso1;
            nuevafila[4] = oferta.Curso2;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "oferta");
        }

        // Metodo que borra ofertas de la bbdd 
        public void borrar_oferta(int id){
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from oferta where idOferta = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que actualiza los datos de un oferta
        public void modificar_oferta(OfertaEN oferta){
            // Aqui realizamos el update en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("update oferta set  idOferta = " + ", nombre = '" + oferta.Nombre + "', avatar = '" + oferta.Avatar + "', curso1 = " + oferta.Curso1 + ", curso2 =" + oferta.Curso2 + "where idOferta = " + oferta.IdOferta, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que muestra un oferta en concreto a partir de un id, que identifica a los cursos
        public OfertaEN mostrar_oferta(int id){
            OfertaEN p = new OfertaEN ();
            return p;
        }
    }
}
