using System;

public class Estudiante
{
  
           Nombre = "Ernesto José Diaz Herrera";
            Edad = 18;
            Curso = "Primer año de Ingenieria en Sistema";
        
        }

        public Estudiante(string NombreEstudiante, int EdadEstudiante, string CursoEstudiante)
        {
            Nombre = NombreEstudiante;
            Edad = EdadEstudiante;
            Curso = CursoEstudiante;
        }

        public string getInfoEstudiante()
        {
            return "Información del estudiante:\n " +  " Nombre: " + Nombre + "      Edad:" + " " + Edad + "      Curso: " +  Curso;
        }
        private string Nombre;
        private int Edad;
        private string Curso;
   } 
   
}

class Program
{
    static void Main(string[] args)
    {
           Estudiante estudiante1 = new Estudiante(); // crear objeto/instancia de tipo estudiante.
            // dar un estado Inicial al estudiante.
            
            Console.WriteLine(estudiante1.getInfoEstudiante());

            Estudiante estudiante2 = new Estudiante("Anielka Vanesa Arteaga Gómez", 20, "Tercer año de Adminstración de Empresa");

            Console.WriteLine(estudiante2.getInfoEstudiante());
            Console.ReadKey();
    }
}
