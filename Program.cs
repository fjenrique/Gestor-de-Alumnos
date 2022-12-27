namespace Lista_de_Alumnos
{
    class Program
    {
        private static Curso objetoCurso = new();
        public static void Main()
        {
            int opcionMenuPrincipal;
            do
            {
                opcionMenuPrincipal = MenuPrincipal();
                switch (opcionMenuPrincipal)
                {
                    case 1:
                        int opcionListasAlumno;
                        do
                        {
                            opcionListasAlumno = MenuListas();
                            switch (opcionListasAlumno)
                            {
                                case 1:
                                    ListarAlumno();
                                    PresioneEnter();
                                    break;
                                case 2:
                                    MostrarAprobados();
                                    break;
                                case 3:
                                    MostrarDesaprobados();
                                    break;
                                case 4:
                                    VolverMenuPrincipal();
                                    break;
                                default:
                                    OpcionErronea();
                                    break;
                            }
                        } while (opcionListasAlumno != 4);
                        break;
                    case 2:
                        MostrarPromedio();
                        break;
                    case 3:
                        int opcionGestionarAlumno;
                        do
                        {
                            opcionGestionarAlumno = MenuGesionarAlumno();
                            switch (opcionGestionarAlumno)
                            {
                                case 1:
                                    AgregarAlumnoNuevo();
                                    break;
                                case 2:
                                    EditarAlumno();
                                    break;
                                case 3:
                                    EliminarAlumno();
                                    break;
                                case 4:
                                    VolverMenuPrincipal();
                                    break;
                                default:
                                    OpcionErronea();
                                    break;
                            }
                        } while (opcionGestionarAlumno != 4);
                        break;
                    case 4:
                        Salir();
                        break;
                    default:
                        OpcionErronea();
                        break;
                }
            } while (opcionMenuPrincipal != 4);
        }

        public static int MenuPrincipal()
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
        public static int MenuListas()
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
        public static int MenuGesionarAlumno()
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
        public static void VolverMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Volviendo al Menu principal   --" + "\n" + "\n");
            PresioneEnter();
        }
        public static void Salir()
        {
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado   --  SALIR  --" + "\n" + "\n" + "\n");
            Console.WriteLine("Que tenga un buen dia :D" + "\n" + "\n" + "\n");
            Console.ReadKey();
        }
        public static void OpcionErronea()
        {
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado una opcion ERRONEA" + "\n" + "\n" + "\n");
            PresioneEnter();
        }
        private static void PresioneEnter()
        {
            Console.WriteLine("--   Presione ENTER para continuar   --" + "\n" + "\n" + "\n");
            Console.ReadKey();
        }


        private static void AgregarAlumnoNuevo()
        {
            // ingresar datos
            Alumno alumnoConDatos = IngresarDatos(); // se llama al metodo (IngresarDatos()), se le pasa como parametro un objeto vacio (alumnoVacio) y luego se guarda el objeto editado que devuelve el metodo en otro objeto (alumnoConDatos)

            // guardar
            objetoCurso.agregarAlumno(alumnoConDatos); //se llama al metodo de otra clase (objetoCurso.agregarAlumno) para guardarlo en memoria.

            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Se ha agregado los Datos del alumno   --" + "\n" + "\n");
            PresioneEnter();
        }
        private static Alumno IngresarDatos() //definicion del metodo con el TIPO DE DATO que recibe(clase Alumno) y el TIPO DE DATO que devuelve (clase Alumno)
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
                Console.Write("Ingrese N° de Documento: ");

                esDocumento = int.TryParse(Console.ReadLine(), out valorDocumento);

                if (!esDocumento)
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "\n" + "--   Documento ingresado, NO VALIDO   --" + "\n" + "\n");
                    PresioneEnter();
                }
                else
                {
                    objetoAlumno.NumDocumento = valorDocumento;
                    Console.WriteLine("\n" + "\n" + "--   Se ha agregado N° de Doumento   --" + "\n" + "\n");
                    PresioneEnter();
                }
            }

            Console.Clear();
            Console.Write("Ingrese Nota Final: ");
            do
            {
                try
                {
                    objetoAlumno.Nota = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("--   El valor de la Nota final debe ser entre 1 y 10   --" + "\n" + "\n");
                    Console.Write("Ingrese la Nota Final nuevamente: ");
                }
            } while (objetoAlumno.Nota < 1 || objetoAlumno.Nota > 10);
            if (objetoAlumno.Nota >= 1 || objetoAlumno.Nota <= 10)
            {
                Console.WriteLine("\n" + "\n" + "--   Se ha agregado Nota Final   --" + "\n" + "\n");
                PresioneEnter();
            }
            return objetoAlumno;
        }


        private static void EditarAlumno()
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
        private static void EliminarAlumno()
        {
            // mostrar lista
            // se hace en el metodo SeleccionarAlumno()

            // elegir un elemento de la lista escribiendo el legajo

            Alumno alumnoAEliminar = SeleccionarAlumno();
            //  Console.ReadKey();
            // eliminar
            objetoCurso.eliminarAlumno(alumnoAEliminar);
            Console.Clear();
            Console.WriteLine("\n" + "\n" + "--   Se ha eliminado un Alumno   --" + "\n" + "\n");
            PresioneEnter();
        }
        private static Alumno SeleccionarAlumno()
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
                    Console.Write("Ingrese N° de Legajo del alumno que desea: ");
                    ingresarLegajo = Convert.ToInt16(Console.ReadLine());
                    alumnoSeleccionado = objetoCurso.buscarPorLegajo(ingresarLegajo);
                }
                catch 
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "\n" + "--   El valor del Legajo, NO es correcto.   --" + "\n" + "\n");
                    PresioneEnter();
                }
            } while (alumnoSeleccionado.Legajo == 0);

            Console.WriteLine("\n" + "\n" + "--   Se ha seleccionado un Alumno   --" + "\n" + "\n");
            Console.ReadKey();

            return alumnoSeleccionado;
        }


        private static void ListarAlumno()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Datos de los Alumnos: ");
            Console.WriteLine(objetoCurso.listarAlumno());
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
        }
        private static void MostrarPromedio()
        {
            Console.Clear();
            int promedio = objetoCurso.calcularPromedio();
            Console.WriteLine("***********************************************" + "\n");
            Console.WriteLine("MATERIA:   Algoritmos y Estructuras de Datos I " + "\n" + "\n");
            Console.WriteLine("El promedio general de las Notas es: " + "\n" + "\n" + "||   " + promedio.ToString() + "   ||" + "\n");
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
            PresioneEnter();
        }
        private static void MostrarAprobados()
        {
            Console.Clear();
            Console.WriteLine("***********************************************" + "\n");
            Console.WriteLine("Alumnos APROBADOS: ");
            Console.WriteLine(objetoCurso.alumnosAprobados() + "\n");
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
            PresioneEnter();
        }
        private static void MostrarDesaprobados()
        {
            Console.Clear();
            Console.WriteLine("***********************************************" + "\n");
            Console.WriteLine("Alumnos DESAPROBADOS: ");
            Console.WriteLine(objetoCurso.alumnosDesaprobados() + "\n");
            Console.WriteLine("***********************************************" + "\n" + "\n" + "\n");
            PresioneEnter();
        }

        

    }
}