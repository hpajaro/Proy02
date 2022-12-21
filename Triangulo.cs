using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometria
{
    public class Triangulo : Figura2D
    {
        private float _lado1;
        private float _lado2;
        private float _lado3;
        private float _perimetro;

        public Triangulo() { }
        public Triangulo(string nombre, float lado1, float lado2, float lado3) : base(nombre)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;

        }

        public float Lado1 { get => _lado1; set => _lado1 = value; }
        public float Lado2 { get => _lado2; set => _lado2 = value; }
        public float Lado3 { get => _lado3; set => _lado3 = value; }

        public override float getPerimetro()
        {
            _perimetro = Lado1 + Lado2 + Lado3;
            return _perimetro;
        }

        public override float getSize()
        {
            float s = _perimetro / 2;
            float temp = s * (s - Lado1) * (s - Lado2) * (s - Lado3);
            double area = Math.Sqrt(temp);
            this.Size = Convert.ToSingle(area);
            return this.Size;

        }
    }
}