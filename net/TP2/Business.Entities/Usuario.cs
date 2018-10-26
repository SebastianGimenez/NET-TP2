using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public abstract class Usuario
    {
        string nombreUsuario;
        string contraseña;
        tipoUsuario tipoUsuario;
        int idUsuario;

        public Usuario() { }
        protected Usuario(tipoUsuario tipo, string nombreUsuario, string contraseña)
        {
            this.tipoUsuario = tipo;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        protected Usuario(tipoUsuario tipo)
        {
            this.tipoUsuario = tipo;
        }

        public string NombreUsuario
        {
            get { return this.nombreUsuario; }
            set { this.nombreUsuario = value; }
        }


        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }
        }

        public tipoUsuario TipoUsuario
        {
            get { return this.tipoUsuario; }
            set { this.tipoUsuario = value; }
        }
    }
}
