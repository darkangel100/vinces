using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Facturacion.Controldor
{
    class CompraDB
    {
        compra comp = null;
        conexcion con = new conexcion();

        public compra getcompra()
        {
            if (comp == null)
            {
                this.comp = new compra();
            }
            return comp;
        }
        public void setcompra(compra compra)
        {
            comp = compra;
        }
        public int registrarcompra(compra c)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcomp = "Insert compra (id_compra,pre_tot,id_pro,nom_pro,id_proveedor) Values(" + c.Idcomp + "," + c.Totcompra + "," + c.Idpro + ",'" + c.Nompro + "',"+c.Idprov+")";
                cmd = new MySqlCommand(sqlcomp, cn);
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

        public int idcomptrae()
        {
            int nro = 0;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlpro = "Select max(id_compra) as nro from compra";
                cmd = new MySqlCommand(sqlpro, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["nro"])
                        nro = 0;
                    else
                        nro = Convert.ToInt32(dr["nro"]);


                }
                dr.Close();

            }
            catch (MySqlException ex)
            {
                nro = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                nro = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return nro;
        }

    }
}
