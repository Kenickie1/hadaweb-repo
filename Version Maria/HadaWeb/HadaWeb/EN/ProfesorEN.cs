using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class ProfesorEN : UsuarioEN
    {
        private ProfesorCAD profesor_cad;

        public ProfesorEN()
            : base(){}

        public ProfesorEN(int idUsuario, string email, string nick, string nombre, string apellidos, string contrasenya, string telefono, string avatar, Nullable<DateTime> f_nacimiento)
            : base(idUsuario, email, nick, nombre, apellidos, contrasenya, telefono, avatar, f_nacimiento){}
        /*
        //Constructor de copia
        public ProfesorEN(ProfesorEN profesor)
        {
            ProfesorEN aux = new ProfesorEN(profesor.IdUsuario, profesor.Email, profesor.Nick, profesor.Nombre, profesor.Apellidos, profesor.Contrasenya, profesor.Telefono, profesor.Avatar, profesor.F_nacimiento, profesor.NumCursos, profesor.NumAlumnos);
            asignar(aux.IdUsuario, aux.Email, aux.Nick, aux.Nombre, aux.Apellidos, aux.Contrasenya, aux.Telefono, aux.Avatar, aux.F_nacimiento);
            numCursos = aux.NumCursos;
            numAlumnos = aux.NumCursos;
        }*/

        public void insertar_profesor()
        {
            base.insertar_usuario();
            try
            {
                profesor_cad = new ProfesorCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            profesor_cad.insertar_profesor(this);
        }

        public void borrar_profesor()
        {
            try
            {
                profesor_cad = new ProfesorCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            profesor_cad.borrar_profesor(base.IdUsuario);
            base.borrar_usuario();
        }

        public void modificar_profesor()
        {
            base.modificar_usuario();
            profesor_cad = new ProfesorCAD("bbddSQLhada");
            try
            {
                //
                profesor_cad = new ProfesorCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            profesor_cad.modificar_profesor(this);
        }

        public void mostrar_profesor()
        {
            base.mostrar_usuario();
            try
            {
                profesor_cad = new ProfesorCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            profesor_cad.mostrar_profesor(base.IdUsuario);
        }
    }
    }

