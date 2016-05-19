using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class ComentarioEN
    {
        private int idComentario, likes, curso, usuario;
        private string comentario;
        private Nullable<DateTime> f_comentario;
        private ComentarioCAD comentario_cad;

        public int IdComentario
        {
            get { return idComentario; }
            set { idComentario = value; }
        }

        public int Likes
        {
            get { return likes; }
            set { likes = value; }
        }

        public int Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public int Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Nullable<DateTime> F_comentario
        {
            get { return f_comentario; }
            set { f_comentario = value; }
        }

        private void asignar(int idComentario, int likes, int curso, string comentario, int usuario, Nullable<DateTime> f_comentario)
        {
            this.idComentario = idComentario;
            this.likes = likes;
            this.curso = curso;
            this.comentario = comentario;
            this.usuario = usuario;
            this.f_comentario = f_comentario;
        }

        public ComentarioEN()
        {
            asignar(0, 0, 0, "", 0, null);
        }

        public ComentarioEN(int idComentario, int likes, int curso, string comentario, int usuario, Nullable<DateTime> f_comentario)
        {
            asignar(idComentario, likes, curso, comentario, usuario, f_comentario);
        }

        public void insertar_comentario()
        {
            try
            {
                comentario_cad = new ComentarioCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Comentario en insertar_comentario: %s\n", e);
            }
            comentario_cad.insertar_comentario(this);
        }

        public void borrar_comentario()
        {
            try
            {
                comentario_cad = new ComentarioCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Comentario en borra_comentario: %s\n", e);
            }
            comentario_cad.borrar_comentario(idComentario);
        }

        public void modificar_comentario()
        {
            try
            {
                comentario_cad = new ComentarioCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario en modificar_comentario: %s\n", e);
            }
            comentario_cad.modificar_comentario(this);
        }

        public void mostrar_comentario()
        {
            try
            {
                comentario_cad = new ComentarioCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario en mostrar_comentario: %s\n", e);
            }
            comentario_cad.mostrar_comentario(idComentario);
        }
    }
}