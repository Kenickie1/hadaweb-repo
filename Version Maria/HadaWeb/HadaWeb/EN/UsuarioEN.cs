using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticaGrupalHADA
{
    public class UsuarioEN
    {
        private int idUsuario;
        private string email, nick, nombre, apellidos, contrasenya, telefono, avatar;
        private Nullable<DateTime> f_nacimiento;
        private UsuarioCAD usuario_cad; 

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        
        public string Contrasenya
        {
            get { return contrasenya; }
            set { contrasenya = value; }
        }
        
        public Nullable<DateTime> F_nacimiento
        {
            get { return f_nacimiento; }
            set { f_nacimiento = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        protected void asignar(int idUsuario, string email, string nick, string nombre, string apellidos, string contrasenya, string telefono, string avatar, Nullable<DateTime> f_nacimiento)
        {
            this.idUsuario = idUsuario;
            this.email = email;
            this.nick = nick;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.contrasenya = contrasenya;
            this.telefono = telefono;
            this.avatar = avatar;
            this.f_nacimiento = f_nacimiento;
        }

        public UsuarioEN()
        {
            asignar(0, "", "", "", "", "", "", "", null);
        }

        public UsuarioEN(int idUsuario, string email, string nick, string nombre, string apellidos, string contrasenya, string telefono, string avatar, Nullable<DateTime> f_nacimiento)
        {
            asignar(idUsuario, email, nick, nombre, apellidos, contrasenya, telefono, avatar, f_nacimiento);
        }

        public virtual void insertar_usuario() 
        {
            try {
                usuario_cad = new UsuarioCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            usuario_cad.insertar_usuario(this);
        }

        public virtual void borrar_usuario() {
            try{
                usuario_cad = new UsuarioCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            usuario_cad.borrar_usuario(this.idUsuario);
        }

        public virtual void modificar_usuario()
        {
            try
            {
                usuario_cad = new UsuarioCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            usuario_cad.modificar_usuario(this);
        }

        public virtual UsuarioEN mostrar_usuario()
        {
            try
            {
                usuario_cad = new UsuarioCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
            return usuario_cad.mostrar_usuario(this.idUsuario);
        }

        public void Last_ID()
        {
            try
            {
                usuario_cad = new UsuarioCAD();
                idUsuario = usuario_cad.Last_ID();
 
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario: %s\n", e);
            }
        }

        public bool ComprobarNick(string nick) {
            UsuarioCAD usuario_cad = new UsuarioCAD();
            return usuario_cad.comprobarNick(nick);
        }

        public bool comprobarNickContrasenya()
        {
            UsuarioCAD cad = new UsuarioCAD();
            return cad.comprobarNickContrasenya(nick, contrasenya);
        }


    }
}
