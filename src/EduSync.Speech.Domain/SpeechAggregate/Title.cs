using System;
using System.Collections.Generic;
using EduSync.Speech.Domain.Exceptions;

namespace EduSync.Speech.Domain.SpeechAggregate
{
    public class Title : IEquatable<Title>
    {
        private const int MinLength = 10;
        private const int MaxLength = 60;
        public string Value { get; }

        public Title(string value)
        {
            if (value?.Length < MinLength)
                throw new InvalidLenghtAggregateException("Value is too short");

            if (value?.Length > MaxLength)
                throw new InvalidLenghtAggregateException("Value is too long");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Title);
        }

        public bool Equals(Title other)
        {
            return other != null &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(Title title1, Title title2)
        {
            return EqualityComparer<Title>.Default.Equals(title1, title2);
        }

        public static bool operator !=(Title title1, Title title2)
        {
            return !(title1 == title2);
        }
    }
}