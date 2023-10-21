using System;

public class Empleado
{
   
    public string Nombre { get; set; }
    public double Salario { get; set; }

    
    public double CalcularSalarioAnual()
    {
       return  Salario * 12;
        
    }
}

class Program
{
    static void Main(string[] args)
    {
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Stefani Valeria Aguilar Estrada";
            empleado1.Salario = 3000;

            Empleado empleado2 = new Empleado();
            empleado2.Nombre = "Jonathan Alexander Espinoza Herrera";
            empleado2.Salario = 6000;

            Console.WriteLine("El salario anual de " +empleado1.Nombre+ " es de " + empleado1.CalcularSalarioAnual());
            Console.WriteLine("El salario anual de " +empleado2.Nombre+ " es de " + empleado2.CalcularSalarioAnual());

            Console.ReadKey();

        }
    }
}
