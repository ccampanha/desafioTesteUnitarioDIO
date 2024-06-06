using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private Queue<int> _memoria;

        public Calculadora()
        {
            _memoria = new Queue<int>(3);
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            AdicionarMemoria(resultado);
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            AdicionarMemoria(resultado);
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            AdicionarMemoria(resultado);
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida");
            int resultado = a / b;
            AdicionarMemoria(resultado);
            return resultado;
        }

        private void AdicionarMemoria(int resultado)
        {
            if (_memoria.Count == 3)
            {
                _memoria.Dequeue();
            }
            _memoria.Enqueue(resultado);
        }

        public int[] ObterMemoria()
        {
            return _memoria.ToArray();
        }
    }
}
