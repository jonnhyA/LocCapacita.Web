using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IRepositoryContato _repositoryContato;

        public ContatoService(IRepositoryContato repositoryContato)
            : base(repositoryContato)
        {
            _repositoryContato = repositoryContato;
        }
    }
}
