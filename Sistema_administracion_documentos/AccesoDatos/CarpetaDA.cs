using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AccesoDatos {
    public class CarpetaDA {
        /*public BindingList<Carpeta> devolverListaCarpetas() {
            BindingList<Carpeta> listaCarpetas = new BindingList<Carpeta>();
            FileStream inFile = new FileStream("promociones.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter breader = new BinaryFormatter();

            while (true) {
                try {
                    Carpeta carp = (Carpeta)breader.Deserialize(inFile);
                    listaCarpetas.Add(carp);
                }
                catch (Exception exc) { inFile.Close(); break; }
            }

            return listaCarpetas;
        }*/
    }
}
