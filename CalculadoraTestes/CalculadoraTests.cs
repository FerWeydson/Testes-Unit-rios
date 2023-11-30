using Calculadora.Services;


namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomarDoisInteiros_Retornar30()
    {
        //Arrange
        int num1 = 10;
        int num2 = 20;

        //Act
        int resultado = _calc.Somar(num1, num2);
        
        //Act
        Assert.Equal(30, resultado);
    }
        [Fact]
    public void DeveSomarDoisInteiros_Retornar45()
    {
        //Arrange
        int num1 = 40;
        int num2 = 5;

        //Act
        int resultado = _calc.Somar(num1, num2);
        
        //Act
        Assert.Equal(45, resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 10, 12})]
    public void DeveVerificarSeOResultadoEPar(int[] numeros)
    {
        //Act //Assert
        Assert.All(numeros, num => Assert.True(_calc.EPar(num)));
    }
}