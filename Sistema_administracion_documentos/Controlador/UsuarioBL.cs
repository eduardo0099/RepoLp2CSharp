using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

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
    }
}
