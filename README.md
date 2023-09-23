# Strategy Design Pattern
Padrão de projeto comportamental Strategy 

Descrição detalhada de cada etapa da criação e uso do dicionário de estratégias para mapear combinações de `paymentBrand` e `paymentType` em C#:

**Passo 1: Definição das Estratégias**

Primeiro, você precisa definir as estratégias que representarão as diferentes combinações de `paymentBrand` e `paymentType`. No seu exemplo, foram criadas três estratégias: `PixPAStrategy`, `PixDBStrategy` e `PixTRStrategy`. Cada uma dessas estratégias implementa a interface `IPaymentStrategy` e possui um método `Execute` que contém a lógica específica para aquela combinação.

```csharp
public interface IPaymentStrategy
{
    void Execute();
}

public class PixPAStrategy : IPaymentStrategy
{
    public void Execute()
    {
        // Lógica específica para PaymentBrand.Pix e PaymentType.PA
    }
}

public class PixDBStrategy : IPaymentStrategy
{
    public void Execute()
    {
        // Lógica específica para PaymentBrand.Pix e PaymentType.DB
    }
}

public class PixTRStrategy : IPaymentStrategy
{
    public void Execute()
    {
        // Lógica específica para PaymentBrand.Pix e PaymentType.TR
    }
}
```

**Passo 2: Criação do Dicionário**

Em seguida, você cria um dicionário que mapeia as combinações de `paymentBrand` e `paymentType` para as estratégias correspondentes. Você pode fazer isso em um construtor de uma classe que será responsável por processar os pagamentos, como a classe `PaymentProcessor` no exemplo abaixo:

```csharp
public class PaymentProcessor
{
    private readonly Dictionary<(PaymentBrand, PaymentType), IPaymentStrategy> strategies;

    public PaymentProcessor()
    {
        strategies = new Dictionary<(PaymentBrand, PaymentType), IPaymentStrategy>
        {
            {(PaymentBrand.Pix, PaymentType.PA), new PixPAStrategy()},
            {(PaymentBrand.Pix, PaymentType.DB), new PixDBStrategy()},
            {(PaymentBrand.Pix, PaymentType.TR), new PixTRStrategy()},
        };
    }

    // ...
}
```

**Passo 3: Processamento do Pagamento**

Agora, você pode usar o dicionário de estratégias para processar pagamentos com base nas combinações de `paymentBrand` e `paymentType`. Crie um método, como o `ProcessPayment` abaixo, que aceita esses valores e usa o dicionário para encontrar a estratégia correspondente e executá-la:

```csharp
public void ProcessPayment(PaymentBrand paymentBrand, PaymentType paymentType)
{
    if (strategies.TryGetValue((paymentBrand, paymentType), out var strategy))
    {
        strategy.Execute();
    }
    else
    {
        // Lógica para lidar com combinações não suportadas
    }
}
```

**Passo 4: Uso do PaymentProcessor**

Agora você pode criar uma instância da classe `PaymentProcessorContext` e usá-la para processar pagamentos. Basta chamar o método `ProcessPayment` com as combinações apropriadas de `paymentBrand` e `paymentType`:

```csharp
var paymentProcessorContext = new PaymentProcessorContext();
paymentProcessor.ProcessPayment(PaymentBrand.Pix, PaymentType.PA); // Executa a estratégia PixPAStrategy
```

Isso permitirá que você processe pagamentos de forma flexível com base nas combinações de `paymentBrand` e `paymentType` sem a necessidade de repetir condicionais complexos. Cada combinação tem sua estratégia associada e pode ser facilmente estendida para novas combinações no futuro, mantendo seu código organizado e flexível.
