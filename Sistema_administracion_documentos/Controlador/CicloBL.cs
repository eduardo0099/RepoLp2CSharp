using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CicloBL
    {
        public int busquedaCicloVingente()
        {
            int cicloV;
            CicloDA accesoD = new CicloDA();
            cicloV = accesoD.busquedaCicloVingente();
            return cicloV;
        }
    }
}
