using System;

namespace Lista_de_Alumnos
{
    public class Alumno : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumDocumento { get; set; }
        public int Legajo { get; set; }
        public int Nota { get; set; }
        public int NumAlumno { get; set; }

        public Alumno()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.NumDocumento = 0;
            this.Nota = 0;
            this.NumAlumno = 0;
            this.Legajo = 0;
        }

        public Alumno(string nombre, string apellido, int dni, int nota)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NumDocumento = dni;
            this.Nota = nota;
            this.NumAlumno = 0;
            this.Legajo = 0;
        }
    }
}