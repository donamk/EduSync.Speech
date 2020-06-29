using System;
using System.Collections.Generic;
using EduSync.Speech.Domain.Exceptions;

namespace EduSync.Speech.Domain.SpeechAggregate
{
    public enum SpeechTypeEnum
    {
        TrainingVideo = 2,
        SelfPacedLabs = 1,
        Conferences = 3
    }

    public class SpeechType : IEquatable<SpeechType>
    {
        public static readonly SpeechType TrainingVideo = new SpeechType(SpeechTypeEnum.TrainingVideo);
        public static readonly SpeechType Conferences = new SpeechType(SpeechTypeEnum.Conferences);
        public static readonly SpeechType SelfPacedLabs = new SpeechType(SpeechTypeEnum.SelfPacedLabs);

        public SpeechTypeEnum Value { get; }

        private SpeechType(SpeechTypeEnum value)
        {
            Value = value;
        }

        public SpeechType(string value)
        {
            Enum.TryParse(typeof(SpeechTypeEnum), value, out var result);

            Value = (SpeechTypeEnum?)result ??
                    throw new InvalidEnumAggregateException("SpeechType should be valid and not empty");
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SpeechType);
        }

        public bool Equals(SpeechType other)
        {
            return other != null &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(SpeechType type1, SpeechType type2)
        {
            return EqualityComparer<SpeechType>.Default.Equals(type1, type2);
        }

        public static bool operator !=(SpeechType type1, SpeechType type2)
        {
            return !(type1 == type2);
        }
    }
}