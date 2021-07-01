﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Estilo_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Estilo> GetEstilos()
        {
            List<Estilo> lista = new List<Estilo>();
            string consulta = "SELECT ESTILOS.ID, ESTILOS.NOMBRE FROM ESTILOS";
            DataTable tabla = accesoDatos.ObtenerTabla("Estilos", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Estilo estilo= new Estilo
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString()
                };


                lista.Add(estilo);
            }

            return lista;
        }
    }
}