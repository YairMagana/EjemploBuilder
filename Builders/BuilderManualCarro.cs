using EjemploBuilder.Producto;

namespace EjemploBuilder
{
    partial class Program
    {
        public class BuilderManualCarro : IBuilder
        {
            private Producto _product = new Producto();

            public BuilderManualCarro()
            {
                this.Reset();
            }

            public void Reset()
            {
                this._product = new Producto();
            }

            public void PonerAsientos(int n)
            {
                this._product.Poner($":Manual {n} Asientos");
            }

            public void PonerMotor(IMotor motor)
            {
                this._product.Poner($":Manual Motor {motor.Nombre}");
            }

            public void PonerComputadora()
            {
                this._product.Poner(":Manual Computadora");
            }

            public void PonerGPS()
            {
                this._product.Poner(":Manual GPS");
            }

            public Producto ObtenerResultado()
            {
                Producto result = this._product;

                this.Reset();

                return result;
            }
        }
    }
}
