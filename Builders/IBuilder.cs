using EjemploBuilder.Producto;

namespace EjemploBuilder
{
    partial class Program
    {
        public interface IBuilder
        {
            void Reset();
            void PonerAsientos(int n);
            void PonerMotor(IMotor motor);
            void PonerComputadora();
            void PonerGPS();
        }
    }
}
