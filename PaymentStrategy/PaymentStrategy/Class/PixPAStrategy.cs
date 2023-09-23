using PaymentStrategy.Class.Interfaces;
using PaymentStrategy.Resources;

namespace PaymentStrategy.Class
{
    /// <summary>
    /// Estratégia de pagamento para PaymentBrand.Pix e PaymentType.DB.
    /// </summary>
    public class PixPAStrategy : IPaymentStrategy
    {
        public void Execute()
        {
            // Lógica específica para PaymentBrand.Pix e PaymentType.PA
            Console.WriteLine(ReturnMsg.INF0002);
        }
    }
}
