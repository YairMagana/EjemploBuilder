using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBuilder
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Carro
            var director = new Director();
            var builderCarro = new BuilderCarro();
            director.Builder = builderCarro;

            Console.WriteLine("Carro SUV:");
            director.HacerSUV();
            Console.WriteLine(builderCarro.ObtenerResultado().ListarPartes());

            Console.WriteLine("Carro Deportivo:");
            director.HacerDeportivo();
            Console.WriteLine(builderCarro.ObtenerResultado().ListarPartes());

            // Manual
            var builderManualCarro = new BuilderManualCarro();
            director.Builder = builderManualCarro;

            Console.WriteLine("Manual de Carro SUV:");
            director.HacerSUV();
            Console.WriteLine(builderManualCarro.ObtenerResultado().ListarPartes());

            Console.WriteLine("Manual de Carro Deportivo:");
            director.HacerDeportivo();
            Console.WriteLine(builderManualCarro.ObtenerResultado().ListarPartes());

            Console.ReadKey();
        }
    }
}
