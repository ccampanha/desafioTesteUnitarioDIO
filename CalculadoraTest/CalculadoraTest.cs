using CalculadoraApp;

namespace CalculadoraTest
{
    public class CalculadoraTest
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Somar_DeveRetornarSomaCorreta()
        {
            int resultado = _calculadora.Somar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarSubtracaoCorreta()
        {
            int resultado = _calculadora.Subtrair(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarMultiplicacaoCorreta()
        {
            int resultado = _calculadora.Multiplicar(2, 3);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarDivisaoCorreta()
        {
            int resultado = _calculadora.Dividir(6, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_DivisaoPorZero_DeveLancarExcecao()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(6, 0));
        }

        [Fact]
        public void Memoria_DeveArmazenarTresUltimosResultados()
        {
            _calculadora.Somar(1, 1);  // 2
            _calculadora.Somar(2, 2);  // 4
            _calculadora.Somar(3, 3);  // 6
            _calculadora.Somar(4, 4);  // 8

            int[] memoria = _calculadora.ObterMemoria();
            Assert.Equal(3, memoria.Length);
            Assert.Equal(4, memoria[0]);
            Assert.Equal(6, memoria[1]);
            Assert.Equal(8, memoria[2]);
        }
    }
}