using Financeiro;

namespace FinanceiroTeste
{
    [TestClass]
    public class ContaTeste
    {
        [TestMethod]
        public void SacarValorMenorSladoTest()
        {
            //cenario
            decimal valorSaque = 100.50m;
            decimal saldoInicial = 1000.50m;
            decimal saldoFinal = 900;
            Conta conta1 = new Conta();
            conta1.Depositar(saldoInicial);


            //acao
            conta1.Sacar(valorSaque);

            //verificação 
            Assert.AreEqual(saldoFinal, conta1.Saldo);
        }
    }
}