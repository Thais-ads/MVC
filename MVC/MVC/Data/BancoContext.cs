using Microsoft.EntityFrameworkCore;
using MVCI.Models;


namespace MVCI.Data
{
    public class BancoContext : DbContext
    {   
        //configuração padrao, criar o construtor.
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        
        {
        }

        //pode ter varias tabelas,

        public DbSet<ContatoModel> Contatos { get; set; }


    }
}
