using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class MensajesEN
    {
        private int idMensaje, emisor, receptor;
        private string mensaje;
        private Boolean leido;
        private Nullable<DateTime> f_envio;
        private MensajesCAD mensajes_cad;

        public int IdMensaje
        {
            get { return idMensaje; }
            set { idMensaje = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public int Emisor
        {
            get { return emisor; }
            set { emisor = value; }
        }
        public int Receptor
        {
            get { return receptor; }
            set { receptor = value; }
        }

        public Boolean Leido
        {
            get { return leido; }
            set { leido = value; }
        }

        public Nullable<DateTime> F_envio
        {
            get { return f_envio; }
            set { f_envio = value; }
        }

        private void asignar(int idMensaje, string mensaje, int emisor, int receptor,Boolean leido, Nullable<DateTime> f_envio)
        {
            this.idMensaje = idMensaje;
            this.mensaje = mensaje;
            this.emisor = emisor;
            this.receptor = receptor;
            this.leido = leido;
            this.f_envio = f_envio;
        }

        public MensajesEN()
        {
            asignar(0, "", 0, 0, false, null);
        }

        public MensajesEN(int idMensaje, string mensaje, int emisor, int receptor, Boolean leido, Nullable<DateTime> f_envio)
        {
            asignar(idMensaje, mensaje, emisor, receptor, leido, f_envio);
        }

        public void insertar_mensaje()
        {
            try
            {
                mensajes_cad = new MensajesCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Mensaje: %s\n", e);
            }
            mensajes_cad.insertar_mensaje(this);
        }

        public void borrar_mensaje()
        {
            try
            {
                mensajes_cad = new MensajesCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Mensaje: %s\n", e);
            }
            mensajes_cad.borrar_mensaje(idMensaje);
        }

        public void modificar_mensaje()
        {
            try
            {
                mensajes_cad = new MensajesCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Mensaje: %s\n", e);
            }
            mensajes_cad.modificar_mensaje(this);
        }

        public void mostrar_mensaje()
        {
            try
            {
                mensajes_cad = new MensajesCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Mensaje: %s\n", e);
            }
            mensajes_cad.mostrar_mensaje(idMensaje);
        }
    }
}
