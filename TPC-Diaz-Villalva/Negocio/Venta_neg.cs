﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Venta_neg
    {
        public List<Venta> listarVentas()
        {
            Venta_dao venta_Dao = new Venta_dao();
            return venta_Dao.GetVentas();
        }
    }
}