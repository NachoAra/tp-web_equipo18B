﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class VoucherNegocio
    {
        private AccesoDatos accesoDatos;

        public VoucherNegocio()
        {
            accesoDatos = new AccesoDatos();
        }

        public bool existeVoucher(string voucher )//, int FechaCanje = 0
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM VOUCHER WHERE Voucher = @voucher");
                datos.setearParametro("@voucher", voucher);
              //  datos.setearParametro("@fechacanje", FechaCanje);
                datos.ejecutarConsulta();

                if (datos.Lector.Read())//&& (datetime)datos.Lector[0] > 0
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}


