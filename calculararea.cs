using System;

namespace FigurasGeometricas
{
    // Clase para representar un Círculo
    public class Circulo
    {
        private double radio;

        // Constructor
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro (circunferencia) del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un Cuadrado
    public class Cuadrado
    {
        private double lado;

        // Constructor
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Método para calcular el área del cuadrado
        public double CalcularArea()
        {
            return lado * lado;
        }

        // Método para calcular el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    // Clase Principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Área: {miCirculo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro():F2}");

            // Crear un cuadrado con lado 4
            Cuadrado miCuadrado = new Cuadrado(4);
            Console.WriteLine("\nCuadrado:");
            Console.WriteLine($"Área: {miCuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {miCuadrado.CalcularPerimetro():F2}");

            Console.ReadKey();
        }
    }
}
