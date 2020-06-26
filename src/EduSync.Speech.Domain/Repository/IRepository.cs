using System.Threading.Tasks;

namespace EduSync.Speech.Domain.SpeechAggregate
{
    public interface IRepository<in T, TIdentifier> where T : AggregateRoot<TIdentifier>
    {
        Task CreateAsync(T entity);
    }
}