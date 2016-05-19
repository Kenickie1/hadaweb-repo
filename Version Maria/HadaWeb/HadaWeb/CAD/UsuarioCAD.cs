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
namespace PracticaGrupalHADA
{
    class UsuarioCAD
    {

        //Datos del CAD.

       private String BDD;
       private UsuarioEN usuario;
       private ArrayList AlmacenUsuarios;
       private SqlConnection conex;



        public UsuarioCAD()
        {
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            usuario = new UsuarioEN();
            //Aqui accederíamos a la base de datos.
        }

        //Módulo para insertar un usuario en la base de datos.
        public void insertar_usuario(UsuarioEN usuario)
        {
            this.usuario = usuario;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from usuario";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "usuario");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["usuario"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = usuario.IdUsuario;
            nuevafila[1] = usuario.Email;
            nuevafila[2] = usuario.Nick;
            nuevafila[3] = usuario.Nombre;
            nuevafila[4] = usuario.Contrasenya;
            nuevafila[5] = usuario.F_nacimiento;
            nuevafila[6] = usuario.Telefono;
            nuevafila[7] = usuario.Avatar;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "usuario");

        }
        //Módulo que borra un usuario de la BD
        public void borrar_usuario(int id)
        {
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from usuario where idUsuario = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }
        //Módulo que modifica algun dato de un usuario.
        public void modificar_usuario(UsuarioEN u)
        {
            conex.Open();
            SqlCommand com = new SqlCommand("update usuario set email = '" + u.Email + "', nick ='" + u.Nick + "', nombre = '" + u.Nombre + "', contrasenya = '" + u.Contrasenya + "', telefono = '" + u.Telefono + "', avatar = '" + u.Avatar + "' where idUsuario = " + u.IdUsuario, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }
        //Modulo que muestra algun dato de un usuario.
        public UsuarioEN mostrar_usuario(int id)
        {
            UsuarioEN us = new UsuarioEN();
            SqlDataReader dr;
            try{
            conex.Open();
            string operation = "Select * from usuario where idUsuario = " + id;
            SqlCommand com = new SqlCommand(operation, conex);
            dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
            }
            //return dr;
            catch (Exception e) {

            }
            finally{
                conex.Close();
                
            }    
            return us;
        }

        public int Last_ID()
        {
            int id = 0;
            SqlDataReader dr;
            try
            {
                conex.Open();
                string operation = "Select max(idUsuario) from usuario";
                SqlCommand com = new SqlCommand(operation, conex);
                dr = com.ExecuteReader();
                dr.Read();
                if(dr.HasRows){
                    id = dr.GetInt32(0);
                    id++;
               }
               else 
                   id = 1;                
                dr.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conex.Close();
            }
            return id;
        }

        public bool comprobarNick(string nick)
        {
            bool unico = true;
            UsuarioEN us = new UsuarioEN();
            SqlDataReader dr;
            conex.Open();
            string operation = "Select * from usuario";
            SqlCommand com = new SqlCommand(operation, conex);
            dr = com.ExecuteReader();
            while (dr.Read() && unico == true){
                string nickAux = dr["nick"].ToString();
                if (nick == nickAux)
                    unico = false;                  
            }
            dr.Close();
            conex.Close();
            return unico;
        }

        public bool comprobarNickContrasenya(string nick, string password)
        {
            bool existe = false, ok = false;
            UsuarioEN us = new UsuarioEN();
            SqlDataReader dr;
            conex.Open();
            string operation = "Select * from usuario";
            SqlCommand com = new SqlCommand(operation, conex);
            dr = com.ExecuteReader();
            while (dr.Read() && existe == false && ok == false)
            {
                existe = false;
                string nickAux = dr["nick"].ToString();
                string passAux = dr["contrasenya"].ToString();
                if (nick == nickAux)
                {
                    if (passAux == password)
                    {
                        ok = true;
                    }
                    existe = true;
                }
            }
            dr.Close();
            conex.Close();
            return existe && ok;
        }
    }
}




