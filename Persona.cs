using System;

namespace Lista_de_Alumnos
{
    public interface IPersona
    {
        string Nombre {get; set;}
        string Apellido {get; set;}
        int NumDocumento {get; set;}

    }
}