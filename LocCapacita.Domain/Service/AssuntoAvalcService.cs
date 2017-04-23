using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class AssuntoAvalcService : ServiceBase<AssuntoAvalc>, IAssuntoAvalcService
    {
        private readonly IRepositoryAssuntoAvalc _repositoryAssuntoAvalc;

        public AssuntoAvalcService(IRepositoryAssuntoAvalc repositoryAssuntoAvalc)
            : base(repositoryAssuntoAvalc)
        {
            _repositoryAssuntoAvalc = repositoryAssuntoAvalc;
        }
    }
}
