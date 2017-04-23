using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class AvalcPrflService : ServiceBase<AvalcPrfl>, IAvalcPrflService
    {
        private readonly IRepositoryAvalcPrfl _repositoryAvalcPrfl;

        public AvalcPrflService(IRepositoryAvalcPrfl repositoryAvalcPrfl)
            : base(repositoryAvalcPrfl)
        {
            _repositoryAvalcPrfl = repositoryAvalcPrfl;
        }
    }
}
