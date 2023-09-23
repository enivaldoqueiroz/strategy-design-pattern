using PaymentStrategy.Class.Interfaces;
using PaymentStrategy.Resources;

namespace PaymentStrategy.Class
{
    /// <summary>
    /// Estratégia de pagamento para PaymentBrand.Pix e PaymentType.TR.
    /// </summary>
    internal class PixTRStrategy : IPaymentStrategy
    {
        public void Execute()
        {
            // Lógica específica para PaymentBrand.Pix e PaymentType.TR
            Console.WriteLine(ReturnMsg.INF0003);
        }
    }
}
