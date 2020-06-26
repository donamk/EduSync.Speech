using System;
using System.Collections.Generic;

namespace EduSync.Speech.Domain.SpeechAggregate
{
    public abstract class Entity<T> : IEquatable<Entity<T>>
    {
        public T Id { get; protected set; }
        
        public bool Equals(Entity<T> other)
        {
            return other != null && EqualityComparer<T>.Default.Equals(Id, other.Id);
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        
        public override bool Equals(object obj)
        {
            return Equals(obj as Entity<T>);
        }
        
        public static bool operator ==(Entity<T> entity1, Entity<T> entity2)
        {
            return EqualityComparer<Entity<T>>.Default.Equals(entity1, entity2);
        }

        public static bool operator !=(Entity<T> entity1, Entity<T> entity2)
        {
            return !(entity1 == entity2);
        }
    }
}