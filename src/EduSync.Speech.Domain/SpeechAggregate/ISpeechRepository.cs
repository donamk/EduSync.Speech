using System;
using System.Threading.Tasks;

namespace EduSync.Speech.Domain.SpeechAggregate
{
    public interface ISpeechRepository : IRepository<Speech, Guid>
    {
    }
}