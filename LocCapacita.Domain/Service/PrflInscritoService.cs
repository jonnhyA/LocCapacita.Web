using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class PrflInscritoService : ServiceBase<PrflInscrito>, IPrflInscritoService
    {
        private readonly IRepositoryPrflInscrito _repositoryPrflInscrito;

        public PrflInscritoService(IRepositoryPrflInscrito repositoryPrflInscrito)
            : base(repositoryPrflInscrito)
        {
            _repositoryPrflInscrito = repositoryPrflInscrito;
        }
    }
}
