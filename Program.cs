namespace Lista_de_Alumnos
{
    class Program
    {
        public static void Main()
        {
            GestorMenu menu = new();
            int opcionMenuPrincipal;
            do
            {
                opcionMenuPrincipal = menu.MenuPrincipal();
                switch (opcionMenuPrincipal)
                {
                    case 1:
                        int opcionListasAlumno;
                        do
                        {
                            opcionListasAlumno = menu.MenuListas();
                            switch (opcionListasAlumno)
                            {
                                case 1:
                                    menu.ListarAlumno();
                                    menu.PresioneEnter();
                                    break;
                                case 2:
                                    menu.MostrarAprobados();
                                    break;
                                case 3:
                                    menu.MostrarDesaprobados();
                                    break;
                                case 4:
                                    menu.VolverMenuPrincipal();
                                    break;
                                default:
                                   menu.OpcionErronea();
                                    break;
                            }
                        } while (opcionListasAlumno != 4);
                        break;
                    case 2:
                        menu.MostrarPromedio();
                        break;
                    case 3:
                        int opcionGestionarAlumno;
                        do
                        {
                            opcionGestionarAlumno = menu.MenuGesionarAlumno();
                            switch (opcionGestionarAlumno)
                            {
                                case 1:
                                    menu.AgregarAlumnoNuevo();
                                    break;
                                case 2:
                                    menu.EditarAlumno();
                                    break;
                                case 3:
                                    menu.EliminarAlumno();
                                    break;
                                case 4:
                                    menu.VolverMenuPrincipal();
                                    break;
                                default:
                                    menu.OpcionErronea();
                                    break;
                            }
                        } while (opcionGestionarAlumno != 4);
                        break;
                    case 4:
                        menu.Salir();
                        break;
                    default:
                        menu.OpcionErronea();
                        break;
                }
            } while (opcionMenuPrincipal != 4);
        }

    }
}