using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void SomaDeveSer15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);

    }

    [Fact]
    public void SubtacaoDeveSerMenos5()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(-5, resultado);

    }

    [Fact]
    public void MultiplicacaoDeveSer50()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(50, resultado);

    }
}