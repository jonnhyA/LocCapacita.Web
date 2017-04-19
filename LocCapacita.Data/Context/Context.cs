using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocCapacita.Data.Context
{
    public class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }
        public Context() : base("LocCapacita")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 240;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Configurations.Add(new AplicacaoMap());
            //modelBuilder.Configurations.Add(new CorMap());
            //modelBuilder.Configurations.Add(new CodinomeMap());
            //modelBuilder.Configurations.Add(new GrupoEtwMap());
            //modelBuilder.Configurations.Add(new AssociarCodinomeMap());
            //modelBuilder.Configurations.Add(new StatusMap());
            //modelBuilder.Configurations.Add(new NivelAcessoMap());
            //modelBuilder.Configurations.Add(new DelegacaoMap());
            //modelBuilder.Configurations.Add(new AssociarMuMap());
            //modelBuilder.Configurations.Add(new PerfilMap());
            //modelBuilder.Configurations.Add(new CallHandlingMap());
            //modelBuilder.Configurations.Add(new PerfilAplicacaoMap());
            //modelBuilder.Configurations.Add(new PerfilSkillMap());
            //modelBuilder.Configurations.Add(new AssociarPerfilMap());
            //modelBuilder.Configurations.Add(new ViewPerfilMap());
            //modelBuilder.Configurations.Add(new ViewPerfilAplicacaoMap());
            //modelBuilder.Configurations.Add(new ViewPerfilSkillMap());
            //modelBuilder.Configurations.Add(new ViewAssociarPerfilMap());
            //modelBuilder.Configurations.Add(new RevisaoMap());
            //modelBuilder.Configurations.Add(new NotificacaoRevisaoMap());
            //modelBuilder.Configurations.Add(new ViewDelegacaoMap());
            //modelBuilder.Configurations.Add(new AssociarPerfilMassaMap());
            //modelBuilder.Configurations.Add(new LoginFuncionarioMap());
            //modelBuilder.Configurations.Add(new LoginColaboradorMap());
            //modelBuilder.Configurations.Add(new ViewRelatorioHistoricoFuncionarioPerfilMap());
            //modelBuilder.Configurations.Add(new ViewRelatorioGeralMap());
            //modelBuilder.Configurations.Add(new ViewRelatorioRevisaoMap());
            //modelBuilder.Configurations.Add(new ViewAssociarPerfilMassaMap());
            //modelBuilder.Configurations.Add(new RevisaoAssociacaoPerfilMap());
            //modelBuilder.Configurations.Add(new ViewRelatorioHistoricoFuncionarioCodinomeMap());
            //modelBuilder.Configurations.Add(new ViewRelatorioHistoricoFuncionarioSkillMap());
            //modelBuilder.Configurations.Add(new ViewFuncionarioColaboradorLoginMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
