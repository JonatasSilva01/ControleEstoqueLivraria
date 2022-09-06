using ControleEstoqueLivraria.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente onRepositoryCliente { get; set; }

        public ClienteService()
        {
            onRepositoryCliente = new RepositoryCliente();
        }
    }
}
