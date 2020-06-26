using System;

namespace EduSync.Speech.Domain.SpeechAggregate
{
    public class Speech : AggregateRoot<Guid>
    {
        public string Title { get; }
        public string Url { get; }
        public string Description { get; }
        public string Type { get; }

        public Speech(string title, string url, string description, string type)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Url = url ?? throw new ArgumentNullException(nameof(url));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }
    }
}