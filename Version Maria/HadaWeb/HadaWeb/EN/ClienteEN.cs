using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace PracticaGrupalHADA
{
    public class ClienteEN : UsuarioEN
    {
        private int puntosTotales;
        private ClienteCAD cliente_cad;

        public int PuntosTotales 
        {
            get { return puntosTotales; }
            set { puntosTotales = value; }
        }

        public ClienteEN()
            : base()
        {
            puntosTotales = 0;
        }

        public ClienteEN(int idUsuario, string email, string nick, string nombre, string apellidos, string contrasenya, string telefono, string avatar, Nullable<DateTime> f_nacimiento, int puntosTotales)
            : base(idUsuario, email, nick, nombre, apellidos, contrasenya, telefono, avatar, f_nacimiento)
        {
            this.puntosTotales = 0;
        }

        public void insertar_cliente()
        {
            base.insertar_usuario();
            try
            {
                cliente_cad = new ClienteCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario en inserta_usuario: %s\n", e);
            }
            cliente_cad.insertar_cliente(this);
        }

        public void borrar_cliente()
        {
            try
            {
                cliente_cad = new ClienteCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario en borra_usuario: %s\n", e);
            }
            cliente_cad.borrar_cliente(base.IdUsuario);
            base.borrar_usuario();
        }

        public void modificar_cliente()
        {
            base.modificar_usuario();
            try
            {
                cliente_cad = new ClienteCAD("bbddSQLhada");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error creando Usuario en modificar_cliente: %s\n", e);
            }
            cliente_cad.modificar_cliente(this);
        }

        public void mostrar_cliente()
        {
            base.mostrar_usuario();
            try
            {
                cliente_cad = new ClienteCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Usuario en mostrar_clientes: %s\n", e);
            }
            cliente_cad.mostrar_cliente(base.IdUsuario);
        }
    }
}
