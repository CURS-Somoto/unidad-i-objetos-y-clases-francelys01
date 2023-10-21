using System;

public class Libro
{
    // Propiedades
 
 private String Autor;

        public String Autor1
        {
            get { return Autor; }
            set { Autor = value; }
        }
        private String Título;

        public String Título1
        {
            get { return Título; }
            set { Título = value; }
        }

        public Libro(String tit, String aut)
        {
            Título = tit;
            Autor = aut;
        }
        public override string ToString()
        {
            return "Título : " + Título + "\n" + "Autor: " + Autor;
        }
    }
}
  
   
}

class Program
{
    static void Main(string[] args)
    {
            Libro lib1 = new Libro("El programador progmático", "Andy Hunt");

            Libro lib2 = new Libro("Clean Code", "Robert C Martin");

            Console.WriteLine(lib1);
            Console.WriteLine(lib2);
            Console.ReadKey();
    }
}
