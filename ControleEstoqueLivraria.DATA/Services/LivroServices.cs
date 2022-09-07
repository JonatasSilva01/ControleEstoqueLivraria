using ControleEstoqueLivraria.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Services
{
    public class LivroServices
    {
        public RepositoryLivro onRepositoryLivro { get; set; }

        public LivroServices()
        {
            onRepositoryLivro = new RepositoryLivro();
        }

    }
}
