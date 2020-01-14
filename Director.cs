using EjemploBuilder.Producto;

namespace EjemploBuilder
{
    partial class Program
    {
        public class Director
        {
            private IBuilder _builder;

            public IBuilder Builder
            {
                set { _builder = value; }
            }

            public void HacerSUV()
            {
                this._builder.PonerAsientos(4);
                this._builder.PonerMotor(new MotorNormal());
                this._builder.PonerComputadora();
                this._builder.PonerGPS();
            }

            public void HacerDeportivo()
            {
                this._builder.PonerAsientos(2);
                this._builder.PonerMotor(new MotorDeportivo());
                this._builder.PonerComputadora();
                this._builder.PonerGPS();
            }
        }
    }
}
