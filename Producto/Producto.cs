using System.Collections.Generic;

namespace EjemploBuilder
{
    partial class Program
    {
        public class Producto
        {
            private List<object> _parts = new List<object>();

            public void Poner(string part)
            {
                this._parts.Add(part);
            }

            public string ListarPartes()
            {
                string str = string.Empty;

                for (int i = 0; i < this._parts.Count; i++)
                {
                    str += this._parts[i] + ", ";
                }

                return "Partes del producto: " + str + "\n";
            }
        }
    }
}
