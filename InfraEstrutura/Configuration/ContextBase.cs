using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) 
        { 
            
        }    
        public DbSet<Products> Products { get; set; }
        /// <summary>
        /// Setando a string de conexão com a base de dados
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                //provisóriamente deixaremos a string vazia caso não haja 
                //uma string de configuração
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }
        private string GetStringConnectionConfig()
        {
            //provisóriamente teremos uma string privada de conexão sem 
            //a base de dados que ainda será criada.
            string connectionString = string.Empty;
            return connectionString;
        }
    }
}
