using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {

        public Contexto() : base("strConn")

        {

        }


        public DbSet<Aluno> Alunos { get; set; }
    }
}
