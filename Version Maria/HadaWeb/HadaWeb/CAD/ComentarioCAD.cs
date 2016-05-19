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
using System.Timers;

namespace PracticaGrupalHADA
{
    // Clase que gestiona la insercion y borrado de comentarios de clientes en los cursos
    public class ComentarioCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante

        private String BDD;
        private ComentarioEN comentario;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

        // Constructor de comentarioCAD
        public ComentarioCAD(string bbdd = ""){
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            comentario = new ComentarioEN();
        }

        // Metodo que inserta comentarios en la bbdd 
        public void insertar_comentario(ComentarioEN comentario){
            // Aqui realizamos el insert en la bbdd
            this.comentario = comentario;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from comentario";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "comentario");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["comentario"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = comentario.IdComentario;
            nuevafila[1] = comentario.Comentario;
            nuevafila[2] = comentario.Usuario;
            nuevafila[3] = comentario.Likes;
            nuevafila[4] = comentario.F_comentario;
            nuevafila[5] = comentario.Curso;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "comentario");
        }

        // Metodo que borra comentarios de la bbdd
        public void borrar_comentario(int id){
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from comentario where idComentario = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que muestra un comentario en concreto a partir de un id, que identifica a los comentarios
        public ComentarioEN mostrar_comentario(int id)
        {
            ComentarioEN c = new ComentarioEN(); ;
            return c;
        }
        
        //Método para modificar el comentario a partir de una id
        public void modificar_comentario(ComentarioEN c)
        {
            conex.Open();
            SqlCommand com = new SqlCommand("update comentario set comentario = '" + c.Comentario + "', usuario = " + c.Usuario + ", puntuacion = " + c.Likes + ", f_comentario =  + getdate(), curso =" + c.Curso + " where idComentario = " + c.IdComentario, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Para recibir una lista con todos los comentarios de la bbdd se llama a este modulo
        public List<ComentarioEN> mostrar_todos_comentarios()
        {
            List<ComentarioEN> comentarios = new List<ComentarioEN>();
            return comentarios;
        }
    }
}
