using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_dotnet_desafio_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dio_dotnet_desafio_api.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}