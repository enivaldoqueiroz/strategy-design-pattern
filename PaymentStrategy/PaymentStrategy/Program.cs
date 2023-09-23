using PaymentStrategy.Class;
using PaymentStrategy.Enums;

Console.WriteLine("Digite o PaymentBrand: ");
Console.WriteLine("0 - PIX| ...");
PaymentBrand paymentBrand = (PaymentBrand)Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o PaymentType: ");
Console.WriteLine("PA = 0 | DB = 1 | TR = 2");
PaymentType paymentType = (PaymentType)Convert.ToInt16(Console.ReadLine());

PaymentProcessorContext context = new PaymentProcessorContext();

context.ProcessPayment(paymentBrand, paymentType);

Console.Read();