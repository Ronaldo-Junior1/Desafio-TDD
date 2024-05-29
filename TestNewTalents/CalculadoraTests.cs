using NewTalents.Models;

namespace TestNewTalents
{
    public class CalculadoraTests
    {
        private Calculadora _calc;

        
        public CalculadoraTests() 
        {
            string data = "29/05/2024";
            _calc = new Calculadora(data);         
        }   

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1,int num2,int resultado)
        {
            // Arrange

            // act
            int resultaod = _calc.Somar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultaod);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            // Arrange

            // act
            int resultaod = _calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultaod);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            // Arrange

            // act
            int resultaod = _calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultado, resultaod);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(25, 5, 5)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            // Arrange

            // act
            int resultaod = _calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultado, resultaod);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calc.Dividir(3, 0)
                );
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 3);
            _calc.Somar(2, 6);
            _calc.Somar(45, 9);
            _calc.Somar(5, 1);

            var lista = _calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}