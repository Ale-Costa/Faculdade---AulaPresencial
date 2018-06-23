using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
   public class ProfessoresController
    {

        List<Professor> tabelaProfessores = new List<Professor>();

        public void Inserir(Professor p)
        {


            tabelaProfessores.Add(p);
        }

        public List<Professor> ListarTodos()
        {

            return tabelaProfessores;
        }

    }


}
