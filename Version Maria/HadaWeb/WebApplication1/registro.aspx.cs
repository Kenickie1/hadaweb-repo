using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
namespace WebApplication1
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            Page.Validate();
            if (DesplegableDia.Items.Count == 0)
            {
                for (int i = 1; i <= 31; i++)
                {
                    // Crea un nuevo Item
                    ListItem item = new ListItem(i.ToString());
                    // Lo agrega a la colección de Items del DropDownList
                    DesplegableDia.Items.Add(item);
                }
                for (int i = 1900; i <= 2015; i++)
                {
                    // Crea un nuevo Item
                    ListItem item = new ListItem(i.ToString());
                    // Lo agrega a la colección de Items del DropDownList
                    DesplegableAno.Items.Add(item);
                }
            }
                
        }

        protected void Registrar(object sender, EventArgs e)
        {
            if (Page.IsValid){
                UsuarioEN cliente = new UsuarioEN();
                cliente.Last_ID();
                cliente.Nick = Nick.Text;
                cliente.Nombre = Name.Text;
                cliente.Email = Email.Text;
                cliente.Contrasenya = Contrasenya.Text;
                string fecha = DesplegableDia.Text + "/" + DesplegableMes.Text + "/" + DesplegableAno.Text;
                string mes = DesplegableMes.Text;
                if(Convert.ToInt32(DesplegableDia.Text) > 28 && (mes == "02"))
                    fecha = "28/" + DesplegableMes.Text + "/" + DesplegableAno.Text;
                else if (Convert.ToInt32(DesplegableDia.Text) == 31 && (mes == "04" || mes == "06" || mes == "09" || mes == "11"))
                    fecha = "30/" + DesplegableMes.Text + "/" + DesplegableAno.Text;
                cliente.F_nacimiento = Convert.ToDateTime(fecha);
                cliente.Telefono = Telefono.Text;
                cliente.insertar_usuario();
            }
        }

        protected void ComprobarUsuario(object sender, ServerValidateEventArgs e) { 
            string nick = e.Value.ToLower();            
            UsuarioEN us = new UsuarioEN();
            e.IsValid = us.ComprobarNick(nick);
        }
    }
}