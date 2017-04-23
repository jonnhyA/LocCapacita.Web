using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class AssuntoService : ServiceBase<Assunto>, IAssuntoService
    {
        private readonly IRepositoryAssunto _repositoryAssunto;

        public AssuntoService(IRepositoryAssunto repositoryAssunto)
            : base(repositoryAssunto)
        {
            _repositoryAssunto = repositoryAssunto;
        }
    }
}
