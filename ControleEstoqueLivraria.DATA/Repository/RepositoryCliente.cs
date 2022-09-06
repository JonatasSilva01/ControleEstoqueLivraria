using ControleEstoqueLivraria.DATA.Interfaces;
using ControleEstoqueLivraria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Repository
{
    public class RepositoryCliente : Repository<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChange = true) : base(SaveChange)
        {

        }
    }
}
