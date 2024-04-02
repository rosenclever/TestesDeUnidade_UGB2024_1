using CalculadoraCientifica;

namespace CalculadoraCientificaTests
{
    [TestClass]
    public class Calculadora4OperacoesTests
    {
        [TestMethod]
        public void Test_soma_dois_numeros()
        {
            //cen�rio
            int num1 = 20;
            int num2 = 22;
            int resultadoEsperado = 42;
            Calculadora4Operacoes calc = new Calculadora4Operacoes();

            //a��o
            int resultadoObtido = calc.Somar(num1, num2);

            //verifica��o
            Assert.AreEqual(resultadoObtido, resultadoEsperado, 0, "Falha na realiza��o da soma");
        }
    }
}