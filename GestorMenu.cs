using System;

namespace Lista_de_Alumnos
{

    public class GestorMenu
    {
        Curso objetoCurso = new();

        public int MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("MATERIA:   Algoritmos y Estructuras de Datos I " + "\n");
            Console.WriteLine("Profesor:   Javier De Jorge" + "\n" + "\n");
            Console.WriteLine("      |   MENU PRINCIPAL   |" + "\n");
            Console.WriteLine("------------------------------------------" + "\n");
            Console.WriteLine("1 = Lista de Alumnos" + "\n");
            Console.WriteLine("2 = Mostrar Promedio General de la clase" + "\n");
            Console.WriteLine("3 = Gestionar Alumnos" + "\n");
            Console.WriteLine("4 = Salir" + "\n");
            Console.WriteLine("------------------------------------------" + "\n");
            Console.Write("Ingrese una Opcion: ");

            int respuesta;
            string? opcionSeleccionadaMenu = Console.ReadLine();
            if (int.TryParse(opcionSeleccionadaMenu, out respuesta))
            {
                return respuesta;
            }
            return 0;
        }
        public int MenuListas()
        {
            Console.Clear();
            Console.WriteLine("MATERIA:   Algoritmos y Estructuras de Datos I " + "\n");
            Console.WriteLine("      |   LISTAS DE ALUMNOS   |" + "\n");
            Console.WriteLine("------------------------------------------" + "\n");
            Console.WriteLine("1 = Mostrar Datos de los Alumnos" + "\n");
            Console.WriteLine("2 = Alumnos Aprobados" + "\n");
            Console.WriteLine("3 = Alumnos Desaprobados" + "\n");
            Console.WriteLine("4 = Volver al Menu Principal" + "\n");
            Console.WriteLine("------------------------------------------" + "\n");
            Console.Write("Ingrese una Opcion: ");

            int respuesta;
            string? opcionSeleccionadaMenu = Console.ReadLine();
            if (int.TryParse(opcionSeleccionadaMenu, out respuesta))
            {
                return respuesta;
            }
            return 0;
        }
        public int MenuGesionarAlumno()
        {
            Console.Clear();
            Console.WriteLine("MATERIA:   Algoritmos y Estructuras de Datos I " + "\n");
            Console.WriteLine("      |   GESTIONAR ALUMNOS   |" + "\n");
            Console.WriteLine("------------------------------------------" + "\n");
            Console.WriteLine("1 = Agregar datos del Alumno" + "\n");
            Console.WriteLine("2 = Editar datos" + "\n");
            Console.WriteLine("3 = Eliminar Alumno" + "\n");
            Console.WriteLine("4 = Volver al Menu Principal" + "\n");
            Console.WriteLine("------------------------------------------" + "\n");
            Console.Write("Ingrese una Opcion: ");

            int respuesta;
            string? opcionSeleccionadaMenu = Console.ReadLine();
            if (int.TryParse(opcionSeleccionadaMenu, out respuesta))
            {
                return respuesta;
            }
            return 0;
        }
        public void VolverMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Volviendo al Menu principal   --" + "\n" + "\n");
            PresioneEnter();
        }
        public void Salir()
        {
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado   --  SALIR  --" + "\n" + "\n" + "\n");
            Console.WriteLine("Que tenga un buen dia :D" + "\n" + "\n" + "\n");
            Console.ReadKey();
        }
        public void OpcionErronea()
        {
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado una opcion ERRONEA" + "\n" + "\n" + "\n");
            PresioneEnter();
        }


        public void AgregarAlumnoNuevo()
        {
            // ingresar datos
            Alumno alumnoConDatos = IngresarDatos(); // se llama al metodo (IngresarDatos()), se le pasa como parametro un objeto vacio (alumnoVacio) y luego se guarda el objeto editado que devuelve el metodo en otro objeto (alumnoConDatos)

            // guardar
            objetoCurso.agregarAlumno(alumnoConDatos); //se llama al metodo de otra clase (objetoCurso.agregarAlumno) para guardarlo en memoria.

            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Se ha agregado los Datos del alumno   --" + "\n" + "\n");
            PresioneEnter();
        }
        private Alumno IngresarDatos() //definicion del metodo con el TIPO DE DATO que recibe(clase Alumno) y el TIPO DE DATO que devuelve (clase Alumno)
        {
            Alumno objetoAlumno = new();

            // cargar datos
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            objetoAlumno.Nombre = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese Apellido: ");
            objetoAlumno.Apellido = Console.ReadLine() ?? string.Empty;

            Console.Clear();
            int valorDocumento;
            bool esDocumento = false;
            while (!esDocumento)
            {
                Console.Clear();
                Console.WriteLine("Ingrese N° de Documento: ");

                esDocumento = int.TryParse(Console.ReadLine(), out valorDocumento);

                if (!esDocumento)
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "\n" + "--   Documento ingresado, NO VALIDO   --" + "\n" + "\n");
                    Console.WriteLine("--   Presione ENTER para continuar   --" + "\n" + "\n" + "\n");
                    Console.ReadKey();
                }
                else
                {
                    objetoAlumno.NumDocumento = valorDocumento;
                    Console.WriteLine("\n" + "\n" + "--   Se ha agregado N° de Doumento   --" + "\n" + "\n");
                    Console.WriteLine("--   Presione ENTER para continuar   --" + "\n" + "\n" + "\n");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine("Ingrese Nota Final: ");
            do
            {
                try
                {
                    objetoAlumno.Nota = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "\n" + "--   El valor de la Nota final debe ser entre 1 y 10   --" + "\n" + "\n");
                    Console.Write("Ingrese la Nota Final nuevamente: ");
                }
            } while (objetoAlumno.Nota < 1 || objetoAlumno.Nota > 10);
            if (objetoAlumno.Nota >= 1 || objetoAlumno.Nota <= 10)
            {
                Console.WriteLine("\n" + "\n" + "--   Se ha agregado Nota Final   --" + "\n" + "\n");
                Console.WriteLine("--   Presione ENTER para continuar   --" + "\n" + "\n" + "\n");
                Console.ReadKey();
            }
            return objetoAlumno;
        }


        public void EditarAlumno()
        {
            // mostrar lista
            // se hace en el metodo SeleccionarAlumno()

            // elegir un elemento de la lista escribiendo el legajo
            Alumno alumnoAEditar = SeleccionarAlumno();

            //editar, cargar los datos nuevamente
            Alumno alumnoEditado = IngresarDatos(); // se utiliza nuevamente el metodo IngresarDatos, el mismo se uso cuando se agrego el nuevo Alumno.
            alumnoEditado.Legajo = alumnoAEditar.Legajo;
            //update
            objetoCurso.actualizarAlumno(alumnoAEditar, alumnoEditado);

            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Se ha acutalizado los Datos del Alumno   --" + "\n" + "\n");
            PresioneEnter();

        }
        public void EliminarAlumno()
        {
            // mostrar lista
            // se hace en el metodo SeleccionarAlumno()

            // elegir un elemento de la lista escribiendo el legajo

            Alumno alumnoAEliminar = SeleccionarAlumno();
            //  Console.ReadKey();
            // eliminar
            objetoCurso.eliminarAlumno(alumnoAEliminar);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Se ha eliminado un Alumno   --" + "\n" + "\n");
            PresioneEnter();
        }

        private Alumno SeleccionarAlumno()
        {
            //TODO
            // Mostrar info de alumnos
            Alumno alumnoSeleccionado = new();

            // elegir un alumno por el legajo

            int ingresarLegajo;
            do
            {
                try
                {
                    Console.Clear();
                    ListarAlumno();
                    Console.WriteLine("Ingrese N° de Legajo del alumno que desea editar: " + "\n" + "\n" + "\n");
                    ingresarLegajo = Convert.ToInt16(Console.ReadLine());
                    alumnoSeleccionado = objetoCurso.buscarPorLegajo(ingresarLegajo);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "\n" + "--   El valor del Legajo, NO es correcto.   --" + "\n" + "\n");
                }
            } while (alumnoSeleccionado.Legajo == 0);

            Console.WriteLine("\n" + "\n" + "--   Se ha seleccionado un Alumno   --" + "\n" + "\n");
            Console.ReadKey();

            return alumnoSeleccionado;
        }

        public void ListarAlumno()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Datos de los Alumnos: ");
            Console.WriteLine(objetoCurso.listarAlumno());
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
        }
        public void MostrarPromedio()
        {
            Console.Clear();
            int promedio = objetoCurso.calcularPromedio();
            Console.WriteLine("***********************************************" + "\n");
            Console.WriteLine("MATERIA:   Algoritmos y Estructuras de Datos I " + "\n" + "\n");
            Console.WriteLine("El promedio general de las Notas es: " + "\n" + "\n" + "||   " + promedio.ToString() + "   ||" + "\n");
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
            PresioneEnter();
        }
        public void MostrarAprobados()
        {
            Console.Clear();
            Console.WriteLine("***********************************************" + "\n");
            Console.WriteLine("Alumnos APROBADOS: ");
            Console.WriteLine(objetoCurso.alumnosAprobados() + "\n");
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
            PresioneEnter();
        }
        public void MostrarDesaprobados()
        {
            Console.Clear();
            Console.WriteLine("***********************************************" + "\n");
            Console.WriteLine("Alumnos DESAPROBADOS: ");
            Console.WriteLine(objetoCurso.alumnosDesaprobados() + "\n");
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
            PresioneEnter();
        }

        public void PresioneEnter()
        {
            Console.WriteLine("--   Presione ENTER para continuar   --" + "\n" + "\n" + "\n");
            Console.ReadKey();
        }
    }
}