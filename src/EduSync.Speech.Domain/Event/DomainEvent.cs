using System;

namespace EduSync.Speech.Domain.Event
{
    public abstract class DomainEvent
    {
        public Guid Id { get; protected set;  }
        public DateTime OcurrendOn { get; }

        public DomainEvent()
        { 
            OcurrendOn = DateTime.UtcNow;            
        }
    }
}