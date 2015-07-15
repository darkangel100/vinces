using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Facturacion.Controldor
{
    class ProveedorDB
    {
        Proveerdor prov = null;
        conexcion con = new conexcion();

        public Proveerdor getproveedor()
        {
            if (prov == null)
            {
               this.prov = new Proveerdor();
            }
            return prov;
        }
        public void setproveedor(Proveerdor p)
        {
            prov = p;
        }
        public int InsertaProveedor(Proveerdor pro)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Insert proveedor set nombre_empresa='" + pro.Empresapro + "',id_per='" + pro.Idpro + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }

        public List<Proveerdor> TraeProveTodos()//metodo trae cliente por apellido
        {
            ProveedorDB pro = null;
            List<Proveerdor> Listapro = new List<Proveerdor>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {

                string sqlcad = " select * from proveedor ";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pro = new ProveedorDB();


                    pro.getproveedor().Nombre = dr[1].ToString();
                    pro.getproveedor().Idpro= Convert.ToInt32(dr[2].ToString());
                    Listapro.Add(pro.getproveedor());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pro = null;
                throw ex;
            }
            catch (Exception ex)
            {
                pro = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return Listapro;
        }
    }
}
