using PaymentStrategy.Class.Interfaces;
using PaymentStrategy.Enums;
using PaymentStrategy.Resources;

namespace PaymentStrategy.Class
{
    public class PaymentProcessorContext
    {
        private readonly Dictionary<(PaymentBrand, PaymentType), IPaymentStrategy> strategies;

        public PaymentProcessorContext()
        {
            strategies = new Dictionary<(PaymentBrand, PaymentType), IPaymentStrategy>
            {
                {(PaymentBrand.PIX, PaymentType.PA), new PixPAStrategy()},
                {(PaymentBrand.PIX, PaymentType.DB), new PixDBStrategy()},
                {(PaymentBrand.PIX, PaymentType.TR), new PixTRStrategy()},
            };
        }

        public void ProcessPayment(PaymentBrand paymentBrand, PaymentType paymentType)
        {
            if (strategies.TryGetValue((paymentBrand, paymentType), out var strategy))
                strategy.Execute();
            else
                Console.WriteLine(ReturnMsg.INF0004);
        }
    }
}
