using ControleEstoqueLivraria.DATA.Interfaces;
using ControleEstoqueLivraria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueLivraria.DATA.Repository
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        protected EmprestimoLivroClienteContext _Contexto;
        public bool _SaveChanges = true;// pra saber se ta salvado tudo bonitinho.

        public Repository(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Contexto = new EmprestimoLivroClienteContext();
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }
        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);

            if (_SaveChanges) _Contexto.SaveChanges();

            return objeto;

        }
        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges) _Contexto.SaveChanges();

            return objeto;
        }
        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);

            if (_SaveChanges) _Contexto.SaveChanges();
            
        }
        public void Excluir(params object[] variavel)
        {
            var obj = Selecionar_Pk(variavel);
            Excluir(obj);
        }

        public T Selecionar_Pk(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }


        public void SaveShanges()
        {
            throw new NotImplementedException();
        }
    }
}
