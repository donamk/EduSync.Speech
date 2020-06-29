using System;

namespace EduSync.Speech.Domain.Event
{
    public interface IDomainEvent
    {
        Guid EventId { get; }
        long AggregateVersion { get; }
        void BuildVersion(long aggregateVersion);
    }
}