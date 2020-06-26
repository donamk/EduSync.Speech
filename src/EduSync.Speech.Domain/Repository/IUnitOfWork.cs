using System;

namespace EduSync.Speech.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}