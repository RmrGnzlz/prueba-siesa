using System;
using Domain.Repositories;

namespace Domain.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        #region [Repositories]
        public IPersonaRepository PersonaRepository { get;}
        #endregion

        int Commit();
    }
}