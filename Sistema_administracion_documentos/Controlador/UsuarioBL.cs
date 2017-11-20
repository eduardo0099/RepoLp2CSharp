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
        public void actualizarUsuario(Usuario user)
        {
            sistemaUsuario.actualizarUsuario(user);
        }
        public string devolverNombrePorId(int id) {
            return sistemaUsuario.devolverNombrePorID(id);
        }

        public int devolverIDUsuario(string codigo) {
            return sistemaUsuario.devolverIDUsuario(codigo);
        }

        public string obtenerCorreoAlternativo(int id) {
            return sistemaUsuario.obtenerCorreoAlternativo(id);
        }

        public string obtenerContrasenaUsuario(int id) {
            return sistemaUsuario.obtenerContrasenaUsuario(id);
        }
    }
}
