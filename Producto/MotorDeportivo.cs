using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBuilder.Producto
{
    class MotorDeportivo : IMotor
    {
        public MotorDeportivo()
        {
            Nombre = "Deportivo";
        }
        public string Nombre { get; set; }
    }
}
