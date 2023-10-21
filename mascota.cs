using System;

public class Mascota
 private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public void crearmascota(string _nombre, string _tipo, int _edad)
        {
            nombre = _nombre;
            this.tipo = _tipo;
            this.edad = _edad;
        }
    }
}
{
     
     
}

class Program
{
    static void Main(string[] args)
    {
      Mascota mascota1 = new Mascota();
            mascota1.crearmascota("Scoby", "perro", 5);

            Mascota mascota2 = new Mascota();
            mascota2.crearmascota("Pepe", "loro", 1);

            Mascota mascota3 = new Mascota();
            mascota3.crearmascota("Tom", "gato", 3);


            Console.WriteLine("La mascota se llama " + mascota1.Nombre + ", es tipo " + mascota1.Tipo + " y tiene  " + mascota1.Edad + " años de edad. ");
            Console.WriteLine("La mascota se llama " + mascota2.Nombre + ", es tipo " + mascota2.Tipo + " y tiene  " + mascota2.Edad + " año de edad. ");
            Console.WriteLine("La mascota se llama " + mascota3.Nombre + ", es tipo " + mascota3.Tipo + " y tiene  " + mascota3.Edad + " años de edad. ");
            Console.ReadLine();

    }
}
