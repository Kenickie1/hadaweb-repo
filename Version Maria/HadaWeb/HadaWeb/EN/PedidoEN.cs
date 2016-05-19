using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class PedidoEN
    {
        private int idPedido, puntos, estadoPago, formaPago, estadoPedido, cliente, curso;
        private String descripcion;
        private Nullable<DateTime> f_compra;
        private Double importe_total;
        private PedidoCAD pedido_cad;

        public int IdPedido 
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public int Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        public int EstadoPago
        {
            get { return estadoPago; }
            set { estadoPago = value; }
        }

        public int FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }

        public int EstadoPedido
        {
            get { return estadoPedido; }
            set { estadoPedido = value; }
        }

        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Nullable<DateTime> F_compra 
        {
            get { return f_compra; }
            set { f_compra = value; }
        }

        public double Importe_total
        {
            get { return importe_total; }
            set { importe_total = value; }
        }

        public string Ref_estadoPedido() 
        {
            switch (estadoPedido)
            {
                case 1:
                    return "Reservado";
                case 2:
                    return "Activo";
                case 3:
                    return "Finalizado";
                default:
                    return "Estado de pedido erroneo.";
            }
        }

        public string Ref_formaPago()
        {
            switch (formaPago)
            {
                case 1:
                    return "Tarjeta";
                case 2:
                    return "Paypal";
                case 3:
                    return "Transferencia bancaria";
                default:
                    return "Forma de pago erronea.";
            }
        }

        public string Ref_estadoPago()
        {
            switch (estadoPago)
            {
                case 1:
                    return "Pendiente";
                case 2:
                    return "Pagado";
                default:
                    return "Estado de pago erroneo";
            }
        }

        private void asignar (int idPedido, int puntos, int estadoPago, int formaPago, int estadoPedido, int cliente, String descripcion, Nullable<DateTime> f_compra, Double importe_total, int curso)
        {
            this.idPedido = idPedido;
            this.puntos = puntos;
            this.estadoPago = estadoPago;
            this.formaPago = formaPago;
            this.estadoPedido = estadoPedido;
            this.cliente = cliente;
            this.descripcion = descripcion;
            this.f_compra = f_compra;
            this.importe_total = importe_total;
            this.curso = curso;
        }

        public PedidoEN()
        {
            asignar(0, 0, 0, 0, 0, 0, "", null, 0d, 0);
        }

        public PedidoEN(int idPedido, int puntos, int estadoPago, int formaPago, int estadoPedido, int cliente, String descripcion, Nullable<DateTime> f_compra, Double importe_total, int curso)
        {
            asignar(idPedido, puntos, estadoPago, formaPago, estadoPedido, cliente, descripcion, f_compra, importe_total, curso);
        }

        public void insertar_pedido()
        {
            try
            {
                pedido_cad = new PedidoCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Pedido: %s\n", e);
            }
            pedido_cad.insertar_pedido(this);
        }

        public void borrar_pedido()
        {
            try
            {
                pedido_cad = new PedidoCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Pedido: %s\n", e);
            }
            pedido_cad.borrar_pedido(idPedido);
        }

        public void modificar_pedido()
        {
            try
            {
                pedido_cad = new PedidoCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Pedido: %s\n", e);
            }
            pedido_cad.modificar_pedido(this);
        }

        public void mostrar_pedido()
        {
            try
            {
                pedido_cad = new PedidoCAD("bbddSQLhada");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Pedido: %s\n", e);
            }
            pedido_cad.mostrar_pedido(idPedido);
        }
    }
}










