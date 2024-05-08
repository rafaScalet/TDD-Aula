using src.models;

namespace tests;

public class TesteCalculadora
{
    Calculadora calc = new();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = calc.Somar(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 3, 6)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = calc.Multiplicar(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(4, 2, 2)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = calc.Subtrair(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(4, 2, 2)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = calc.Dividir(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Fact]
    public void DividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TesteListarHistorico()
    {
    }
}