﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Articulo_neg
    {

        public List<Articulo> ListarArticulos()
        {
            Articulo_dao art = new Articulo_dao();
            return art.GetArticulos();
        }

    }
}