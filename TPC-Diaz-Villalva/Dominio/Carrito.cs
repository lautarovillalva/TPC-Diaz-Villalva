﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public List<Articulo> lista { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }
    }
}