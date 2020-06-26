namespace EduSync.Speech.Domain.SpeechAggregate
{
    public abstract class AggregateRoot<T> : Entity<T>, IEventSourcing
    {
    }
}