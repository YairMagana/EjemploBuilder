using EjemploBuilder.Producto;

namespace EjemploBuilder
{
    partial class Program
    {
        public class MotorNormal : IMotor
        {
            public MotorNormal()
            {
                Nombre = "Normal";
            }
            public string Nombre { get; set; }
        }
    }
}
