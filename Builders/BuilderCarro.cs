using EjemploBuilder.Producto;

namespace EjemploBuilder
{
    partial class Program
    {
        public class BuilderCarro : IBuilder
        {
            private Producto _product = new Producto();

            public BuilderCarro()
            {
                this.Reset();
            }

            public void Reset()
            {
                this._product = new Producto();
            }

            public void PonerAsientos( int n)
            {
                this._product.Poner($":{n} Asientos");
            }

            public void PonerMotor(IMotor motor)
            {
                this._product.Poner($":Motor {motor.Nombre}");
            }

            public void PonerComputadora()
            {
                this._product.Poner(":Computadora");
            }

            public void PonerGPS()
            {
                this._product.Poner(":GPS");
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
