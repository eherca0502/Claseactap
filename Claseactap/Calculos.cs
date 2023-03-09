using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseactap
{
    internal class Calculos
    {
        //Metodo para el calculo del promedio
        public double promedio(int con, double suma)
        {
            return suma / con;
        }

        public string resultado(int con, double suma)
        {
            string res;
            if(promedio(con, suma) > 61)
            {
                res = "Aprobado";
            }
            else
            {
                res = "Reprobado";
            }
            return res;
        }
    }
}
