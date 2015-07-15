using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Facturacion.Controldor
{
    class detalle_compDB
    {
        detalle_comp detcomp;
        conexcion con = new conexcion();
        public detalle_comp getdetallecompra()
        {
            if (detcomp == null)
            {
                detcomp = new detalle_comp();
            }
            return detcomp;
        }
        public void setdetalle(detalle_comp dc)
        {
            detcomp = dc;
        }
        public int registra(detalle_comp dtcomp)
        {
           MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqldetalle = "Insert detalle_comp Values(" + dtcomp.Iddetallecomp + "," + dtcomp.Idcomp + "," +dtcomp.Idpro + "," + dtcomp.Canpro + "," + dtcomp.Valuni + "," + dtcomp.Totcomp + "," + dtcomp.Iva+")";
                cmd = new MySqlCommand(sqldetalle, cn);
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
        public int Traeiddetalle()
        {
            int nro = 0;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlpro = "Select max(id_detalle) as nro from detalle_comp";
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
