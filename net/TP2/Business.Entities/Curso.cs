using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso
    {
        string nombre;
        int cupo;
        int idCurso;
        Comision comision;
        Materia materia;
        List<Docente> docentes;
        int nota;

        public Curso()
        { docentes = new List<Docente>(); }
        public Curso(string nombre, int cupo)
        {
            this.nombre = nombre;
            this.cupo = cupo;
            docentes = new List<Docente>();
        }
        public void agregarComision(Comision com)
        {
            this.comision = com;
        }
        public void agregarMateria(Materia mat)
        {
            this.materia = mat;
        }
        public void agregarDocente(Docente doc)
        {   
            this.docentes.Add(doc);
        }
        public int Nota
        {
            get { return nota; }
            set { this.nota = value; }
        }
        public int IdCurso
        {
            get { return this.idCurso; }
            set { this.idCurso = value; }
        }
            
            
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Cupo
        {
            get { return this.cupo; }
            set { this.cupo = value; }
        }

        public Comision Comision
        {
            get { return this.comision; }
            set { this.comision = value; }
        }

        public Materia Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }

        public List<Docente> Docentes
        {
            get { return this.docentes; }
            set { this.docentes = value; }
        }
    }
}
