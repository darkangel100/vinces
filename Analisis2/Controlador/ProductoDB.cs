using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace Facturacion.Controldor
{
    class ProductoDB
    {


        Producto pro;
        conexcion con = new conexcion();

        public Producto getproducto()
        {
            if (pro == null)
            {
                this.pro = new Producto();
            }
            return pro;

        }
        public void setproducto(Producto p)
        {
            pro = p;
        }

        public int InsertaProducto(Producto prod)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert producto(nom_pro,descripcion,precio_comp,precio_vent,stock,est_pro,color) values('" + prod.Nompro + "','" + prod.Descpro + "'," + prod.Precomp + "," + prod.Prevent + "," + prod.Stockpro + ",'" + prod.Estpro + "','"+prod.Colorpro+"')";
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
            prod = null;
            return resp;
        }

     
          
            public int sumastock(int co, int can)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;

            try
            {
                string sqlpro = "Update producto set stock=stock+" + can + " where cod_prod='" + co + "'";
                cmd = new MySqlCommand(sqlpro, cn);
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
            cmd = null;
            cn.Close();
            return resp;

        }

            public List<Producto> listarporestado(string estado)
            {
                ProductoDB pro = new ProductoDB();
                List<Producto> ListaPro = new List<Producto>();
                MySqlCommand cmd;
                MySqlConnection cn = con.GetConnection();

                try
                {
                    string sqlcad = "Select * From producto order by nom_pro";
                    cmd = new MySqlCommand(sqlcad, cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        pro = new ProductoDB();
                        pro.getproducto().Idpro = Convert.ToInt32(dr[0]);
                        pro.getproducto().Nompro=dr[1].ToString();
                        pro.getproducto().Descpro = dr[2].ToString();
                        pro.getproducto().Precomp = Convert.ToDouble(dr[3]);
                        pro.getproducto().Prevent = Convert.ToDouble(dr[4]);
                        pro.getproducto().Stockpro = Convert.ToInt32(dr[5]);
                        pro.getproducto().Estpro = dr[6].ToString();
                        pro.getproducto().Colorpro = dr[7].ToString();
                        ListaPro.Add(pro.getproducto());
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
                return ListaPro;

            }



    }
}
