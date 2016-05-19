using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class OfertaEN
    {
        private int idOferta;
        private string nombre;
        private string avatar;
        private int curso1;
        private int curso2;
        private OfertaCAD oferta_cad;

        public int IdOferta
        {
            get { return idOferta; }
            set { idOferta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public int Curso1
        {
            get { return curso1; }
            set { curso1 = value; }
        }

        public int Curso2
        {
            get { return curso2; }
            set { curso2 = value; }
        }
        private void asignar (int idOferta, string nombre, string avatar, int curso1, int curso2) {
            this.idOferta = idOferta;
            this.nombre = nombre;
            this.avatar = avatar;
            this.curso1 = curso1;
            this.curso2 = curso2;
        }
        public OfertaEN() {
            asignar(0, "", "", 0, 0);
        }

        public OfertaEN(int idOferta, string nombre, string avatar, int curso1, int curso2) {
            asignar(idOferta, nombre, avatar, curso1, curso2);
        }

        public void insertar_oferta()
        {
            try
            {
                oferta_cad = new OfertaCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Oferta: %s\n", e);
            }
            oferta_cad.insertar_oferta(this);
        }

        public void borrar_oferta()
        {
            try
            {
                oferta_cad = new OfertaCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Oferta: %s\n", e);
            }
            oferta_cad.borrar_oferta(IdOferta);
        }

        public void modificar_oferta()
        {
            try
            {
                oferta_cad = new OfertaCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Oferta: %s\n", e);
            }
            oferta_cad.modificar_oferta(this);
        }

        public void mostrar_oferta()
        {
            try
            {
                oferta_cad = new OfertaCAD();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Oferta: %s\n", e);
            }
            oferta_cad.mostrar_oferta(idOferta);
        }










    }
}
