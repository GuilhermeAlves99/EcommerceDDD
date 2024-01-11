using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGenerics<T> where T : class
    {
        /// <summary>
        /// Uma Classe genérica para ser usada para criar listas de, por exemplo
        /// produtos ou qualquer outra busca, inserção, remoção ou atualização na
        /// base de dados
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        Task Add(T Object);

        Task Update(T Object);

        Task Delete(T Object);

        Task<T> GetEntityById(int Id);

       Task<List<T>> List();
    }
}
