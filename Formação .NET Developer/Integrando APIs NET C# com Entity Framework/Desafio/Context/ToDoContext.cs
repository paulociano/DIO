using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas {get;set;}
    }
}