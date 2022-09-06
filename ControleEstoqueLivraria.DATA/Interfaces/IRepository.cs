using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> SelecionarTodos();// Select * From ?
        T Selecionar_Pk(params object[] variavel);// Select cliente where Id = ?
        T Incluir(T objeto); // INSERT
        T Alterar(T objeto); // UPDATE
        void Excluir(T objeto); // DELETE
        void Excluir(params object[] variavel); // DELETE where Id = ?
        void SaveShanges();// Salvar Dados
    }
}
