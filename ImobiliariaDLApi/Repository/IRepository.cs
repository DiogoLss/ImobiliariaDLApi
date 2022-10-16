using System.Linq.Expressions;

namespace ImobiliariaDLApi.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
        Task<T> GetById(Expression<Func<T, bool>> predicate);
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(T entity);
    }
}
