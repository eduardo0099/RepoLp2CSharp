using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Controlador {
    public class UsuarioBL {
        private UsuarioDA sistemaUsuario;

        public UsuarioBL() {
            sistemaUsuario = new UsuarioDA();
        }

        public bool validarUsuario(string codigoUsuario, string contrasenaUsuario) {
            return sistemaUsuario.validarUsuario(codigoUsuario, contrasenaUsuario);
        }

        public string obtenerNombreUsuario(string codigoUsuario) {
            return sistemaUsuario.obtenerNombreUsuario(codigoUsuario);
        }

        public Usuario obtenerUsuario(string codigoUsuario)
        {
            return sistemaUsuario.obtenerUsuario(codigoUsuario);
        }
    }
}
