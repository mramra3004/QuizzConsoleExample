using System;

namespace ProductManagement.ConsoleApplication.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}