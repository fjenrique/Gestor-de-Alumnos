using System;

namespace Lista_de_Alumnos
{
    public class Curso
    {
        private List<Alumno> datosAlumnos;
        private int contadorAlumnos; // el contador arranca en 0
        
        public void agregarAlumno(Alumno alumnoNuevo) // definicion del metodo con el TIPO DE DATO que recibe(clase Alumno) y el TIPO DE DATO que devuelve (clase Alumno)
        {
            datosAlumnos.Add(alumnoNuevo); //se añade un elemento a la lista (alumnoNuevo)
            contadorAlumnos++;
            alumnoNuevo.Legajo = contadorAlumnos + 1000;
        }
        public string listarAlumno()
        {
            int numAlumno = 1;
            string devolver = string.Empty;
            foreach (Alumno caracAlumno in datosAlumnos)
            {
                caracAlumno.NumAlumno = numAlumno;
                devolver = devolver + "----------------------------" + "\n"
                + "| Nombre: " + caracAlumno.Nombre.ToUpper().Trim() + "\n"
                + "| Apellido: " + caracAlumno.Apellido.ToUpper().Trim() + "\n"
                + "| N° de Documento: " + caracAlumno.NumDocumento.ToString() + "\n"
                + "| Legajo: " + caracAlumno.Legajo.ToString() + "\n" + "\n"
                + "- Nota Final: | " + caracAlumno.Nota.ToString() + " | -" + "\n" + "\n"
                + "[ Alumno N°: " + numAlumno + " ]" + "\n";
                numAlumno++;
            }
            return devolver;
        }
        public int calcularPromedio()
        {
            int resultado = 0;
            foreach (Alumno notaAlumno in datosAlumnos)
            {
                resultado = resultado + notaAlumno.Nota;
            }
            if (datosAlumnos.Count > 0)
            {
                resultado = resultado / datosAlumnos.Count;
            }
            return resultado;
        }
        public string alumnosAprobados()
        {
            string devolverAprobados = string.Empty;
            foreach (Alumno caracAlumno in datosAlumnos)
            {
                if (caracAlumno.Nota >= 4 && caracAlumno.Nota <= 10)
                {
                    devolverAprobados = devolverAprobados + caracAlumno.NumAlumno
                    + "- " + caracAlumno.Apellido.ToUpper().Trim() + " "
                    + caracAlumno.Nombre.ToUpper().Trim()
                    + "   |   " + "Aprobado con:   --  " + caracAlumno.Nota.ToString() + "  --" + "\n";
                }
            }
            return devolverAprobados;
        }
        public string alumnosDesaprobados()
        {
            string devolverDesaprobados = string.Empty;
            foreach (Alumno caracAlumno in datosAlumnos)
            {
                if (caracAlumno.Nota >= 0 && caracAlumno.Nota <= 3)
                {
                    devolverDesaprobados = devolverDesaprobados + caracAlumno.NumAlumno
                    + "- " + caracAlumno.Apellido.ToUpper().Trim() + " "
                    + caracAlumno.Nombre.ToUpper().Trim()
                    + "   |   " + "Desaprobado con:   --  " + caracAlumno.Nota.ToString() + "  --" + "\n";
                }
            }
            return devolverDesaprobados;
        }


        public void actualizarAlumno(Alumno alumnoViejo, Alumno alumnoActualizado)// reemplaza el elemento viejo por el elemento nuevo (lo deja en la misma posicion)
        {
            int indice = datosAlumnos.IndexOf(alumnoViejo); // posicion del elemento viejo a eliminar

            datosAlumnos.RemoveAt(indice); // elimina un elemento pasandole la posicion del elemento

            datosAlumnos.Insert(indice, alumnoActualizado); // inserta un elemento en una posicion

            //otra opcion que no mantiene la posicion original
            //datosAlumnos.Remove(alumnoViejo); // elimina un elemento pasandole el elemento
            //datosAlumnos.Add(alumnoActualizado);
        }

        public void eliminarAlumno(Alumno alumnoViejo)
        {
            datosAlumnos.Remove(alumnoViejo); // elimina un elemento pasandole el elemento
        }

        public Alumno buscarPorLegajo(int legajo)
        {
            return datosAlumnos.Single(alumno => alumno.Legajo == legajo);
        }

        public void cargarDataInicial()
        {
            Alumno alumno1 = new("Homero", "Simpson", 10123456, 5);
            Alumno alumno2 = new("Bart", "Simpson", 20123456, 6);
            Alumno alumno3 = new("Lisa", "Simpson", 30123456, 7);
            Alumno alumno4 = new("Marge", "Simpson", 30123456, 8);
            this.agregarAlumno(alumno1);
            this.agregarAlumno(alumno2);
            this.agregarAlumno(alumno3);
            this.agregarAlumno(alumno4);
        }

        public Curso()
        {
            datosAlumnos = new();
            contadorAlumnos = 0;
            cargarDataInicial();
        }


    }
}