using Contracts;

namespace Producer
{
    public class SomeProducer
    {
        public void Produce()
        {
            // do some work to create transactions
            var transaction = new Transaction() { Amount = 1, PostingDate = DateTimeOffset.UtcNow, TransactionId = Guid.NewGuid(), ReferenceNumber = "Sample Reference Number" };
            
            // todo: post transaction on service bus
        }
    }
}
