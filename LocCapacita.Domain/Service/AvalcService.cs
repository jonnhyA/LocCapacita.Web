using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class AvalcService : ServiceBase<Avalc>, IAvalcService
    {
        private readonly IRepositoryAvalc _repositoryAvalc;

        public AvalcService(IRepositoryAvalc repositoryAvalc)
            : base(repositoryAvalc)
        {
            _repositoryAvalc = repositoryAvalc;
        }
    }
}
