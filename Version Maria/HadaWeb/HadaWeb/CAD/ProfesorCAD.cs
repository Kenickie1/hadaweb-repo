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
    class ProfesorCAD
    {
        //Datos;
        private String BDD;
        private ProfesorEN profesor;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

        //Constrcutor ProfesorCAD.
        public ProfesorCAD(String i)
        {
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            profesor = new ProfesorEN();
        }
        //Metodo que inserta profesores.
        public void insertar_profesor(ProfesorEN profesor){
            this.profesor = profesor;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from profesor";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "profesor");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["profesor"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = profesor.IdUsuario;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "profesor");
        }
        //Metodo que modifica algún dato de un profesor
        public void modificar_profesor(ProfesorEN profesor){
            // Al realizar la modificación del profesor, primero se llama a base.borrar_usuario() ya que deriva de esta entidad
            // y despues se realiza a borrar_profesor() pero como esta tabla solo almacena los id's de los profesores, no modifica
            // ningun dato en la entidad profesor
        }
        //Metodo que borra un profesor de la bd.
        public void borrar_profesor(int id){
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from profesor where idProfesor = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        //Metodo que muestra datos de un profesor.
        public void mostrar_profesor(int id)
        {

        }

    }
}
