using System;

namespace Metodologías
{
    public interface Strategy
    {
        bool esIgual(Comparable a, Comparable b);
        bool esMenor(Comparable a, Comparable b);
        bool esMayor(Comparable a, Comparable b);
    }
    public class porDNI : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Persona)a).getDni == ((Persona)b).getDni;
        }
        
        public bool esMenor(Comparable a, Comparable b)
        {
            return ((Persona)a).getDni < ((Persona)b).getDni;
        }

        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Persona)a).getDni > ((Persona)b).getDni;
        }
    }
    public class porNombre : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Persona)a).getNombre == ((Persona)b).getNombre;
        }
        public bool esMenor(Comparable a, Comparable b)
        {return false;}
        public bool esMayor(Comparable a, Comparable b)
        {return false;}
    }
    public class porLegajo : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo == ((Alumno)b).getLegajo;
        }
        public bool esMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo < ((Alumno)b).getLegajo;
        }

        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo > ((Alumno)b).getLegajo;
        }
    }
    public class porPromedio : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio == ((Alumno)b).getPromedio;
        }
        public bool esMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio < ((Alumno)b).getPromedio;
        }
        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio > ((Alumno)b).getPromedio;
        }
    }
       
}