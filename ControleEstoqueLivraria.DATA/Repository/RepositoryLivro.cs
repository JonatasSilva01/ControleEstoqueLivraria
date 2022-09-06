using ControleEstoqueLivraria.DATA.Interfaces;
using ControleEstoqueLivraria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Repository
{
    public class RepositoryLivro : Repository<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanges  = true) : base(SaveChanges)
        {
            
        }
    }
}
