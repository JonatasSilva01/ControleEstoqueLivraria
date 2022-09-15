using ControleEstoqueLivraria.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Services
{
    public class LivroClienteEmprestimoServices
    {
        public RepositoryLivroClienteEmprestimo onRepositoryClienteLivroEmprestmo { get; set; }

        public LivroClienteEmprestimoServices()
        {
            onRepositoryClienteLivroEmprestmo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
