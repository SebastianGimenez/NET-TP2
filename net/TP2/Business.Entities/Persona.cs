using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    abstract public class Persona: Usuario
    {
        public Persona(tipoUsuario tipo, string nom, string ape, string legajo, string dni, string email, string telefono)
		:base(tipo)
		{
            this.nombre = nom;
            this.apellido = ape;
            this.legajo = legajo;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
        }
        string nombre;
        string apellido;
        string legajo;
        string dni;
        string email;
        string telefono;
        int idPersona;
        //DateTime fechaNac;

        public string Nombre
        {
        get {return this.nombre;}
        set{this.nombre= value;}
        }
		/* se movio a usuario*/
        /*public tipoPersona TipoPersona
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }*/
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int IDPersona
        {
            get { return this.idPersona; }
            set { this.idPersona = value; }
        }
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

    }
}
