using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class BuscaService : ServiceBase<Busca>, IBuscaService
    {
        private readonly IRepositoryBusca _repositoryBusca;

        public BuscaService(IRepositoryBusca repositoryBusca)
            : base(repositoryBusca)
        {
            _repositoryBusca = repositoryBusca;
        }
    }
}
