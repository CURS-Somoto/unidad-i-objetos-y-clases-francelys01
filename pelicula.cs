using System;

public class Película
{
    
    public string Titulo { get; set; }
    public int AnyoLanzamiento { get; set; }

                public Película()
            {
                Calificación = 0;
            }

            public Película(string titulo, int añodelanzamiento)
            {
                Título = titulo;
                AñoDeLanzamiento = añodelanzamiento;
                Calificación = 0;
            }
            public void Calificar(int calificación)
            {
                if (calificación >= 1 && calificación <= 5)
                {
                    Calificación = calificación;
                }
                else
                {

                    Console.WriteLine("La calificación debe ser entre 1 y 5");
                }
            }

}

class Program
{
    static void Main(string[] args)
    {
       Película película1 = new Película("Apocalipsis", 2007);
            película1.Calificar(5);

            Película película2 = new Película("Corazón Azul", 2021);
            película2.Calificar(3);

            Console.WriteLine("Cuando se estrenó la película " +película1.Título+ " en el año " +película1.AñoDeLanzamiento+" me encantó mucho que la califico con "+ película1.Calificación +" estrellas.");
            Console.WriteLine("Cuando se estrenó la película " +película2.Título+ " en el año " +película2.AñoDeLanzamiento+" me encantó mucho que la califico con "+ película2.Calificación +" estrellas.");
           
            Console.ReadKey();
       }
    }
}
