using System;
using MinhaBiblioteca;
using BibliotecaConversao;
using ConvertorDeMoeda;
using AreaTriangulo;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        var calc = new Calculadora();
        var conversor = new Conversor();
        var conversorMoeda = new ConvertorMoeda();
        var area = new Area();

        Console.WriteLine("Soma: " + calc.Somar(5, 3));
        Console.WriteLine("Multiplicar: " + calc.Multiplicar(5, 3));

        Console.WriteLine("Fahrenheit para Celsius: " + conversor.ConversorDeFahrenheitToCelsius(32.0));
        Console.WriteLine("Metro para Quilômetro: " + conversor.ConversorDeMetrosParaQuilometros(100.0));
        Console.WriteLine("Real para Dolar: " + conversorMoeda.ConverterRealParaDolar(100.0,0.19));
        Console.WriteLine("Real para Dolar: " + conversorMoeda.ConverterRealParaDolar(100.0,0.19));
        Console.WriteLine("Area do triangulo: " + area.CalculoDaArea(10,5));
    }
}