using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class ReservaEN
    {
        private int idReserva;
        private Nullable<DateTime> f_reserva;
        private int articulo, cliente;
        private Boolean reservado;
        private ReservaCAD reserva_cad;

        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        public Nullable<DateTime> F_reserva
        {
            get { return f_reserva; }
            set { f_reserva = value; }
        }

        public int Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Boolean Reservado
        {
            get { return reservado; }
            set { reservado = value; }
        }

        private void asignar(int idReserva, Nullable<DateTime> f_reserva, int articulo, int cliente, Boolean reservado)
        {
            this.idReserva = idReserva;
            this.f_reserva = f_reserva;
            this.articulo = articulo;
            this.reservado = reservado;
            this.cliente = cliente;
        }

        public ReservaEN()
        {
            asignar(0, null, 0, 0, false);
        }

        public ReservaEN(int idReserva, Nullable<DateTime> f_reserva, int articulo, int cliente, Boolean reservado)
        {
            asignar(idReserva, f_reserva, articulo, cliente, reservado);
        }

        public void insertar_reserva()
        {
            try
            {
                reserva_cad = new ReservaCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Reserva: %s\n", e);
            }
            reserva_cad.insertar_reserva(this);
        }

        public void borrar_reserva()
        {
            try
            {
                reserva_cad = new ReservaCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Reserva: %s\n", e);
            }
            reserva_cad.borrar_reserva(idReserva);
        }

        public void modificar_reserva()
        {
            try
            {
                reserva_cad = new ReservaCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Reserva: %s\n", e);
            }
            reserva_cad.modificar_reserva(this);
        }

        public void mostrar_reserva()
        {
            try
            {
                reserva_cad = new ReservaCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Reserva: %s\n", e);
            }
            reserva_cad.mostrar_reserva(idReserva);
        }
    }
}
